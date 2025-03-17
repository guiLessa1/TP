namespace TP_produto
{
    partial class Form1
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
            this.btCriar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txPreco = new System.Windows.Forms.TextBox();
            this.dtRelatorio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btCriar
            // 
            this.btCriar.Location = new System.Drawing.Point(416, 65);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(105, 67);
            this.btCriar.TabIndex = 0;
            this.btCriar.Text = "Criar";
            this.btCriar.UseVisualStyleBackColor = true;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click_1);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(209, 68);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(47, 16);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(209, 113);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(46, 16);
            this.lbPreco.TabIndex = 2;
            this.lbPreco.Text = "Preço:";
            this.lbPreco.Click += new System.EventHandler(this.lbPreco_Click);
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(289, 65);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(100, 22);
            this.txNome.TabIndex = 3;
            // 
            // txPreco
            // 
            this.txPreco.Location = new System.Drawing.Point(289, 110);
            this.txPreco.Name = "txPreco";
            this.txPreco.Size = new System.Drawing.Size(100, 22);
            this.txPreco.TabIndex = 4;
            // 
            // dtRelatorio
            // 
            this.dtRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRelatorio.Location = new System.Drawing.Point(112, 297);
            this.dtRelatorio.Name = "dtRelatorio";
            this.dtRelatorio.RowHeadersWidth = 51;
            this.dtRelatorio.RowTemplate.Height = 24;
            this.dtRelatorio.Size = new System.Drawing.Size(623, 150);
            this.dtRelatorio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtRelatorio);
            this.Controls.Add(this.txPreco);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.btCriar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txPreco;
        private System.Windows.Forms.DataGridView dtRelatorio;
    }
}

