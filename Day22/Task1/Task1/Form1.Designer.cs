namespace Task1
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
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            textBoxZ = new TextBox();
            X = new Label();
            Y = new Label();
            Z = new Label();
            buttonCalculate = new Button();
            textBoxResult = new RichTextBox();
            SuspendLayout();
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(503, 93);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 0;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // textBoxY
            // 
            textBoxY.AllowDrop = true;
            textBoxY.Location = new Point(503, 144);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(125, 27);
            textBoxY.TabIndex = 1;
            // 
            // textBoxZ
            // 
            textBoxZ.Location = new Point(503, 195);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(125, 27);
            textBoxZ.TabIndex = 2;
            // 
            // X
            // 
            X.AutoSize = true;
            X.Location = new Point(172, 93);
            X.Name = "X";
            X.Size = new Size(148, 20);
            X.TabIndex = 3;
            X.Text = "Введите значение Х";
            X.Click += X_Click;
            // 
            // Y
            // 
            Y.AutoSize = true;
            Y.Location = new Point(172, 144);
            Y.Name = "Y";
            Y.Size = new Size(148, 20);
            Y.TabIndex = 4;
            Y.Text = "Введите значение У";
            // 
            // Z
            // 
            Z.AutoSize = true;
            Z.Location = new Point(172, 195);
            Z.Name = "Z";
            Z.Size = new Size(148, 20);
            Z.TabIndex = 5;
            Z.Text = "Введите значение Z";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(633, 375);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(113, 29);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Выполнить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(207, 262);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(342, 162);
            textBoxResult.TabIndex = 7;
            textBoxResult.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(buttonCalculate);
            Controls.Add(Z);
            Controls.Add(Y);
            Controls.Add(X);
            Controls.Add(textBoxZ);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX;
        private TextBox textBoxY;
        private TextBox textBoxZ;
        private Label X;
        private Label Y;
        private Label Z;
        private Button buttonCalculate;
        private RichTextBox textBoxResult;
    }
}
