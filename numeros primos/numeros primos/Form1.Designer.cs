namespace numeros_primos
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            insertLabel = new Label();
            resultsLabel = new Label();
            numberTextBox = new TextBox();
            resultsButton = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 20);
            label1.Name = "label1";
            label1.Size = new Size(365, 46);
            label1.TabIndex = 0;
            label1.Text = "Es numero primo?";
            // 
            // insertLabel
            // 
            insertLabel.AutoSize = true;
            insertLabel.Font = new Font("Segoe UI", 14F);
            insertLabel.Location = new Point(329, 177);
            insertLabel.Name = "insertLabel";
            insertLabel.Size = new Size(164, 25);
            insertLabel.TabIndex = 1;
            insertLabel.Text = "Inserte su numero";
            insertLabel.Click += insertLabel_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(58, 404);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(25, 15);
            resultsLabel.TabIndex = 2;
            resultsLabel.Text = "-->";
            resultsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(361, 231);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(100, 23);
            numberTextBox.TabIndex = 3;
            // 
            // resultsButton
            // 
            resultsButton.Location = new Point(374, 274);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(75, 23);
            resultsButton.TabIndex = 4;
            resultsButton.Text = "Click";
            resultsButton.UseVisualStyleBackColor = true;
            resultsButton.Click += resultsButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsButton);
            Controls.Add(numberTextBox);
            Controls.Add(resultsLabel);
            Controls.Add(insertLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button resultsButton;
        private TextBox numberTextBox;
        private Label resultsLabel;
        private Label insertLabel;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}
