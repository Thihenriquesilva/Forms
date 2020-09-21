namespace EstudoTaskool.Views
{
    partial class frmListaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaUsuario = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.lblContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaUsuario
            // 
            this.dgvListaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuario.Location = new System.Drawing.Point(11, 37);
            this.dgvListaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaUsuario.Name = "dgvListaUsuario";
            this.dgvListaUsuario.RowHeadersWidth = 51;
            this.dgvListaUsuario.RowTemplate.Height = 24;
            this.dgvListaUsuario.Size = new System.Drawing.Size(811, 496);
            this.dgvListaUsuario.TabIndex = 0;
            this.dgvListaUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuario_CellClick);
            this.dgvListaUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaUsuario_CellMouseClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Location = new System.Drawing.Point(827, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro:";
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(50, 10);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(291, 20);
            this.filtroTextBox.TabIndex = 3;
            this.filtroTextBox.TextChanged += new System.EventHandler(this.filtroTextBox_TextChanged);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(827, 520);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 13);
            this.lblContador.TabIndex = 4;
            this.lblContador.Text = "label2";
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 544);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvListaUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaUsuario";
            this.Text = "Listagem de Usuário";
            this.Load += new System.EventHandler(this.frmListaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaUsuario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Label lblContador;
    }
}