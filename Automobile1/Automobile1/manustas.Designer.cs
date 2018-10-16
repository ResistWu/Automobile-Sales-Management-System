namespace Automobile1
{
    partial class manustas
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mcountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobile111DataSet5 = new Automobile1.automobile111DataSet5();
            this.manufacturerinfoTableAdapter = new Automobile1.automobile111DataSet5TableAdapters.manufacturerinfoTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "导出报表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mnoDataGridViewTextBoxColumn,
            this.mnameDataGridViewTextBoxColumn,
            this.maddrDataGridViewTextBoxColumn,
            this.mstatusDataGridViewTextBoxColumn,
            this.mcountDataGridViewTextBoxColumn,
            this.mtelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.manufacturerinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(649, 388);
            this.dataGridView1.TabIndex = 6;
            // 
            // mnoDataGridViewTextBoxColumn
            // 
            this.mnoDataGridViewTextBoxColumn.DataPropertyName = "mno";
            this.mnoDataGridViewTextBoxColumn.HeaderText = "mno";
            this.mnoDataGridViewTextBoxColumn.Name = "mnoDataGridViewTextBoxColumn";
            // 
            // mnameDataGridViewTextBoxColumn
            // 
            this.mnameDataGridViewTextBoxColumn.DataPropertyName = "mname";
            this.mnameDataGridViewTextBoxColumn.HeaderText = "mname";
            this.mnameDataGridViewTextBoxColumn.Name = "mnameDataGridViewTextBoxColumn";
            // 
            // maddrDataGridViewTextBoxColumn
            // 
            this.maddrDataGridViewTextBoxColumn.DataPropertyName = "maddr";
            this.maddrDataGridViewTextBoxColumn.HeaderText = "maddr";
            this.maddrDataGridViewTextBoxColumn.Name = "maddrDataGridViewTextBoxColumn";
            // 
            // mstatusDataGridViewTextBoxColumn
            // 
            this.mstatusDataGridViewTextBoxColumn.DataPropertyName = "mstatus";
            this.mstatusDataGridViewTextBoxColumn.HeaderText = "mstatus";
            this.mstatusDataGridViewTextBoxColumn.Name = "mstatusDataGridViewTextBoxColumn";
            // 
            // mcountDataGridViewTextBoxColumn
            // 
            this.mcountDataGridViewTextBoxColumn.DataPropertyName = "mcount";
            this.mcountDataGridViewTextBoxColumn.HeaderText = "mcount";
            this.mcountDataGridViewTextBoxColumn.Name = "mcountDataGridViewTextBoxColumn";
            // 
            // mtelDataGridViewTextBoxColumn
            // 
            this.mtelDataGridViewTextBoxColumn.DataPropertyName = "mtel";
            this.mtelDataGridViewTextBoxColumn.HeaderText = "mtel";
            this.mtelDataGridViewTextBoxColumn.Name = "mtelDataGridViewTextBoxColumn";
            // 
            // manufacturerinfoBindingSource
            // 
            this.manufacturerinfoBindingSource.DataMember = "manufacturerinfo";
            this.manufacturerinfoBindingSource.DataSource = this.automobile111DataSet5;
            // 
            // automobile111DataSet5
            // 
            this.automobile111DataSet5.DataSetName = "automobile111DataSet5";
            this.automobile111DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufacturerinfoTableAdapter
            // 
            this.manufacturerinfoTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(545, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "导出报表";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // manustas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "manustas";
            this.Text = "厂商信息统计";
            this.Load += new System.EventHandler(this.manustas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private automobile111DataSet5 automobile111DataSet5;
        private System.Windows.Forms.BindingSource manufacturerinfoBindingSource;
        private automobile111DataSet5TableAdapters.manufacturerinfoTableAdapter manufacturerinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mcountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}