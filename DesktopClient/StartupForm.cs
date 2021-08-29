﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClient
{
    public partial class StartupForm : Form
    {
        MainClientDisplay display = new MainClientDisplay();

        public StartupForm()
        {
            InitializeComponent();
        }

        private void letmein_Click(object sender, EventArgs e)
        {
            display.ShowDialog();
        }
    }
}
