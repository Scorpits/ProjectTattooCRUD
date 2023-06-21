namespace ProjectTattoo {
    partial class MainMenu {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_consultar_cliente = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_cadastrar.BackgroundImage")));
            this.bt_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.bt_cadastrar.Location = new System.Drawing.Point(12, 12);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(191, 78);
            this.bt_cadastrar.TabIndex = 0;
            this.bt_cadastrar.Text = " CADASTRAR / ATUALIZAR CLIENTE";
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_consultar_cliente
            // 
            this.bt_consultar_cliente.BackColor = System.Drawing.Color.Transparent;
            this.bt_consultar_cliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_consultar_cliente.BackgroundImage")));
            this.bt_consultar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_consultar_cliente.FlatAppearance.BorderSize = 0;
            this.bt_consultar_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_consultar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_consultar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_consultar_cliente.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_consultar_cliente.ForeColor = System.Drawing.Color.Black;
            this.bt_consultar_cliente.Location = new System.Drawing.Point(12, 96);
            this.bt_consultar_cliente.Name = "bt_consultar_cliente";
            this.bt_consultar_cliente.Size = new System.Drawing.Size(191, 78);
            this.bt_consultar_cliente.TabIndex = 1;
            this.bt_consultar_cliente.Text = "CONSULTAR / EXCLUIR CLIENTE";
            this.bt_consultar_cliente.UseVisualStyleBackColor = false;
            this.bt_consultar_cliente.Click += new System.EventHandler(this.bt_consultar_cliente_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Transparent;
            this.bt_sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sair.BackgroundImage")));
            this.bt_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            this.bt_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Yu Gothic UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.Black;
            this.bt_sair.Location = new System.Drawing.Point(601, 361);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(191, 78);
            this.bt_sair.TabIndex = 2;
            this.bt_sair.Text = "SAIR";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_consultar_cliente);
            this.Controls.Add(this.bt_cadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venus Tattoo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_consultar_cliente;
        private System.Windows.Forms.Button bt_sair;
    }
}

