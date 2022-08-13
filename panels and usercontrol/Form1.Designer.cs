namespace panels_and_usercontrol
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Black = new System.Windows.Forms.Label();
            this.lbl_Blue = new System.Windows.Forms.Label();
            this.lbl_Red = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(269, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 355);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Black);
            this.panel1.Controls.Add(this.lbl_Blue);
            this.panel1.Controls.Add(this.lbl_Red);
            this.panel1.Location = new System.Drawing.Point(18, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 358);
            this.panel1.TabIndex = 7;
            // 
            // lbl_Black
            // 
            this.lbl_Black.AutoSize = true;
            this.lbl_Black.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Black.Location = new System.Drawing.Point(32, 239);
            this.lbl_Black.Name = "lbl_Black";
            this.lbl_Black.Size = new System.Drawing.Size(104, 22);
            this.lbl_Black.TabIndex = 2;
            this.lbl_Black.Text = "Turn to Green";
            this.lbl_Black.Click += new System.EventHandler(this.lbl_Black_Click);
            // 
            // lbl_Blue
            // 
            this.lbl_Blue.AutoSize = true;
            this.lbl_Blue.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Blue.Location = new System.Drawing.Point(38, 145);
            this.lbl_Blue.Name = "lbl_Blue";
            this.lbl_Blue.Size = new System.Drawing.Size(93, 22);
            this.lbl_Blue.TabIndex = 1;
            this.lbl_Blue.Text = "Turn to Blue";
            this.lbl_Blue.Click += new System.EventHandler(this.lbl_Blue_Click);
            // 
            // lbl_Red
            // 
            this.lbl_Red.AutoSize = true;
            this.lbl_Red.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Red.Location = new System.Drawing.Point(38, 48);
            this.lbl_Red.Name = "lbl_Red";
            this.lbl_Red.Size = new System.Drawing.Size(89, 22);
            this.lbl_Red.TabIndex = 0;
            this.lbl_Red.Text = "Turn to Red";
            this.lbl_Red.Click += new System.EventHandler(this.lbl_Red_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "HELLO";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(335, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(453, 355);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Black;
        private System.Windows.Forms.Label lbl_Blue;
        private System.Windows.Forms.Label lbl_Red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

