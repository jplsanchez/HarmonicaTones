using HarmonicaTones.Properties;
using HarmonicaTones.res;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonicaTones
{
    public partial class MainForm : Form
    {
        public MainFormDisplay display = new MainFormDisplay(@"..\..\res\scales\");

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //public Scale ActiveScale = new Scale();
            display.ImageLayoutPanel = ImageLayoutPanel;
            display.ConfigureLabels();
            display.Load_ComboBox_withNotes(ToneComboBox);
            display.Load_ComboBox_withNotes(ScaleNotesComboBox);
            display.Load_ScaleComboBox(ScaleComboBox);

            RefreshAll();
        }

        private void RefreshAll()
        {
            display.RefreshToneComboBox(ToneComboBox); 
            display.RefreshScaleComboBox(ScaleComboBox); 
            display.RefreshScaleNotesComboBox(ScaleNotesComboBox); 
            display.MarkNotesInScale(display.Scale.Scale);
            display.UpdateNotes_atHarmonicaLabels();
        }

        private void TabsToolsMenuItem_Click(object sender, EventArgs e)
        {
            _2___TabsUtilityForm tabsForm = new _2___TabsUtilityForm(display.Harmonica);
            tabsForm.StartPosition = FormStartPosition.CenterParent;
            tabsForm.Size = this.Size;
            tabsForm.ShowDialog(this);
        }

        private void ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void ScaleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void ScaleNotesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }


       

        
    }

}
