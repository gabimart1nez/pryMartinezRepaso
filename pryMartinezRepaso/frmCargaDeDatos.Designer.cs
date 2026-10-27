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
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(77, 20);
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
            btnRegistrar.Location = new Point(142, 67);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(71, 25);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmCargaDeDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 117);
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
    }
}