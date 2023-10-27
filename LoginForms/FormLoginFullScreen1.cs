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
    public partial class FormLoginFullScreen1 : Form
    {
        // Free images used form https://www.freepik.com/
        public FormLoginFullScreen1()
        {
            InitializeComponent();

            // Transperant background used for givin g WaterMark feel on text above logo.
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // Login logic check code here

            this.DialogResult = DialogResult.OK;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Form close code here

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
