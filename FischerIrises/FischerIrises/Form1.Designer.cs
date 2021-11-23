namespace FischerIrises
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title17 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title18 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title19 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title20 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browse_but = new System.Windows.Forms.Button();
            this.file_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_execute = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_sepal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pie_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_petal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_sepal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_petal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_width)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.34801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.59204F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.34801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.71195F));
            this.tableLayoutPanel1.Controls.Add(this.browse_but, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.file_path, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.but_execute, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // browse_but
            // 
            this.browse_but.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browse_but.Location = new System.Drawing.Point(748, 3);
            this.browse_but.Name = "browse_but";
            this.browse_but.Size = new System.Drawing.Size(140, 29);
            this.browse_but.TabIndex = 1;
            this.browse_but.Text = "Browse";
            this.browse_but.UseVisualStyleBackColor = true;
            this.browse_but.Click += new System.EventHandler(this.browse_but_Click);
            // 
            // file_path
            // 
            this.file_path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.file_path.Location = new System.Drawing.Point(149, 3);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(593, 30);
            this.file_path.TabIndex = 1;
            this.file_path.Text = "C:\\Users\\egor1\\OneDrive\\Рабочий стол\\iris.csv";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path";
            // 
            // but_execute
            // 
            this.but_execute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.but_execute.Location = new System.Drawing.Point(894, 3);
            this.but_execute.Name = "but_execute";
            this.but_execute.Size = new System.Drawing.Size(127, 29);
            this.but_execute.TabIndex = 0;
            this.but_execute.Text = "Execute";
            this.but_execute.UseVisualStyleBackColor = true;
            this.but_execute.Click += new System.EventHandler(this.but_execute_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.06196F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.93804F));
            this.tableLayoutPanel2.Controls.Add(this.chart_sepal_width, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pie_chart, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chart_petal_length, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chart_sepal_length, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chart_petal_width, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1024, 442);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // chart_sepal_width
            // 
            this.chart_sepal_width.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea16.Name = "ChartArea1";
            this.chart_sepal_width.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chart_sepal_width.Legends.Add(legend16);
            this.chart_sepal_width.Location = new System.Drawing.Point(515, 3);
            this.chart_sepal_width.Name = "chart_sepal_width";
            this.chart_sepal_width.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chart_sepal_width.Size = new System.Drawing.Size(506, 104);
            this.chart_sepal_width.TabIndex = 10;
            this.chart_sepal_width.Text = "chart4";
            title16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title16.Name = "Title1";
            this.chart_sepal_width.Titles.Add(title16);
            // 
            // pie_chart
            // 
            this.pie_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea17.Name = "ChartArea1";
            this.pie_chart.ChartAreas.Add(chartArea17);
            this.tableLayoutPanel2.SetColumnSpan(this.pie_chart, 2);
            legend17.BackColor = System.Drawing.Color.White;
            legend17.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend17.IsTextAutoFit = false;
            legend17.Name = "Legend1";
            this.pie_chart.Legends.Add(legend17);
            this.pie_chart.Location = new System.Drawing.Point(3, 223);
            this.pie_chart.Name = "pie_chart";
            this.pie_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.LabelAngle = 20;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.pie_chart.Series.Add(series4);
            this.pie_chart.Size = new System.Drawing.Size(1018, 216);
            this.pie_chart.TabIndex = 8;
            this.pie_chart.Text = "chart5";
            this.pie_chart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title17.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title17.ForeColor = System.Drawing.Color.Maroon;
            title17.Name = "Title1";
            title17.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.pie_chart.Titles.Add(title17);
            // 
            // chart_petal_length
            // 
            this.chart_petal_length.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea18.Name = "ChartArea1";
            this.chart_petal_length.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart_petal_length.Legends.Add(legend18);
            this.chart_petal_length.Location = new System.Drawing.Point(3, 113);
            this.chart_petal_length.Name = "chart_petal_length";
            this.chart_petal_length.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chart_petal_length.Size = new System.Drawing.Size(506, 104);
            this.chart_petal_length.TabIndex = 7;
            this.chart_petal_length.Text = "chart3";
            title18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title18.Name = "Title1";
            this.chart_petal_length.Titles.Add(title18);
            // 
            // chart_sepal_length
            // 
            this.chart_sepal_length.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea19.Name = "ChartArea1";
            this.chart_sepal_length.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chart_sepal_length.Legends.Add(legend19);
            this.chart_sepal_length.Location = new System.Drawing.Point(3, 3);
            this.chart_sepal_length.Name = "chart_sepal_length";
            this.chart_sepal_length.Size = new System.Drawing.Size(506, 104);
            this.chart_sepal_length.TabIndex = 9;
            this.chart_sepal_length.Text = "chart1";
            title19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title19.Name = "Title1";
            this.chart_sepal_length.Titles.Add(title19);
            // 
            // chart_petal_width
            // 
            this.chart_petal_width.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea20.Name = "ChartArea1";
            this.chart_petal_width.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chart_petal_width.Legends.Add(legend20);
            this.chart_petal_width.Location = new System.Drawing.Point(515, 113);
            this.chart_petal_width.Name = "chart_petal_width";
            this.chart_petal_width.Size = new System.Drawing.Size(506, 104);
            this.chart_petal_width.TabIndex = 6;
            this.chart_petal_width.Text = "chart2";
            title20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title20.Name = "Title1";
            this.chart_petal_width.Titles.Add(title20);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 477);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_sepal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_petal_width)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox file_path;
        private System.Windows.Forms.Button but_execute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browse_but;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_petal_length;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_petal_width;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sepal_width;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_sepal_length;
    }
}

