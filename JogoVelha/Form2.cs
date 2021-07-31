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
    public partial class Pontuação : Form
    {
        FormJogo jogo = new FormJogo();

        bool pisca;
        public Pontuação()
        {
            InitializeComponent();
        }

 

        private void vitoria_Click(object sender, EventArgs e)
        {
            mudarCor();
        }

        private void Pontuação_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        public void mudarCor()
        {
            for (int i = 0; i < 10; i++)
            { 
            if (pisca == false)
            {
                vitoria.BackColor = Color.Red;
                vitoria.ForeColor = Color.Blue;
             }

            pisca = true;
            if (pisca == true)
            {
                vitoria.BackColor = Color.Blue;
                vitoria.ForeColor = Color.Red;
                }
            }
            pisca = false;
        }


        private void jogador1placarim_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
