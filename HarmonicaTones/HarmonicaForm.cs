﻿using HarmonicaTones.Properties;
using HarmonicaTones.res;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarmonicaTones
{
    public partial class MainForm : Form
    {
        private MusicalNotes Notes = new MusicalNotes();

        public List<Label> blowNote_labels = new List<Label>();
        public List<Label> drawNote_labels = new List<Label>();
        public List<Label> bendNote_labels = new List<Label>();

        public Harmonica harmonica = new Harmonica();
        public string scalesPath = @"..\..\res\scales\";

        public MainForm()
        {
            InitializeComponent();
        }

        // General Use
        private void RefreshAll()
        {

            if (ToneComboBox.SelectedValue.GetType() == typeof(int))
            {
                int selectedNote = (int)ToneComboBox.SelectedValue;
                harmonica.ChangeHarmonicaTune(selectedNote);
            }

            if (ScaleComboBox.SelectedValue != null)
            {
                harmonica.HarmonicaScale.ChangeScale(scalesPath + ScaleComboBox.SelectedValue);

            }

            if (ScaleNotesComboBox.SelectedValue != null)
            {
                if (ScaleNotesComboBox.SelectedValue.GetType() == typeof(int))
                {
                    int selectedScaleNote = (int)ScaleNotesComboBox.SelectedValue;
                    harmonica.HarmonicaScale.ChangeScaleTone(selectedScaleNote);
                }
            }
            
            MarkNotesInScale(harmonica.HarmonicaScale.scale);
            UpdateNotes_atHarmonicaLabels();
        }

        // Menus Strip Options

        private void tabsToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Loading Form
        private void MainForm_Load(object sender, EventArgs e)
        {
            //public Scale ActiveScale = new Scale();
            ConfigureLabels();
            Load_ComboBox_withNotes(ToneComboBox);
            Load_ComboBox_withNotes(ScaleNotesComboBox);
            Load_ScaleComboBox();

            RefreshAll();

            var BFC = new ByteFileCreator("Mixolídio");
            BFC.GenerateScaleByteFile(false);
        }

        private void Load_ComboBox_withNotes(ComboBox cbx)
        {
            cbx.DataSource = new BindingSource(Notes.NotesCode, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";
            //ToneComboBox.SelectedIndex = 0;
        }

        private void Load_ScaleComboBox()
        {
            string[] Scales = Directory.GetFiles(scalesPath);

            int i = 0;
            foreach (string item in Scales)
            {
                Scales[i] = item.Substring(scalesPath.Length);
                i++;
            }
            ScaleComboBox.DataSource = new BindingSource(Scales, null);
        }

        private void ConfigureLabels()
        {
            ImageLayoutPanel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);

            for (int i = 0; i < harmonica.HARMONICA_HOLES; i++)
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
            ConfigureBendLabels();
        }


        // Label Format
        private void ClearLabelFormating()
        {
            for (int i = 0; i < harmonica.HARMONICA_HOLES; i++)
            {
                blowNote_labels[i].ForeColor = Color.Gray;
                blowNote_labels[i].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
                drawNote_labels[i].ForeColor = Color.Gray;
                drawNote_labels[i].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            }

            ClearBendLabelFormating();

        }

        private void ChangeLabelColor(Label label, Color color, FontStyle fontstyle)
        {
            label.ForeColor = color;
            label.Font = new Font("Microsoft Sans Serif", 12F, fontstyle);
        }

        // Harmonica Tuning

        private void UpdateNotes_atHarmonicaLabels()
        {
            UpdateBendNotes_atLabels();
            for (int i = 0; i < harmonica.HARMONICA_HOLES; i++)
            {
                if (harmonica.BlowNotes.TryGetValue(i + 1, out int Note_asInteger))
                {
                    if (Notes.NotesCode.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        blowNote_labels[i].Text = Note_asString;
                    }

                }
                if (harmonica.DrawNotes.TryGetValue(i + 1, out Note_asInteger))
                {
                    if (Notes.NotesCode.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        drawNote_labels[i].Text = Note_asString;
                    }
                }
            }
        }

        // Scale Marker
        private void MarkNotesInScale(List<int> scale)
        {
            ClearLabelFormating();
            foreach (int note in scale)
            {
                for (int i = 0; i < harmonica.HARMONICA_HOLES; i++)
                {
                    if (note == harmonica.BlowNotes[i + 1])
                    {
                        ChangeLabelColor(blowNote_labels[i], Color.Red, FontStyle.Bold);
                    }
                    if (note == harmonica.DrawNotes[i + 1])
                    {
                        ChangeLabelColor(drawNote_labels[i], Color.Red, FontStyle.Bold);
                    }
                }

                MarkBendNotesInScale(note);
            }
        }

        //Controls Onchanged
        private void ToneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void ScaleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void ScaleNotesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAll();
        }


        // Bends
        private void ConfigureBendLabels()
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

        private void AddBendLabel(int i, int hole, int bendDegree)
        {
            bendNote_labels.Add(new Label());
            ImageLayoutPanel.Controls.Add(bendNote_labels[i], hole + 1, 3 + bendDegree);

            bendNote_labels[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                            | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
            bendNote_labels[i].AutoSize = true;
            bendNote_labels[i].BackColor = System.Drawing.Color.Transparent;
            bendNote_labels[i].Location = new System.Drawing.Point(83, 0);
            bendNote_labels[i].Name = "Bend" + (i + 1).ToString();
            bendNote_labels[i].Size = new System.Drawing.Size(101, 92);
            bendNote_labels[i].TabIndex = 0;
            bendNote_labels[i].Text = "label";
            bendNote_labels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void UpdateBendNotes_atLabels()
        {
            for (int i = 0; i < harmonica.BendNotes.Count; i++)
            {
                if (harmonica.BendNotes.TryGetValue(i + 1, out int Note_asInteger))
                {
                    if (Notes.NotesCode.TryGetValue(Note_asInteger, out string Note_asString))
                    {
                        bendNote_labels[i].Text = Note_asString;
                    }

                }
            }
        }

        private void MarkBendNotesInScale(int note)
        {
            for (int i = 0; i < harmonica.BendNotes.Count(); i++)
            {
                if (note == harmonica.BendNotes[i + 1])
                {
                    ChangeLabelColor(bendNote_labels[i], Color.Blue, FontStyle.Bold);
                }
            }
        }

        private void ClearBendLabelFormating()
        {
            for (int i = 0; i < harmonica.BendNotes.Count; i++)
            {
                bendNote_labels[i].ForeColor = Color.Gray;
                bendNote_labels[i].Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular);
            }
        }

        
    }

}
