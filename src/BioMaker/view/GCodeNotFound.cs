﻿using BioMaker.model;
using System;
using System.Windows.Forms;

namespace BioMaker.view
{
    public partial class GCodeNotFound : Form
    {
        private static GCodeNotFound form = null;

        public static void execute(string file)
        {
            if (form == null)
                form = new GCodeNotFound();
            form.labelFile.Text = file;
            form.ShowDialog();
        }

        public GCodeNotFound()
        {
            InitializeComponent();
            translate();
            Main.main.languageChanged += translate;
        }

        public void translate()
        {
            Text = Trans.T("W_GCODE_NOT_FOUND");
            labelExpectedFilenameLocation.Text = Trans.T("L_EXPECTED_FILENAME_AND_LOCATION");
            labelGCodeNotFoundInfo.Text = Trans.T("L_GCODE_NOT_FOUND_INFO");
            buttonClose.Text = Trans.T("B_CLOSE");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}