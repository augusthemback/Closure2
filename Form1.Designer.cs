namespace Closure2
{
    partial class ClosureForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClosureForm));
			this.InstantShutdownBtn = new System.Windows.Forms.Button();
			this.SecondsSlider = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.HoursSlider = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.MinutesSlider = new System.Windows.Forms.NumericUpDown();
			this.DelayedShutdownBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SecondsSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HoursSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MinutesSlider)).BeginInit();
			this.SuspendLayout();
			// 
			// InstantShutdownBtn
			// 
			this.InstantShutdownBtn.BackColor = System.Drawing.Color.White;
			this.InstantShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.InstantShutdownBtn.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InstantShutdownBtn.ForeColor = System.Drawing.Color.White;
			this.InstantShutdownBtn.Location = new System.Drawing.Point(11, 104);
			this.InstantShutdownBtn.Margin = new System.Windows.Forms.Padding(2);
			this.InstantShutdownBtn.Name = "InstantShutdownBtn";
			this.InstantShutdownBtn.Size = new System.Drawing.Size(83, 46);
			this.InstantShutdownBtn.TabIndex = 0;
			this.InstantShutdownBtn.Text = "Instant Shutdown";
			this.InstantShutdownBtn.UseVisualStyleBackColor = false;
			this.InstantShutdownBtn.Click += new System.EventHandler(this.InstantShutdownBtn_Click);
			// 
			// SecondsSlider
			// 
			this.SecondsSlider.Location = new System.Drawing.Point(176, 50);
			this.SecondsSlider.Name = "SecondsSlider";
			this.SecondsSlider.Size = new System.Drawing.Size(56, 20);
			this.SecondsSlider.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Roboto Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(114, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Minutes";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Roboto Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Hours";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HoursSlider
			// 
			this.HoursSlider.Location = new System.Drawing.Point(52, 50);
			this.HoursSlider.Name = "HoursSlider";
			this.HoursSlider.Size = new System.Drawing.Size(56, 20);
			this.HoursSlider.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Roboto Medium", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(176, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Seconds";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MinutesSlider
			// 
			this.MinutesSlider.Location = new System.Drawing.Point(114, 50);
			this.MinutesSlider.Name = "MinutesSlider";
			this.MinutesSlider.Size = new System.Drawing.Size(56, 20);
			this.MinutesSlider.TabIndex = 5;
			// 
			// DelayedShutdownBtn
			// 
			this.DelayedShutdownBtn.BackColor = System.Drawing.Color.White;
			this.DelayedShutdownBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
			this.DelayedShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DelayedShutdownBtn.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DelayedShutdownBtn.ForeColor = System.Drawing.Color.White;
			this.DelayedShutdownBtn.Location = new System.Drawing.Point(190, 104);
			this.DelayedShutdownBtn.Margin = new System.Windows.Forms.Padding(2);
			this.DelayedShutdownBtn.Name = "DelayedShutdownBtn";
			this.DelayedShutdownBtn.Size = new System.Drawing.Size(83, 46);
			this.DelayedShutdownBtn.TabIndex = 7;
			this.DelayedShutdownBtn.Text = "Delayed Shutdown";
			this.DelayedShutdownBtn.UseVisualStyleBackColor = false;
			this.DelayedShutdownBtn.Click += new System.EventHandler(this.DelayedShutdownBtn_Click);
			// 
			// ClosureForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.DelayedShutdownBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.MinutesSlider);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.HoursSlider);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SecondsSlider);
			this.Controls.Add(this.InstantShutdownBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "ClosureForm";
			this.Opacity = 0.92D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Closure 2";
			this.Load += new System.EventHandler(this.ClosureForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.SecondsSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HoursSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MinutesSlider)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstantShutdownBtn;
		private System.Windows.Forms.NumericUpDown SecondsSlider;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown HoursSlider;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown MinutesSlider;
		private System.Windows.Forms.Button DelayedShutdownBtn;
	}
}

