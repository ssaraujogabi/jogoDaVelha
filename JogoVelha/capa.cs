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
    public partial class capa : Form
    {
        public capa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormJogo jogo = new FormJogo();
            jogo.Show();
            this.Hide();
        }

        private void capa_Load(object sender, EventArgs e)
        {

        }
    }
}
