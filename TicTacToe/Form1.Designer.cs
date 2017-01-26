namespace TicTacToe {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.btnUpperLeft = new System.Windows.Forms.Button();
            this.btnUpperMid = new System.Windows.Forms.Button();
            this.btnUpperRight = new System.Windows.Forms.Button();
            this.btnMidLeft = new System.Windows.Forms.Button();
            this.btnLowerLeft = new System.Windows.Forms.Button();
            this.btnMidMid = new System.Windows.Forms.Button();
            this.btnMidRight = new System.Windows.Forms.Button();
            this.btnLowerMid = new System.Windows.Forms.Button();
            this.btnLowerRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpperLeft
            // 
            this.btnUpperLeft.Location = new System.Drawing.Point(12, 12);
            this.btnUpperLeft.Name = "btnUpperLeft";
            this.btnUpperLeft.Size = new System.Drawing.Size(170, 170);
            this.btnUpperLeft.TabIndex = 0;
            this.btnUpperLeft.UseVisualStyleBackColor = true;
            this.btnUpperLeft.Click += new System.EventHandler(this.btnUpperLeft_Click);
            // 
            // btnUpperMid
            // 
            this.btnUpperMid.Location = new System.Drawing.Point(188, 12);
            this.btnUpperMid.Name = "btnUpperMid";
            this.btnUpperMid.Size = new System.Drawing.Size(170, 170);
            this.btnUpperMid.TabIndex = 1;
            this.btnUpperMid.UseVisualStyleBackColor = true;
            this.btnUpperMid.Click += new System.EventHandler(this.btnUpperMid_Click);
            // 
            // btnUpperRight
            // 
            this.btnUpperRight.Location = new System.Drawing.Point(364, 12);
            this.btnUpperRight.Name = "btnUpperRight";
            this.btnUpperRight.Size = new System.Drawing.Size(170, 170);
            this.btnUpperRight.TabIndex = 2;
            this.btnUpperRight.UseVisualStyleBackColor = true;
            this.btnUpperRight.Click += new System.EventHandler(this.btnUpperRight_Click);
            // 
            // btnMidLeft
            // 
            this.btnMidLeft.Location = new System.Drawing.Point(12, 188);
            this.btnMidLeft.Name = "btnMidLeft";
            this.btnMidLeft.Size = new System.Drawing.Size(170, 170);
            this.btnMidLeft.TabIndex = 3;
            this.btnMidLeft.UseVisualStyleBackColor = true;
            this.btnMidLeft.Click += new System.EventHandler(this.btnMidLeft_Click);
            // 
            // btnLowerLeft
            // 
            this.btnLowerLeft.Location = new System.Drawing.Point(12, 364);
            this.btnLowerLeft.Name = "btnLowerLeft";
            this.btnLowerLeft.Size = new System.Drawing.Size(170, 170);
            this.btnLowerLeft.TabIndex = 4;
            this.btnLowerLeft.UseVisualStyleBackColor = true;
            this.btnLowerLeft.Click += new System.EventHandler(this.btnLowerLeft_Click);
            // 
            // btnMidMid
            // 
            this.btnMidMid.Location = new System.Drawing.Point(188, 188);
            this.btnMidMid.Name = "btnMidMid";
            this.btnMidMid.Size = new System.Drawing.Size(170, 170);
            this.btnMidMid.TabIndex = 5;
            this.btnMidMid.UseVisualStyleBackColor = true;
            this.btnMidMid.Click += new System.EventHandler(this.btnMidMid_Click);
            // 
            // btnMidRight
            // 
            this.btnMidRight.Location = new System.Drawing.Point(364, 188);
            this.btnMidRight.Name = "btnMidRight";
            this.btnMidRight.Size = new System.Drawing.Size(170, 170);
            this.btnMidRight.TabIndex = 6;
            this.btnMidRight.UseVisualStyleBackColor = true;
            this.btnMidRight.Click += new System.EventHandler(this.btnMidRight_Click);
            // 
            // btnLowerMid
            // 
            this.btnLowerMid.Location = new System.Drawing.Point(188, 364);
            this.btnLowerMid.Name = "btnLowerMid";
            this.btnLowerMid.Size = new System.Drawing.Size(170, 170);
            this.btnLowerMid.TabIndex = 7;
            this.btnLowerMid.UseVisualStyleBackColor = true;
            this.btnLowerMid.Click += new System.EventHandler(this.btnLowerMid_Click);
            // 
            // btnLowerRight
            // 
            this.btnLowerRight.Location = new System.Drawing.Point(364, 364);
            this.btnLowerRight.Name = "btnLowerRight";
            this.btnLowerRight.Size = new System.Drawing.Size(170, 170);
            this.btnLowerRight.TabIndex = 8;
            this.btnLowerRight.UseVisualStyleBackColor = true;
            this.btnLowerRight.Click += new System.EventHandler(this.btnLowerRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 546);
            this.Controls.Add(this.btnLowerRight);
            this.Controls.Add(this.btnLowerMid);
            this.Controls.Add(this.btnMidRight);
            this.Controls.Add(this.btnMidMid);
            this.Controls.Add(this.btnLowerLeft);
            this.Controls.Add(this.btnMidLeft);
            this.Controls.Add(this.btnUpperRight);
            this.Controls.Add(this.btnUpperMid);
            this.Controls.Add(this.btnUpperLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpperLeft;
        private System.Windows.Forms.Button btnUpperMid;
        private System.Windows.Forms.Button btnUpperRight;
        private System.Windows.Forms.Button btnMidLeft;
        private System.Windows.Forms.Button btnLowerLeft;
        private System.Windows.Forms.Button btnMidMid;
        private System.Windows.Forms.Button btnMidRight;
        private System.Windows.Forms.Button btnLowerMid;
        private System.Windows.Forms.Button btnLowerRight;
    }
}

