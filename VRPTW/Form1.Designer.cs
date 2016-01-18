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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chooseFile_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.output_textbox.ReadOnly = true;
            this.output_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_textbox.Size = new System.Drawing.Size(427, 372);
            this.output_textbox.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 10D;
            chartArea1.AxisX.Maximum = 100D;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.MaximumAutoSize = 100F;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(566, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(404, 372);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 400);
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
    }
}

