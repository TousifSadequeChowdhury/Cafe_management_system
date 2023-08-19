
namespace newdesign
{
    partial class Aboutus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBackAboutEmp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackAboutAd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnBackAboutEmp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBackAboutAd);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 454);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBackAboutEmp
            // 
            this.btnBackAboutEmp.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBackAboutEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAboutEmp.Location = new System.Drawing.Point(11, 417);
            this.btnBackAboutEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackAboutEmp.Name = "btnBackAboutEmp";
            this.btnBackAboutEmp.Size = new System.Drawing.Size(73, 24);
            this.btnBackAboutEmp.TabIndex = 3;
            this.btnBackAboutEmp.Text = "Back";
            this.btnBackAboutEmp.UseVisualStyleBackColor = false;
            this.btnBackAboutEmp.Click += new System.EventHandler(this.btnBackAboutEmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::newdesign.Properties.Resources.sifz_cafe_about;
            this.pictureBox1.Location = new System.Drawing.Point(-83, -61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackAboutAd
            // 
            this.btnBackAboutAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAboutAd.Location = new System.Drawing.Point(651, 292);
            this.btnBackAboutAd.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackAboutAd.Name = "btnBackAboutAd";
            this.btnBackAboutAd.Size = new System.Drawing.Size(83, 31);
            this.btnBackAboutAd.TabIndex = 4;
            this.btnBackAboutAd.Text = "Back";
            this.btnBackAboutAd.UseVisualStyleBackColor = true;
            this.btnBackAboutAd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Aboutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aboutus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aboutus";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnBackAboutEmp;
        public System.Windows.Forms.Button btnBackAboutAd;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button1;
    }
}