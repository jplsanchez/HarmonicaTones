using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HarmonicaTones
{
    public class MainFormDisplay
    {
        private string ScalesPath { get; set; }
        public TableLayoutPanel ImageLayoutPanel { get; set; }
        public List<Label> BlowNote_labels { get; set; }
        public List<Label> DrawNote_labels { get; set; }
        public List<Label> BendNote_labels { get; set; }
        public MusicalNotes Notes { get; set; }
        public Harmonica Harmonica { get; set; }
        public MusicalScale Scale { get; set; }


        public MainFormDisplay(string scalesPath)
        {
            ScalesPath = scalesPath;
            BlowNote_labels = new List<Label>();
            DrawNote_labels = new List<Label>();
            BendNote_labels = new List<Label>();
            Notes = new MusicalNotes();
            Harmonica = new Harmonica();
            Scale = new MusicalScale();
        }

        // Loading Form
        public void Load_ComboBox_withNotes(ComboBox cbx)
        {
            cbx.DataSource = new BindingSource(Notes.NotesCode, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";
            //ToneComboBox.SelectedIndex = 0;
        }
        public void Load_ScaleComboBox(ComboBox cbx)
        {
            string[] Scales = Directory.GetFiles(ScalesPath);

            int i = 0;
            foreach (string item in Scales)
            {
                Scales[i] = item.Substring(ScalesPath.Length);
                i++;
            }
            cbx.DataSource = new BindingSource(Scales, null);
        }
        public void ConfigureLabels()
        {
            ImageLayoutPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);

            for (int i = 0; i < Harmonica.HARMONICA_HOLES; i++)
            {
                //Blow

                BlowNote_labels.Add(new Label());
                ImageLayoutPanel.Controls.Add(BlowNote_labels[i], i + 1, 0);

                BlowNote_labels[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                BlowNote_labels[i].AutoSize = true;
                BlowNote_labels[i].BackColor = System.Drawing.Color.Transparent;
                BlowNote_labels[i].Location = new System.Drawing.Point(83, 0);
                BlowNote_labels[i].Name = "B" + (i + 1).ToString();
                BlowNote_labels[i].Size = new System.Drawing.Size(101, 92);
                BlowNote_labels[i].TabIndex = 0;
                BlowNote_labels[i].Text = "label";
                BlowNote_labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                //Draw

                DrawNote_labels.Add(new Label());
                ImageLayoutPanel.Controls.Add(DrawNote_labels[i], i + 1, 2);

                DrawNote_labels[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                DrawNote_labels[i].AutoSize = true;
                DrawNote_labels[i].BackColor = System.Drawing.Color.Transparent;
                DrawNote_labels[i].Location = new System.Drawing.Point(83, 0);
                DrawNote_labels[i].Name = "D" + (i + 1).ToString();
                DrawNote_labels[i].Size = new System.Drawing.Size(101, 92);
                DrawNote_labels[i].TabIndex = 0;
                DrawNote_labels[i].Text = "label";
                DrawNote_labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            ConfigureBendLabels();
        }

        //Refresh Displays 
        public void RefreshToneComboBox(ComboBox ToneComboBox)
        {
            if (ToneComboBox.SelectedValue.GetType() == typeof(int))
            {
                int selectedNote = (int)ToneComboBox.SelectedValue;
                Harmonica.ChangeHarmonicaTune(selectedNote);
            }
        }
        public void RefreshScaleComboBox(ComboBox ScaleComboBox)
        {
            if (ScaleComboBox.SelectedValue != null)
            {
                Scale.ChangeScale(ScalesPath + ScaleComboBox.SelectedValue);

            }
        }
        public void RefreshScaleNotesComboBox(ComboBox ScaleNotesComboBox)
        {

            if (ScaleNotesComboBox.SelectedValue != null)
            {
                if (ScaleNotesComboBox.SelectedValue.GetType() == typeof(int))
                {
                    int selectedScaleNote = (int)ScaleNotesComboBox.SelectedValue;
                    Scale.ChangeScaleTone(selectedScaleNote);
                }
            }
        }

        // Label Format
        public void ClearLabelFormating()
        {
            for (int i = 0; i < Harmonica.HARMONICA_HOLES; i++)
            {
                BlowNote_labels[i].ForeColor = Color.Gray;
                BlowNote_labels[i].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                DrawNote_labels[i].ForeColor = Color.Gray;
                DrawNote_labels[i].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            }

            ClearBendLabelFormating();

        }
        public void ChangeLabelColor(Label label, Color color, FontStyle fontstyle)
        {
            label.ForeColor = color;
            label.Font = new Font("Microsoft Sans Serif", 12F, fontstyle);
        }

        // Harmonica Tuning
        public void UpdateNotes_atHarmonicaLabels()
        {
            UpdateBendNotes_atLabels();
            for (int i = 0; i < Harmonica.HARMONICA_HOLES; i++)
            {
                if (Harmonica.BlowNotes.TryGetValue(i + 1, out int Note_asInteger))
                {
                    if (Notes.NotesCode.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        BlowNote_labels[i].Text = Note_asString;
                    }

                }
                if (Harmonica.DrawNotes.TryGetValue(i + 1, out Note_asInteger))
                {
                    if (Notes.NotesCode.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        DrawNote_labels[i].Text = Note_asString;
                    }
                }
            }
        }

        // Scale Marker
        public void MarkNotesInScale(List<int> scale)
        {
            ClearLabelFormating();
            foreach (int note in scale)
            {
                for (int i = 0; i < Harmonica.HARMONICA_HOLES; i++)
                {
                    if (note == Harmonica.BlowNotes[i + 1])
                    {
                        ChangeLabelColor(BlowNote_labels[i], Color.Red, FontStyle.Bold);
                    }
                    if (note == Harmonica.DrawNotes[i + 1])
                    {
                        ChangeLabelColor(DrawNote_labels[i], Color.Red, FontStyle.Bold);
                    }
                }

                MarkBendNotesInScale(note);
            }
        }

        // Bends Extension
        public void ConfigureBendLabels()
        {
            int i = 0; //contador
            int bendDegreeCounter = 0;

            for (int hole = 0; hole < 6; hole++)
            {
                if (bendDegreeCounter < 3)
                {
                    for (int bendDegree = 0; bendDegree <= bendDegreeCounter; bendDegree++)
                    {
                        AddBendLabel(i, hole, bendDegree);
                        i++;
                    }
                }
                else if (hole != 4)
                {
                    AddBendLabel(i, hole, 0);
                    i++;
                }
                bendDegreeCounter++;
            }


        }
        public void AddBendLabel(int i, int hole, int bendDegree)
        {
            BendNote_labels.Add(new Label());
            ImageLayoutPanel.Controls.Add(BendNote_labels[i], hole + 1, 3 + bendDegree);

            BendNote_labels[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
            BendNote_labels[i].AutoSize = true;
            BendNote_labels[i].BackColor = System.Drawing.Color.Transparent;
            BendNote_labels[i].Location = new System.Drawing.Point(83, 0);
            BendNote_labels[i].Name = "Bend" + (i + 1).ToString();
            BendNote_labels[i].Size = new System.Drawing.Size(101, 92);
            BendNote_labels[i].TabIndex = 0;
            BendNote_labels[i].Text = "label";
            BendNote_labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
        public void UpdateBendNotes_atLabels()
        {
            for (int i = 0; i < Harmonica.BendNotes.Count; i++)
            {
                if (Harmonica.BendNotes.TryGetValue(i + 1, out int Note_asInteger))
                {
                    if (Notes.NotesCode.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        BendNote_labels[i].Text = Note_asString;
                    }

                }
            }
        }
        public void MarkBendNotesInScale(int note)
        {
            for (int i = 0; i < Harmonica.BendNotes.Count(); i++)
            {
                if (note == Harmonica.BendNotes[i + 1])
                {
                    ChangeLabelColor(BendNote_labels[i], Color.Blue, FontStyle.Bold);
                }
            }
        }
        public void ClearBendLabelFormating()
        {
            for (int i = 0; i < Harmonica.BendNotes.Count; i++)
            {
                BendNote_labels[i].ForeColor = Color.Gray;
                BendNote_labels[i].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            }
        }
    }
}
