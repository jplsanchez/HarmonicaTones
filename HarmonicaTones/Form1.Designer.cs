
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
            this.label_HarmonicaTune = new System.Windows.Forms.Label();
            this.ToneComboBox = new System.Windows.Forms.ComboBox();
            this.label_ScaleFamily = new System.Windows.Forms.Label();
            this.ScaleComboBox = new System.Windows.Forms.ComboBox();
            this.ScaleNotesComboBox = new System.Windows.Forms.ComboBox();
            this.HarmonicaPicture = new System.Windows.Forms.PictureBox();
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImageLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicaPicture)).BeginInit();
            this.MainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLayoutPanel
            // 
            this.HeaderLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderLayoutPanel.ColumnCount = 4;
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.46777F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53222F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.HeaderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 631F));
            this.HeaderLayoutPanel.Controls.Add(this.label_HarmonicaTune, 0, 0);
            this.HeaderLayoutPanel.Controls.Add(this.ToneComboBox, 0, 1);
            this.HeaderLayoutPanel.Controls.Add(this.label_ScaleFamily, 1, 0);
            this.HeaderLayoutPanel.Controls.Add(this.ScaleComboBox, 2, 1);
            this.HeaderLayoutPanel.Controls.Add(this.ScaleNotesComboBox, 1, 1);
            this.HeaderLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.HeaderLayoutPanel.Name = "HeaderLayoutPanel";
            this.HeaderLayoutPanel.RowCount = 4;
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.90244F));
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.09756F));
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.HeaderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.HeaderLayoutPanel.Size = new System.Drawing.Size(1232, 177);
            this.HeaderLayoutPanel.TabIndex = 1;
            // 
            // label_HarmonicaTune
            // 
            this.label_HarmonicaTune.AutoSize = true;
            this.label_HarmonicaTune.Location = new System.Drawing.Point(3, 0);
            this.label_HarmonicaTune.Name = "label_HarmonicaTune";
            this.label_HarmonicaTune.Size = new System.Drawing.Size(184, 25);
            this.label_HarmonicaTune.TabIndex = 2;
            this.label_HarmonicaTune.Text = "Afinação da Gaita";
            // 
            // ToneComboBox
            // 
            this.ToneComboBox.FormattingEnabled = true;
            this.ToneComboBox.Location = new System.Drawing.Point(3, 45);
            this.ToneComboBox.Name = "ToneComboBox";
            this.ToneComboBox.Size = new System.Drawing.Size(310, 33);
            this.ToneComboBox.TabIndex = 2;
            this.ToneComboBox.SelectedIndexChanged += new System.EventHandler(this.ToneComboBox_SelectedIndexChanged);
            // 
            // label_ScaleFamily
            // 
            this.label_ScaleFamily.AutoSize = true;
            this.label_ScaleFamily.Location = new System.Drawing.Point(365, 0);
            this.label_ScaleFamily.Name = "label_ScaleFamily";
            this.label_ScaleFamily.Size = new System.Drawing.Size(77, 25);
            this.label_ScaleFamily.TabIndex = 4;
            this.label_ScaleFamily.Text = "Escala";
            // 
            // ScaleComboBox
            // 
            this.ScaleComboBox.FormattingEnabled = true;
            this.ScaleComboBox.Location = new System.Drawing.Point(482, 45);
            this.ScaleComboBox.Name = "ScaleComboBox";
            this.ScaleComboBox.Size = new System.Drawing.Size(115, 33);
            this.ScaleComboBox.TabIndex = 3;
            this.ScaleComboBox.SelectedIndexChanged += new System.EventHandler(this.ScaleComboBox_SelectedIndexChanged);
            // 
            // ScaleNotesComboBox
            // 
            this.ScaleNotesComboBox.FormattingEnabled = true;
            this.ScaleNotesComboBox.Location = new System.Drawing.Point(365, 45);
            this.ScaleNotesComboBox.Name = "ScaleNotesComboBox";
            this.ScaleNotesComboBox.Size = new System.Drawing.Size(111, 33);
            this.ScaleNotesComboBox.TabIndex = 6;
            this.ScaleNotesComboBox.SelectedIndexChanged += new System.EventHandler(this.ScaleNotesComboBox_SelectedIndexChanged);
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
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
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
            this.ImageLayoutPanel.Location = new System.Drawing.Point(3, 186);
            this.ImageLayoutPanel.Name = "ImageLayoutPanel";
            this.ImageLayoutPanel.RowCount = 6;
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.87861F));
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.68786F));
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.72254F));
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ImageLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ImageLayoutPanel.Size = new System.Drawing.Size(1232, 375);
            this.ImageLayoutPanel.TabIndex = 3;
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
            this.HeaderLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HarmonicaPicture)).EndInit();
            this.MainLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel HeaderLayoutPanel;
        private ComboBox ToneComboBox;
        private PictureBox HarmonicaPicture;
        private TableLayoutPanel MainLayoutPanel;
        private TableLayoutPanel ImageLayoutPanel;
        private ComboBox ScaleComboBox;
        private Label label_HarmonicaTune;
        private Label label_ScaleFamily;
        private ComboBox ScaleNotesComboBox;
    }
}

