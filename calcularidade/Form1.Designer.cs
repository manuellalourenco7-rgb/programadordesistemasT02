namespace calcularidade
{
    partial class frmCalcularIdade
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
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoNasc.ForeColor = System.Drawing.Color.White;
            this.lblAnoNasc.Location = new System.Drawing.Point(272, 57);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(115, 26);
            this.lblAnoNasc.TabIndex = 0;
            this.lblAnoNasc.Text = "Ano de nascimento";
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoNasc.Location = new System.Drawing.Point(279, 98);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(100, 28);
            this.txtAnoNasc.TabIndex = 1;
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoAtual.ForeColor = System.Drawing.Color.White;
            this.lblAnoAtual.Location = new System.Drawing.Point(297, 141);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(64, 26);
            this.lblAnoAtual.TabIndex = 2;
            this.lblAnoAtual.Text = "Ano atual";
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnoAtual.Location = new System.Drawing.Point(279, 182);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(100, 28);
            this.txtAnoAtual.TabIndex = 3;
            this.txtAnoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnoAtual_KeyPress);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(318, 225);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(22, 32);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "0";
            // 
            // frmCalcularIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtAnoAtual);
            this.Controls.Add(this.lblAnoAtual);
            this.Controls.Add(this.txtAnoNasc);
            this.Controls.Add(this.lblAnoNasc);
            this.Name = "frmCalcularIdade";
            this.Text = "Calcular Idade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblIdade;
    }
}

