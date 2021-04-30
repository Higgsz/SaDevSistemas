using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaDsenvolvimentoSistemas
{
    public partial class formFuncionario : Form
    {
        //Criando a lista para armazenas os funcionários
        List<Funcionario> funcionarios;
        public formFuncionario()
        {
            InitializeComponent();

            //Instacionando a lista
            funcionarios = new List<Funcionario>();

            //Criando os cargos
            cbCargo.Items.Add("Operador de Máquinas");
            cbCargo.Items.Add("Porteiro");
            cbCargo.Items.Add("Manobrista");
            cbCargo.Items.Add("Estoquista");

            //Criando as opções de sexo
            cbSexoFunc.Items.Add("Masculino");
            cbSexoFunc.Items.Add("Feminino");
            cbSexoFunc.Items.Add("Outro");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Conferindo se os campos foram preenchidos

            //Conferindo o campo NOME
            if(tbNomeFunc.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO NOME!");
                tbNomeFunc.Focus();
                return;
            }

            //Conferindo o campo CPF
            if (tbCpfFunc.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO CPF!");
                tbCpfFunc.Focus();
                return;
            }

            //Conferindo o campo SEXO
            if (cbSexoFunc.Text == "")
            {
                MessageBox.Show("SELECIONE UM SEXO!");
                cbSexoFunc.Focus();
                return;
            }

            //Conferindo o campo TELEFONE
            if (tbTelFunc.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO TELEFONE!");
                tbTelFunc.Focus();
                return;
            }

            //Conferindo o campo CARGO
            if (cbCargo.Text == "")
            {
                MessageBox.Show("SELECIONE UM CARGO!");
                cbCargo.Focus();
                return;
            }

            //Conferindo o campo SALÁRIO
            if (tbSalario.Text == "")
            {
                MessageBox.Show("PREENCHA O CAMPO SALARIO!");
                tbNomeFunc.Focus();
                return;
            }

            //Verificando se o CPF ja existe no sistema
            int index = -1;

            //Convertendo o campo do CPF para inteiro
            int valorcpf = Convert.ToInt32(tbCpfFunc.Text);

            foreach (Funcionario funcionarios in funcionarios)
            {
                if(valorcpf == funcionarios.CpfFunc)
                {
                    MessageBox.Show("O CPF JÁ ESTÁ CADASTRADO NO SISTEMA");
                    return;
                }
            }

            Funcionario f = new Funcionario();
            f.NomeFunc = tbNomeFunc.Text;
            f.CpfFunc = Convert.ToInt32(tbCpfFunc.Text);
            f.TelefoneFunc = Convert.ToInt32(tbTelFunc.Text);
            f.Cargo = cbCargo.SelectedItem.ToString();
            f.Salario = Convert.ToInt32(tbSalario.Text);

            funcionarios.Add(f);

            MessageBox.Show("FUNCIONÁRIO CADASTRADO COM SUCESSO!");

            
        }

        public void Listar()
        {
            listaFunc.Items.Clear();

            foreach(Funcionario f in funcionarios)
            {
                listaFunc.Items.Add(f.CpfFunc);
            }
        }

        private void btnListaFunc_Click(object sender, EventArgs e)
        {
            teste formteste = new teste(String v);
            formteste.ShowDialog();
        }

        private void listaFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }

    }
}
