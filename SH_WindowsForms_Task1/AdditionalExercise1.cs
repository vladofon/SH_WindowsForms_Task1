﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SH_WindowsForms_Task1
{
    public partial class AdditionalExercise1 : Form
    {
        public AdditionalExercise1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdditionalExercise1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new
                System.Drawing.Drawing2D.GraphicsPath();

            myPath.AddEllipse(0, 0, this.Width, this.Height);

            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
