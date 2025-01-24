using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class FormMenu : Form
    {
        FormMain formMain = new FormMain();
        FormRule rule = new FormRule();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            formMain.Show();
        }

        private void buttonRule_Click(object sender, EventArgs e)
        {
            rule.Show();
        }
    }
}
