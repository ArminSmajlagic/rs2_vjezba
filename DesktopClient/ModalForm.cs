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
    public partial class ModalForm : Form
    {
        public ModalForm(string msg)
        {
            InitializeComponent();
            OnLoad(msg);
        }

        private void OnLoad(string msg)
        {
            lblMessage.Text = msg;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
