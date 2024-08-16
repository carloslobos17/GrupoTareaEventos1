namespace teclaforms.forms
{
    partial class teclaForm1
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
            label1 = new Label();
            consonanteTextBox1 = new TextBox();
            resultadoLabel2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 24);
            label1.Name = "label1";
            label1.Size = new Size(328, 25);
            label1.TabIndex = 0;
            label1.Text = "comprobar si la tecla es consonante";
            // 
            // consonanteTextBox1
            // 
            consonanteTextBox1.Location = new Point(194, 95);
            consonanteTextBox1.Multiline = true;
            consonanteTextBox1.Name = "consonanteTextBox1";
            consonanteTextBox1.Size = new Size(513, 49);
            consonanteTextBox1.TabIndex = 1;
            consonanteTextBox1.KeyDown += consonanteTextBox1_KeyDown;
            // 
            // resultadoLabel2
            // 
            resultadoLabel2.AutoSize = true;
            resultadoLabel2.Location = new Point(188, 295);
            resultadoLabel2.Name = "resultadoLabel2";
            resultadoLabel2.Size = new Size(0, 25);
            resultadoLabel2.TabIndex = 2;
            // 
            // teclaForm1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 749);
            Controls.Add(resultadoLabel2);
            Controls.Add(consonanteTextBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "teclaForm1";
            Text = "teclaForm1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox consonanteTextBox1;
        private Label resultadoLabel2;
    }
}