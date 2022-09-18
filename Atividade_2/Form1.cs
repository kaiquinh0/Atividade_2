using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2
{
    public partial class Cadastro : Form
    {
        Jogador obj;
        Jogador[] v = new Jogador[15];
        int i = 0;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (i < 5)
            {
                obj = new Jogador();
                obj.Nome = txtNome.Text;
                obj.Peso = Convert.ToDouble(txtPeso.Text);
                obj.Altura = Convert.ToDouble(txtAltura.Text);
                obj.Idade = Convert.ToInt32(txtIdade.Text);
                obj.Camisa = Convert.ToInt32(txtCamisa.Text);
                obj.Time = txtTime.Text;
                v[i] = obj;
                i++;
            }
            else
            {
                MessageBox.Show("Não é possível gravar");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 15; j++)
            {
                if (v[j].Nome.Equals(txtNome.Text))
                {
                    txtNome.Text = v[j].Nome;
                    txtPeso.Text = v[j].Peso.ToString();
                    txtAltura.Text = v[j].Altura.ToString();
                    txtIdade.Text = v[j].Idade.ToString();
                    txtCamisa.Text = v[j].Camisa.ToString();
                    txtTime.Text = v[j].Time;
                    j = 14;
                }
                else
                {
                    if (j == 14) MessageBox.Show("Pessoa não encontrada");
                }
            }
        }
    }
}
