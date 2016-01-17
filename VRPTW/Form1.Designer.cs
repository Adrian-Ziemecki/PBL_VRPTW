namespace VRPTW
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
            this.chooseFile_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.output_textbox = new System.Windows.Forms.TextBox();
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
            this.output_textbox.Location = new System.Drawing.Point(133, 12);
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.ReadOnly = true;
            this.output_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.output_textbox.Size = new System.Drawing.Size(639, 372);
            this.output_textbox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 398);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.chooseFile_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFile_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox output_textbox;
    }
}

