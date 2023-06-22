namespace ProjectTattoo.View {
    partial class MenuCadastrar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCadastrar));
            this.label_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label_endereco = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.bt_new = new System.Windows.Forms.Button();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.label_CEP = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.label_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label_cidade = new System.Windows.Forms.Label();
            this.label_telefne = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label_horario = new System.Windows.Forms.Label();
            this.date_horario = new System.Windows.Forms.DateTimePicker();
            this.label_tatuagem = new System.Windows.Forms.Label();
            this.txt_tatuagem = new System.Windows.Forms.RichTextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label_buscaID = new System.Windows.Forms.Label();
            this.bt_busca = new System.Windows.Forms.Button();
            this.txt_busca = new System.Windows.Forms.MaskedTextBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(13, 58);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(16, 75);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(36, 20);
            this.txt_ID.TabIndex = 3;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(59, 58);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(39, 13);
            this.label_nome.TabIndex = 4;
            this.label_nome.Text = "Nome*";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(62, 74);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(726, 20);
            this.txt_nome.TabIndex = 5;
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Location = new System.Drawing.Point(13, 98);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(57, 13);
            this.label_endereco.TabIndex = 6;
            this.label_endereco.Text = "Endereço*";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(16, 114);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(772, 20);
            this.txt_endereco.TabIndex = 7;
            // 
            // bt_new
            // 
            this.bt_new.BackColor = System.Drawing.SystemColors.Control;
            this.bt_new.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_new.BackgroundImage")));
            this.bt_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_new.FlatAppearance.BorderSize = 0;
            this.bt_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_new.Location = new System.Drawing.Point(16, 12);
            this.bt_new.Name = "bt_new";
            this.bt_new.Size = new System.Drawing.Size(36, 43);
            this.bt_new.TabIndex = 8;
            this.bt_new.UseVisualStyleBackColor = false;
            this.bt_new.Click += new System.EventHandler(this.bt_new_Click);
            // 
            // bt_salvar
            // 
            this.bt_salvar.BackColor = System.Drawing.SystemColors.Control;
            this.bt_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_salvar.BackgroundImage")));
            this.bt_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_salvar.FlatAppearance.BorderSize = 0;
            this.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_salvar.Location = new System.Drawing.Point(58, 12);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(36, 43);
            this.bt_salvar.TabIndex = 9;
            this.bt_salvar.UseVisualStyleBackColor = false;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // label_CEP
            // 
            this.label_CEP.AutoSize = true;
            this.label_CEP.Location = new System.Drawing.Point(13, 141);
            this.label_CEP.Name = "label_CEP";
            this.label_CEP.Size = new System.Drawing.Size(28, 13);
            this.label_CEP.TabIndex = 10;
            this.label_CEP.Text = "CEP";
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(16, 158);
            this.txt_cep.Mask = "00000-000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(59, 20);
            this.txt_cep.TabIndex = 11;
            // 
            // label_bairro
            // 
            this.label_bairro.AutoSize = true;
            this.label_bairro.Location = new System.Drawing.Point(77, 141);
            this.label_bairro.Name = "label_bairro";
            this.label_bairro.Size = new System.Drawing.Size(38, 13);
            this.label_bairro.TabIndex = 12;
            this.label_bairro.Text = "Bairro*";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(81, 158);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(288, 20);
            this.txt_bairro.TabIndex = 13;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(375, 158);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(413, 20);
            this.txt_cidade.TabIndex = 14;
            // 
            // label_cidade
            // 
            this.label_cidade.AutoSize = true;
            this.label_cidade.Location = new System.Drawing.Point(375, 141);
            this.label_cidade.Name = "label_cidade";
            this.label_cidade.Size = new System.Drawing.Size(44, 13);
            this.label_cidade.TabIndex = 15;
            this.label_cidade.Text = "Cidade*";
            // 
            // label_telefne
            // 
            this.label_telefne.AutoSize = true;
            this.label_telefne.Location = new System.Drawing.Point(16, 185);
            this.label_telefne.Name = "label_telefne";
            this.label_telefne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_telefne.Size = new System.Drawing.Size(49, 13);
            this.label_telefne.TabIndex = 16;
            this.label_telefne.Text = "Telefone";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(16, 201);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(88, 20);
            this.txt_telefone.TabIndex = 17;
            // 
            // label_horario
            // 
            this.label_horario.AutoSize = true;
            this.label_horario.Location = new System.Drawing.Point(111, 185);
            this.label_horario.Name = "label_horario";
            this.label_horario.Size = new System.Drawing.Size(89, 13);
            this.label_horario.TabIndex = 18;
            this.label_horario.Text = "Dia da Tatuagem";
            // 
            // date_horario
            // 
            this.date_horario.Location = new System.Drawing.Point(114, 201);
            this.date_horario.Name = "date_horario";
            this.date_horario.Size = new System.Drawing.Size(674, 20);
            this.date_horario.TabIndex = 19;
            // 
            // label_tatuagem
            // 
            this.label_tatuagem.AutoSize = true;
            this.label_tatuagem.Location = new System.Drawing.Point(16, 228);
            this.label_tatuagem.Name = "label_tatuagem";
            this.label_tatuagem.Size = new System.Drawing.Size(114, 13);
            this.label_tatuagem.TabIndex = 20;
            this.label_tatuagem.Text = "Detalhe da Tatuagem*";
            // 
            // txt_tatuagem
            // 
            this.txt_tatuagem.Location = new System.Drawing.Point(16, 244);
            this.txt_tatuagem.Name = "txt_tatuagem";
            this.txt_tatuagem.Size = new System.Drawing.Size(772, 96);
            this.txt_tatuagem.TabIndex = 21;
            this.txt_tatuagem.Text = "";
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.bt_cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cancel.BackgroundImage")));
            this.bt_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cancel.FlatAppearance.BorderSize = 0;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Location = new System.Drawing.Point(100, 12);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(36, 43);
            this.bt_cancel.TabIndex = 22;
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label_buscaID
            // 
            this.label_buscaID.AutoSize = true;
            this.label_buscaID.Location = new System.Drawing.Point(142, 12);
            this.label_buscaID.Name = "label_buscaID";
            this.label_buscaID.Size = new System.Drawing.Size(72, 13);
            this.label_buscaID.TabIndex = 23;
            this.label_buscaID.Text = "Busca por ID:";
            // 
            // bt_busca
            // 
            this.bt_busca.BackColor = System.Drawing.SystemColors.Control;
            this.bt_busca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_busca.BackgroundImage")));
            this.bt_busca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_busca.FlatAppearance.BorderSize = 0;
            this.bt_busca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_busca.Location = new System.Drawing.Point(251, 12);
            this.bt_busca.Name = "bt_busca";
            this.bt_busca.Size = new System.Drawing.Size(27, 32);
            this.bt_busca.TabIndex = 25;
            this.bt_busca.UseVisualStyleBackColor = false;
            this.bt_busca.Click += new System.EventHandler(this.bt_busca_Click);
            // 
            // txt_busca
            // 
            this.txt_busca.Location = new System.Drawing.Point(145, 24);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(100, 20);
            this.txt_busca.TabIndex = 26;
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(713, 416);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 27;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // MenuCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.bt_busca);
            this.Controls.Add(this.label_buscaID);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.txt_tatuagem);
            this.Controls.Add(this.label_tatuagem);
            this.Controls.Add(this.date_horario);
            this.Controls.Add(this.label_horario);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.label_telefne);
            this.Controls.Add(this.label_cidade);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label_bairro);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.label_CEP);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.bt_new);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label_endereco);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label_ID);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 490);
            this.MinimumSize = new System.Drawing.Size(820, 490);
            this.Name = "MenuCadastrar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Clientes";
            this.Load += new System.EventHandler(this.MenuCadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label_endereco;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Button bt_new;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Label label_CEP;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.Label label_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label_cidade;
        private System.Windows.Forms.Label label_telefne;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label label_horario;
        private System.Windows.Forms.DateTimePicker date_horario;
        private System.Windows.Forms.Label label_tatuagem;
        private System.Windows.Forms.RichTextBox txt_tatuagem;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label_buscaID;
        private System.Windows.Forms.Button bt_busca;
        private System.Windows.Forms.MaskedTextBox txt_busca;
        private System.Windows.Forms.Button bt_sair;
    }
}