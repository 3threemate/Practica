namespace Task2
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
            txtX = new TextBox();
            txtY = new TextBox();
            btnCalculate = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtResults = new RichTextBox();
            SuspendLayout();
            // 
            // txtX
            // 
            txtX.Location = new Point(256, 75);
            txtX.Name = "txtX";
            txtX.Size = new Size(125, 27);
            txtX.TabIndex = 0;
            // 
            // txtY
            // 
            txtY.Location = new Point(256, 148);
            txtY.Name = "txtY";
            txtY.Size = new Size(125, 27);
            txtY.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(615, 370);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(491, 370);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Очистить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 81);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 5;
            label1.Text = "Введите значение X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 155);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 6;
            label2.Text = "Введите значение Y";
            // 
            // txtResults
            // 
            txtResults.Location = new Point(491, 75);
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(225, 213);
            txtResults.TabIndex = 7;
            txtResults.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResults);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnCalculate);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtX;
        private TextBox txtY;
        private Button btnCalculate;
        private Button button2;
        private Label label1;
        private Label label2;
        private RichTextBox txtResults;
    }
}
