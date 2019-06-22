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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
           
        }

             

        private void button1_Click(object sender, EventArgs e)
        {
            frequency_analysis_form analysis = new frequency_analysis_form();//задаем метод открытия формы для вкладки меню шифрование
            analysis.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encrypt_form Encrypt = new Encrypt_form();//задаем метод открытия формы для вкладки меню шифрование
            Encrypt.Show();
            this.Visible = false;

        }
    }
}
