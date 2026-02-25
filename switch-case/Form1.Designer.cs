namespace switch_case
{
    partial class frmSwitch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigoInserido = new System.Windows.Forms.TextBox();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImage = global::switch_case.Properties.Resources.koikeyusuke_skyscrapers_6594833_1920;
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.txtCodigoInserido);
            this.panel1.Controls.Add(this.lblTítulo);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Black;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.Moccasin;
            this.btnEnviar.Location = new System.Drawing.Point(322, 190);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 31);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEnviar_MouseClick);
            // 
            // lblDescricao
            // 
            this.lblDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Moccasin;
            this.lblDescricao.Location = new System.Drawing.Point(322, 141);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(100, 23);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoInserido
            // 
            this.txtCodigoInserido.BackColor = System.Drawing.Color.Moccasin;
            this.txtCodigoInserido.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoInserido.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCodigoInserido.Location = new System.Drawing.Point(322, 89);
            this.txtCodigoInserido.Name = "txtCodigoInserido";
            this.txtCodigoInserido.Size = new System.Drawing.Size(100, 28);
            this.txtCodigoInserido.TabIndex = 1;
            this.txtCodigoInserido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.ForeColor = System.Drawing.Color.Moccasin;
            this.lblTítulo.Location = new System.Drawing.Point(304, 50);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(136, 26);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Insira o código de 1 a 6:";
            // 
            // frmSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmSwitch";
            this.Text = "Condicional Switch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigoInserido;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnEnviar;
    }
}

