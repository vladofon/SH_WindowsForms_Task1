using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(300, 500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exercise2 form = new Exercise2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nForm form = new nForm();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ParentForm form = new ParentForm();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdditionalExercise1 form = new AdditionalExercise1();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdditionalExercise2_Parent form = new AdditionalExercise2_Parent();
            form.Show();
        }
    }
}
