using System;
using System.Collections.Generic;
using System.IO;

namespace HarmonicaTones
{
    public class MusicalScale
    {
        public List<int> Scale { get; set; }
        public MusicalNotes Notes { get; set; }


        public MusicalScale()
        {
            Notes = new MusicalNotes();
            Scale = new List<int>();
        }

        public void ChangeScale(string scalePath)
        {
            byte[] scaleInByte = File.ReadAllBytes(scalePath);
            this.Scale.Clear();

            foreach (byte note in scaleInByte)
            {
                Scale.Add(Convert.ToInt32(note));
            }
        }
        public void ChangeScaleTone(int targetTone)
        {
            int shift = Notes.GetShift(1, targetTone);

            for (int i = 0; i < Scale.Count; i++)
            {
                this.Scale[i] = Notes.TransposeNote(this.Scale[i], shift);
            }
        }

    }

}
