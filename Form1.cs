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
            Lbl_Resultado.Text = "";//Limpa o texto
            Txt_Nome.Clear();//limpa os text
            Txt_Sobrenome.Clear();
            Txt_Idade.Clear();
            Txt_Celular.Clear();
            Txt_Bairro.Clear();
            Txt_Email.Clear();
        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {
            Btn_Nome.Enabled = true;// Ativa os botoes
            Btn_Sobrenome.Enabled = true;
            Btn_Idade.Enabled = true;
            btn_Email.Enabled = true;
            Btn_Celular.Enabled = true;
            Btn_Bairro.Enabled = true;
            Btn_D_Completos.Enabled = true;
            Btn_Deastivar.Enabled = true;
            Btn_Limpar.Enabled = true;
            Btn_Enviar.Enabled = true;
            Txt_Nome.Enabled = true;
            Txt_Sobrenome.Enabled = true;
            Txt_Idade.Enabled = true;
            Txt_Email.Enabled = true;
            Txt_Bairro.Enabled=true;
            Txt_Celular.Enabled=true;
            Lbl_Nome.Enabled = true;
            Lbl_Sobrenome.Enabled = true;
            Lbl_Idade.Enabled = true; 
            Lbl_Celular.Enabled = true;
            Lbl_Email.Enabled = true;
            Lbl_Cadastro_Pessoal.Enabled = true;
            Lbl_Resultado.Enabled = true;
            Lbl_Conf_dados.Enabled = true;
            Lbl_Bairro.Enabled = true;
            Btn_Ativar.Enabled = false;
            Grp_Temas.Enabled = true;


        }

        private void Btn_Deastivar_Click(object sender, EventArgs e)
        {
            Btn_Nome.Enabled = false;//Desativa os botoes 
            Btn_Ativar.Enabled = true;
            Btn_Sobrenome.Enabled = false;
            Btn_Idade.Enabled = false;
            btn_Email.Enabled = false;
            Btn_Celular.Enabled = false;
            Btn_Bairro.Enabled = false;
            Btn_D_Completos.Enabled = false;
            Btn_Deastivar.Enabled = false;
            Btn_Limpar.Enabled = false;
            Btn_Enviar.Enabled = false;
            Txt_Nome.Enabled = false;
            Txt_Nome.Enabled = false;
            Txt_Sobrenome.Enabled = false;
            Txt_Idade.Enabled = false;
            Txt_Email.Enabled = false;
            Txt_Bairro.Enabled = false;
            Txt_Celular.Enabled = false;
            Lbl_Nome.Enabled = false;
            Lbl_Sobrenome.Enabled = false;
            Lbl_Idade.Enabled = false;
            Lbl_Celular.Enabled = false;
            Lbl_Email.Enabled = false;
            Lbl_Cadastro_Pessoal.Enabled = false;
            Lbl_Resultado.Enabled = false;
            Lbl_Conf_dados.Enabled = false;
            Lbl_Bairro.Enabled = false;
            Grp_Temas.Enabled = false;
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Cadastrado com Sucesso");//Messagem cadastro efetuado
            Lbl_Resultado.Text = ""; // lIMPANDO LBL RESULTADO
            Txt_Nome.Clear();//limpa os text
            Txt_Sobrenome.Clear();
            Txt_Idade.Clear();
            Txt_Celular.Clear();
            Txt_Bairro.Clear();
            Txt_Email.Clear();

            Btn_Enviar.FlatStyle = FlatStyle.Flat;
            Btn_Enviar.FlatAppearance.MouseOverBackColor = Color.Green;
            Btn_Enviar.BackColor = Color.LightGray;

        }
    }
}
