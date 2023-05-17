using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_Jogo_da_Memoria
{
    public partial class Form1 : Form
    {
        string figura1 = "?";
        string figura2 = "?";
        string figura3 = "?";
        string figura4 = "?";
        string figura5 = "?";
        string figura6 = "?";
        string figura7 = "?";
        string figura8 = "?";
        string figura9 = "?";
        string figura10 = "?";
        string figura11 = "?";
        string figura12 = "?";
        int vida = 0;
        public Form1()
        {
            InitializeComponent();
            labelMENSAGEM.Text = "";
            pictureBox1.Image = Properties.Resources.duvida;
            pictureBox2.Image = Properties.Resources.duvida;
            pictureBox3.Image = Properties.Resources.duvida;
            pictureBox4.Image = Properties.Resources.duvida;
            pictureBox5.Image = Properties.Resources.duvida;
            pictureBox6.Image = Properties.Resources.duvida;
            pictureBox7.Image = Properties.Resources.duvida;
            pictureBox8.Image = Properties.Resources.duvida;
            pictureBox9.Image = Properties.Resources.duvida;
            pictureBox10.Image = Properties.Resources.duvida;
            pictureBox11.Image = Properties.Resources.duvida;
            pictureBox12.Image = Properties.Resources.duvida;
        }
        public void cliques ()
        {
            if (vida == 2)
            {
                if (figura1 == "f" && figura5 != "f" || figura1 != "f" && figura5 == "f")
                {
                    pictureBox1.Image = Properties.Resources.duvida;
                    pictureBox5.Image = Properties.Resources.duvida;
                }
                if (figura2 == "f" && figura8 != "f" || figura2 != "f" && figura8 == "f")
                {
                    pictureBox2.Image = Properties.Resources.duvida;
                    pictureBox8.Image = Properties.Resources.duvida;
                }
                if (figura3 == "f" && figura9 != "f" || figura3 != "f" && figura9 == "f")
                {
                    pictureBox3.Image = Properties.Resources.duvida;
                    pictureBox9.Image = Properties.Resources.duvida;
                }
                if (figura4 == "f" && figura10 != "f" || figura4 != "f" && figura10 == "f")
                {
                    pictureBox4.Image = Properties.Resources.duvida;
                    pictureBox10.Image = Properties.Resources.duvida;
                }
                if (figura6 == "f" && figura11 != "f" || figura6 != "f" && figura11 == "f")
                {
                    pictureBox6.Image = Properties.Resources.duvida;
                    pictureBox11.Image = Properties.Resources.duvida;
                }
                if (figura7 == "f" && figura12 != "f" || figura7 != "f" && figura12 == "f")
                {
                    pictureBox7.Image = Properties.Resources.duvida;
                    pictureBox12.Image = Properties.Resources.duvida;
                }
                if (figura1 == "f" && figura5 != "f" || figura1 != "f" && figura5 == "f")
                {
                    pictureBox1.Image = Properties.Resources.duvida;
                    pictureBox5.Image = Properties.Resources.duvida;
                }
                figura1 = "?";
                figura2 = "?";
                figura3 = "?";
                figura4 = "?";
                figura5 = "?";
                figura6 = "?";
                figura7 = "?";
                figura8 = "?";
                figura9 = "?";
                figura10 = "?";
                figura11 = "?";
                figura12 = "?";
                vida = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (figura1 == "?")
            {
                pictureBox1.Image = Properties.Resources.viuva_negra;
                figura1 = "f";
            } else
            {
                pictureBox1.Image = Properties.Resources.duvida;
                figura1 = "?";
            }
            if (figura1 == "f" && figura5 == "f")
            {
                pictureBox1.Enabled = false;
                pictureBox5.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (figura2 == "?")
            {
                pictureBox2.Image = Properties.Resources.loki;
                figura2 = "f";
            }
            else
            {
                pictureBox2.Image = Properties.Resources.duvida;
                figura2 = "?";
            }
            if (figura2 == "f" && figura8 == "f")
            {
                pictureBox2.Enabled = false;
                pictureBox8.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (figura3 == "?")
            {
                pictureBox3.Image = Properties.Resources.homem_de_ferro;
                figura3 = "f";
            }
            else
            {
                pictureBox3.Image = Properties.Resources.duvida;
                figura3 = "?";
            }
            if (figura3 == "f" && figura9 == "f")
            {
                pictureBox3.Enabled = false;
                pictureBox9.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (figura4 == "?")
            {
                pictureBox4.Image = Properties.Resources.feiticeira_escarlate;
                figura4 = "f";
            }
            else
            {
                pictureBox4.Image = Properties.Resources.duvida;
                figura4 = "?";
            }
            if (figura4 == "f" && figura10 == "f")
            {
                pictureBox4.Enabled = false;
                pictureBox10.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (figura5 == "?")
            {
                pictureBox5.Image = Properties.Resources.viuva_negra;
                figura5 = "f";
            }
            else
            {
                pictureBox5.Image = Properties.Resources.duvida;
                figura5 = "?";
            }
            if (figura1 == "f" && figura5 == "f")
            {
                pictureBox1.Enabled = false;
                pictureBox5.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (figura6 == "?")
            {
                pictureBox6.Image = Properties.Resources.capitao_america;
                figura6 = "f";
            }
            else
            {
                pictureBox6.Image = Properties.Resources.duvida;
                figura6 = "?";
            }
            if (figura6 == "f" && figura11 == "f")
            {
                pictureBox6.Enabled = false;
                pictureBox11.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (figura7 == "?")
            {
                pictureBox7.Image = Properties.Resources.capita_marvel;
                figura7 = "f";
            }
            else
            {
                pictureBox7.Image = Properties.Resources.duvida;
                figura7 = "?";
            }
            if (figura7 == "f" && figura12 == "f")
            {
                pictureBox7.Enabled = false;
                pictureBox12.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (figura8 == "?")
            {
                pictureBox8.Image = Properties.Resources.loki;
                figura8 = "f";
            }
            else
            {
                pictureBox8.Image = Properties.Resources.duvida;
                figura8 = "?";
            }
            if (figura2 == "f" && figura8 == "f")
            {
                pictureBox2.Enabled = false;
                pictureBox8.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (figura9 == "?")
            {
                pictureBox9.Image = Properties.Resources.homem_de_ferro;
                figura9 = "f";
            }
            else
            {
                pictureBox9.Image = Properties.Resources.duvida;
                figura9 = "?";
            }
            if (figura3 == "f" && figura9 == "f")
            {
                pictureBox3.Enabled = false;
                pictureBox9.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (figura10 == "?")
            {
                pictureBox10.Image = Properties.Resources.feiticeira_escarlate;
                figura10 = "f";
            }
            else
            {
                pictureBox10.Image = Properties.Resources.duvida;
                figura10 = "?";
            }
            if (figura4 == "f" && figura10 == "f")
            {
                pictureBox4.Enabled = false;
                pictureBox10.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (figura11 == "?")
            {
                pictureBox11.Image = Properties.Resources.capitao_america;
                figura11 = "f";
            }
            else
            {
                pictureBox11.Image = Properties.Resources.duvida;
                figura11 = "?";
            }
            if (figura6 == "f" && figura11 == "f")
            {
                pictureBox6.Enabled = false;
                pictureBox11.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (figura12 == "?")
            {
                pictureBox12.Image = Properties.Resources.capita_marvel;
                figura12 = "f";
            }
            else
            {
                pictureBox12.Image = Properties.Resources.duvida;
                figura12 = "?";
            }
            if (figura7 == "f" && figura12 == "f")
            {
                pictureBox7.Enabled = false;
                pictureBox12.Enabled = false;
            }
            vida++;
            cliques();
            ganhou();
        }
        public void ganhou()
        {
            if (figura1 == "f" && figura2 == "f" && figura3 == "f" && figura4 == "f" && figura5 == "f" && figura6 == "f" && figura7 == "f" && figura8 == "f" && figura9 == "f" && figura10 == "f" && figura11 == "f" && figura12 == "f")
            {
                labelMENSAGEM.Text = "Você conseguiu, parabéns!";
                labelMENSAGEM.BackColor = Color.Green;
            }
        }
    }
}
