namespace pryMartinezRepaso
{
    partial class frmCalculo
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
            lblMonto = new Label();
            lblIva = new Label();
            cbIva = new ComboBox();
            txtMonto = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(21, 28);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(21, 70);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(24, 15);
            lblIva.TabIndex = 1;
            lblIva.Text = "IVA";
            // 
            // cbIva
            // 
            cbIva.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIva.FormattingEnabled = true;
            cbIva.Items.AddRange(new object[] { "10%", "21%" });
            cbIva.Location = new Point(81, 62);
            cbIva.Name = "cbIva";
            cbIva.Size = new Size(93, 23);
            cbIva.TabIndex = 2;
            cbIva.SelectedIndexChanged += cbIva_SelectedIndexChanged;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(81, 28);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(93, 23);
            txtMonto.TabIndex = 3;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(143, 105);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(62, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(81, 139);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            // 
            // frmCalculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 173);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtMonto);
            Controls.Add(cbIva);
            Controls.Add(lblIva);
            Controls.Add(lblMonto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalculo";
            Text = "Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblIva;
        private ComboBox cbIva;
        private TextBox txtMonto;
        private Button btnCalcular;
        private Label lblResultado;
    }
}