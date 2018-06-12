using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontCatalog {
    class PromptDialog {
        public static DialogResult InputDate(string title, string promptText, ref DateTime value) {
            var dateBox = new DateTimePicker {
                Value = value,
                Format = DateTimePickerFormat.Short
            };
            var ret = InputPrompt(title, promptText, dateBox);
            value = dateBox.Value;
            return ret;
        }

        public static DialogResult InputString(string title, string promptText, ref string value) {
            var textBox = new TextBox() {
                Text = value,
            };
            var ret = InputPrompt(title, promptText, textBox);
            value = textBox.Text;
            return ret;
        }

        public static DialogResult InputFilename(string title, string promptText, ref string value) {
            DialogResult ret;
            var regexSearch = "\\" +
                              new string(Path.GetInvalidFileNameChars()) +
                              new string(Path.GetInvalidPathChars());
            var r = new Regex($"[{Regex.Escape(regexSearch)}]");
            var textBox = new TextBox();
            do {
                textBox.Text = value;
                ret = InputPrompt(title, promptText, textBox);
                value = r.Replace(textBox.Text, "");
            }
            while (ret == DialogResult.OK && !value.Equals(textBox.Text));
            return ret;
        }

        public static DialogResult InputMasked(string title, string promptText, ref string value, string mask) {
            var textBox = new MaskedTextBox() {
                Text = value,
                Mask = mask
            };

            var ret = InputPrompt(title, promptText, textBox);
            value = textBox.Text;
            return ret;
        }

        public static DialogResult InputDecimal(string title, string promptText, ref decimal value) {
            var textBox = new TextBox() {
                Text = value.ToString(),
            };
            var ret = InputPrompt(title, promptText, textBox);
            decimal.TryParse(textBox.Text, out value);
            return ret;
        }

        public static DialogResult InputPrompt(string title, string promptText, Control inputControl) {
            // http://www.csharp-examples.net/inputbox/
            var font = new Font("Segoe UI", 12);
            var form = new Form();
            var label = new Label();
            var buttonOk = new Button();
            var buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            inputControl.Font = font;

            buttonOk.Text = @"OK";
            buttonCancel.Text = @"Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 12, 372, 13);
            inputControl.SetBounds(12, 40, 372, 24);
            buttonOk.SetBounds(228, 86, 75, 30);
            buttonCancel.SetBounds(309, 86, 75, 30);

            label.AutoSize = true;
            inputControl.Anchor = inputControl.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 130);
            form.Font = font;
            form.Controls.AddRange(new Control[] { label, inputControl, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var dialogResult = form.ShowDialog();
            return dialogResult;
        }
    }
}
