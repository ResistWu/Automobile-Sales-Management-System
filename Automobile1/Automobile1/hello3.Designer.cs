namespace Automobile1
{
    partial class hello3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hello3));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckPWD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(154, 220);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 50);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 50);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // CheckPWD
            // 
            this.CheckPWD.Location = new System.Drawing.Point(268, 234);
            this.CheckPWD.Name = "CheckPWD";
            this.CheckPWD.Size = new System.Drawing.Size(184, 21);
            this.CheckPWD.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(268, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 44);
            this.button1.TabIndex = 24;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PwdBox
            // 
            this.PwdBox.Location = new System.Drawing.Point(268, 153);
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.PasswordChar = '*';
            this.PwdBox.Size = new System.Drawing.Size(100, 21);
            this.PwdBox.TabIndex = 23;
            this.PwdBox.TextChanged += new System.EventHandler(this.PwdBox_TextChanged);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(268, 67);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 21);
            this.IDBox.TabIndex = 21;
            // 
            // hello3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 403);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckPWD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PwdBox);
            this.Controls.Add(this.IDBox);
            this.Name = "hello3";
            this.Text = "普通管理员登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CheckPWD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PwdBox;
        private System.Windows.Forms.TextBox IDBox;

    }
}