﻿namespace VRPTW
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chooseFile_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.population_tb = new System.Windows.Forms.TextBox();
            this.generations_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFile_btn
            // 
            this.chooseFile_btn.Location = new System.Drawing.Point(12, 12);
            this.chooseFile_btn.Name = "chooseFile_btn";
            this.chooseFile_btn.Size = new System.Drawing.Size(106, 23);
            this.chooseFile_btn.TabIndex = 1;
            this.chooseFile_btn.Text = "Load file...";
            this.chooseFile_btn.UseVisualStyleBackColor = true;
            this.chooseFile_btn.Click += new System.EventHandler(this.openFileDialog_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // output_textbox
            // 
            this.output_textbox.AcceptsReturn = true;
            this.output_textbox.AcceptsTab = true;
            this.output_textbox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output_textbox.Location = new System.Drawing.Point(133, 12);
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_textbox.Size = new System.Drawing.Size(499, 372);
            this.output_textbox.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 10D;
            chartArea2.AxisX.Maximum = 100D;
            chartArea2.AxisX.MaximumAutoSize = 100F;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Interval = 10D;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.MaximumAutoSize = 100F;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(638, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Name = "Points";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(627, 589);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(12, 42);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(106, 23);
            this.start_btn.TabIndex = 4;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Population";
            // 
            // population_tb
            // 
            this.population_tb.Location = new System.Drawing.Point(12, 89);
            this.population_tb.Name = "population_tb";
            this.population_tb.Size = new System.Drawing.Size(100, 20);
            this.population_tb.TabIndex = 6;
            this.population_tb.Text = "20";
            // 
            // generations_tb
            // 
            this.generations_tb.Location = new System.Drawing.Point(12, 129);
            this.generations_tb.Name = "generations_tb";
            this.generations_tb.Size = new System.Drawing.Size(100, 20);
            this.generations_tb.TabIndex = 8;
            this.generations_tb.Text = "100";
            this.generations_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Generations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 613);
            this.Controls.Add(this.generations_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.population_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.chooseFile_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFile_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox population_tb;
        private System.Windows.Forms.TextBox generations_tb;
        private System.Windows.Forms.Label label2;
    }
}

