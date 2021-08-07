using System;
using System.Windows.Forms;

namespace HarmonicaTones
{
    public partial class _2___TabsUtilityForm : Form
    {
        public Harmonica Harmonica { get; set; }
        public MusicalNotes Notes { get; set; }
        public TabHandler Tab { get; set; }
        public _2___TabsUtilityForm(Harmonica harmonica)
        {
            InitializeComponent();
            Harmonica = harmonica;
        }

        //Events
        private void _2___TabsUtilityForm_Load(object sender, EventArgs e)
        {
            Notes = new MusicalNotes();
            Tab = new TabHandler(tabTextBox.Text);
            InfoLabel.Text = $"Gaita na afinação de {Notes.NotesCode[Harmonica.Harmonica_tune]}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotesToTabsButton_Click(object sender, EventArgs e)
        {
            tabTextBox.Text = Tab.NotesToTabs();
            //throw new NotImplementedException();
        }
    }
}
