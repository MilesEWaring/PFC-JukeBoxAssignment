﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JukeBoxAssignmentv1._1
{
    public partial class SetUp : Form
    {
        public SetUp()
        {
            InitializeComponent();
        }

        private void SetupCancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
