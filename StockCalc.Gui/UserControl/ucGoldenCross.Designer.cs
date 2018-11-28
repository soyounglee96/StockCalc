namespace StockCalc.Gui.UserControl
{
    partial class ucGoldenCross
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cbShortMVA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLongMAV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(465, 5);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(88, 25);
            this.numericUpDown.TabIndex = 7;
            this.numericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbShortMVA
            // 
            this.cbShortMVA.FormattingEnabled = true;
            this.cbShortMVA.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "60"});
            this.cbShortMVA.Location = new System.Drawing.Point(4, 7);
            this.cbShortMVA.Name = "cbShortMVA";
            this.cbShortMVA.Size = new System.Drawing.Size(46, 23);
            this.cbShortMVA.TabIndex = 6;
            this.cbShortMVA.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "종목개수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "일 이평선이 ";
            // 
            // cbLongMAV
            // 
            this.cbLongMAV.FormattingEnabled = true;
            this.cbLongMAV.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "60"});
            this.cbLongMAV.Location = new System.Drawing.Point(142, 7);
            this.cbLongMAV.Name = "cbLongMAV";
            this.cbLongMAV.Size = new System.Drawing.Size(46, 23);
            this.cbLongMAV.TabIndex = 9;
            this.cbLongMAV.Text = "60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "일 이평선으로 GoldenCross";
            // 
            // ucGoldenCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbLongMAV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.cbShortMVA);
            this.Controls.Add(this.label2);
            this.Name = "ucGoldenCross";
            this.Size = new System.Drawing.Size(600, 40);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ComboBox cbShortMVA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLongMAV;
        private System.Windows.Forms.Label label4;
    }
}
