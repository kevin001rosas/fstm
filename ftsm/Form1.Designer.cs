namespace ftsm
{
    partial class Form1
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
            this.comboBox_estado = new System.Windows.Forms.ComboBox();
            this.comboBox_cliente = new System.Windows.Forms.ComboBox();
            this.comboBox_gerente = new System.Windows.Forms.ComboBox();
            this.comboBox_operador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_estado
            // 
            this.comboBox_estado.FormattingEnabled = true;
            this.comboBox_estado.Location = new System.Drawing.Point(126, 19);
            this.comboBox_estado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_estado.Name = "comboBox_estado";
            this.comboBox_estado.Size = new System.Drawing.Size(385, 29);
            this.comboBox_estado.TabIndex = 0;
            this.comboBox_estado.SelectedValueChanged += new System.EventHandler(this.csomboBox_estado_SelectedValueChanged);
            // 
            // comboBox_cliente
            // 
            this.comboBox_cliente.FormattingEnabled = true;
            this.comboBox_cliente.Location = new System.Drawing.Point(126, 63);
            this.comboBox_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_cliente.Name = "comboBox_cliente";
            this.comboBox_cliente.Size = new System.Drawing.Size(385, 29);
            this.comboBox_cliente.TabIndex = 0;
            this.comboBox_cliente.SelectedValueChanged += new System.EventHandler(this.comboBox_cliente_SelectedValueChanged);
            // 
            // comboBox_gerente
            // 
            this.comboBox_gerente.FormattingEnabled = true;
            this.comboBox_gerente.Location = new System.Drawing.Point(126, 107);
            this.comboBox_gerente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_gerente.Name = "comboBox_gerente";
            this.comboBox_gerente.Size = new System.Drawing.Size(385, 29);
            this.comboBox_gerente.TabIndex = 0;
            this.comboBox_gerente.SelectedValueChanged += new System.EventHandler(this.comboBox_gerente_SelectedValueChanged);
            // 
            // comboBox_operador
            // 
            this.comboBox_operador.FormattingEnabled = true;
            this.comboBox_operador.Location = new System.Drawing.Point(126, 150);
            this.comboBox_operador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_operador.Name = "comboBox_operador";
            this.comboBox_operador.Size = new System.Drawing.Size(385, 29);
            this.comboBox_operador.TabIndex = 0;
            this.comboBox_operador.SelectedValueChanged += new System.EventHandler(this.comboBox_operador_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gerente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Operador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(58, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Así se programa pinche Mathus!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_operador);
            this.Controls.Add(this.comboBox_gerente);
            this.Controls.Add(this.comboBox_cliente);
            this.Controls.Add(this.comboBox_estado);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_estado;
        private System.Windows.Forms.ComboBox comboBox_cliente;
        private System.Windows.Forms.ComboBox comboBox_gerente;
        private System.Windows.Forms.ComboBox comboBox_operador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

