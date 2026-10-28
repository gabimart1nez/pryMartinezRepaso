namespace pryMartinezRepaso
{
    partial class frmArray
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
            lblGrupo = new Label();
            lstDatos = new ListBox();
            cbCodigo = new ComboBox();
            lblGrupo1 = new Label();
            lblDato = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btnGrabar = new Button();
            btnSobreescribir = new Button();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(12, 9);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "Grupo";
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.Location = new Point(12, 35);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(153, 94);
            lstDatos.TabIndex = 1;
            lstDatos.SelectedIndexChanged += lstDatos_SelectedIndexChanged;
            // 
            // cbCodigo
            // 
            cbCodigo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCodigo.FormattingEnabled = true;
            cbCodigo.Location = new Point(58, 6);
            cbCodigo.Name = "cbCodigo";
            cbCodigo.Size = new Size(107, 23);
            cbCodigo.TabIndex = 2;
            cbCodigo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblGrupo1
            // 
            lblGrupo1.AutoSize = true;
            lblGrupo1.Location = new Point(12, 204);
            lblGrupo1.Name = "lblGrupo1";
            lblGrupo1.Size = new Size(40, 15);
            lblGrupo1.TabIndex = 3;
            lblGrupo1.Text = "Grupo";
            lblGrupo1.Click += label1_Click;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(12, 233);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(32, 15);
            lblDato.TabIndex = 4;
            lblDato.Text = "Dato";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(58, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 6;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(91, 264);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnSobreescribir
            // 
            btnSobreescribir.Location = new Point(13, 147);
            btnSobreescribir.Name = "btnSobreescribir";
            btnSobreescribir.Size = new Size(153, 23);
            btnSobreescribir.TabIndex = 8;
            btnSobreescribir.Text = "Sobreescribir Array";
            btnSobreescribir.UseVisualStyleBackColor = true;
            // 
            // frmArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(177, 299);
            Controls.Add(btnSobreescribir);
            Controls.Add(btnGrabar);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lblDato);
            Controls.Add(lblGrupo1);
            Controls.Add(cbCodigo);
            Controls.Add(lstDatos);
            Controls.Add(lblGrupo);
            Name = "frmArray";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Planes";
            Load += frmArray_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupo;
        private ListBox lstDatos;
        private ComboBox cbCodigo;
        private Label lblGrupo1;
        private Label lblDato;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btnGrabar;
        private Button btnSobreescribir;
    }
}