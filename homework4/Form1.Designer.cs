﻿namespace homework4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pTarget = new System.Windows.Forms.Panel();
            this.bBike1 = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.pStart = new System.Windows.Forms.Panel();
            this.bBike2 = new System.Windows.Forms.Button();
            this.bBike3 = new System.Windows.Forms.Button();
            this.bStep1 = new System.Windows.Forms.Button();
            this.pDepo = new System.Windows.Forms.Panel();
            this.bStep2 = new System.Windows.Forms.Button();
            this.bCounter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pTarget
            // 
            this.pTarget.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pTarget.Location = new System.Drawing.Point(742, 21);
            this.pTarget.Name = "pTarget";
            this.pTarget.Size = new System.Drawing.Size(273, 360);
            this.pTarget.TabIndex = 0;
            // 
            // bBike1
            // 
            this.bBike1.Font = new System.Drawing.Font("Webdings", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBike1.Location = new System.Drawing.Point(34, 45);
            this.bBike1.Name = "bBike1";
            this.bBike1.Size = new System.Drawing.Size(128, 103);
            this.bBike1.TabIndex = 0;
            this.bBike1.Text = "b";
            this.bBike1.UseVisualStyleBackColor = true;
            this.bBike1.Click += new System.EventHandler(this.bike_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(34, 394);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(117, 26);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // pStart
            // 
            this.pStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pStart.Location = new System.Drawing.Point(257, 21);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(173, 369);
            this.pStart.TabIndex = 4;
            // 
            // bBike2
            // 
            this.bBike2.Font = new System.Drawing.Font("Webdings", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBike2.Location = new System.Drawing.Point(34, 154);
            this.bBike2.Name = "bBike2";
            this.bBike2.Size = new System.Drawing.Size(128, 103);
            this.bBike2.TabIndex = 5;
            this.bBike2.Text = "b";
            this.bBike2.UseVisualStyleBackColor = true;
            this.bBike2.Click += new System.EventHandler(this.bike_Click);
            // 
            // bBike3
            // 
            this.bBike3.Font = new System.Drawing.Font("Webdings", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bBike3.Location = new System.Drawing.Point(34, 263);
            this.bBike3.Name = "bBike3";
            this.bBike3.Size = new System.Drawing.Size(128, 103);
            this.bBike3.TabIndex = 6;
            this.bBike3.Text = "b";
            this.bBike3.UseVisualStyleBackColor = true;
            this.bBike3.Click += new System.EventHandler(this.bike_Click);
            // 
            // bStep1
            // 
            this.bStep1.Location = new System.Drawing.Point(289, 397);
            this.bStep1.Name = "bStep1";
            this.bStep1.Size = new System.Drawing.Size(112, 23);
            this.bStep1.TabIndex = 0;
            this.bStep1.Text = "Step1";
            this.bStep1.UseVisualStyleBackColor = true;
            this.bStep1.Click += new System.EventHandler(this.bStep1_Click);
            // 
            // pDepo
            // 
            this.pDepo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pDepo.Location = new System.Drawing.Point(501, 21);
            this.pDepo.Name = "pDepo";
            this.pDepo.Size = new System.Drawing.Size(173, 369);
            this.pDepo.TabIndex = 5;
            // 
            // bStep2
            // 
            this.bStep2.Location = new System.Drawing.Point(539, 397);
            this.bStep2.Name = "bStep2";
            this.bStep2.Size = new System.Drawing.Size(112, 23);
            this.bStep2.TabIndex = 7;
            this.bStep2.Text = "Step2";
            this.bStep2.UseVisualStyleBackColor = true;
            this.bStep2.Click += new System.EventHandler(this.bStep2_Click);
            // 
            // bCounter
            // 
            this.bCounter.Location = new System.Drawing.Point(855, 394);
            this.bCounter.Name = "bCounter";
            this.bCounter.Size = new System.Drawing.Size(75, 23);
            this.bCounter.TabIndex = 8;
            this.bCounter.Text = "0";
            this.bCounter.UseVisualStyleBackColor = true;
            this.bCounter.Click += new System.EventHandler(this.bCounter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 449);
            this.Controls.Add(this.bCounter);
            this.Controls.Add(this.bBike3);
            this.Controls.Add(this.bBike1);
            this.Controls.Add(this.bBike2);
            this.Controls.Add(this.bStep2);
            this.Controls.Add(this.bStep1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pStart);
            this.Controls.Add(this.pDepo);
            this.Controls.Add(this.pTarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pTarget;
        private Button bBike1;
        private Button bStart;
        private Panel pStart;
        private Button bBike2;
        private Button bBike3;
        private Button bStep1;
        private Panel pDepo;
        private Button bStep2;
        private Button bCounter;
    }
}