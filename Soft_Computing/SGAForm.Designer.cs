namespace Soft_Computing
{
    partial class SGAForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.findSolutionBtn = new System.Windows.Forms.Button();
            this.solutionsLV = new System.Windows.Forms.ListView();
            this.Generation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.murationProbNUD = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.crossingProbNUD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numberOfAttemptsNUD = new System.Windows.Forms.NumericUpDown();
            this.populationSizeNUD = new System.Windows.Forms.NumericUpDown();
            this.precisionNUD = new System.Windows.Forms.NumericUpDown();
            this.minRangeNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.maxRangeNUD = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.stopValueNUD = new System.Windows.Forms.NumericUpDown();
            this.Fitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bestFitLV = new System.Windows.Forms.ListView();
            this.bfGeneration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bfValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.bfFitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.stopGenerationsNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.murationProbNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossingProbNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAttemptsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precisionNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRangeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRangeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopValueNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopGenerationsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Function: f(x) = (e^x * sin(10 * PI * x) + 1) / (x + 5)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Range: [";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Population size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of attempts:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mutation probability:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Crossing probability:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Precision:";
            // 
            // findSolutionBtn
            // 
            this.findSolutionBtn.Location = new System.Drawing.Point(12, 417);
            this.findSolutionBtn.Name = "findSolutionBtn";
            this.findSolutionBtn.Size = new System.Drawing.Size(324, 23);
            this.findSolutionBtn.TabIndex = 1;
            this.findSolutionBtn.Text = "Find Solution";
            this.findSolutionBtn.UseVisualStyleBackColor = true;
            this.findSolutionBtn.Click += new System.EventHandler(this.findSolutionBtn_Click);
            // 
            // solutionsLV
            // 
            this.solutionsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Generation,
            this.Value,
            this.Fitness});
            this.solutionsLV.FullRowSelect = true;
            this.solutionsLV.GridLines = true;
            this.solutionsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.solutionsLV.Location = new System.Drawing.Point(342, 26);
            this.solutionsLV.Name = "solutionsLV";
            this.solutionsLV.Size = new System.Drawing.Size(368, 229);
            this.solutionsLV.TabIndex = 8;
            this.solutionsLV.UseCompatibleStateImageBehavior = false;
            this.solutionsLV.View = System.Windows.Forms.View.Details;
            // 
            // Generation
            // 
            this.Generation.Text = "Generation";
            this.Generation.Width = 79;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Solutions found:";
            // 
            // murationProbNUD
            // 
            this.murationProbNUD.Location = new System.Drawing.Point(180, 121);
            this.murationProbNUD.Name = "murationProbNUD";
            this.murationProbNUD.Size = new System.Drawing.Size(100, 22);
            this.murationProbNUD.TabIndex = 20;
            this.murationProbNUD.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.murationProbNUD.ValueChanged += new System.EventHandler(this.mutationProbNUD_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(286, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "%";
            // 
            // crossingProbNUD
            // 
            this.crossingProbNUD.Location = new System.Drawing.Point(180, 149);
            this.crossingProbNUD.Name = "crossingProbNUD";
            this.crossingProbNUD.Size = new System.Drawing.Size(100, 22);
            this.crossingProbNUD.TabIndex = 20;
            this.crossingProbNUD.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            this.crossingProbNUD.ValueChanged += new System.EventHandler(this.crossingProbNUD_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "%";
            // 
            // numberOfAttemptsNUD
            // 
            this.numberOfAttemptsNUD.Location = new System.Drawing.Point(180, 93);
            this.numberOfAttemptsNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberOfAttemptsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfAttemptsNUD.Name = "numberOfAttemptsNUD";
            this.numberOfAttemptsNUD.Size = new System.Drawing.Size(100, 22);
            this.numberOfAttemptsNUD.TabIndex = 20;
            this.numberOfAttemptsNUD.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // populationSizeNUD
            // 
            this.populationSizeNUD.Location = new System.Drawing.Point(180, 65);
            this.populationSizeNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.populationSizeNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.populationSizeNUD.Name = "populationSizeNUD";
            this.populationSizeNUD.Size = new System.Drawing.Size(100, 22);
            this.populationSizeNUD.TabIndex = 20;
            this.populationSizeNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // precisionNUD
            // 
            this.precisionNUD.Location = new System.Drawing.Point(180, 177);
            this.precisionNUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.precisionNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precisionNUD.Name = "precisionNUD";
            this.precisionNUD.Size = new System.Drawing.Size(100, 22);
            this.precisionNUD.TabIndex = 20;
            this.precisionNUD.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // minRangeNUD
            // 
            this.minRangeNUD.DecimalPlaces = 2;
            this.minRangeNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.minRangeNUD.Location = new System.Drawing.Point(80, 35);
            this.minRangeNUD.Name = "minRangeNUD";
            this.minRangeNUD.Size = new System.Drawing.Size(67, 22);
            this.minRangeNUD.TabIndex = 22;
            this.minRangeNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.minRangeNUD.ValueChanged += new System.EventHandler(this.minRangeNUD_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = ";";
            // 
            // maxRangeNUD
            // 
            this.maxRangeNUD.DecimalPlaces = 2;
            this.maxRangeNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.maxRangeNUD.Location = new System.Drawing.Point(171, 35);
            this.maxRangeNUD.Name = "maxRangeNUD";
            this.maxRangeNUD.Size = new System.Drawing.Size(66, 22);
            this.maxRangeNUD.TabIndex = 22;
            this.maxRangeNUD.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.maxRangeNUD.ValueChanged += new System.EventHandler(this.maxRangeNUD_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Stop value:";
            // 
            // stopValueNUD
            // 
            this.stopValueNUD.DecimalPlaces = 4;
            this.stopValueNUD.Location = new System.Drawing.Point(180, 205);
            this.stopValueNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.stopValueNUD.Name = "stopValueNUD";
            this.stopValueNUD.Size = new System.Drawing.Size(100, 22);
            this.stopValueNUD.TabIndex = 20;
            this.stopValueNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // Fitness
            // 
            this.Fitness.Text = "Fitness";
            // 
            // bestFitLV
            // 
            this.bestFitLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bfGeneration,
            this.bfValue,
            this.bfFitness});
            this.bestFitLV.FullRowSelect = true;
            this.bestFitLV.GridLines = true;
            this.bestFitLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bestFitLV.Location = new System.Drawing.Point(342, 287);
            this.bestFitLV.Name = "bestFitLV";
            this.bestFitLV.Size = new System.Drawing.Size(368, 153);
            this.bestFitLV.TabIndex = 8;
            this.bestFitLV.UseCompatibleStateImageBehavior = false;
            this.bestFitLV.View = System.Windows.Forms.View.Details;
            // 
            // bfGeneration
            // 
            this.bfGeneration.Text = "Generation";
            this.bfGeneration.Width = 79;
            // 
            // bfValue
            // 
            this.bfValue.Text = "Value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "Best fits:";
            // 
            // bfFitness
            // 
            this.bfFitness.Text = "Fitness";
            this.bfFitness.Width = 87;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Stop generations:";
            // 
            // stopGenerationsNUD
            // 
            this.stopGenerationsNUD.Location = new System.Drawing.Point(180, 236);
            this.stopGenerationsNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stopGenerationsNUD.Name = "stopGenerationsNUD";
            this.stopGenerationsNUD.Size = new System.Drawing.Size(100, 22);
            this.stopGenerationsNUD.TabIndex = 20;
            this.stopGenerationsNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SGAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxRangeNUD);
            this.Controls.Add(this.minRangeNUD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stopGenerationsNUD);
            this.Controls.Add(this.stopValueNUD);
            this.Controls.Add(this.precisionNUD);
            this.Controls.Add(this.crossingProbNUD);
            this.Controls.Add(this.populationSizeNUD);
            this.Controls.Add(this.numberOfAttemptsNUD);
            this.Controls.Add(this.murationProbNUD);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bestFitLV);
            this.Controls.Add(this.solutionsLV);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.findSolutionBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SGAForm";
            this.Text = "Simple Genetic Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.murationProbNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossingProbNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfAttemptsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precisionNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRangeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxRangeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopValueNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopGenerationsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button findSolutionBtn;
        private System.Windows.Forms.ListView solutionsLV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown murationProbNUD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown crossingProbNUD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numberOfAttemptsNUD;
        private System.Windows.Forms.NumericUpDown populationSizeNUD;
        private System.Windows.Forms.NumericUpDown precisionNUD;
        private System.Windows.Forms.ColumnHeader Generation;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.NumericUpDown minRangeNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown maxRangeNUD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown stopValueNUD;
        private System.Windows.Forms.ColumnHeader Fitness;
        private System.Windows.Forms.ListView bestFitLV;
        private System.Windows.Forms.ColumnHeader bfGeneration;
        private System.Windows.Forms.ColumnHeader bfValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader bfFitness;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown stopGenerationsNUD;
    }
}