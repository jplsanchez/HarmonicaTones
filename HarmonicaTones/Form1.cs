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
    public partial class MainForm : Form
    {
        public List<Label> blowNote_labels = new List<Label>();
        public List<Label> drawNote_labels = new List<Label>();
        public Dictionary<int, string> Notes = new Dictionary<int, string>() //Translate notes to int
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
        public Dictionary<int, int> BlowNotes = new Dictionary<int, int>() //blow positions to notes
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
        public Dictionary<int, int> DrawNotes = new Dictionary<int, int>() //draw positions to notes
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


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            ConfigureLabels();
            
        }

        private void ConfigureLabels()
        {
            for (int i = 0; i < 10; i++)
            {
                blowNote_labels.Add(new Label());
                ImageLayoutPanel.Controls.Add(blowNote_labels[i], i + 1, 0);

                blowNote_labels[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                blowNote_labels[i].AutoSize = true;
                blowNote_labels[i].BackColor = System.Drawing.Color.Transparent;
                blowNote_labels[i].Location = new System.Drawing.Point(83, 0);
                blowNote_labels[i].Name = "B" + (i + 1).ToString();
                blowNote_labels[i].Size = new System.Drawing.Size(101, 92);
                blowNote_labels[i].TabIndex = 0;
                blowNote_labels[i].Text = "label";
                blowNote_labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                
                if (BlowNotes.TryGetValue(i + 1, out int Note_asInteger))
                {
                    if (Notes.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        blowNote_labels[i].Text = Note_asString;
                    }
                    
                }
            }

            for (int i = 0; i < 10; i++)
            {
                drawNote_labels.Add(new Label());
                ImageLayoutPanel.Controls.Add(drawNote_labels[i], i + 1, 2);

                drawNote_labels[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                drawNote_labels[i].AutoSize = true;
                drawNote_labels[i].BackColor = System.Drawing.Color.Transparent;
                drawNote_labels[i].Location = new System.Drawing.Point(83, 0);
                drawNote_labels[i].Name = "D" + (i + 1).ToString();
                drawNote_labels[i].Size = new System.Drawing.Size(101, 92);
                drawNote_labels[i].TabIndex = 0;
                drawNote_labels[i].Text = "label";
                drawNote_labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                if (DrawNotes.TryGetValue(i + 1, out int Note_asInteger))
                {
                    if (Notes.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        drawNote_labels[i].Text = Note_asString;
                    }
                }
            }
        }

        private int TransposeNote(int note, int shift)
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

        private int GetShift(int tune, int targetTune)
        {
            return tune - targetTune;
        }

        private int ChangeHarmonicaTune(string tone)
        {
            return 0;
        }
    }
}
