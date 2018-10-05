using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormModels frmModels = new FormModels();
            frmModels.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MirLexus frmMir = new MirLexus();
            frmMir.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUser frmUser = new FormUser();
            frmUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPred frmPred = new FormPred();
            frmPred.Show();
        }
    }
}
