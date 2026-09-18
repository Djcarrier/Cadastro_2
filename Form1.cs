using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_2
{
    public partial class Frm_cadastro : Form
    {
        public Frm_cadastro()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Nome.Text + " " + Txt_Sobrenome.Text + "\n" + Txt_Idade.Text + "\n" + Txt_Bairro.Text + "\n" + Txt_Email.Text; 
        }

        private void Lbl_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Bairro.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Rad_tema1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.close_up_portrait_woman_holding_pencil;
        }

        private void Rad_Tema2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.hand_that_plays_smartphone_is_written_with_white_chalk_his_hand_draw_concept;
        }

        private void Rad_Tema3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.girl_is_typing_laptop_keyboard_girls_hands_keyboard;
        }

        private void Btn_Nome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Nome.Text;
        }

        private void Btn_Sobrenome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Sobrenome.Text;
        }

        private void Btn_Idade_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Idade.Text;
        }

        private void Btn_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Bairro.Text;
        }

        private void Btn_Celular_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Celular.Text;
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Email.Text;
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Txt_Nome.Clear();
            Txt_Sobrenome.Clear();
            Txt_Idade.Clear();
            Txt_Celular.Clear();
            Txt_Bairro.Clear();
            Txt_Email.Clear();
        }
    }
}
