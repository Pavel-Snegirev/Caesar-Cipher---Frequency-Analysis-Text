using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPV_encryption
{
    public partial class ListAnalysisForm : Form
    {
        public ListAnalysisForm()
        {
            InitializeComponent();

        }

        private void ListAnalysisForm_Load(object sender, EventArgs e)
        {
            Encrypt_form encr = new Encrypt_form();
            encr.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Visible = false;
        }
    }
}