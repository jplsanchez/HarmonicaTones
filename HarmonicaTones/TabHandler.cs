using System.Collections.Generic;

namespace HarmonicaTones
{
    public class TabHandler
    {
        public string Text { get; set; }
        public MusicalNotes Notes { get; set; }
        public List<int> NoteCodesList { get; set; }


        public TabHandler(string tabText)
        {
            Notes = new MusicalNotes();

            Text = tabText;
            NoteCodesList = new List<int>();
        }

        public string NotesToTabs()
        {
            List<int> codesList = NoteTextToCodes();
            foreach (int code in codesList)
            {
                ;
            }
            return $"{1} ";
        }
        private List<int> NoteTextToCodes()
        {
            int index = 0;
            foreach (char character in Text)
            {
                if (ValidateIfCharIsANote(character))
                {
                    int noteCode = Notes.NotesCodeFromString[$"{character}"];
                    noteCode = CheckandUpdateNoteCodeforAccidents(index, noteCode);
                    NoteCodesList.Add(noteCode);
                }
                index++;
            }
            return NoteCodesList;
        }
        private int CheckandUpdateNoteCodeforAccidents(int index, int noteCode)
        {
            if (ValidateIfCharBelongsToAnAccidentNote(index))
            {
                char accident = Text[index + 1];
                noteCode = Notes.UpdateNoteCodeFromAccident(noteCode, accident);
            }

            return noteCode;
        }
        private bool ValidateIfCharBelongsToAnAccidentNote(int index)
        {
            if (Text.Length > index + 1)
            {
                bool valor = Text[index + 1] == 'b' | Text[index + 1] == '#';
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
