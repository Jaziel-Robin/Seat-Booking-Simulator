/*
Class: DIT/FT/2B21
Admission Number: P2129187
Name: Jaziel Robin Premraj
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SeatBookingSimulator
{
    public partial class ParentForm : Form
    {
        public Form1 form1;
        public Form2 form2;
        public Form3 form3;
        public ParentForm()
        {
            InitializeComponent();
            this.normalModeToolStripMenuItem.Click += new EventHandler(this.NormalModeToolStripMenuItem_Click);
        }

        private void NormalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {

                // No need to create a new Form1 Instance.
                // Just show the form because form1 is still referencing an existing Form1 Instance.
                form1.Show();
            }
            if (form1 == null)
            {


                form1 = new Form1();// Create a new Form1 Instance
                form1.MdiParent = this;
                form1.Show();
            }
        }

        private void SafeDistanceModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2 != null)
            {

                // No need to create a new Form2 Instance.
                // Just show the form because form1 is still referencing an existing Form2 Instance.
                form2.Show();
            }
            if (form2 == null)
            {


                form2 = new Form2();// Create a new Form2 Instance
                form2.MdiParent = this;
                form2.Show();
            }
        }

        private void SafeDistanceSmartModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3 != null)
            {

                // No need to create a new Form3 Instance.
                // Just show the form because form3 is still referencing an existing Form3 Instance.
                form3.Show();
            }
            if (form3 == null)
            {


                form3 = new Form3();// Create a new Form3 Instance
                form3.MdiParent = this;
                form3.Show();
            }
        }
    }
}
