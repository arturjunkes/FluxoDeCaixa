namespace FluxoDeCaixa.Grafico
{
    partial class TelaPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tpRegistros = new System.Windows.Forms.TabPage();
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btRemoverRegistro = new System.Windows.Forms.Button();
            this.btAlterarRegistro = new System.Windows.Forms.Button();
            this.btAdicionarRegistro = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tpRegistros);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tpRegistros
            // 
            this.tpRegistros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpRegistros.Controls.Add(this.dgRegistros);
            this.tpRegistros.Controls.Add(this.btRemoverRegistro);
            this.tpRegistros.Controls.Add(this.btAlterarRegistro);
            this.tpRegistros.Controls.Add(this.btAdicionarRegistro);
            this.tpRegistros.Location = new System.Drawing.Point(4, 22);
            this.tpRegistros.Name = "tpRegistros";
            this.tpRegistros.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistros.Size = new System.Drawing.Size(480, 311);
            this.tpRegistros.TabIndex = 0;
            this.tpRegistros.Text = "Registros";
            // 
            // dgRegistros
            // 
            this.dgRegistros.AllowUserToAddRows = false;
            this.dgRegistros.AllowUserToDeleteRows = false;
            this.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Valor});
            this.dgRegistros.Location = new System.Drawing.Point(7, 37);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.ReadOnly = true;
            this.dgRegistros.Size = new System.Drawing.Size(467, 266);
            this.dgRegistros.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Valor";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // btRemoverRegistro
            // 
            this.btRemoverRegistro.Location = new System.Drawing.Point(169, 7);
            this.btRemoverRegistro.Name = "btRemoverRegistro";
            this.btRemoverRegistro.Size = new System.Drawing.Size(75, 23);
            this.btRemoverRegistro.TabIndex = 2;
            this.btRemoverRegistro.Text = "Remover";
            this.btRemoverRegistro.UseVisualStyleBackColor = true;
            this.btRemoverRegistro.Click += new System.EventHandler(this.btRemoverRegistro_Click);
            // 
            // btAlterarRegistro
            // 
            this.btAlterarRegistro.Location = new System.Drawing.Point(88, 7);
            this.btAlterarRegistro.Name = "btAlterarRegistro";
            this.btAlterarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btAlterarRegistro.TabIndex = 1;
            this.btAlterarRegistro.Text = "Alterar";
            this.btAlterarRegistro.UseVisualStyleBackColor = true;
            this.btAlterarRegistro.Click += new System.EventHandler(this.btAlterarRegistro_Click);
            // 
            // btAdicionarRegistro
            // 
            this.btAdicionarRegistro.Location = new System.Drawing.Point(7, 7);
            this.btAdicionarRegistro.Name = "btAdicionarRegistro";
            this.btAdicionarRegistro.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarRegistro.TabIndex = 0;
            this.btAdicionarRegistro.Text = "Adicionar";
            this.btAdicionarRegistro.UseVisualStyleBackColor = true;
            this.btAdicionarRegistro.Click += new System.EventHandler(this.btAdicionarRegistro_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "TelaPrincipal";
            this.Text = "Fluxo de Caixa";
            this.tabControl1.ResumeLayout(false);
            this.tpRegistros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpRegistros;
        private System.Windows.Forms.Button btRemoverRegistro;
        private System.Windows.Forms.Button btAlterarRegistro;
        private System.Windows.Forms.Button btAdicionarRegistro;
        private System.Windows.Forms.DataGridView dgRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}

