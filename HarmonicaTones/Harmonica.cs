using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicaTones
{
    public class Harmonica
    {
        public MusicalNotes Notes { get; set; }
        public int HARMONICA_HOLES { get; private set; }
        public int Harmonica_tune { get; private set; }
        public Dictionary<int, int> BlowNotes { get; set; }
        public Dictionary<int, int> DrawNotes { get; set; }
        public Dictionary<int, int> BendNotes { get; set; }


        public Harmonica()
        {
            Notes = new MusicalNotes();

            HARMONICA_HOLES = 10;
            Harmonica_tune = 1; // Code note at C

            BlowNotes = new Dictionary<int, int>() //blow positions to notes
                    {
                        {1, 1},
                        {2, 5},
                        {3, 8},
                        {4, 1},
                        {5, 5},
                        {6, 8},
                        {7, 1},
                        {8, 5},
                        {9, 8},
                        {10, 1}
                    };
            DrawNotes = new Dictionary<int, int>() //draw positions to notes
                    {
                        {1, 3},
                        {2, 8},
                        {3, 12},
                        {4, 3},
                        {5, 6},
                        {6, 10},
                        {7, 12},
                        {8, 3},
                        {9, 6},
                        {10, 10}
                    };
            BendNotes = new Dictionary<int, int>() //draw positions to notes
                    {
                        {1, 2},
                        {2, 7},
                        {3, 6},
                        {4, 11},
                        {5, 10},
                        {6, 9},
                        {7, 2},
                        {8, 9},
                    };
        }

        public void ChangeHarmonicaTune(int targetTune)
        {
            int shift = Notes.GetShift(Harmonica_tune, targetTune);

            for (int i = 1; i <= HARMONICA_HOLES; i++)
            {
                BlowNotes[i] = Notes.TransposeNote(BlowNotes[i], shift);
                DrawNotes[i] = Notes.TransposeNote(DrawNotes[i], shift);
            }
            ChangeBendsInHarmonicaTune(shift);

            Harmonica_tune = targetTune;
        }
        private void ChangeBendsInHarmonicaTune(int shift)
        {
            for (int i = 1; i <= BendNotes.Count; i++)
            {
                BendNotes[i] = Notes.TransposeNote(BendNotes[i], shift);
            }
        }
    }
}
