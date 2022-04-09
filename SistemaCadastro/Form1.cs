using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            ComboCivil.Items.Add("Casado");
            ComboCivil.Items.Add("Solteiro");
            ComboCivil.Items.Add("Viuvo");
            ComboCivil.Items.Add("Separado");

            ComboCivil.SelectedIndex = 0;

            Nome.ForeColor = System.Drawing.Color.White;
            DtNasc.ForeColor = System.Drawing.Color.White;
            EstCivil.ForeColor = System.Drawing.Color.White;
            Telefone.ForeColor = System.Drawing.Color.White;
            CheckCasa.ForeColor = System.Drawing.Color.White;
            CheckVeiculo.ForeColor = System.Drawing.Color.White;
            GrupoSexo.ForeColor = System.Drawing.Color.White;
            RadioM.ForeColor = System.Drawing.Color.White;
            RadioF.ForeColor = System.Drawing.Color.White;
            RadioO.ForeColor = System.Drawing.Color.White;

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if(pessoa.Nome == TxtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

            if(TxtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome!");
                TxtNome.Focus();
                return;
            }

            if (TxtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone!");
                TxtTelefone.Focus();
                return;
            }

            if (ComboCivil.Items.Contains(ComboCivil.Text) == false)
            {
                MessageBox.Show("Escolha uma das opções cadastradas!");
                ComboCivil.Focus();
                return;
            }

            char sexo;

            if (RadioM.Checked)
            {
                sexo = 'M';
            } else if (RadioF.Checked)
            {
                sexo = 'F';
            } else if(RadioO.Checked)
            {
                sexo = 'O';
            }
            else
            {
                MessageBox.Show("Informe qual o seu sexo!");
                GrupoSexo.Focus();
                return;
            }

            Pessoa p = new Pessoa();
            p.Nome = TxtNome.Text;
            p.DataNascimento = TxtData.Text;
            p.EstadoCivil = ComboCivil.SelectedItem.ToString();
            p.Telefone = TxtTelefone.Text;
            p.CasaPropria = CheckCasa.Checked;
            p.Veiculo = CheckVeiculo.Checked;
            p.Sexo = sexo;

            if(index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }
            
            BtnLimpar_Click(BtnLimpar, EventArgs.Empty);
            Listar();
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            MessageBox.Show("Cadastro excluído com sucesso!");
            Listar();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtNome.Text = "";
            TxtData.Text = "";
            TxtTelefone.Text = "";
            ComboCivil.SelectedIndex = 0;
            CheckCasa.Checked = false;
            CheckVeiculo.Checked = false;

            if (RadioM.Checked)
            {
                RadioM.Checked = false;
            } else if (RadioF.Checked)
            {
                RadioF.Checked = false;
            }
            else
            {
                RadioO.Checked = false;
            }
            TxtNome.Focus();
        }

        private void Listar()
        {
            Lista.Items.Clear();
            
            foreach(Pessoa p in pessoas)
            {
                Lista.Items.Add(p.Nome);
            }
        }

        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = Lista.SelectedIndex;
            Pessoa p = pessoas[indice];

            TxtNome.Text = p.Nome;
            TxtData.Text = p.DataNascimento;
            ComboCivil.SelectedItem = p.EstadoCivil;
            TxtTelefone.Text = p.Telefone;
            CheckCasa.Checked = p.CasaPropria;
            CheckVeiculo.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    RadioM.Checked = true;
                    break;
                case 'F':
                    RadioF.Checked = true;
                    break;
                default:
                    RadioO.Checked = true;
                    break;
            }
        }
    }
}
