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
    public partial class Form1 : Form
    {
        public String nomeFunc;
        public int idadeFunc;

        List<Funcionario> funcionario;
        public Form1()
        {
            InitializeComponent();

            funcionario = new List<Funcionario>();
        }

        public void Listar()
        {
            ListaFucionarios.Items.Clear();

            foreach(Funcionario f in funcionario)
            {
                ListaFucionarios.Items.Add(f.Nome+", "+f.Idade+" Anos");
            }
        }

        

        private void btnLista_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();

            Funcionario f = new Funcionario();
            f.Nome = nomeFunc;
            f.Idade = idadeFunc;

            funcionario.Add(f);

            Listar();

        }

        private void tbListaNomes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void ListaFucionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListaFucionarios.SelectedIndex;

            nomeFunc = funcionario[index].Nome;
            idadeFunc = funcionario[index].Idade;

            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}
