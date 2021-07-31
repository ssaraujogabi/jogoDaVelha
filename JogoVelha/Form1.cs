using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha
{
    public partial class FormJogo : Form
    {

        string jogador = "1";
        string[,] resultado = new string[3, 3];
        int count = 1;
        int numeroPartidas;
        int contadorMensagem = 1;

        public FormJogo()
        {
            InitializeComponent();
        }

        private void bt_0_0_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 0, 0);
        }

        private void bt_0_1_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 0, 1);
        }

        public void bt_0_2_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 0, 2);
        }

        private void bt_1_0_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 1, 0);
        }

        private void bt_1_1_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 1, 1);
        }

        private void bt_1_2_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 1, 2);
        }

        private void bt_2_0_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 2, 0);
        }

        private void bt_2_1_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 2, 1);
        }

        private void bt_2_2_Click(object sender, EventArgs e)
        {
            realizarJogada(((Button)sender), 2, 2);
        }

        
        public void realizarJogada(Button botao, int linha, int coluna)
        {
           
            if (botao.Text == "")
            {

                if (jogador.Equals("1"))
                {
                    botao.Text = "X";
                    botao.ForeColor = Color.Red;
                    jogador = "2";
                    resultado[linha, coluna] = "X";
                    vezdojogador.Text = "2";
                    vezdojogador.ForeColor = Color.Blue;
                }
                else
                {
                    botao.Text = "O";
                    botao.ForeColor = Color.Blue;
                    jogador = "1";
                    resultado[linha, coluna] = "0";
                    botao.Click += null;
                    vezdojogador.Text = "1";
                    vezdojogador.ForeColor = Color.Red;
                }


                verificarResultado();
                count++;
            }
            }

        public void verificarResultado()
        {
            if (resultado[0, 0] == "X" && resultado[0, 1] == "X" && resultado[0, 2] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[1, 0] == "X" && resultado[1, 1] == "X" && resultado[1, 2] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[2, 0] == "X" && resultado[2, 1] == "X" && resultado[2, 2] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar(); 
            }

            else if (resultado[0, 0] == "X" && resultado[1, 0] == "X" && resultado[2, 0] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 1] == "X" && resultado[1, 1] == "X" && resultado[2, 1] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 2] == "X" && resultado[1, 2] == "X" && resultado[2, 2] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 0] == "X" && resultado[1, 1] == "X" && resultado[2, 2] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 2] == "X" && resultado[1, 1] == "X" && resultado[2, 0] == "X")
            {
                ganhouX();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 0] == "0" && resultado[0, 1] == "0" && resultado[0, 2] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[1, 0] == "0" && resultado[1, 1] == "0" && resultado[1, 2] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[2, 0] == "0" && resultado[2, 1] == "0" && resultado[2, 2] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 0] == "0" && resultado[1, 0] == "0" && resultado[2, 0] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 1] == "0" && resultado[1, 1] == "0" && resultado[2, 1] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 2] == "0" && resultado[1, 2] == "0" && resultado[2, 2] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 0] == "0" && resultado[1, 1] == "0" && resultado[2, 2] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (resultado[0, 2] == "0" && resultado[1, 1] == "0" && resultado[2, 0] == "0")
            {
                ganhouO();
                contadorMensagem++;
                reiniciar();
            }

            else if (count == 9)
            {
                MessageBox.Show("Empate");

                string empate = empateplacarin.Text;
                int empate2 = Convert.ToInt16(empate);
                empate2 = empate2 + 1;
                empate = Convert.ToString(empate2);
                empateplacarin.Text = empate;
                reiniciar();

                numeroPartidas = numeroPartidas + 1;
            }

        }
        
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

        }

        private void empateplacarin_TextChanged(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Pontuação chamar = new Pontuação();
            chamar.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zerarPlacar();
            reiniciar();
        }

        public void ganhouX()
        {

            if (contadorMensagem == 1)
            {
                MessageBox.Show("Jogador 1 venceu");
            }

            string placarX = jogador1placarim.Text;
            int placarX2 = Convert.ToInt16(placarX);
            placarX2 = placarX2 + 1;
            placarX = Convert.ToString(placarX2);
            jogador1placarim.Text = placarX;

            numeroPartidas = numeroPartidas + 1;
        }

        public void ganhouO()
        {
            if (contadorMensagem == 1)
            {
                MessageBox.Show("Jogador 2 venceu");
            }

            string placarO = jogador2placarin.Text;
            int placarO2 = Convert.ToInt16(placarO);
            placarO2 = placarO2 + 1;
            placarO = Convert.ToString(placarO2);
            jogador2placarin.Text = placarO;

            numeroPartidas = numeroPartidas + 1;

            //vencer = jogador2placarin.Text;
            //placarConvertidoo = Convert.ToInt16(vencer);
            //placarConvertidoo = placaro + 1;
            //vencer = Convert.ToString(placarConvertidoo);
            //jogador2placarin.Text = vencer;

        }

      
        public void zerarPlacar()
        {
            string empate = empateplacarin.Text;
            int empate2 = Convert.ToInt16(empate);
            empate2 = 0;
            empate = Convert.ToString(empate2);
            empateplacarin.Text = empate;

            string placarO = jogador2placarin.Text;
            int placarO2 = Convert.ToInt16(placarO);
            placarO2 = 0;
            placarO = Convert.ToString(placarO2);
            jogador2placarin.Text = placarO;

            string placarX = jogador1placarim.Text;
            int placarX2 = Convert.ToInt16(placarX);
            placarX2 = 0;
            placarX = Convert.ToString(placarX2);
            jogador1placarim.Text = placarX;


        }

        public void reiniciar()
        {

            foreach (Button botao in groupBox1.Controls)
            {
                botao.Text = "";
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultado[i, j] = "";
                }
            }


            count = 1;
            contadorMensagem = 1;

        }

        private void jogador2placarin_TextChanged(object sender, EventArgs e)
        {

        }

        private void vezdojogador_Click(object sender, EventArgs e)
        {

        }

        private void jogador1placarim_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
