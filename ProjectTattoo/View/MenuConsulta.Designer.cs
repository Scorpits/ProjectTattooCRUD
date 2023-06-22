namespace ProjectTattoo.View {
    partial class MenuConsulta {
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.bt_carregarData = new System.Windows.Forms.Button();
            this.label_buscaID = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.bt_buscarID = new System.Windows.Forms.Button();
            this.label_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.label_endereco = new System.Windows.Forms.Label();
            this.label_cep = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.label_telefone = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label_horario = new System.Windows.Forms.Label();
            this.txt_horario = new System.Windows.Forms.TextBox();
            this.label_tatuagem = new System.Windows.Forms.Label();
            this.txt_tatuagem = new System.Windows.Forms.RichTextBox();
            this.label_escolhido = new System.Windows.Forms.Label();
            this.txt_reallyID = new System.Windows.Forms.TextBox();
            this.label_bairro = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label_cidade = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.bt_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(399, 7);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(393, 432);
            this.dataGrid.TabIndex = 0;
            // 
            // bt_carregarData
            // 
            this.bt_carregarData.Location = new System.Drawing.Point(286, 386);
            this.bt_carregarData.Name = "bt_carregarData";
            this.bt_carregarData.Size = new System.Drawing.Size(107, 23);
            this.bt_carregarData.TabIndex = 1;
            this.bt_carregarData.Text = "Atualizar dados";
            this.bt_carregarData.UseVisualStyleBackColor = true;
            this.bt_carregarData.Click += new System.EventHandler(this.bt_carregarData_Click);
            // 
            // label_buscaID
            // 
            this.label_buscaID.AutoSize = true;
            this.label_buscaID.Location = new System.Drawing.Point(13, 12);
            this.label_buscaID.Name = "label_buscaID";
            this.label_buscaID.Size = new System.Drawing.Size(57, 13);
            this.label_buscaID.TabIndex = 2;
            this.label_buscaID.Text = "Buscar ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(76, 9);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(204, 20);
            this.txt_id.TabIndex = 3;
            // 
            // bt_buscarID
            // 
            this.bt_buscarID.Location = new System.Drawing.Point(286, 7);
            this.bt_buscarID.Name = "bt_buscarID";
            this.bt_buscarID.Size = new System.Drawing.Size(107, 23);
            this.bt_buscarID.TabIndex = 4;
            this.bt_buscarID.Text = "Buscar ID";
            this.bt_buscarID.UseVisualStyleBackColor = true;
            this.bt_buscarID.Click += new System.EventHandler(this.bt_buscarID_Click);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(16, 38);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(38, 13);
            this.label_nome.TabIndex = 5;
            this.label_nome.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(57, 35);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.ReadOnly = true;
            this.txt_nome.Size = new System.Drawing.Size(336, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(12, 386);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(121, 23);
            this.bt_excluir.TabIndex = 7;
            this.bt_excluir.Text = "Excluir ID selecionado";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Location = new System.Drawing.Point(-2, 62);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(56, 13);
            this.label_endereco.TabIndex = 8;
            this.label_endereco.Text = "Endereço:";
            // 
            // label_cep
            // 
            this.label_cep.AutoSize = true;
            this.label_cep.Location = new System.Drawing.Point(23, 89);
            this.label_cep.Name = "label_cep";
            this.label_cep.Size = new System.Drawing.Size(31, 13);
            this.label_cep.TabIndex = 9;
            this.label_cep.Text = "CEP:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(57, 59);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.ReadOnly = true;
            this.txt_endereco.Size = new System.Drawing.Size(336, 20);
            this.txt_endereco.TabIndex = 10;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(57, 86);
            this.txt_cep.Mask = "00000-000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.ReadOnly = true;
            this.txt_cep.Size = new System.Drawing.Size(100, 20);
            this.txt_cep.TabIndex = 11;
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Location = new System.Drawing.Point(163, 89);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(66, 13);
            this.label_telefone.TabIndex = 12;
            this.label_telefone.Text = "TELEFONE:";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(235, 86);
            this.txt_telefone.Mask = "(00) 00000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.ReadOnly = true;
            this.txt_telefone.Size = new System.Drawing.Size(158, 20);
            this.txt_telefone.TabIndex = 13;
            // 
            // label_horario
            // 
            this.label_horario.AutoSize = true;
            this.label_horario.Location = new System.Drawing.Point(25, 116);
            this.label_horario.Name = "label_horario";
            this.label_horario.Size = new System.Drawing.Size(26, 13);
            this.label_horario.TabIndex = 16;
            this.label_horario.Text = "Dia:";
            // 
            // txt_horario
            // 
            this.txt_horario.Location = new System.Drawing.Point(57, 113);
            this.txt_horario.Name = "txt_horario";
            this.txt_horario.ReadOnly = true;
            this.txt_horario.Size = new System.Drawing.Size(336, 20);
            this.txt_horario.TabIndex = 17;
            // 
            // label_tatuagem
            // 
            this.label_tatuagem.AutoSize = true;
            this.label_tatuagem.Location = new System.Drawing.Point(-2, 192);
            this.label_tatuagem.Name = "label_tatuagem";
            this.label_tatuagem.Size = new System.Drawing.Size(58, 13);
            this.label_tatuagem.TabIndex = 18;
            this.label_tatuagem.Text = "Tatuagem:";
            // 
            // txt_tatuagem
            // 
            this.txt_tatuagem.Location = new System.Drawing.Point(57, 189);
            this.txt_tatuagem.Name = "txt_tatuagem";
            this.txt_tatuagem.ReadOnly = true;
            this.txt_tatuagem.Size = new System.Drawing.Size(336, 191);
            this.txt_tatuagem.TabIndex = 19;
            this.txt_tatuagem.Text = "";
            // 
            // label_escolhido
            // 
            this.label_escolhido.AutoSize = true;
            this.label_escolhido.Location = new System.Drawing.Point(139, 391);
            this.label_escolhido.Name = "label_escolhido";
            this.label_escolhido.Size = new System.Drawing.Size(21, 13);
            this.label_escolhido.TabIndex = 20;
            this.label_escolhido.Text = "ID:";
            // 
            // txt_reallyID
            // 
            this.txt_reallyID.Location = new System.Drawing.Point(157, 388);
            this.txt_reallyID.Name = "txt_reallyID";
            this.txt_reallyID.ReadOnly = true;
            this.txt_reallyID.Size = new System.Drawing.Size(123, 20);
            this.txt_reallyID.TabIndex = 21;
            // 
            // label_bairro
            // 
            this.label_bairro.AutoSize = true;
            this.label_bairro.Location = new System.Drawing.Point(14, 142);
            this.label_bairro.Name = "label_bairro";
            this.label_bairro.Size = new System.Drawing.Size(37, 13);
            this.label_bairro.TabIndex = 22;
            this.label_bairro.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(57, 139);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.ReadOnly = true;
            this.txt_bairro.Size = new System.Drawing.Size(336, 20);
            this.txt_bairro.TabIndex = 23;
            // 
            // label_cidade
            // 
            this.label_cidade.AutoSize = true;
            this.label_cidade.Location = new System.Drawing.Point(9, 166);
            this.label_cidade.Name = "label_cidade";
            this.label_cidade.Size = new System.Drawing.Size(43, 13);
            this.label_cidade.TabIndex = 24;
            this.label_cidade.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(57, 163);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.ReadOnly = true;
            this.txt_cidade.Size = new System.Drawing.Size(336, 20);
            this.txt_cidade.TabIndex = 25;
            // 
            // bt_voltar
            // 
            this.bt_voltar.Location = new System.Drawing.Point(12, 416);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(75, 23);
            this.bt_voltar.TabIndex = 26;
            this.bt_voltar.Text = "Sair";
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // MenuConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label_bairro);
            this.Controls.Add(this.txt_reallyID);
            this.Controls.Add(this.label_escolhido);
            this.Controls.Add(this.txt_tatuagem);
            this.Controls.Add(this.label_tatuagem);
            this.Controls.Add(this.txt_horario);
            this.Controls.Add(this.label_horario);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.label_telefone);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label_cep);
            this.Controls.Add(this.label_endereco);
            this.Controls.Add(this.bt_excluir);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.bt_buscarID);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label_buscaID);
            this.Controls.Add(this.bt_carregarData);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.MenuConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button bt_carregarData;
        private System.Windows.Forms.Label label_buscaID;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button bt_buscarID;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Label label_endereco;
        private System.Windows.Forms.Label label_cep;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label label_horario;
        private System.Windows.Forms.TextBox txt_horario;
        private System.Windows.Forms.Label label_tatuagem;
        private System.Windows.Forms.RichTextBox txt_tatuagem;
        private System.Windows.Forms.Label label_escolhido;
        private System.Windows.Forms.TextBox txt_reallyID;
        private System.Windows.Forms.Label label_bairro;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label_cidade;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Button bt_voltar;
    }
}