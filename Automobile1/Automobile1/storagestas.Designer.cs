namespace Automobile1
{
    partial class storagestas
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
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobile111DataSet8 = new Automobile1.automobile111DataSet8();
            this.storageinfoTableAdapter = new Automobile1.automobile111DataSet8TableAdapters.storageinfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(554, 382);
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
            this.snoDataGridViewTextBoxColumn,
            this.saddrDataGridViewTextBoxColumn,
            this.simportDataGridViewTextBoxColumn,
            this.sexportDataGridViewTextBoxColumn,
            this.scountDataGridViewTextBoxColumn,
            this.stelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.storageinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(640, 341);
            this.dataGridView1.TabIndex = 6;
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // saddrDataGridViewTextBoxColumn
            // 
            this.saddrDataGridViewTextBoxColumn.DataPropertyName = "saddr";
            this.saddrDataGridViewTextBoxColumn.HeaderText = "saddr";
            this.saddrDataGridViewTextBoxColumn.Name = "saddrDataGridViewTextBoxColumn";
            // 
            // simportDataGridViewTextBoxColumn
            // 
            this.simportDataGridViewTextBoxColumn.DataPropertyName = "simport";
            this.simportDataGridViewTextBoxColumn.HeaderText = "simport";
            this.simportDataGridViewTextBoxColumn.Name = "simportDataGridViewTextBoxColumn";
            // 
            // sexportDataGridViewTextBoxColumn
            // 
            this.sexportDataGridViewTextBoxColumn.DataPropertyName = "sexport";
            this.sexportDataGridViewTextBoxColumn.HeaderText = "sexport";
            this.sexportDataGridViewTextBoxColumn.Name = "sexportDataGridViewTextBoxColumn";
            // 
            // scountDataGridViewTextBoxColumn
            // 
            this.scountDataGridViewTextBoxColumn.DataPropertyName = "scount";
            this.scountDataGridViewTextBoxColumn.HeaderText = "scount";
            this.scountDataGridViewTextBoxColumn.Name = "scountDataGridViewTextBoxColumn";
            // 
            // stelDataGridViewTextBoxColumn
            // 
            this.stelDataGridViewTextBoxColumn.DataPropertyName = "stel";
            this.stelDataGridViewTextBoxColumn.HeaderText = "stel";
            this.stelDataGridViewTextBoxColumn.Name = "stelDataGridViewTextBoxColumn";
            // 
            // storageinfoBindingSource
            // 
            this.storageinfoBindingSource.DataMember = "storageinfo";
            this.storageinfoBindingSource.DataSource = this.automobile111DataSet8;
            // 
            // automobile111DataSet8
            // 
            this.automobile111DataSet8.DataSetName = "automobile111DataSet8";
            this.automobile111DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storageinfoTableAdapter
            // 
            this.storageinfoTableAdapter.ClearBeforeFill = true;
            // 
            // storagestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "storagestas";
            this.Text = "仓库信息统计";
            this.Load += new System.EventHandler(this.storagestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private automobile111DataSet8 automobile111DataSet8;
        private System.Windows.Forms.BindingSource storageinfoBindingSource;
        private automobile111DataSet8TableAdapters.storageinfoTableAdapter storageinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stelDataGridViewTextBoxColumn;
    }
}