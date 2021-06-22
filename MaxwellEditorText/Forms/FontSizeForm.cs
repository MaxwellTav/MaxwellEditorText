using System;
using System.Windows.Forms;

namespace MaxwellEditorText.Forms
{
    public partial class FontSizeForm : Form
    {
        public FontSizeForm()
        { InitializeComponent(); }

        private void ApplyFontSizeButton_Click(object sender, EventArgs e)
        { Hide(); }

        private void SizeValueTrackBar_Scroll(object sender, ScrollEventArgs e)
        { PercentSize.Text = "Tamaño " + SizeValueTrackBar.Value + "%"; }
    }
}
