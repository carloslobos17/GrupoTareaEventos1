namespace mauseforms.forms
{
    partial class mauseForm1
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
            calcularRaizlabel1 = new Label();
            incresarnumberlabel1 = new Label();
            ingresarnumbertextBox1 = new TextBox();
            calcularbutton1 = new Button();
            resultadoLabel1 = new Label();
            SuspendLayout();
            // 
            // calcularRaizlabel1
            // 
            calcularRaizlabel1.AutoSize = true;
            calcularRaizlabel1.Location = new Point(257, 19);
            calcularRaizlabel1.Name = "calcularRaizlabel1";
            calcularRaizlabel1.Size = new Size(357, 25);
            calcularRaizlabel1.TabIndex = 0;
            calcularRaizlabel1.Text = "calcular la raíz cuadrada de un número";
            // 
            // incresarnumberlabel1
            // 
            incresarnumberlabel1.AutoSize = true;
            incresarnumberlabel1.Location = new Point(162, 82);
            incresarnumberlabel1.Name = "incresarnumberlabel1";
            incresarnumberlabel1.Size = new Size(177, 25);
            incresarnumberlabel1.TabIndex = 1;
            incresarnumberlabel1.Text = "ingrese un nunero";
            // 
            // ingresarnumbertextBox1
            // 
            ingresarnumbertextBox1.Location = new Point(384, 82);
            ingresarnumbertextBox1.Name = "ingresarnumbertextBox1";
            ingresarnumbertextBox1.Size = new Size(163, 33);
            ingresarnumbertextBox1.TabIndex = 2;
            // 
            // calcularbutton1
            // 
            calcularbutton1.Location = new Point(306, 146);
            calcularbutton1.Name = "calcularbutton1";
            calcularbutton1.Size = new Size(94, 43);
            calcularbutton1.TabIndex = 3;
            calcularbutton1.Text = "calcular";
            calcularbutton1.UseVisualStyleBackColor = true;
            calcularbutton1.MouseClick += calcularbutton1_MouseClick;
            // 
            // resultadoLabel1
            // 
            resultadoLabel1.AutoSize = true;
            resultadoLabel1.Location = new Point(162, 220);
            resultadoLabel1.Name = "resultadoLabel1";
            resultadoLabel1.Size = new Size(0, 25);
            resultadoLabel1.TabIndex = 4;
            // 
            // mauseForm1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 749);
            Controls.Add(resultadoLabel1);
            Controls.Add(calcularbutton1);
            Controls.Add(ingresarnumbertextBox1);
            Controls.Add(incresarnumberlabel1);
            Controls.Add(calcularRaizlabel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "mauseForm1";
            Text = "mauseForm1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label calcularRaizlabel1;
        private Label incresarnumberlabel1;
        private TextBox ingresarnumbertextBox1;
        private Button calcularbutton1;
        private Label resultadoLabel1;
    }
}