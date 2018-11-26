namespace StockCalc.Gui
{
    partial class StockCalculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncollection = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentER = new System.Windows.Forms.TextBox();
            this.txtCurrentValue = new System.Windows.Forms.TextBox();
            this.txtBaseMoney = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnStockHolding = new System.Windows.Forms.Button();
            this.btnGoldenCross = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbDis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(660, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(284, 288);
            this.dataGridView1.TabIndex = 32;
            // 
            // btncollection
            // 
            this.btncollection.Location = new System.Drawing.Point(869, 454);
            this.btncollection.Name = "btncollection";
            this.btncollection.Size = new System.Drawing.Size(75, 31);
            this.btncollection.TabIndex = 31;
            this.btncollection.Text = "수집";
            this.btncollection.UseVisualStyleBackColor = true;
            this.btncollection.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 40);
            this.panel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(922, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(922, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(922, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "원";
            // 
            // txtCurrentER
            // 
            this.txtCurrentER.Enabled = false;
            this.txtCurrentER.Location = new System.Drawing.Point(727, 95);
            this.txtCurrentER.Name = "txtCurrentER";
            this.txtCurrentER.ReadOnly = true;
            this.txtCurrentER.Size = new System.Drawing.Size(189, 25);
            this.txtCurrentER.TabIndex = 26;
            // 
            // txtCurrentValue
            // 
            this.txtCurrentValue.Enabled = false;
            this.txtCurrentValue.Location = new System.Drawing.Point(727, 57);
            this.txtCurrentValue.Name = "txtCurrentValue";
            this.txtCurrentValue.ReadOnly = true;
            this.txtCurrentValue.Size = new System.Drawing.Size(189, 25);
            this.txtCurrentValue.TabIndex = 25;
            // 
            // txtBaseMoney
            // 
            this.txtBaseMoney.Location = new System.Drawing.Point(727, 19);
            this.txtBaseMoney.Name = "txtBaseMoney";
            this.txtBaseMoney.Size = new System.Drawing.Size(189, 25);
            this.txtBaseMoney.TabIndex = 24;
            this.txtBaseMoney.Text = "1000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "수익률";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "현재가치";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "자본금";
            // 
            // btnPer
            // 
            this.btnPer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPer.Location = new System.Drawing.Point(306, 9);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(130, 30);
            this.btnPer.TabIndex = 20;
            this.btnPer.Text = "PER";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnStockHolding
            // 
            this.btnStockHolding.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockHolding.Location = new System.Drawing.Point(158, 9);
            this.btnStockHolding.Name = "btnStockHolding";
            this.btnStockHolding.Size = new System.Drawing.Size(130, 30);
            this.btnStockHolding.TabIndex = 19;
            this.btnStockHolding.Text = "StockHolding";
            this.btnStockHolding.UseVisualStyleBackColor = true;
            this.btnStockHolding.Click += new System.EventHandler(this.btnStockHolding_Click);
            // 
            // btnGoldenCross
            // 
            this.btnGoldenCross.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoldenCross.Location = new System.Drawing.Point(12, 10);
            this.btnGoldenCross.Name = "btnGoldenCross";
            this.btnGoldenCross.Size = new System.Drawing.Size(130, 30);
            this.btnGoldenCross.TabIndex = 18;
            this.btnGoldenCross.Text = "GoldenCross";
            this.btnGoldenCross.UseVisualStyleBackColor = true;
            this.btnGoldenCross.Click += new System.EventHandler(this.btnGoldenCross_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 118);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(600, 368);
            this.chart1.TabIndex = 33;
            this.chart1.Text = "chart1";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(507, 9);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(105, 32);
            this.btnCalc.TabIndex = 34;
            this.btnCalc.Text = "계산(&C)";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbDis
            // 
            this.lbDis.AutoSize = true;
            this.lbDis.Location = new System.Drawing.Point(12, 43);
            this.lbDis.Name = "lbDis";
            this.lbDis.Size = new System.Drawing.Size(0, 15);
            this.lbDis.TabIndex = 35;
            // 
            // StockCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 507);
            this.Controls.Add(this.lbDis);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncollection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCurrentER);
            this.Controls.Add(this.txtCurrentValue);
            this.Controls.Add(this.txtBaseMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnStockHolding);
            this.Controls.Add(this.btnGoldenCross);
            this.Name = "StockCalculator";
            this.Text = "Stock Calculator";
            this.Load += new System.EventHandler(this.StockCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncollection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentER;
        private System.Windows.Forms.TextBox txtCurrentValue;
        private System.Windows.Forms.TextBox txtBaseMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnStockHolding;
        private System.Windows.Forms.Button btnGoldenCross;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbDis;
    }
}

