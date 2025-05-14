namespace Task3
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
            textBoxX0 = new TextBox();
            textBoxXk = new TextBox();
            textBoxDx = new TextBox();
            textBoxB = new TextBox();
            textBoxA = new TextBox();
            textBoxResults = new RichTextBox();
            btnCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxX0
            // 
            textBoxX0.Location = new Point(243, 24);
            textBoxX0.Name = "textBoxX0";
            textBoxX0.Size = new Size(125, 27);
            textBoxX0.TabIndex = 0;
            // 
            // textBoxXk
            // 
            textBoxXk.Location = new Point(243, 72);
            textBoxXk.Name = "textBoxXk";
            textBoxXk.Size = new Size(125, 27);
            textBoxXk.TabIndex = 1;
            // 
            // textBoxDx
            // 
            textBoxDx.Location = new Point(243, 121);
            textBoxDx.Name = "textBoxDx";
            textBoxDx.Size = new Size(125, 27);
            textBoxDx.TabIndex = 2;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(243, 216);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 3;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(243, 170);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 4;
            // 
            // textBoxResults
            // 
            textBoxResults.Location = new Point(394, 24);
            textBoxResults.Name = "textBoxResults";
            textBoxResults.Size = new Size(260, 306);
            textBoxResults.TabIndex = 5;
            textBoxResults.Text = "";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(27, 269);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(125, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 31);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 7;
            label1.Text = "Введите значение X0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(155, 20);
            label2.TabIndex = 8;
            label2.Text = "Введите значение Xk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 124);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 9;
            label3.Text = "Введите значение Dx";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 173);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 10;
            label4.Text = "Введите значение A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 219);
            label5.Name = "label5";
            label5.Size = new Size(148, 20);
            label5.TabIndex = 11;
            label5.Text = "Введите значение B";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 350);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Controls.Add(textBoxResults);
            Controls.Add(textBoxA);
            Controls.Add(textBoxB);
            Controls.Add(textBoxDx);
            Controls.Add(textBoxXk);
            Controls.Add(textBoxX0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxX0;
        private TextBox textBoxXk;
        private TextBox textBoxDx;
        private TextBox textBoxB;
        private TextBox textBoxA;
        private RichTextBox textBoxResults;
        private Button btnCalculate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
