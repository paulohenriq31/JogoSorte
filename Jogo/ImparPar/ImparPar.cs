using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImparPar
{
    public partial class ImparPar : Form
    {
        public ImparPar()
        {
            InitializeComponent();
        }

        private void rdbImpar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int numeroJogador = 0, numeroComputador = 0, total;
            string nome = txtNome.Text;
            Random dado = new Random();
            numeroComputador = dado.Next(0, 11);

            StreamWriter arquivo;
            String caminho = "C:\\Users\\phhen\\Documents\\Guto\\Jogo\\ImparPar\\placarPlacar.txt";
            arquivo = File.AppendText(caminho);

            numeroJogador = Convert.ToInt32(txtValor.Text);
            total = (numeroComputador + numeroJogador);

            MessageBox.Show("Seu número: " +txtValor.Text + "\nNúmero do computador: " + numeroComputador.ToString() + "\nTotal: " + total.ToString());

            if(rdbImpar.Checked == true)
            {
                if(total % 2 != 0)
                {
                    MessageBox.Show("Você escolheu ímpar. Parabens " + nome + ", você ganhou");

                    arquivo.Write(txtNome.Text);
                    arquivo.WriteLine(" Ganhou");
                    arquivo.WriteLine();

                    txtNome.Text = "";
                    txtValor.Text = "";
                }

                else
                {
                    MessageBox.Show("Você escolheu ímpar. " + nome + ", você Perdeu!");

                    arquivo.Write(txtNome.Text);
                    arquivo.WriteLine(" Perdeu");
                    arquivo.WriteLine();

                    txtNome.Text = "";
                    txtValor.Text = "";
                }

            }
            else
            {
                if (total % 2 == 0)
                {
                    MessageBox.Show("Você escolheu par. Parabens " + nome + ", você ganhou");

                    arquivo.Write(txtNome.Text);
                    arquivo.WriteLine(" Ganhou");
                    arquivo.WriteLine();

                    txtNome.Text = "";
                    txtValor.Text = "";
                }
                else
                {
                    MessageBox.Show("Você escolheu par. " + nome + ", você Perdeu!");

                    arquivo.Write(txtNome.Text);
                    arquivo.WriteLine(" Perdeu");
                    arquivo.WriteLine();

                    txtNome.Text = "";
                    txtValor.Text = "";
                }


            }

            arquivo.Close();

        }

        private void btnPlacar_Click(object sender, EventArgs e)
        {

            string caminho = "C:\\Users\\phhen\\Documents\\Guto\\Jogo\\ImparPar\\placarPlacar.txt";
            System.Diagnostics.Process.Start("notepad", caminho);

        }
    }
}
