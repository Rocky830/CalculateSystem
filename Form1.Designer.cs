namespace CalculateSystem
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
            this.lsbDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbDisplay
            // 
            this.lsbDisplay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbDisplay.FormattingEnabled = true;
            this.lsbDisplay.ItemHeight = 21;
            this.lsbDisplay.Location = new System.Drawing.Point(295, 192);
            this.lsbDisplay.Name = "lsbDisplay";
            this.lsbDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lsbDisplay.Size = new System.Drawing.Size(210, 67);
            this.lsbDisplay.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbDisplay;
    }
}