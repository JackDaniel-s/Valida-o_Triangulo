
namespace AtividadeTriangulo
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLado1 = new System.Windows.Forms.Label();
            this.txbLado1 = new System.Windows.Forms.TextBox();
            this.txbLado2 = new System.Windows.Forms.TextBox();
            this.lblLado2 = new System.Windows.Forms.Label();
            this.txbLado3 = new System.Windows.Forms.TextBox();
            this.lblLado3 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLado1.Location = new System.Drawing.Point(49, 42);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(46, 16);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado 1";
            // 
            // txbLado1
            // 
            this.txbLado1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLado1.Location = new System.Drawing.Point(49, 60);
            this.txbLado1.Name = "txbLado1";
            this.txbLado1.Size = new System.Drawing.Size(216, 22);
            this.txbLado1.TabIndex = 1;
            // 
            // txbLado2
            // 
            this.txbLado2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLado2.Location = new System.Drawing.Point(49, 130);
            this.txbLado2.Name = "txbLado2";
            this.txbLado2.Size = new System.Drawing.Size(216, 22);
            this.txbLado2.TabIndex = 3;
            // 
            // lblLado2
            // 
            this.lblLado2.AutoSize = true;
            this.lblLado2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLado2.Location = new System.Drawing.Point(49, 112);
            this.lblLado2.Name = "lblLado2";
            this.lblLado2.Size = new System.Drawing.Size(46, 16);
            this.lblLado2.TabIndex = 2;
            this.lblLado2.Text = "Lado 2";
            // 
            // txbLado3
            // 
            this.txbLado3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbLado3.Location = new System.Drawing.Point(49, 206);
            this.txbLado3.Name = "txbLado3";
            this.txbLado3.Size = new System.Drawing.Size(216, 22);
            this.txbLado3.TabIndex = 5;
            // 
            // lblLado3
            // 
            this.lblLado3.AutoSize = true;
            this.lblLado3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLado3.Location = new System.Drawing.Point(49, 188);
            this.lblLado3.Name = "lblLado3";
            this.lblLado3.Size = new System.Drawing.Size(46, 16);
            this.lblLado3.TabIndex = 4;
            this.lblLado3.Text = "Lado 3";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerificar.Location = new System.Drawing.Point(49, 259);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(216, 23);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResposta.Location = new System.Drawing.Point(49, 308);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(62, 16);
            this.lblResposta.TabIndex = 7;
            this.lblResposta.Text = "Resposta";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 349);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbLado3);
            this.Controls.Add(this.lblLado3);
            this.Controls.Add(this.txbLado2);
            this.Controls.Add(this.lblLado2);
            this.Controls.Add(this.txbLado1);
            this.Controls.Add(this.lblLado1);
            this.Name = "FrmPrincipal";
            this.Text = "Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.TextBox txbLado1;
        private System.Windows.Forms.TextBox txbLado2;
        private System.Windows.Forms.Label lblLado2;
        private System.Windows.Forms.TextBox txbLado3;
        private System.Windows.Forms.Label lblLado3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResposta;
    }
}

