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
        public const int HARMONICA_HOLES = 10;
        public int harmonica_tune = 1;
        public List<Label> blowNote_labels = new List<Label>();
        public List<Label> drawNote_labels = new List<Label>();
        public Dictionary<int, string> Notes = new Dictionary<int, string>() //Translate note values to their meaning
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
        public Dictionary<string, int> NotesFromString = new Dictionary<string, int>() //Translate notes strings to their value
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

        // Loading Form

        private void MainForm_Load(object sender, EventArgs e)
        {
            Load_ToneComboBox();
            ConfigureLabels();
            
        }

        private void Load_ToneComboBox()
        {
            ToneComboBox.DataSource = new BindingSource(Notes, null);
            ToneComboBox.DisplayMember = "Value";
            ToneComboBox.ValueMember = "Key";
            //ToneComboBox.SelectedIndex = 0;
        }

        private void ConfigureLabels()
        {
            ImageLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            for (int i = 0; i < HARMONICA_HOLES; i++)
            {
                //Blow

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

                //Draw

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
            }

            UpdateNotes_atHarmonicaLabels();
        }

        // Harmonica Tuning

        private void UpdateNotes_atHarmonicaLabels()
        {
            for (int i = 0; i < HARMONICA_HOLES; i++)
            {
                if (BlowNotes.TryGetValue(i + 1, out int Note_asInteger))
                {
                    if (Notes.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        blowNote_labels[i].Text = Note_asString;
                    }

                }
                if (DrawNotes.TryGetValue(i + 1, out Note_asInteger))
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
            return targetTune - tune;
        }

        private void ChangeHarmonicaTune(int tune, int targetTune)
        {
            int shift = GetShift(tune, targetTune);

            for (int i = 1; i <= HARMONICA_HOLES; i++)
            {
                BlowNotes[i] = TransposeNote(BlowNotes[i], shift);
                DrawNotes[i] = TransposeNote(DrawNotes[i], shift);
            }
            this.harmonica_tune = targetTune;
            UpdateNotes_atHarmonicaLabels();
        }

        private void ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToneComboBox.SelectedValue.GetType() == typeof(int))
            {
                int selectedNote = (int)ToneComboBox.SelectedValue;
                ChangeHarmonicaTune(harmonica_tune, selectedNote);
            }
        }

        // Scale Marker

        private void ScalePicker()
        {

        }
        private void MarkNotesInScale()
        {

        }
        private void ChangeLabelColor()
        {

        }



    }
}
