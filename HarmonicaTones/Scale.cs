using System;
using System.Collections.Generic;
using System.IO;

namespace HarmonicaTones
{
    public class Scale
    {
        public List<int> scale = new List<int>()
        {
            1,
            3,
            5,
            6,
            8,
            10,
            12

        };

        public Scale()
        {

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

        public void ChangeScale(string scalePath)
        {
            byte[] scaleInByte = File.ReadAllBytes(scalePath);
            this.scale.Clear();

            foreach (byte note in scaleInByte)
            {
                scale.Add(Convert.ToInt32(note));
            }
        }

        public void ChangeScaleTone(int targetTone)
        {
            int shift = GetShift(1, targetTone);

            for (int i = 0; i < scale.Count; i++)
            {
                this.scale[i] = TransposeNote(this.scale[i], shift);
            }
        }

    }

}
