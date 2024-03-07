namespace imcApp5
{
    partial class ImcApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblCalculo = new Label();
            lblClass = new Label();
            numPeso = new NumericUpDown();
            numAltura = new NumericUpDown();
            btCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(197, 41);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 0;
            label1.Text = "Peso (Kg):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(197, 93);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Altura (m):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 208);
            label3.Name = "label3";
            label3.Size = new Size(526, 32);
            label3.TabIndex = 2;
            label3.Text = "============ Resultados ============";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 284);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 3;
            label4.Text = "Cálculo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 337);
            label5.Name = "label5";
            label5.Size = new Size(152, 32);
            label5.TabIndex = 4;
            label5.Text = "Classificação:";
            // 
            // lblCalculo
            // 
            lblCalculo.AutoSize = true;
            lblCalculo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalculo.Location = new Point(174, 284);
            lblCalculo.Name = "lblCalculo";
            lblCalculo.Size = new Size(0, 32);
            lblCalculo.TabIndex = 5;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblClass.Location = new Point(174, 337);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(0, 32);
            lblClass.TabIndex = 6;
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 1;
            numPeso.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numPeso.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numPeso.Location = new Point(323, 39);
            numPeso.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(144, 39);
            numPeso.TabIndex = 7;
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            numAltura.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            numAltura.Location = new Point(323, 91);
            numAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(144, 39);
            numAltura.TabIndex = 8;
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btCalcular.Location = new Point(278, 145);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(117, 47);
            btCalcular.TabIndex = 9;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // ImcApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 385);
            Controls.Add(btCalcular);
            Controls.Add(numAltura);
            Controls.Add(numPeso);
            Controls.Add(lblClass);
            Controls.Add(lblCalculo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ImcApp";
            Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblCalculo;
        private Label lblClass;
        private NumericUpDown numPeso;
        private NumericUpDown numAltura;
        private Button btCalcular;
    }
}
