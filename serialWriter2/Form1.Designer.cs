namespace serialWriter2
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
            this.HighButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LowButton = new System.Windows.Forms.Button();
            this.FrequencyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HighButton
            // 
            this.HighButton.Location = new System.Drawing.Point(346, 203);
            this.HighButton.Name = "HighButton";
            this.HighButton.Size = new System.Drawing.Size(75, 23);
            this.HighButton.TabIndex = 0;
            this.HighButton.Text = "HIGH";
            this.HighButton.UseVisualStyleBackColor = true;
            this.HighButton.Click += new System.EventHandler(this.HighButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start";
            // 
            // LowButton
            // 
            this.LowButton.Location = new System.Drawing.Point(346, 233);
            this.LowButton.Name = "LowButton";
            this.LowButton.Size = new System.Drawing.Size(75, 23);
            this.LowButton.TabIndex = 2;
            this.LowButton.Text = "LOW";
            this.LowButton.UseVisualStyleBackColor = true;
            this.LowButton.Click += new System.EventHandler(this.LowButton_Click);
            // 
            // FrequencyButton
            // 
            this.FrequencyButton.Location = new System.Drawing.Point(346, 263);
            this.FrequencyButton.Name = "FrequencyButton";
            this.FrequencyButton.Size = new System.Drawing.Size(75, 23);
            this.FrequencyButton.TabIndex = 3;
            this.FrequencyButton.Text = "FREQ";
            this.FrequencyButton.UseVisualStyleBackColor = true;
            this.FrequencyButton.Click += new System.EventHandler(this.FrequencyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FrequencyButton);
            this.Controls.Add(this.LowButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HighButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LowButton;
        private System.Windows.Forms.Button FrequencyButton;
    }
}

