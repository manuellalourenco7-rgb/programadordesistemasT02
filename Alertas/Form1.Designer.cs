namespace Alertas
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
            this.lblTítulo = new System.Windows.Forms.Label();
            this.btnAlertaSimples = new System.Windows.Forms.Button();
            this.btnAlertaRobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(36, 30);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(172, 20);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Teste os alertas abaixo";
            // 
            // btnAlertaSimples
            // 
            this.btnAlertaSimples.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAlertaSimples.FlatAppearance.BorderSize = 0;
            this.btnAlertaSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaSimples.Location = new System.Drawing.Point(74, 65);
            this.btnAlertaSimples.Name = "btnAlertaSimples";
            this.btnAlertaSimples.Size = new System.Drawing.Size(95, 25);
            this.btnAlertaSimples.TabIndex = 1;
            this.btnAlertaSimples.Text = "Alerta Simples";
            this.btnAlertaSimples.UseVisualStyleBackColor = false;
            this.btnAlertaSimples.Click += new System.EventHandler(this.btnAlertaSimples_Click);
            // 
            // btnAlertaRobusto
            // 
            this.btnAlertaRobusto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAlertaRobusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertaRobusto.FlatAppearance.BorderSize = 0;
            this.btnAlertaRobusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlertaRobusto.Font = new System.Drawing.Font("Rockwell Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaRobusto.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnAlertaRobusto.Location = new System.Drawing.Point(74, 112);
            this.btnAlertaRobusto.Name = "btnAlertaRobusto";
            this.btnAlertaRobusto.Size = new System.Drawing.Size(95, 23);
            this.btnAlertaRobusto.TabIndex = 2;
            this.btnAlertaRobusto.Text = "Alerta Robusto";
            this.btnAlertaRobusto.UseVisualStyleBackColor = false;
            this.btnAlertaRobusto.Click += new System.EventHandler(this.btnAlertaRobusto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlertaRobusto);
            this.Controls.Add(this.btnAlertaSimples);
            this.Controls.Add(this.lblTítulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Button btnAlertaSimples;
        private System.Windows.Forms.Button btnAlertaRobusto;
    }
}

