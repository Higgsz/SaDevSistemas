using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesForms
{
    public partial class Form2 : Form
    {
        Form1 f;
        public Form2(Form1 form1)
        {
            InitializeComponent();

            f = form1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            f.nomeFunc = tbNome.Text;
            f.idadeFunc = Convert.ToInt32(tbIdade.Text);
            MessageBox.Show("FUNCIONÁRIO CADASTRADOS!");
            this.Hide();
        }
    }
}
