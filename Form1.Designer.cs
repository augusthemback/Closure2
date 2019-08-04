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
            this.SuspendLayout();
            // 
            // InstantShutdownBtn
            // 
            this.InstantShutdownBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.InstantShutdownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InstantShutdownBtn.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstantShutdownBtn.ForeColor = System.Drawing.Color.White;
            this.InstantShutdownBtn.Location = new System.Drawing.Point(12, 381);
            this.InstantShutdownBtn.Name = "InstantShutdownBtn";
            this.InstantShutdownBtn.Size = new System.Drawing.Size(111, 57);
            this.InstantShutdownBtn.TabIndex = 0;
            this.InstantShutdownBtn.Text = "Instant Shutdown";
            this.InstantShutdownBtn.UseVisualStyleBackColor = false;
            this.InstantShutdownBtn.Click += new System.EventHandler(this.InstantShutdownBtn_Click);
            // 
            // ClosureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstantShutdownBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClosureForm";
            this.Opacity = 0.95D;
            this.Text = "Closure 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstantShutdownBtn;
    }
}

