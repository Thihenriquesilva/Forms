namespace OpenFileDialogDemo
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
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txtArquivos = new System.Windows.Forms.TextBox();
            this.btnSelecionarArquivos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.FilterIndex = 2;
            this.ofd1.ReadOnlyChecked = true;
            this.ofd1.RestoreDirectory = true;
            this.ofd1.ShowReadOnly = true;
            // 
            // txtArquivos
            // 
            this.txtArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivos.Location = new System.Drawing.Point(12, 12);
            this.txtArquivos.Name = "txtArquivos";
            this.txtArquivos.Size = new System.Drawing.Size(242, 23);
            this.txtArquivos.TabIndex = 0;
            // 
            // btnSelecionarArquivos
            // 
            this.btnSelecionarArquivos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelecionarArquivos.Location = new System.Drawing.Point(293, 12);
            this.btnSelecionarArquivos.Name = "btnSelecionarArquivos";
            this.btnSelecionarArquivos.Size = new System.Drawing.Size(136, 29);
            this.btnSelecionarArquivos.TabIndex = 1;
            this.btnSelecionarArquivos.Text = "Selecionar Arquivos";
            this.btnSelecionarArquivos.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivos.Click += new System.EventHandler(this.btnSelecionarArquivos_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(417, 300);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(441, 359);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnSelecionarArquivos);
            this.Controls.Add(this.txtArquivos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.TextBox txtArquivos;
        private System.Windows.Forms.Button btnSelecionarArquivos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

