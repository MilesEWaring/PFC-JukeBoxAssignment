using System;
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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void CloseAbout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("heello");
            Close();
        }
    }
}
