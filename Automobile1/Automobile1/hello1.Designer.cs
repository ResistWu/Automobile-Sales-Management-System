namespace Automobile1
{
    partial class hello1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hello1));
            this.IDBox = new System.Windows.Forms.TextBox();
            this.PwdBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckPWD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(258, 66);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 21);
            this.IDBox.TabIndex = 1;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // PwdBox
            // 
            this.PwdBox.Location = new System.Drawing.Point(258, 152);
            this.PwdBox.Name = "PwdBox";
            this.PwdBox.PasswordChar = '*';
            this.PwdBox.Size = new System.Drawing.Size(100, 21);
            this.PwdBox.TabIndex = 3;
            this.PwdBox.TextChanged += new System.EventHandler(this.PwdBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(258, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckPWD
            // 
            this.CheckPWD.Location = new System.Drawing.Point(258, 233);
            this.CheckPWD.Name = "CheckPWD";
            this.CheckPWD.Size = new System.Drawing.Size(184, 21);
            this.CheckPWD.TabIndex = 6;
            this.CheckPWD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(146, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 50);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(146, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 50);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // hello1
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
            this.Name = "hello1";
            this.Text = "超级管理员登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox PwdBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CheckPWD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

