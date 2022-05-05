namespace Signals
{
    partial class GraphicsSignalView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plus_b = new System.Windows.Forms.Button();
            this.minus_b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plus_b
            // 
            this.plus_b.Location = new System.Drawing.Point(14, 27);
            this.plus_b.Name = "plus_b";
            this.plus_b.Size = new System.Drawing.Size(55, 23);
            this.plus_b.TabIndex = 0;
            this.plus_b.Text = "+";
            this.plus_b.UseVisualStyleBackColor = true;
            this.plus_b.Click += new System.EventHandler(this.plus_b_Click);
            // 
            // minus_b
            // 
            this.minus_b.Location = new System.Drawing.Point(75, 27);
            this.minus_b.Name = "minus_b";
            this.minus_b.Size = new System.Drawing.Size(55, 24);
            this.minus_b.TabIndex = 1;
            this.minus_b.Text = "-";
            this.minus_b.UseVisualStyleBackColor = true;
            this.minus_b.Click += new System.EventHandler(this.minus_b_Click);
            // 
            // GraphicsSignalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.minus_b);
            this.Controls.Add(this.plus_b);
            this.Name = "GraphicsSignalView";
            this.Size = new System.Drawing.Size(538, 431);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plus_b;
        private System.Windows.Forms.Button minus_b;
    }
}
