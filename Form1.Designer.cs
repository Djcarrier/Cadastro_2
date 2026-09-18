namespace Cadastro_2
{
    partial class Frm_cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadastro));
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Sobrenome = new System.Windows.Forms.Label();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Celular = new System.Windows.Forms.Label();
            this.Lbl_Conf_dados = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Sobrenome = new System.Windows.Forms.TextBox();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Txt_Celular = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Btn_Nome = new System.Windows.Forms.Button();
            this.Btn_Sobrenome = new System.Windows.Forms.Button();
            this.Btn_Idade = new System.Windows.Forms.Button();
            this.Btn_Bairro = new System.Windows.Forms.Button();
            this.Btn_Celular = new System.Windows.Forms.Button();
            this.Btn_D_Completos = new System.Windows.Forms.Button();
            this.Lbl_Cadastro_Pessoal = new System.Windows.Forms.Label();
            this.Grp_Temas = new System.Windows.Forms.GroupBox();
            this.Rad_Tema3 = new System.Windows.Forms.RadioButton();
            this.Rad_Tema2 = new System.Windows.Forms.RadioButton();
            this.Rad_tema1 = new System.Windows.Forms.RadioButton();
            this.Btn_Ativar = new System.Windows.Forms.Button();
            this.Btn_Deastivar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.btn_Email = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Grp_Temas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Location = new System.Drawing.Point(150, 276);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Lbl_Sobrenome
            // 
            this.Lbl_Sobrenome.AutoSize = true;
            this.Lbl_Sobrenome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Sobrenome.Location = new System.Drawing.Point(150, 301);
            this.Lbl_Sobrenome.Name = "Lbl_Sobrenome";
            this.Lbl_Sobrenome.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Sobrenome.TabIndex = 1;
            this.Lbl_Sobrenome.Text = "Sobrenome";
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Idade.Location = new System.Drawing.Point(150, 328);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Idade.TabIndex = 2;
            this.Lbl_Idade.Text = "Idade";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Bairro.Location = new System.Drawing.Point(150, 356);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 3;
            this.Lbl_Bairro.Text = "Bairro";
            this.Lbl_Bairro.Click += new System.EventHandler(this.Lbl_Bairro_Click);
            // 
            // Lbl_Celular
            // 
            this.Lbl_Celular.AutoSize = true;
            this.Lbl_Celular.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Celular.Location = new System.Drawing.Point(150, 384);
            this.Lbl_Celular.Name = "Lbl_Celular";
            this.Lbl_Celular.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Celular.TabIndex = 4;
            this.Lbl_Celular.Text = "Celular";
            // 
            // Lbl_Conf_dados
            // 
            this.Lbl_Conf_dados.AutoSize = true;
            this.Lbl_Conf_dados.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Conf_dados.Location = new System.Drawing.Point(150, 457);
            this.Lbl_Conf_dados.Name = "Lbl_Conf_dados";
            this.Lbl_Conf_dados.Size = new System.Drawing.Size(115, 13);
            this.Lbl_Conf_dados.TabIndex = 5;
            this.Lbl_Conf_dados.Text = "Confirmação de Dados";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(282, 269);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(279, 20);
            this.Txt_Nome.TabIndex = 6;
            // 
            // Txt_Sobrenome
            // 
            this.Txt_Sobrenome.Location = new System.Drawing.Point(282, 294);
            this.Txt_Sobrenome.Name = "Txt_Sobrenome";
            this.Txt_Sobrenome.Size = new System.Drawing.Size(279, 20);
            this.Txt_Sobrenome.TabIndex = 7;
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Location = new System.Drawing.Point(282, 321);
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(84, 20);
            this.Txt_Idade.TabIndex = 8;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(282, 353);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(279, 20);
            this.Txt_Bairro.TabIndex = 9;
            // 
            // Txt_Celular
            // 
            this.Txt_Celular.Location = new System.Drawing.Point(282, 377);
            this.Txt_Celular.Name = "Txt_Celular";
            this.Txt_Celular.Size = new System.Drawing.Size(168, 20);
            this.Txt_Celular.TabIndex = 10;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(282, 403);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(279, 20);
            this.Txt_Email.TabIndex = 11;
            // 
            // Btn_Nome
            // 
            this.Btn_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Nome.Location = new System.Drawing.Point(576, 266);
            this.Btn_Nome.Name = "Btn_Nome";
            this.Btn_Nome.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nome.TabIndex = 12;
            this.Btn_Nome.Text = "Nome";
            this.Btn_Nome.UseVisualStyleBackColor = false;
            this.Btn_Nome.Click += new System.EventHandler(this.Btn_Nome_Click);
            // 
            // Btn_Sobrenome
            // 
            this.Btn_Sobrenome.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Sobrenome.Location = new System.Drawing.Point(576, 291);
            this.Btn_Sobrenome.Name = "Btn_Sobrenome";
            this.Btn_Sobrenome.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sobrenome.TabIndex = 13;
            this.Btn_Sobrenome.Text = "Sobrenome";
            this.Btn_Sobrenome.UseVisualStyleBackColor = false;
            this.Btn_Sobrenome.Click += new System.EventHandler(this.Btn_Sobrenome_Click);
            // 
            // Btn_Idade
            // 
            this.Btn_Idade.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Idade.Location = new System.Drawing.Point(576, 318);
            this.Btn_Idade.Name = "Btn_Idade";
            this.Btn_Idade.Size = new System.Drawing.Size(75, 23);
            this.Btn_Idade.TabIndex = 14;
            this.Btn_Idade.Text = "Idade";
            this.Btn_Idade.UseVisualStyleBackColor = false;
            this.Btn_Idade.Click += new System.EventHandler(this.Btn_Idade_Click);
            // 
            // Btn_Bairro
            // 
            this.Btn_Bairro.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Bairro.Location = new System.Drawing.Point(576, 350);
            this.Btn_Bairro.Name = "Btn_Bairro";
            this.Btn_Bairro.Size = new System.Drawing.Size(75, 23);
            this.Btn_Bairro.TabIndex = 15;
            this.Btn_Bairro.Text = "Bairro";
            this.Btn_Bairro.UseVisualStyleBackColor = false;
            this.Btn_Bairro.Click += new System.EventHandler(this.Btn_Bairro_Click);
            // 
            // Btn_Celular
            // 
            this.Btn_Celular.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Celular.Location = new System.Drawing.Point(576, 379);
            this.Btn_Celular.Name = "Btn_Celular";
            this.Btn_Celular.Size = new System.Drawing.Size(75, 23);
            this.Btn_Celular.TabIndex = 16;
            this.Btn_Celular.Text = "Celular";
            this.Btn_Celular.UseVisualStyleBackColor = false;
            this.Btn_Celular.Click += new System.EventHandler(this.Btn_Celular_Click);
            // 
            // Btn_D_Completos
            // 
            this.Btn_D_Completos.BackColor = System.Drawing.Color.Transparent;
            this.Btn_D_Completos.Location = new System.Drawing.Point(576, 437);
            this.Btn_D_Completos.Name = "Btn_D_Completos";
            this.Btn_D_Completos.Size = new System.Drawing.Size(75, 52);
            this.Btn_D_Completos.TabIndex = 17;
            this.Btn_D_Completos.Text = "Dados Completos";
            this.Btn_D_Completos.UseVisualStyleBackColor = false;
            this.Btn_D_Completos.Click += new System.EventHandler(this.button6_Click);
            // 
            // Lbl_Cadastro_Pessoal
            // 
            this.Lbl_Cadastro_Pessoal.AutoSize = true;
            this.Lbl_Cadastro_Pessoal.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cadastro_Pessoal.Location = new System.Drawing.Point(361, 241);
            this.Lbl_Cadastro_Pessoal.Name = "Lbl_Cadastro_Pessoal";
            this.Lbl_Cadastro_Pessoal.Size = new System.Drawing.Size(89, 13);
            this.Lbl_Cadastro_Pessoal.TabIndex = 18;
            this.Lbl_Cadastro_Pessoal.Text = "Cadastro Pessoal";
            // 
            // Grp_Temas
            // 
            this.Grp_Temas.BackColor = System.Drawing.Color.Transparent;
            this.Grp_Temas.Controls.Add(this.Rad_Tema3);
            this.Grp_Temas.Controls.Add(this.Rad_Tema2);
            this.Grp_Temas.Controls.Add(this.Rad_tema1);
            this.Grp_Temas.Location = new System.Drawing.Point(153, 25);
            this.Grp_Temas.Name = "Grp_Temas";
            this.Grp_Temas.Size = new System.Drawing.Size(498, 56);
            this.Grp_Temas.TabIndex = 19;
            this.Grp_Temas.TabStop = false;
            this.Grp_Temas.Text = "Temas";
            this.Grp_Temas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Rad_Tema3
            // 
            this.Rad_Tema3.AutoSize = true;
            this.Rad_Tema3.Location = new System.Drawing.Point(347, 19);
            this.Rad_Tema3.Name = "Rad_Tema3";
            this.Rad_Tema3.Size = new System.Drawing.Size(61, 17);
            this.Rad_Tema3.TabIndex = 2;
            this.Rad_Tema3.TabStop = true;
            this.Rad_Tema3.Text = "Tema 3";
            this.Rad_Tema3.UseVisualStyleBackColor = true;
            this.Rad_Tema3.CheckedChanged += new System.EventHandler(this.Rad_Tema3_CheckedChanged);
            // 
            // Rad_Tema2
            // 
            this.Rad_Tema2.AutoSize = true;
            this.Rad_Tema2.Location = new System.Drawing.Point(211, 19);
            this.Rad_Tema2.Name = "Rad_Tema2";
            this.Rad_Tema2.Size = new System.Drawing.Size(61, 17);
            this.Rad_Tema2.TabIndex = 1;
            this.Rad_Tema2.TabStop = true;
            this.Rad_Tema2.Text = "Tema 2";
            this.Rad_Tema2.UseVisualStyleBackColor = true;
            this.Rad_Tema2.CheckedChanged += new System.EventHandler(this.Rad_Tema2_CheckedChanged);
            // 
            // Rad_tema1
            // 
            this.Rad_tema1.AutoSize = true;
            this.Rad_tema1.Location = new System.Drawing.Point(83, 19);
            this.Rad_tema1.Name = "Rad_tema1";
            this.Rad_tema1.Size = new System.Drawing.Size(61, 17);
            this.Rad_tema1.TabIndex = 0;
            this.Rad_tema1.TabStop = true;
            this.Rad_tema1.Text = "Tema 1";
            this.Rad_tema1.UseVisualStyleBackColor = true;
            this.Rad_tema1.CheckedChanged += new System.EventHandler(this.Rad_tema1_CheckedChanged);
            // 
            // Btn_Ativar
            // 
            this.Btn_Ativar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_Ativar.Location = new System.Drawing.Point(163, 150);
            this.Btn_Ativar.Name = "Btn_Ativar";
            this.Btn_Ativar.Size = new System.Drawing.Size(121, 47);
            this.Btn_Ativar.TabIndex = 20;
            this.Btn_Ativar.Text = "Ativar";
            this.Btn_Ativar.UseVisualStyleBackColor = false;
            // 
            // Btn_Deastivar
            // 
            this.Btn_Deastivar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Deastivar.Location = new System.Drawing.Point(340, 150);
            this.Btn_Deastivar.Name = "Btn_Deastivar";
            this.Btn_Deastivar.Size = new System.Drawing.Size(121, 47);
            this.Btn_Deastivar.TabIndex = 21;
            this.Btn_Deastivar.Text = "Desativar";
            this.Btn_Deastivar.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Limpar.Location = new System.Drawing.Point(518, 150);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(121, 47);
            this.Btn_Limpar.TabIndex = 22;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Email.Location = new System.Drawing.Point(150, 410);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Email.TabIndex = 24;
            this.Lbl_Email.Text = "Email";
            // 
            // btn_Email
            // 
            this.btn_Email.BackColor = System.Drawing.Color.Transparent;
            this.btn_Email.Location = new System.Drawing.Point(576, 405);
            this.btn_Email.Name = "btn_Email";
            this.btn_Email.Size = new System.Drawing.Size(75, 23);
            this.btn_Email.TabIndex = 25;
            this.btn_Email.Text = "Email";
            this.btn_Email.UseVisualStyleBackColor = false;
            this.btn_Email.Click += new System.EventHandler(this.btn_Email_Click);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Location = new System.Drawing.Point(150, 513);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(55, 13);
            this.Lbl_Resultado.TabIndex = 26;
            this.Lbl_Resultado.Text = "Resultado";
            // 
            // Frm_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cadastro_2.Properties.Resources.asian_business_woman_manager_analyzing_datum_charts_typing_computer_making_notes_documents_table_office_vintage_color_selective_focus_business_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 644);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.btn_Email);
            this.Controls.Add(this.Lbl_Email);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Deastivar);
            this.Controls.Add(this.Btn_Ativar);
            this.Controls.Add(this.Grp_Temas);
            this.Controls.Add(this.Lbl_Cadastro_Pessoal);
            this.Controls.Add(this.Btn_D_Completos);
            this.Controls.Add(this.Btn_Celular);
            this.Controls.Add(this.Btn_Bairro);
            this.Controls.Add(this.Btn_Idade);
            this.Controls.Add(this.Btn_Sobrenome);
            this.Controls.Add(this.Btn_Nome);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Txt_Celular);
            this.Controls.Add(this.Txt_Bairro);
            this.Controls.Add(this.Txt_Idade);
            this.Controls.Add(this.Txt_Sobrenome);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Conf_dados);
            this.Controls.Add(this.Lbl_Celular);
            this.Controls.Add(this.Lbl_Bairro);
            this.Controls.Add(this.Lbl_Idade);
            this.Controls.Add(this.Lbl_Sobrenome);
            this.Controls.Add(this.Lbl_Nome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Grp_Temas.ResumeLayout(false);
            this.Grp_Temas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Sobrenome;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Celular;
        private System.Windows.Forms.Label Lbl_Conf_dados;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Sobrenome;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Celular;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Button Btn_Nome;
        private System.Windows.Forms.Button Btn_Sobrenome;
        private System.Windows.Forms.Button Btn_Idade;
        private System.Windows.Forms.Button Btn_Bairro;
        private System.Windows.Forms.Button Btn_Celular;
        private System.Windows.Forms.Button Btn_D_Completos;
        private System.Windows.Forms.Label Lbl_Cadastro_Pessoal;
        private System.Windows.Forms.GroupBox Grp_Temas;
        private System.Windows.Forms.RadioButton Rad_Tema3;
        private System.Windows.Forms.RadioButton Rad_Tema2;
        private System.Windows.Forms.RadioButton Rad_tema1;
        private System.Windows.Forms.Button Btn_Ativar;
        private System.Windows.Forms.Button Btn_Deastivar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Button btn_Email;
        private System.Windows.Forms.Label Lbl_Resultado;
    }
}

