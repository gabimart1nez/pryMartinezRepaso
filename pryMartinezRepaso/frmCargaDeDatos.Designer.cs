namespace pryMartinezRepaso
{
    partial class frmCargaDeDatos
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
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnRegistrar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(77, 17);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(118, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 20);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Codigo";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(142, 102);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(71, 25);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(77, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 4;
            // 
            // frmCargaDeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 144);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnRegistrar);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            MaximizeBox = false;
            Name = "frmCargaDeDatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carga de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnRegistrar;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}