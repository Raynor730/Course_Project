﻿using System;
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
    public partial class FormWin : Form
    {
        FormMain formMain = new FormMain();
        FormMenu formMenu = new FormMenu();
        public FormWin()
        {
            InitializeComponent();
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            formMain.Hide();
            formMenu.Show();
        }
    }
}
