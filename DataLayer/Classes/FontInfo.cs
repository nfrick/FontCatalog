using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Media;
using System.Drawing;

namespace DataLayer {
    public partial class FontInfo {
        private static readonly CultureInfo Info = new CultureInfo("en-US");

        public string FullName => Folder == null || FileName == null ? "" :
            Path.Combine(Folder.Path, FileName);

        public string FontName => $"{FamilyName} {FaceName}";

        public bool HasInfo => string.IsNullOrEmpty(ErrorMessage);

        public FontStyle FStyle() {
            var fs = FontStyle.Regular;
            if (!HasInfo) return fs;
            if (Weight.IndexOf("bold", StringComparison.OrdinalIgnoreCase) >= 0 ||
                Weight.IndexOf("black", StringComparison.OrdinalIgnoreCase) >= 0)
                fs |= FontStyle.Bold;
            if (Style.IndexOf("italic", StringComparison.OrdinalIgnoreCase) >= 0 ||
                Style.IndexOf("oblique", StringComparison.OrdinalIgnoreCase) >= 0)
                fs |= FontStyle.Italic;
            return fs;
        }

        public FontInfo() {
        }

        public FontInfo(string path) : this(new FileInfo(path)) {
        }

        public FontInfo(FileInfo file, Folder folder = null) {
            Folder = folder;
            FileName = file.Name;
            FontType = file.Extension.Substring(1).ToLower();
            FileDate = file.LastWriteTimeUtc;
            FileSize = (int)file.Length;
            try {
                var ttf = new GlyphTypeface(new Uri(file.FullName));
                FamilyName = GetInfo(ttf.FamilyNames);
                FaceName = GetInfo(ttf.FaceNames);
                Baseline = (decimal)ttf.Baseline;
                CapsHeight = (decimal)ttf.CapsHeight;
                Description = GetInfo(ttf.Descriptions);
                ManufacturerName = GetInfo(ttf.ManufacturerNames);
                GlyphCount = ttf.GlyphCount;
                Height = (decimal)ttf.Height;
                Stretch = ttf.Stretch.ToString();
                Style = ttf.Style.ToString().Trim();
                Symbol = ttf.Symbol;
                Trademark = GetInfo(ttf.Trademarks);
                Version = ttf.Version.ToString(Info).Trim();
                Weight = ttf.Weight.ToString().Trim();
                XHeight = (decimal)ttf.XHeight;
            }
            catch (Exception ex) {
                ErrorMessage = ex.Message;
            }
        }

        private static string GetInfo(IDictionary<CultureInfo, string> dict, int start = 0, int length = 0) {
            if (!dict.ContainsKey(Info)) return null;
            var text = dict[Info].Trim();
            if (start == 0) {
                return length == 0 ? text : text.Substring(0, Math.Min(text.Length, length));
            }
            return start > text.Length ? null : text.Substring(start);
        }
    }
}
