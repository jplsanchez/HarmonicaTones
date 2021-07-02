
using System.Drawing;
using System.Windows.Forms;

namespace HarmonicaTones
{
    partial class MainForm
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
            this.HeaderLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ToneComboBox = new System.Windows.Forms.ComboBox();
            this.HarmonicaPicture = new System.Windows.Forms.PictureBox();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.B1 = new System.Windows.Forms.Label();
            this.HeaderLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicaPicture)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            this.ImageLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLayoutPanel
            // 
            this.HeaderLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLayoutPanel.ColumnCount = 2;
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.05519F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.94481F));
            this.HeaderLayoutPanel.Controls.Add(this.ToneComboBox, 0, 0);
            this.HeaderLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderLayoutPanel.Name = "HeaderLayoutPanel";
            this.HeaderLayoutPanel.RowCount = 2;
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.HeaderLayoutPanel.Size = new System.Drawing.Size(1232, 164);
            this.HeaderLayoutPanel.TabIndex = 1;
            // 
            // ToneComboBox
            // 
            this.ToneComboBox.FormattingEnabled = true;
            this.ToneComboBox.Items.AddRange(new object[] {
            "C",
            "C#",
            "D",
            "D#",
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A",
            "A#",
            "B"});
            this.ToneComboBox.Location = new System.Drawing.Point(3, 3);
            this.ToneComboBox.Name = "ToneComboBox";
            this.ToneComboBox.Size = new System.Drawing.Size(314, 24);
            this.ToneComboBox.TabIndex = 2;
            // 
            // HarmonicaPicture
            // 
            this.HarmonicaPicture.Location = new System.Drawing.Point(0, 0);
            this.HarmonicaPicture.Name = "HarmonicaPicture";
            this.HarmonicaPicture.Size = new System.Drawing.Size(100, 50);
            this.HarmonicaPicture.TabIndex = 0;
            this.HarmonicaPicture.TabStop = false;
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLayoutPanel.ColumnCount = 1;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Controls.Add(this.HeaderLayoutPanel, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.ImageLayoutPanel, 0, 1);
            this.MainLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 3;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.52595F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.47404F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(1238, 649);
            this.MainLayoutPanel.TabIndex = 1;
            // 
            // ImageLayoutPanel
            // 
            this.ImageLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageLayoutPanel.BackgroundImage = global::HarmonicaTones.Properties.Resources.Harmonica;
            this.ImageLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageLayoutPanel.ColumnCount = 12;
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.493506F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.685065F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.847403F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.36039F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.928572F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.36039F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.847403F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.685065F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.522727F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.441559F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.172078F));
            this.ImageLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.574676F));
            this.ImageLayoutPanel.Controls.Add(this.B1, 1, 0);
            this.ImageLayoutPanel.Location = new System.Drawing.Point(3, 173);
            this.ImageLayoutPanel.Name = "ImageLayoutPanel";
            this.ImageLayoutPanel.RowCount = 3;
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.87861F));
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.68786F));
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.72254F));
            this.ImageLayoutPanel.Size = new System.Drawing.Size(1232, 346);
            this.ImageLayoutPanel.TabIndex = 3;
            // 
            // B1
            // 
            this.B1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.B1.AutoSize = true;
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.Location = new System.Drawing.Point(83, 0);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(101, 92);
            this.B1.TabIndex = 0;
            this.B1.Text = "label1";
            this.B1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Harmonica Tones";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.HeaderLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicaPicture)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.ImageLayoutPanel.ResumeLayout(false);
            this.ImageLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel HeaderLayoutPanel;
        private ComboBox ToneComboBox;
        private PictureBox HarmonicaPicture;
        private TableLayoutPanel MainLayoutPanel;
        private TableLayoutPanel ImageLayoutPanel;
        private Label B1;
    }
}

