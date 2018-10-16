namespace Automobile1
{
    partial class clientstas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientstas));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobile111DataSet2 = new Automobile1.automobile111DataSet2();
            this.automobile111DataSet1 = new Automobile1.automobile111DataSet1();
            this.automobile111DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientinfoTableAdapter = new Automobile1.automobile111DataSet2TableAdapters.clientinfoTableAdapter();
            this.automobile111DataSet3 = new Automobile1.automobile111DataSet3();
            this.clientinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientinfoTableAdapter1 = new Automobile1.automobile111DataSet3TableAdapters.clientinfoTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(537, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "导出报表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnoDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.csexDataGridViewTextBoxColumn,
            this.cageDataGridViewTextBoxColumn,
            this.ctelDataGridViewTextBoxColumn,
            this.cworkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(621, 312);
            this.dataGridView1.TabIndex = 4;
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "cno";
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "cname";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            // 
            // csexDataGridViewTextBoxColumn
            // 
            this.csexDataGridViewTextBoxColumn.DataPropertyName = "csex";
            this.csexDataGridViewTextBoxColumn.HeaderText = "csex";
            this.csexDataGridViewTextBoxColumn.Name = "csexDataGridViewTextBoxColumn";
            // 
            // cageDataGridViewTextBoxColumn
            // 
            this.cageDataGridViewTextBoxColumn.DataPropertyName = "cage";
            this.cageDataGridViewTextBoxColumn.HeaderText = "cage";
            this.cageDataGridViewTextBoxColumn.Name = "cageDataGridViewTextBoxColumn";
            // 
            // ctelDataGridViewTextBoxColumn
            // 
            this.ctelDataGridViewTextBoxColumn.DataPropertyName = "ctel";
            this.ctelDataGridViewTextBoxColumn.HeaderText = "ctel";
            this.ctelDataGridViewTextBoxColumn.Name = "ctelDataGridViewTextBoxColumn";
            // 
            // cworkDataGridViewTextBoxColumn
            // 
            this.cworkDataGridViewTextBoxColumn.DataPropertyName = "cwork";
            this.cworkDataGridViewTextBoxColumn.HeaderText = "cwork";
            this.cworkDataGridViewTextBoxColumn.Name = "cworkDataGridViewTextBoxColumn";
            // 
            // clientinfoBindingSource
            // 
            this.clientinfoBindingSource.DataMember = "clientinfo";
            this.clientinfoBindingSource.DataSource = this.automobile111DataSet2;
            // 
            // automobile111DataSet2
            // 
            this.automobile111DataSet2.DataSetName = "automobile111DataSet2";
            this.automobile111DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automobile111DataSet1
            // 
            this.automobile111DataSet1.DataSetName = "automobile111DataSet1";
            this.automobile111DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automobile111DataSet1BindingSource
            // 
            this.automobile111DataSet1BindingSource.DataSource = this.automobile111DataSet1;
            this.automobile111DataSet1BindingSource.Position = 0;
            // 
            // clientinfoTableAdapter
            // 
            this.clientinfoTableAdapter.ClearBeforeFill = true;
            // 
            // automobile111DataSet3
            // 
            this.automobile111DataSet3.DataSetName = "automobile111DataSet3";
            this.automobile111DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientinfoBindingSource1
            // 
            this.clientinfoBindingSource1.DataMember = "clientinfo";
            this.clientinfoBindingSource1.DataSource = this.automobile111DataSet3;
            // 
            // clientinfoTableAdapter1
            // 
            this.clientinfoTableAdapter1.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 407);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "柱状图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 296);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "报表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientstas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "clientstas";
            this.Text = "客户信息统计";
            this.Load += new System.EventHandler(this.clientstas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientinfoBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource automobile111DataSet1BindingSource;
        private automobile111DataSet1 automobile111DataSet1;
        private automobile111DataSet2 automobile111DataSet2;
        private System.Windows.Forms.BindingSource clientinfoBindingSource;
        private automobile111DataSet2TableAdapters.clientinfoTableAdapter clientinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cworkDataGridViewTextBoxColumn;
        private automobile111DataSet3 automobile111DataSet3;
        private System.Windows.Forms.BindingSource clientinfoBindingSource1;
        private automobile111DataSet3TableAdapters.clientinfoTableAdapter clientinfoTableAdapter1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;

    }
}