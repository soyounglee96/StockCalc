namespace StockCalc.Gui
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnGoldenCross = new System.Windows.Forms.Button();
            this.btnStockHolding = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtEarning = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockHoldingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketCapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockCalcDataSet = new StockCalc.Gui.StockCalcDataSet();
            this.stockCalcDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockCalcDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.priceTableAdapter = new StockCalc.Gui.StockCalcDataSetTableAdapters.PriceTableAdapter();
            this.priceDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCalcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCalcDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCalcDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoldenCross
            // 
            this.btnGoldenCross.Location = new System.Drawing.Point(30, 27);
            this.btnGoldenCross.Name = "btnGoldenCross";
            this.btnGoldenCross.Size = new System.Drawing.Size(109, 23);
            this.btnGoldenCross.TabIndex = 0;
            this.btnGoldenCross.Text = "GoldenCross";
            this.btnGoldenCross.UseVisualStyleBackColor = true;
            this.btnGoldenCross.Click += new System.EventHandler(this.btnGoldenCross_Click);
            // 
            // btnStockHolding
            // 
            this.btnStockHolding.Location = new System.Drawing.Point(154, 27);
            this.btnStockHolding.Name = "btnStockHolding";
            this.btnStockHolding.Size = new System.Drawing.Size(109, 23);
            this.btnStockHolding.TabIndex = 1;
            this.btnStockHolding.Text = "StockHolding";
            this.btnStockHolding.UseVisualStyleBackColor = true;
            this.btnStockHolding.Click += new System.EventHandler(this.btnStockHolding_Click);
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(278, 27);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(109, 23);
            this.btnPer.TabIndex = 2;
            this.btnPer.Text = "PER";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(30, 111);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(530, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.stockIdDataGridViewTextBoxColumn,
            this.closeDataGridViewTextBoxColumn,
            this.pERDataGridViewTextBoxColumn,
            this.stockHoldingDataGridViewTextBoxColumn,
            this.marketCapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.priceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(609, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(293, 287);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(617, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "자본금";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "현재가치";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "수익률";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(687, 27);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(189, 25);
            this.txtBase.TabIndex = 8;
            this.txtBase.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.Location = new System.Drawing.Point(687, 65);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(189, 25);
            this.txtValue.TabIndex = 9;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // txtEarning
            // 
            this.txtEarning.Enabled = false;
            this.txtEarning.Location = new System.Drawing.Point(687, 103);
            this.txtEarning.Name = "txtEarning";
            this.txtEarning.Size = new System.Drawing.Size(189, 25);
            this.txtEarning.TabIndex = 10;
            this.txtEarning.TextChanged += new System.EventHandler(this.txtEarning_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(882, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(882, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(882, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "원";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(30, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 49);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(30, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 30);
            this.panel2.TabIndex = 0;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // stockIdDataGridViewTextBoxColumn
            // 
            this.stockIdDataGridViewTextBoxColumn.DataPropertyName = "StockId";
            this.stockIdDataGridViewTextBoxColumn.HeaderText = "StockId";
            this.stockIdDataGridViewTextBoxColumn.Name = "stockIdDataGridViewTextBoxColumn";
            // 
            // closeDataGridViewTextBoxColumn
            // 
            this.closeDataGridViewTextBoxColumn.DataPropertyName = "Close";
            this.closeDataGridViewTextBoxColumn.HeaderText = "Close";
            this.closeDataGridViewTextBoxColumn.Name = "closeDataGridViewTextBoxColumn";
            // 
            // pERDataGridViewTextBoxColumn
            // 
            this.pERDataGridViewTextBoxColumn.DataPropertyName = "PER";
            this.pERDataGridViewTextBoxColumn.HeaderText = "PER";
            this.pERDataGridViewTextBoxColumn.Name = "pERDataGridViewTextBoxColumn";
            // 
            // stockHoldingDataGridViewTextBoxColumn
            // 
            this.stockHoldingDataGridViewTextBoxColumn.DataPropertyName = "StockHolding";
            this.stockHoldingDataGridViewTextBoxColumn.HeaderText = "StockHolding";
            this.stockHoldingDataGridViewTextBoxColumn.Name = "stockHoldingDataGridViewTextBoxColumn";
            // 
            // marketCapDataGridViewTextBoxColumn
            // 
            this.marketCapDataGridViewTextBoxColumn.DataPropertyName = "MarketCap";
            this.marketCapDataGridViewTextBoxColumn.HeaderText = "MarketCap";
            this.marketCapDataGridViewTextBoxColumn.Name = "marketCapDataGridViewTextBoxColumn";
            // 
            // priceBindingSource
            // 
            this.priceBindingSource.DataMember = "Price";
            this.priceBindingSource.DataSource = this.stockCalcDataSet;
            // 
            // stockCalcDataSet
            // 
            this.stockCalcDataSet.DataSetName = "StockCalcDataSet";
            this.stockCalcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockCalcDataSetBindingSource
            // 
            this.stockCalcDataSetBindingSource.DataSource = this.stockCalcDataSet;
            this.stockCalcDataSetBindingSource.Position = 0;
            // 
            // stockCalcDataSetBindingSource1
            // 
            this.stockCalcDataSetBindingSource1.DataSource = this.stockCalcDataSet;
            this.stockCalcDataSetBindingSource1.Position = 0;
            // 
            // priceTableAdapter
            // 
            this.priceTableAdapter.ClearBeforeFill = true;
            // 
            // priceDataBindingSource
            // 
            this.priceDataBindingSource.DataSource = typeof(StockCalc.Data.Data.PriceData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEarning);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnStockHolding);
            this.Controls.Add(this.btnGoldenCross);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCalcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCalcDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockCalcDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoldenCross;
        private System.Windows.Forms.Button btnStockHolding;
        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtEarning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource priceDataBindingSource;
        private System.Windows.Forms.BindingSource stockCalcDataSetBindingSource;
        private StockCalcDataSet stockCalcDataSet;
        private System.Windows.Forms.BindingSource stockCalcDataSetBindingSource1;
        private System.Windows.Forms.BindingSource priceBindingSource;
        private StockCalcDataSetTableAdapters.PriceTableAdapter priceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockHoldingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketCapDataGridViewTextBoxColumn;
    }
}

