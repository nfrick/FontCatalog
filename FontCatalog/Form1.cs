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
        private PrivateFontCollection _pfcSearch = new PrivateFontCollection();
        private PrivateFontCollection _pfcSelected = new PrivateFontCollection();
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
            if (!tlpDisplayFont.Visible) return;
            var pfc = new PrivateFontCollection();
            pfc.AddFontFile(font.FullName);

            textBoxSample.Text = $"{font.FamilyName.ToUpper()} {font.FaceName.ToUpper()} {trackBarSize.Value}" +
                                 "\r\nThe quick brown fox jumps over the lazy dog." +
                                 "\r\n1234567890      R$ 123.456,78" +
                                 "\r\náéíóú ÁÉÍÓÚ ãõ ÃÕ âêîôû ÂÊÎÔÛ";
            try {
                textBoxSample.Font = new Font(pfc.Families[0], trackBarSize.Value, font.FStyle());
            }
            catch {
                MessageBox.Show("Unable to display font sample.", "Font Catalog",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                textBoxSample.BackColor = buttonBackground.BackColor = panel3.BackColor = CD.Color;
        }

        private void buttonColorSwap_Click(object sender, EventArgs e) {
            var temp = textBoxSample.BackColor;
            textBoxSample.BackColor = buttonBackground.BackColor =
                panel3.BackColor = textBoxSample.ForeColor;
            textBoxSample.ForeColor = buttonForeground.BackColor = temp;
        }
        #endregion

        #region SEARCH
        private void buttonSearch_Click(object sender, EventArgs e) {
            IQueryable<FontInfo> fonts;
            var button = sender as Button;
            switch (button.Text) {
                case "Family":
                    fonts = _ctx.Fonts.Where(f => f.FamilyName.Contains(textBoxTarget.Text));
                    break;
                case "Name":
                    fonts = _ctx.Fonts.Where(f => f.FaceName.Contains(textBoxTarget.Text));
                    break;
                case "File":
                    fonts = _ctx.Fonts.Where(f => f.FileName.Contains(textBoxTarget.Text));
                    break;
                default:
                    fonts = _ctx.Fonts.Where(f => f.Symbol == true);
                    break;
            }
            ListViewPopulate(lvSearch, fonts);
        }
        #endregion

        #region LISTVIEW

        private void ListViewPopulate(ListView lv,
            IEnumerable<FontInfo> fonts) {
            lv.Items.Clear();
            if (!fonts.Any()) {
                MessageBox.Show(@"No fonts found.");
                return;
            }

            PrivateFontCollection pfc;
            if (lv.Name == "lvSearch") {
                _pfcSearch = new PrivateFontCollection();
                pfc = _pfcSearch;
            }
            else {
                _pfcSelected = new PrivateFontCollection();
                pfc = _pfcSelected;
            }

            var families = fonts.OrderBy(f => f.FamilyName).GroupBy(f => f.FamilyName);

            foreach (var family in families) {
                var lvg = new ListViewGroup(family.Key);
                lv.Groups.Add(lvg);
                foreach (var font in family.OrderBy(f => f.FontType)
                    .ThenBy(f => f.FaceName).ThenBy(f => f.FileDate)) {
                    pfc.AddFontFile(font.FullName);
                    var fontFamily = pfc.Families.FirstOrDefault(f => f.Name == font.FamilyName) ?? pfc.Families.FirstOrDefault(f => f.Name == font.FontName);
                    var lvi = new ListViewItem {
                        Text = font.FaceName + (fontFamily == null ? "*" : ""),
                        Font = fontFamily == null ? new Font("Segoe UI", 12) : new Font(fontFamily, 16, font.FStyle()),
                        Group = lvg,
                        Tag = font,
                        ImageIndex = font.FontType.ToLower() == "ttf" ? 3 : 2,
                        UseItemStyleForSubItems = false
                    };
                    lvi.SubItems.Add(CreateSubItem(font.GlyphCount.ToString()));
                    lvi.SubItems.Add(CreateSubItem(font.Version));
                    lv.Items.Add(lvi);
                }
            }
            lv.SelectedIndices.Add(0);
        }

        private ListViewItem.ListViewSubItem CreateSubItem(string text) {
            return new ListViewItem.ListViewSubItem() {
                Text = text,
                Font = new Font("Segoe UI", 14),
            };
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

        private void lvFonts_DrawItem(object sender, DrawListViewItemEventArgs e) {
            // Ignored if listview OwnerDraw = false
            e.DrawDefault = true;
            e.Item.BackColor = e.ItemIndex % 2 == 0 ?
                Color.FromArgb(230, 230, 255) : Color.FromArgb(255, 255, 255);
            e.Item.UseItemStyleForSubItems = true;
        }
        #endregion

        #region TABS
        private void tabControl1_Selected(object sender, TabControlEventArgs e) {
            var tab = sender as TabControl;

            switch (tab.SelectedIndex) {
                case 0:
                    toolStripButtonDeselect.Visible = false;
                    toolStripButtonSelect.Visible =
                    toolStripButtonUncheck.Visible =
                        toolStripButtonDelete.Visible =
                        lvSearch.CheckedItems.Cast<ListViewItem>().Any();
                    break;
                case 1:
                    toolStripButtonDeselect.Visible = false;
                    toolStripButtonSelect.Visible =
                    toolStripButtonUncheck.Visible =
                        toolStripButtonDelete.Visible =
                        tvFonts.Nodes.Descendants().Any(n => n.Checked);
                    if (!tvFonts.Nodes.Cast<TreeNode>().Any())
                        GetFontFolder();
                    break;
                case 2:
                    toolStripButtonSelect.Visible = false;
                    toolStripButtonDeselect.Visible =
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
            toolStripButtonDeselect.Visible =
            toolStripButtonUncheck.Visible =
                toolStripButtonDelete.Visible =
                    lv.CheckedItems.Cast<ListViewItem>().Any();
            toolStripButtonSelect.Visible &= tabControl1.SelectedIndex != 2;
            toolStripButtonDeselect.Visible &= tabControl1.SelectedIndex == 2;
        }

        private void toolStripButtonSelect_Click(object sender, EventArgs e) {
            switch (tabControl1.SelectedIndex) {
                case 0:
                    AddToSelected(lvSearch.
                        CheckedItems.Cast<ListViewItem>().Select(n => n.Tag));
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
            var existing = new List<object>();
            existing.AddRange(lvSelected.Items.Cast<ListViewItem>().Select(f => f.Tag));
            var all = fonts.Concat(existing);
            ListViewPopulate(lvSelected, all.Cast<FontInfo>());
        }
        
        private void toolStripButtonUncheck_Click(object sender, EventArgs e) {
            switch (tabControl1.SelectedIndex) {
                case 0:
                    foreach (ListViewItem item in lvSearch.Items)
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
            EnableCheckBasedToolstripButtons(lvSelected);
            var existing = new List<FontInfo>();
            existing.AddRange(lvSelected.Items.Cast<ListViewItem>().Where(f => !f.Checked).Select(f => (FontInfo)f.Tag));
            ListViewPopulate(lvSelected, existing);
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show(@"Are you sure?", @"Delete Fonts",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            switch (tabControl1.SelectedIndex) {
                case 0:
                    DeleteFromListView(lvSearch);
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
                    font = (FontInfo)lvSearch.SelectedItems[0].Tag;
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
            var startInfo = new ProcessStartInfo {
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