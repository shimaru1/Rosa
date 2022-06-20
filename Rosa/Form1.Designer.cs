
namespace Rosa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CadastroRosa = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.ciclo = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadastroRosa
            // 
            this.CadastroRosa.AutoSize = true;
            this.CadastroRosa.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastroRosa.Location = new System.Drawing.Point(855, 428);
            this.CadastroRosa.Name = "CadastroRosa";
            this.CadastroRosa.Size = new System.Drawing.Size(196, 41);
            this.CadastroRosa.TabIndex = 0;
            this.CadastroRosa.Text = "Cadastro Rosa ++";
            // 
            // cadastrar
            // 
            this.cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(31, 50);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(155, 38);
            this.cadastrar.TabIndex = 14;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // ciclo
            // 
            this.ciclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciclo.Location = new System.Drawing.Point(31, 116);
            this.ciclo.Name = "ciclo";
            this.ciclo.Size = new System.Drawing.Size(155, 40);
            this.ciclo.TabIndex = 15;
            this.ciclo.Text = "Ciclo menstrual";
            this.ciclo.UseVisualStyleBackColor = true;
            this.ciclo.Click += new System.EventHandler(this.ciclo_Click);
            // 
            // consultar
            // 
            this.consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(29, 190);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(156, 40);
            this.consultar.TabIndex = 16;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atualizar.Location = new System.Drawing.Point(32, 271);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(152, 37);
            this.Atualizar.TabIndex = 17;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1063, 478);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.ciclo);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.CadastroRosa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rosa ++";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CadastroRosa;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button ciclo;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button Atualizar;
    }
}

