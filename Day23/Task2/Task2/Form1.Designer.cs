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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonCalc = new Button();
            textBoxXmax = new TextBox();
            textBoxXmin = new TextBox();
            textBoxStep = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(50, 12);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(659, 731);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(615, 391);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(94, 29);
            buttonCalc.TabIndex = 1;
            buttonCalc.Text = "Рассчитать";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // textBoxXmax
            // 
            textBoxXmax.Location = new Point(64, 393);
            textBoxXmax.Name = "textBoxXmax";
            textBoxXmax.Size = new Size(125, 27);
            textBoxXmax.TabIndex = 2;
            // 
            // textBoxXmin
            // 
            textBoxXmin.Location = new Point(223, 393);
            textBoxXmin.Name = "textBoxXmin";
            textBoxXmin.Size = new Size(125, 27);
            textBoxXmin.TabIndex = 3;
            // 
            // textBoxStep
            // 
            textBoxStep.Location = new Point(375, 393);
            textBoxStep.Name = "textBoxStep";
            textBoxStep.Size = new Size(125, 27);
            textBoxStep.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 370);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Xmax";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 370);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 5;
            label2.Text = "Xmin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 370);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 6;
            label3.Text = "Step";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxStep);
            Controls.Add(textBoxXmin);
            Controls.Add(textBoxXmax);
            Controls.Add(buttonCalc);
            Controls.Add(chart1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonCalc;
        private TextBox textBoxXmax;
        private TextBox textBoxXmin;
        private TextBox textBoxStep;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
