namespace Area_y_perimetro2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OctagonPictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            ladoLabel = new Label();
            octagonSideTextBox = new TextBox();
            baseTextBox = new TextBox();
            baseLabel = new Label();
            heightTextBox = new TextBox();
            alturaLabel = new Label();
            octagonPerimeterButton = new Button();
            octagonAreaButton = new Button();
            resultsLabel = new Label();
            triangleAreaButton = new Button();
            trianglePerimeterButton = new Button();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OctagonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OctagonPictureBox
            // 
            OctagonPictureBox.BackgroundImage = (Image)resources.GetObject("OctagonPictureBox.BackgroundImage");
            OctagonPictureBox.Image = (Image)resources.GetObject("OctagonPictureBox.Image");
            OctagonPictureBox.Location = new Point(71, 83);
            OctagonPictureBox.Name = "OctagonPictureBox";
            OctagonPictureBox.Size = new Size(282, 267);
            OctagonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            OctagonPictureBox.TabIndex = 0;
            OctagonPictureBox.TabStop = false;
            OctagonPictureBox.Click += OctagonPictureBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(569, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ladoLabel
            // 
            ladoLabel.AutoSize = true;
            ladoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ladoLabel.Location = new Point(125, 358);
            ladoLabel.Name = "ladoLabel";
            ladoLabel.Size = new Size(57, 25);
            ladoLabel.TabIndex = 2;
            ladoLabel.Text = "Lado:";
            ladoLabel.Click += label1_Click;
            // 
            // octagonSideTextBox
            // 
            octagonSideTextBox.Location = new Point(188, 360);
            octagonSideTextBox.Name = "octagonSideTextBox";
            octagonSideTextBox.Size = new Size(100, 23);
            octagonSideTextBox.TabIndex = 3;
            // 
            // baseTextBox
            // 
            baseTextBox.Location = new Point(703, 357);
            baseTextBox.Name = "baseTextBox";
            baseTextBox.Size = new Size(100, 23);
            baseTextBox.TabIndex = 5;
            // 
            // baseLabel
            // 
            baseLabel.AutoSize = true;
            baseLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            baseLabel.Location = new Point(640, 355);
            baseLabel.Name = "baseLabel";
            baseLabel.Size = new Size(55, 25);
            baseLabel.TabIndex = 4;
            baseLabel.Text = "Base:";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(463, 184);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(100, 23);
            heightTextBox.TabIndex = 7;
            // 
            // alturaLabel
            // 
            alturaLabel.AutoSize = true;
            alturaLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            alturaLabel.Location = new Point(400, 182);
            alturaLabel.Name = "alturaLabel";
            alturaLabel.Size = new Size(67, 25);
            alturaLabel.TabIndex = 6;
            alturaLabel.Text = "Altura:";
            // 
            // octagonPerimeterButton
            // 
            octagonPerimeterButton.Location = new Point(125, 415);
            octagonPerimeterButton.Name = "octagonPerimeterButton";
            octagonPerimeterButton.Size = new Size(126, 31);
            octagonPerimeterButton.TabIndex = 8;
            octagonPerimeterButton.Text = "Perimetro";
            octagonPerimeterButton.UseVisualStyleBackColor = true;
            octagonPerimeterButton.Click += octagonPerimeterButton_Click;
            // 
            // octagonAreaButton
            // 
            octagonAreaButton.Location = new Point(112, 461);
            octagonAreaButton.Name = "octagonAreaButton";
            octagonAreaButton.Size = new Size(150, 31);
            octagonAreaButton.TabIndex = 9;
            octagonAreaButton.Text = "Área";
            octagonAreaButton.UseVisualStyleBackColor = true;
            octagonAreaButton.Click += octagonAreaButton_Click;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(103, 531);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(25, 15);
            resultsLabel.TabIndex = 10;
            resultsLabel.Text = "-->";
            resultsLabel.Click += label1_Click_1;
            // 
            // triangleAreaButton
            // 
            triangleAreaButton.Location = new Point(653, 461);
            triangleAreaButton.Name = "triangleAreaButton";
            triangleAreaButton.Size = new Size(150, 31);
            triangleAreaButton.TabIndex = 14;
            triangleAreaButton.Text = "Área";
            triangleAreaButton.UseVisualStyleBackColor = true;
            triangleAreaButton.Click += triangleAreaButton_Click;
            // 
            // trianglePerimeterButton
            // 
            trianglePerimeterButton.Location = new Point(666, 415);
            trianglePerimeterButton.Name = "trianglePerimeterButton";
            trianglePerimeterButton.Size = new Size(126, 31);
            trianglePerimeterButton.TabIndex = 13;
            trianglePerimeterButton.Text = "Perimetro";
            trianglePerimeterButton.UseVisualStyleBackColor = true;
            trianglePerimeterButton.Click += trianglePerimeterButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Century Schoolbook", 24F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(243, 19);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(452, 38);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Perimetros y áreas de figuras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 557);
            Controls.Add(titleLabel);
            Controls.Add(triangleAreaButton);
            Controls.Add(trianglePerimeterButton);
            Controls.Add(resultsLabel);
            Controls.Add(octagonAreaButton);
            Controls.Add(octagonPerimeterButton);
            Controls.Add(heightTextBox);
            Controls.Add(alturaLabel);
            Controls.Add(baseTextBox);
            Controls.Add(baseLabel);
            Controls.Add(octagonSideTextBox);
            Controls.Add(ladoLabel);
            Controls.Add(pictureBox1);
            Controls.Add(OctagonPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)OctagonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox OctagonPictureBox;
        private PictureBox pictureBox1;
        private Label ladoLabel;
        private TextBox octagonSideTextBox;
        private TextBox baseTextBox;
        private Label baseLabel;
        private TextBox heightTextBox;
        private Label alturaLabel;
        private Button octagonPerimeterButton;
        private Button octagonAreaButton;
        private Label resultsLabel;
        private Button triangleAreaButton;
        private Button trianglePerimeterButton;
        private Label titleLabel;
    }
}