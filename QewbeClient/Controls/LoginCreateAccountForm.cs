﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QewbeClient.Http;
using QewbeClient.Config;
using QewbeClient.API;
using System.Threading;
using QewbeClient.API.Reply;

namespace QewbeClient
{
    public partial class LoginCreateAccontForm : Form
    {
        public LoginCreateAccontForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterParent;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult = new CreateAccountForm().ShowDialog(this);
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult = new LoginForm().ShowDialog(this);
            Close();
        }
    }
}
