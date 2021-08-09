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

            string outputText = "";
            foreach (int code in codesList)
            {
                outputText += Notes.NoteCodeToString(code);
            }
            return outputText;
        }
        private List<int> NoteTextToCodes()
        {
            int index = 0;
            foreach (char character in Text)
            {
                if (Notes.ValidateIfCharIsANote(character))
                {
                    int noteCode = Notes.StringToNoteCode($"{character}");
                    noteCode = CheckandUpdateNoteCodeforAccidents(index, noteCode);
                    NoteCodesList.Add(noteCode);
                }
                index++;
            }
            return NoteCodesList;
        }
        private int CheckandUpdateNoteCodeforAccidents(int index, int noteCode)
        {
            char accident = GetNextChar(index);
            if (Notes.ValidateIfCharIsAnAccident(accident))
            {
                noteCode = Notes.UpdateNoteCodeFromAccident(noteCode, accident);
            }
            return noteCode;
        }

        private char GetNextChar(int index)
        {
            if (Text.Length > index + 1)
            {
                return Text[index + 1];
            }
            return ' ';
        }
    }
}
