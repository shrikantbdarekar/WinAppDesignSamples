using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDesignSamples.LoginForms
{
    public partial class FormLoginIndex : Form
    {
        public FormLoginIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLoginSimple FormObj = new FormLoginSimple();
            FormObj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLoginSimpleWithProjectName FormObj = new FormLoginSimpleWithProjectName();
            FormObj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLoginSimpleWithProjectName2 FormObj = new FormLoginSimpleWithProjectName2();
            FormObj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLoginFullScreen1 FormObj = new FormLoginFullScreen1();
            Application.DoEvents();
            FormObj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
