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
    public partial class AdditionalExercise2_Secondary : Form
    {
        public AdditionalExercise2_Secondary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdditionalExercise2_Secondary_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new
                System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[]
                {
                    new Point(100, 100),
                    new Point(200, 150),
                    new Point(100, 200),
                    new Point(0, 150)
                });

            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
