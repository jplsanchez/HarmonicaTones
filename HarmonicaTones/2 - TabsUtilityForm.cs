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

        //Events
        private void _2___TabsUtilityForm_Load(object sender, EventArgs e)
        {
            Notes = new MusicalNotes();
            InfoLabel.Text = $"Gaita na afinação de {Notes.NotesCode[Harmonica.harmonica_tune]}";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotesToTabsButton_Click(object sender, EventArgs e)
        {
            tabTextBox.Text = NotesToTabs(tabTextBox.Text);
            throw new NotImplementedException();
        }

        //Methods- String Manipulation
        private string NotesToTabs(string text)
        {
            List<int> codesList = NoteTextToCodes(text);
            foreach (int code in codesList)
            {
                ;
            }
            return $"{1} ";
        }

        private List<int> NoteTextToCodes(string text)
        {
            List<int> noteCodesList = new List<int>();
            int index = 0;
            foreach (char character in text)
            {
                if (ValidateIfCharIsANote(character))
                {
                    int noteCode = Notes.NotesCodeFromString[$"{character}"];
                    noteCode = CheckandUpdateNoteCodeforAccidents(text, index, noteCode);
                    noteCodesList.Add(noteCode);
                }
                index++;
            }
            return noteCodesList;
        }

        private int CheckandUpdateNoteCodeforAccidents(string text, int index, int noteCode)
        {
            if (ValidateIfNoteBelongsToAnAccidentNote(text, index))
            {
                char accident = text[index + 1];
                noteCode = Notes.UpdateNoteCodeFromAccident(noteCode, accident);
            }

            return noteCode;
        }

        private static bool ValidateIfNoteBelongsToAnAccidentNote(string text, int index)
        {
            if (text.Length > index+1)
            {
                bool valor =  text[index + 1] == 'b' | text[index + 1] == '#';
                return valor;
            }
            return false;
        }

        private bool ValidateIfCharIsANote(char character)
        {
            return Notes.NotesCodeFromString.ContainsKey($"{character}");
        }
    }
}
