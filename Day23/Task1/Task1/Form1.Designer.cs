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
            listBoxStrings = new ListBox();
            btnCount = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // listBoxStrings
            // 
            listBoxStrings.FormattingEnabled = true;
            listBoxStrings.Items.AddRange(new object[] { "лалалалалала. алвалывлаывл, выфвыфв", "мямуияутя, вывы, выывывф, выфв цф,", "дсцдфсдвфц, вывывфы", "слцвлцфслвсцф" });
            listBoxStrings.Location = new Point(173, 12);
            listBoxStrings.Name = "listBoxStrings";
            listBoxStrings.Size = new Size(467, 144);
            listBoxStrings.TabIndex = 0;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(456, 360);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(94, 29);
            btnCount.TabIndex = 1;
            btnCount.Text = "button1";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(283, 181);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 2;
            lblResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCount);
            Controls.Add(listBoxStrings);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxStrings;
        private Button btnCount;
        private Label lblResult;
    }
}
