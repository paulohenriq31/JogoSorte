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

namespace Adivinhacao
{
    public partial class Adivinhacao : Form
    {
        public Adivinhacao()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int valorComputador, valorJogador;

            StreamWriter arquivo;
            String caminho = "C:\\Users\\phhen\\Documents\\Guto\\Placar.txt";
            arquivo = File.AppendText(caminho);

            Random dados = new Random();
            valorComputador = dados.Next(0, 11);
            valorJogador = Convert.ToInt32(txtValor.Text);
            if(valorComputador == valorJogador)
            {

                MessageBox.Show("Venceu" + "\n"+ "Valor: " + valorComputador.ToString(), "Resultado");

                arquivo.Write(txtNome.Text);
                arquivo.WriteLine(" Ganhou");
                arquivo.WriteLine();

                txtNome.Text = "";
                txtValor.Text = "";
                lblResultado.Text = "0";

            }
            else
            {
                MessageBox.Show("Perdeu" + "\n" + "Valor: " + valorComputador.ToString(), "Resultado");
                lblResultado.Text = (Convert.ToInt32(lblResultado.Text) + 1).ToString();

            }

            if (Convert.ToInt32(lblResultado.Text) == 3)
            {
                MessageBox.Show("GAME OVER");
                arquivo.Write(txtNome.Text);
                arquivo.WriteLine(" Perdeu");
                arquivo.WriteLine();

                txtNome.Text = "";
                txtValor.Text = "";
                lblResultado.Text = "0";

            }



            arquivo.Close();

        }

        private void lblTentativa_Click(object sender, EventArgs e)
        {

        }

        private void btnPlacar_Click(object sender, EventArgs e)
        {
            string caminho = "C:\\Users\\phhen\\Documents\\Guto\\Placar.txt";
            System.Diagnostics.Process.Start("notepad", caminho);
        }
    }
}
