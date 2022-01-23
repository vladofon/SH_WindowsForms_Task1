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
    public partial class AdditionalExercise2_Parent : Form
    {
        public AdditionalExercise2_Parent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdditionalExercise2_Secondary form = new AdditionalExercise2_Secondary();
            form.Show();
        }
    }
}
