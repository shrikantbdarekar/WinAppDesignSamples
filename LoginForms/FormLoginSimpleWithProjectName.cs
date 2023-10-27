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
    public partial class FormLoginSimpleWithProjectName : Form
    {
        public FormLoginSimpleWithProjectName()
        {
            InitializeComponent();
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
