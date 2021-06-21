
namespace MaxwellEditorText.Forms
{
    partial class FontSizeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SizeValueTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.ApplyFontSizeButton = new Guna.UI2.WinForms.Guna2Button();
            this.PercentSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SizeValueTrackBar
            // 
            this.SizeValueTrackBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.SizeValueTrackBar.HoverState.Parent = this.SizeValueTrackBar;
            this.SizeValueTrackBar.Location = new System.Drawing.Point(12, 46);
            this.SizeValueTrackBar.Name = "SizeValueTrackBar";
            this.SizeValueTrackBar.Size = new System.Drawing.Size(407, 23);
            this.SizeValueTrackBar.TabIndex = 0;
            this.SizeValueTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.SizeValueTrackBar.Value = 12;
            this.SizeValueTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SizeValueTrackBar_Scroll);
            // 
            // ApplyFontSizeButton
            // 
            this.ApplyFontSizeButton.CheckedState.Parent = this.ApplyFontSizeButton;
            this.ApplyFontSizeButton.CustomImages.Parent = this.ApplyFontSizeButton;
            this.ApplyFontSizeButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyFontSizeButton.ForeColor = System.Drawing.Color.White;
            this.ApplyFontSizeButton.HoverState.Parent = this.ApplyFontSizeButton;
            this.ApplyFontSizeButton.Location = new System.Drawing.Point(12, 82);
            this.ApplyFontSizeButton.Name = "ApplyFontSizeButton";
            this.ApplyFontSizeButton.ShadowDecoration.Parent = this.ApplyFontSizeButton;
            this.ApplyFontSizeButton.Size = new System.Drawing.Size(407, 37);
            this.ApplyFontSizeButton.TabIndex = 1;
            this.ApplyFontSizeButton.Text = "Aplicar tamaño";
            this.ApplyFontSizeButton.Click += new System.EventHandler(this.ApplyFontSizeButton_Click);
            // 
            // PercentSize
            // 
            this.PercentSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentSize.Location = new System.Drawing.Point(12, 9);
            this.PercentSize.Name = "PercentSize";
            this.PercentSize.Size = new System.Drawing.Size(407, 39);
            this.PercentSize.TabIndex = 2;
            this.PercentSize.Text = "Tamaño = 12%";
            this.PercentSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 131);
            this.Controls.Add(this.PercentSize);
            this.Controls.Add(this.ApplyFontSizeButton);
            this.Controls.Add(this.SizeValueTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FontSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FontSizeForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button ApplyFontSizeButton;
        private System.Windows.Forms.Label PercentSize;
        public Guna.UI2.WinForms.Guna2TrackBar SizeValueTrackBar;
    }
}