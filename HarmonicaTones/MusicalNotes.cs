using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HarmonicaTones
{
    public class MusicalNotes
    {
        public Dictionary<int, string> NotesCode = new Dictionary<int, string>() //Translate note values to their meaning
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
        public Dictionary<string, int> NotesCodeFromString = new Dictionary<string, int>() //Translate notes strings to their value
        {
            {"C", 1},
            {"C#", 1},
            {"D", 1},
            {"D#", 1},
            {"E", 1},
            {"F", 1},
            {"F#", 1},
            {"G", 1},
            {"G#", 1},
            {"A", 1},
            {"A#", 1},
            {"B", 1}
        };

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
    }
}
