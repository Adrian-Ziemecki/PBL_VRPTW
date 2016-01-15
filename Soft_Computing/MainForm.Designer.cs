namespace Soft_Computing
{
    partial class MainForm
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
            this.neuronBtn = new System.Windows.Forms.Button();
            this.perceptronBtn = new System.Windows.Forms.Button();
            this.geneticBtn = new System.Windows.Forms.Button();
            this.kohonenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // neuronBtn
            // 
            this.neuronBtn.Location = new System.Drawing.Point(12, 12);
            this.neuronBtn.Name = "neuronBtn";
            this.neuronBtn.Size = new System.Drawing.Size(75, 35);
            this.neuronBtn.TabIndex = 0;
            this.neuronBtn.Text = "Neuron";
            this.neuronBtn.UseVisualStyleBackColor = true;
            this.neuronBtn.Click += new System.EventHandler(this.neuronBtn_Click);
            // 
            // perceptronBtn
            // 
            this.perceptronBtn.Location = new System.Drawing.Point(93, 12);
            this.perceptronBtn.Name = "perceptronBtn";
            this.perceptronBtn.Size = new System.Drawing.Size(94, 35);
            this.perceptronBtn.TabIndex = 1;
            this.perceptronBtn.Text = "Perceptron";
            this.perceptronBtn.UseVisualStyleBackColor = true;
            this.perceptronBtn.Click += new System.EventHandler(this.perceptronBtn_Click);
            // 
            // geneticBtn
            // 
            this.geneticBtn.Location = new System.Drawing.Point(194, 11);
            this.geneticBtn.Name = "geneticBtn";
            this.geneticBtn.Size = new System.Drawing.Size(75, 35);
            this.geneticBtn.TabIndex = 2;
            this.geneticBtn.Text = "Genetic";
            this.geneticBtn.UseVisualStyleBackColor = true;
            this.geneticBtn.Click += new System.EventHandler(this.geneticBtn_Click);
            // 
            // kohonenBtn
            // 
            this.kohonenBtn.Enabled = false;
            this.kohonenBtn.Location = new System.Drawing.Point(275, 12);
            this.kohonenBtn.Name = "kohonenBtn";
            this.kohonenBtn.Size = new System.Drawing.Size(75, 35);
            this.kohonenBtn.TabIndex = 2;
            this.kohonenBtn.Text = "Kohonen";
            this.kohonenBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 90);
            this.Controls.Add(this.kohonenBtn);
            this.Controls.Add(this.geneticBtn);
            this.Controls.Add(this.perceptronBtn);
            this.Controls.Add(this.neuronBtn);
            this.Name = "MainForm";
            this.Text = "Soft Computing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button neuronBtn;
        private System.Windows.Forms.Button perceptronBtn;
        private System.Windows.Forms.Button geneticBtn;
        private System.Windows.Forms.Button kohonenBtn;
    }
}