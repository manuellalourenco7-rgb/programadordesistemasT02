namespace picturebox
{
    partial class frmPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.btnVerImagem = new System.Windows.Forms.Button();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.pbAnexarImagem = new System.Windows.Forms.PictureBox();
            this.btnAnexar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(12, 12);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(326, 149);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputador.TabIndex = 0;
            this.pbComputador.TabStop = false;
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.BackColor = System.Drawing.Color.Maroon;
            this.btnVerImagem.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImagem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnVerImagem.Location = new System.Drawing.Point(26, 327);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(297, 45);
            this.btnVerImagem.TabIndex = 2;
            this.btnVerImagem.Text = "Ver imagem";
            this.btnVerImagem.UseVisualStyleBackColor = false;
            this.btnVerImagem.Click += new System.EventHandler(this.btnVerImagem_Click);
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(12, 177);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(326, 144);
            this.pbCidade.TabIndex = 3;
            this.pbCidade.TabStop = false;
            // 
            // pbAnexarImagem
            // 
            this.pbAnexarImagem.Location = new System.Drawing.Point(344, 12);
            this.pbAnexarImagem.Name = "pbAnexarImagem";
            this.pbAnexarImagem.Size = new System.Drawing.Size(238, 309);
            this.pbAnexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnexarImagem.TabIndex = 4;
            this.pbAnexarImagem.TabStop = false;
            // 
            // btnAnexar
            // 
            this.btnAnexar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAnexar.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAnexar.Location = new System.Drawing.Point(344, 327);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(238, 45);
            this.btnAnexar.TabIndex = 5;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.pbAnexarImagem);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pbComputador);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmPictureBox";
            this.Text = "Picture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.Button btnVerImagem;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.PictureBox pbAnexarImagem;
        private System.Windows.Forms.Button btnAnexar;
    }
}

