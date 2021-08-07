using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonicaTones
{
    public partial class _2___TabsUtilityForm : Form
    {
        public Harmonica Harmonica { get; set; }
        public MusicalNotes Notes { get; set; }
        public _2___TabsUtilityForm(Harmonica harmonica)
        {
            InitializeComponent();
            Harmonica = harmonica;
        }

        private void _2___TabsUtilityForm_Load(object sender, EventArgs e)
        {
            Notes = new MusicalNotes();
            InfoLabel.Text = $"Gaita na afinação de {Notes.NotesCode[Harmonica.harmonica_tune]}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
