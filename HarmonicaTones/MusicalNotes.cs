using System.Collections.Generic;

namespace HarmonicaTones
{
    public class MusicalNotes
    {
        public Dictionary<int, string> NotesCode { get; private set; }
        public Dictionary<string, int> NotesCodeFromString { get; private set; }


        public MusicalNotes()
        {
            NotesCode = new Dictionary<int, string>() //Translate note values to their meaning
            {
                {1, "C"},
                {2, "C#"},
                {3, "D"},
                {4, "D#"},
                {5, "E"},
                {6, "F"},
                {7, "F#"},
                {8, "G"},
                {9, "G#"},
                {10, "A"},
                {11, "A#"},
                {12, "B"}
            };
            NotesCodeFromString = new Dictionary<string, int>() //Translate notes strings to their value
            {
                {"C", 1},
                {"C#", 2},
                {"D", 3},
                {"D#", 4},
                {"E", 5},
                {"F", 6},
                {"F#", 7},
                {"G", 8},
                {"G#", 9},
                {"A", 10},
                {"A#", 11},
                {"B", 12}
            };
        }

        public int GetShift(int tune, int targetTune)
        {
            return targetTune - tune;
        }
        public int TransposeNote(int note, int shift)
        {
            note += shift;
            while (note > 12)
            {
                note -= 12;
            }
            while (note <= 0)
            {
                note += 12;
            }
            return note;
        }
        public int UpdateNoteCodeFromAccident(int noteCode, char accident)
        {
            if (accident == '#')
            {
                noteCode = TransposeNote(noteCode, 1);
            }
            if (accident == 'b')
            {
                noteCode = TransposeNote(noteCode, -1);
            }

            return noteCode;
        }
    }
}
