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
    public partial class FormDefeat : Form
    {
        public FormDefeat()
        {
            InitializeComponent();
        }

        private void FillButtonDefeat_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
