using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithFiles
{
    public partial class InputForm : Form
    {
        public bool isCancel = true;
        public string Info;
        public InputForm(string Title = "", string InputText = "")
        {
            InitializeComponent();
            Text = Title;
            lbInput.Text = InputText;

        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            Info = tbInput.Text;
            Close();
            isCancel = false;
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
