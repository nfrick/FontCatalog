using DataLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FontCatalog {
    public partial class Form1 : Form {
        private FontInfosEntities _ctx;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            _ctx = new FontInfosEntities();
        }

        #region TREEVIEW
        private void treeviewPopulate(string folder) {
            tvFonts.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(folder);
            tvFonts.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private TreeNode CreateDirectoryNode(DirectoryInfo folder) {
            var folderNode = new TreeNode(folder.Name, 0, 0);
            foreach (var directory in folder.GetDirectories())
                folderNode.Nodes.Add(CreateDirectoryNode(directory));

            var folderInDb = _ctx.Folders.FirstOrDefault(f => f.Path == folder.FullName);
            var families = folder.GetFiles().Select(file => new FontInfo(file, folderInDb))
                .GroupBy(f => f.FamilyName)
                .Select(n => new {
                    name = n.Key,
                    Count = n.Count(),
                    fonts = n
                }
                ).OrderBy(n => n.name);

            foreach (var family in families) {
                if (family.Count == 1) {
                    foreach (var font in family.fonts)
                        AddToNode(folderNode, font);
                }
                else {
                    TreeNode pNode;
                    if (families.Count() > 1) {
                        var familyNode = new TreeNode(family.name, 1, 1);
                        folderNode.Nodes.Add(familyNode);
                        pNode = familyNode;
                    }
                    else {
                        pNode = folderNode;
                    }

                    foreach (var font in family.fonts)
                        AddToNode(pNode, font);
                }
            }
            return folderNode;
        }

        private static void AddToNode(TreeNode parentNode, FontInfo font) {
            var index = font.FontType == "ttf" ? 2 : 3;
            var text = font.HasInfo ? $"{font.FamilyName} {font.FaceName}" : font.FileName;
            var node = new TreeNode() {
                Name = font.FullName,
                Text = text,
                ImageIndex = index,
                SelectedImageIndex = index,
                Tag = font
            };
            parentNode.Nodes.Add(node);
        }

        private void tvFonts_AfterSelect(object sender, TreeViewEventArgs e) {
            var tag = tvFonts.SelectedNode.Tag;
            if (tag != null) DisplayFont((FontInfo)tag);
        }

        private void tvFonts_AfterCheck(object sender, TreeViewEventArgs e) {
            CheckChildren(e.Node);
            toolStripButtonUncheck.Visible =
                toolStripButtonDelete.Visible =
                    tvFonts.Nodes.Descendants().Any(n => n.Checked);
        }

        private void CheckChildren(TreeNode parent) {
            if (!parent.Nodes.Cast<TreeNode>().Any()) return;
            foreach (TreeNode node in parent.Nodes) {
                node.Checked = parent.Checked;
                CheckChildren(node);
            }
        }

        private void tvFonts_DoubleClick(object sender, EventArgs e) {
            GetFontFolder();
        }

        private void GetFontFolder() {
            if (FBD.ShowDialog() != DialogResult.OK) return;
            treeviewPopulate(FBD.SelectedPath);
        }
        #endregion

        #region FONT INFO
        private void DisplayFont(FontInfo font) {
            tlpDisplayFont.Visible = !string.IsNullOrEmpty(font.FaceName);
            if (tlpDisplayFont.Visible) {
                var pfc = new PrivateFontCollection();
                pfc.AddFontFile(font.FullName);

                var fs = FontStyle.Regular;
                if (font.HasInfo) {
                    if (font.Weight.IndexOf("bold", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        font.Weight.IndexOf("black", StringComparison.OrdinalIgnoreCase) >= 0)
                        fs |= FontStyle.Bold;
                    if (font.Style.IndexOf("italic", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        font.Style.IndexOf("oblique", StringComparison.OrdinalIgnoreCase) >= 0)
                        fs |= FontStyle.Italic;
                }
                textBoxSample.Text = $"{font.FamilyName.ToUpper()} {font.FaceName.ToUpper()} {trackBarSize.Value}" +
                                     "\r\nThe quick brown fox jumps over the lazy dog." +
                                     "\r\n1234567890";
                try {
                    textBoxSample.Font = new Font(pfc.Families[0], trackBarSize.Value, fs);
                }
                catch {
                    MessageBox.Show("Unable to display font sample.", "Font Catalog", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            labelPath.Text = font.FullName;
            labelDate.Text = font.FileDate.ToString();
            labelSize.Text = $"{font.FileSize:N0} bytes";
            labelName.Text = $"Name: {font.FaceName}";
            labelFamily.Text = $"Family: {font.FamilyName}";
            labelBaseline.Text = $"Baseline: {font.Baseline}";
            labelCapsHeight.Text = $"Caps Height: {font.CapsHeight}";
            textBoxDescription.Text = font.Description;
            labelManufacturerName.Text = $"Manufacturer: {font.ManufacturerName}";
            labelGlyphs.Text = $"Glyphs: {font.GlyphCount}";
            labelHeight.Text = $"Height: {font.Height}";
            labelStretch.Text = $"Stretch: {font.Stretch}";
            labelStyle.Text = $"Style: {font.Style}";
            labelSymbol.Text = $"Symbol: {font.Symbol}";
            labelTrademark.Text = $"Trademark: {font.Trademark}";
            labelVersion.Text = $"Version: {font.Version}";
            labelWeight.Text = $"Weight: {font.Weight}";
            labelXHeight.Text = $"Height: {font.Height}";
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e) {
            const string lf = "\n";
            const string space = " ";
            var text = textBoxSample.Text.Split(lf[0]);
            var firstline = text[0].Split(space[0]);
            firstline[firstline.Length - 1] = $"{trackBarSize.Value}\r";
            text[0] = string.Join(space, firstline);
            textBoxSample.Text = string.Join(lf, text);
            textBoxSample.Font = new Font(textBoxSample.Font.FontFamily,
                trackBarSize.Value, textBoxSample.Font.Style);
        }

        private void buttonForeground_Click(object sender, EventArgs e) {
            CD.Color = textBoxSample.ForeColor;
            if (CD.ShowDialog() == DialogResult.OK)
                textBoxSample.ForeColor = buttonForeground.BackColor = CD.Color;
        }

        private void buttonBackground_Click(object sender, EventArgs e) {
            CD.Color = textBoxSample.BackColor;
            if (CD.ShowDialog() == DialogResult.OK)
                textBoxSample.BackColor = buttonBackground.BackColor = CD.Color;
        }

        private void buttonColorSwap_Click(object sender, EventArgs e) {
            var temp = textBoxSample.BackColor;
            textBoxSample.BackColor = buttonBackground.BackColor = textBoxSample.ForeColor;
            textBoxSample.ForeColor = buttonForeground.BackColor = temp;
        }
        #endregion

        #region SEARCH
        private void buttonSearch_Click(object sender, EventArgs e) {
            IQueryable<FontInfo> fonts;
            var button = sender as Button;
            if (button.Text == "Family") {
                fonts = _ctx.Fonts.Where(f => f.FamilyName.Contains(textBoxTarget.Text));
            }
            else if (button.Text == "Name") {
                fonts = _ctx.Fonts.Where(f => f.FaceName.Contains(textBoxTarget.Text));
            }
            else if (button.Text == "File") {
                fonts = _ctx.Fonts.Where(f => f.FileName.Contains(textBoxTarget.Text));
            }
            else {
                fonts = _ctx.Fonts.Where(f => f.Symbol == true);
            }
            ListViewPopulate(fonts);
        }
        #endregion

        #region LISTVIEW
        private void ListViewPopulate(IQueryable<FontInfo> fonts) {
            lvFonts.Items.Clear();
            if (!fonts.Any()) {
                MessageBox.Show(@"No fonts found.");
                return;
            }
            var families = fonts.GroupBy(f => f.FamilyName);

            foreach (var family in families) {
                var lvg = new ListViewGroup(family.Key);
                lvFonts.Groups.Add(lvg);
                foreach (var font in family.OrderBy(f => f.FontType).ThenBy(f => f.FaceName).ThenBy(f => f.FileDate)) {
                    var lvi = new ListViewItem(font.FaceName) {
                        Group = lvg,
                        Tag = font,
                        ImageIndex = font.FontType.ToLower() == "ttf" ? 3 : 2
                    };
                    lvi.SubItems.Add(font.GlyphCount.ToString());
                    lvi.SubItems.Add(font.Version);
                    lvFonts.Items.Add(lvi);
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e) {
            var lv = (ListView)sender;
            EnableCheckBasedToolstripButtons(lv);
            toolStripButtonRenameFile.Visible = lv.SelectedItems.Count > 0;
            if (!toolStripButtonRenameFile.Visible) return;
            DisplayFont((FontInfo)lv.SelectedItems[0].Tag);
        }

        private void listView_ItemChecked(object sender, ItemCheckedEventArgs e) {
            EnableCheckBasedToolstripButtons((ListView)sender);
        }
        #endregion

        #region TABS
        private void tabControl1_Selected(object sender, TabControlEventArgs e) {
            var tab = sender as TabControl;
            toolStripButtonSelect.Visible = tab.SelectedIndex != 2;
            toolStripButtonDeselect.Visible = tab.SelectedIndex == 2;

            switch (tab.SelectedIndex) {
                case 0:
                    toolStripButtonUncheck.Visible =
                        toolStripButtonDelete.Visible =
                        lvFonts.CheckedItems.Cast<ListViewItem>().Any();
                    break;
                case 1:
                    toolStripButtonUncheck.Visible =
                        toolStripButtonDelete.Visible =
                        tvFonts.Nodes.Descendants().Any(n => n.Checked);
                    if (!tvFonts.Nodes.Cast<TreeNode>().Any())
                        GetFontFolder();
                    break;
                case 2:
                    toolStripButtonUncheck.Visible =
                        toolStripButtonDelete.Visible =
                        lvSelected.CheckedItems.Cast<ListViewItem>().Any();
                    break;
            }
        }
        #endregion

        #region TOOLSTRIP

        private void EnableCheckBasedToolstripButtons(ListView lv) {
            toolStripButtonSelect.Visible =
            toolStripButtonUncheck.Visible =
                toolStripButtonDelete.Visible =
                    lv.CheckedItems.Cast<ListViewItem>().Any();
        }
        private void toolStripButtonSelect_Click(object sender, EventArgs e) {
            switch (tabControl1.SelectedIndex) {
                case 0:
                    AddToSelected(lvFonts.
                        CheckedItems.Cast<ListViewItem>().Select(n => (FontInfo)n.Tag));
                    break;
                case 1:
                    AddToSelected(
                    tvFonts.Nodes.Descendants()
                        .Where(n => n.Checked && !string.IsNullOrEmpty(n.Name))
                        .Select(n => n.Tag));
                    break;
                default:
                case 2:
                    break;
            }
        }

        private void AddToSelected(IEnumerable<object> fonts) {
            foreach (FontInfo font in fonts) {
                if (lvSelected.Items.Cast<ListViewItem>().Any(i => i.Name == font.FullName)) continue;
                var lvg = GetGroup(font.FamilyName);
                var lvi = new ListViewItem(font.FaceName) {
                    Name = font.FullName,
                    Group = lvg,
                    Tag = font,
                    ImageIndex = font.FontType.ToLower() == "ttf" ? 3 : 2
                };
                lvi.SubItems.Add(font.GlyphCount.ToString());
                lvi.SubItems.Add(font.Version);
                lvSelected.Items.Add(lvi);
            }
        }

        private ListViewGroup GetGroup(string text) {
            var lvg = lvSelected.Groups.Cast<ListViewGroup>().FirstOrDefault(g => g.Name == text);
            if (lvg != null) return lvg;
            lvg = new ListViewGroup(text, text);
            lvSelected.Groups.Add(lvg);
            return lvg;
        }

        private void toolStripButtonUncheck_Click(object sender, EventArgs e) {
            switch (tabControl1.SelectedIndex) {
                case 0:
                    foreach (ListViewItem item in lvFonts.Items)
                        item.Checked = false;
                    break;
                case 1:
                    var root = tvFonts.Nodes[0];
                    root.Checked = false;
                    CheckChildren(root);
                    break;
                default:
                case 2:
                    foreach (ListViewItem item in lvSelected.Items)
                        item.Checked = false;
                    break;
            }
        }

        private void toolStripButtonDeselect_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in lvSelected.CheckedItems)
                item.Remove();
            EnableCheckBasedToolstripButtons(lvSelected);
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show(@"Are you sure?", @"Delete Fonts",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            switch (tabControl1.SelectedIndex) {
                case 0:
                    DeleteFromListView(lvFonts);
                    break;
                case 1:
                    foreach (var item in tvFonts.Nodes.Descendants().Where(n => n.Checked)) {
                        MoveFont(item.Tag);
                        tvFonts.Nodes.Remove(item);
                    }
                    break;
                case 2:
                    DeleteFromListView(lvSelected);
                    break;
            }
            _ctx.SaveChanges();
            toolStripButtonDelete.Visible = false;
        }

        private void DeleteFromListView(ListView lv) {
            foreach (var item in lv.CheckedItems.Cast<ListViewItem>()) {
                MoveFont(item.Tag);
                lv.Items.Remove(item);
            }
        }

        private void MoveFont(object tag) {
            var font = (FontInfo)tag;
            var newName = Path.Combine(@"D:\Removed Fonts", font.FileName);
            File.Move(font.FullName, newName);
            _ctx.Fonts.Remove(font);
        }

        private void toolStripButtonRenameFile_Click(object sender, EventArgs e) {
            FontInfo font = null;
            switch (tabControl1.SelectedIndex) {
                case 0:
                    font = (FontInfo)lvFonts.SelectedItems[0].Tag;
                    break;
                case 1:
                    font = (FontInfo)tvFonts.SelectedNode.Tag;
                    break;
                case 2:
                    font = (FontInfo)lvSelected.SelectedItems[0].Tag;
                    break;
            }
            if (font == null) return;

            string newName;
            string newFullName;
            do {
                newName = font.FileName;
                if (PromptDialog.InputFilename("Rename File", "Enter file's new name", ref newName) ==
                    DialogResult.Cancel) return;
                newFullName = Path.Combine(font.Folder.Path, newName);
                if (!File.Exists(newFullName)) break;
                if (MessageBox.Show($"There is already a file named {newName} in {font.Folder.Path}",
                        "Rename File", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) ==
                    DialogResult.Cancel) return;
            } while (true);
            File.Move(font.FullName, newFullName);
            font.FileName = newName;
            _ctx.SaveChanges();
            DisplayFont(font);
        }

        private void toolStripButtonCataloger_Click(object sender, EventArgs e) {
            if (FBD.ShowDialog() != DialogResult.OK) return;
            // Use ProcessStartInfo class
            var startInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                UseShellExecute = false,
                FileName =
                    @"D:\Users\nfric\Documents\Visual Studio 2017\Projects\FontCatalogConsole\FontCatalogConsole\bin\Debug\FontCatalogConsole.exe",
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = "\"" + FBD.SelectedPath + "\""
            };

            try {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (var exeProcess = Process.Start(startInfo)) {
                    exeProcess.WaitForExit();
                }
            }
            catch {
                // Log error.
            }
        }

        #endregion
    }
}