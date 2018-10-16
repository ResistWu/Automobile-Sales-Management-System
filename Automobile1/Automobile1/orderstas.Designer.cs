namespace Automobile1
{
    partial class orderstas
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
            this.onoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oorderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oorderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofinishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobile111DataSet6 = new Automobile1.automobile111DataSet6();
            this.orderinfoTableAdapter = new Automobile1.automobile111DataSet6TableAdapters.orderinfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(525, 396);
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
            this.onoDataGridViewTextBoxColumn,
            this.cnoDataGridViewTextBoxColumn,
            this.oorderedDataGridViewTextBoxColumn,
            this.ofinishedDataGridViewTextBoxColumn,
            this.oorderdateDataGridViewTextBoxColumn,
            this.ofinishdateDataGridViewTextBoxColumn,
            this.snoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(640, 349);
            this.dataGridView1.TabIndex = 6;
            // 
            // onoDataGridViewTextBoxColumn
            // 
            this.onoDataGridViewTextBoxColumn.DataPropertyName = "ono";
            this.onoDataGridViewTextBoxColumn.HeaderText = "ono";
            this.onoDataGridViewTextBoxColumn.Name = "onoDataGridViewTextBoxColumn";
            // 
            // cnoDataGridViewTextBoxColumn
            // 
            this.cnoDataGridViewTextBoxColumn.DataPropertyName = "cno";
            this.cnoDataGridViewTextBoxColumn.HeaderText = "cno";
            this.cnoDataGridViewTextBoxColumn.Name = "cnoDataGridViewTextBoxColumn";
            // 
            // oorderedDataGridViewTextBoxColumn
            // 
            this.oorderedDataGridViewTextBoxColumn.DataPropertyName = "oordered";
            this.oorderedDataGridViewTextBoxColumn.HeaderText = "oordered";
            this.oorderedDataGridViewTextBoxColumn.Name = "oorderedDataGridViewTextBoxColumn";
            // 
            // ofinishedDataGridViewTextBoxColumn
            // 
            this.ofinishedDataGridViewTextBoxColumn.DataPropertyName = "ofinished";
            this.ofinishedDataGridViewTextBoxColumn.HeaderText = "ofinished";
            this.ofinishedDataGridViewTextBoxColumn.Name = "ofinishedDataGridViewTextBoxColumn";
            // 
            // oorderdateDataGridViewTextBoxColumn
            // 
            this.oorderdateDataGridViewTextBoxColumn.DataPropertyName = "oorderdate";
            this.oorderdateDataGridViewTextBoxColumn.HeaderText = "oorderdate";
            this.oorderdateDataGridViewTextBoxColumn.Name = "oorderdateDataGridViewTextBoxColumn";
            // 
            // ofinishdateDataGridViewTextBoxColumn
            // 
            this.ofinishdateDataGridViewTextBoxColumn.DataPropertyName = "ofinishdate";
            this.ofinishdateDataGridViewTextBoxColumn.HeaderText = "ofinishdate";
            this.ofinishdateDataGridViewTextBoxColumn.Name = "ofinishdateDataGridViewTextBoxColumn";
            // 
            // snoDataGridViewTextBoxColumn
            // 
            this.snoDataGridViewTextBoxColumn.DataPropertyName = "sno";
            this.snoDataGridViewTextBoxColumn.HeaderText = "sno";
            this.snoDataGridViewTextBoxColumn.Name = "snoDataGridViewTextBoxColumn";
            // 
            // orderinfoBindingSource
            // 
            this.orderinfoBindingSource.DataMember = "orderinfo";
            this.orderinfoBindingSource.DataSource = this.automobile111DataSet6;
            // 
            // automobile111DataSet6
            // 
            this.automobile111DataSet6.DataSetName = "automobile111DataSet6";
            this.automobile111DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderinfoTableAdapter
            // 
            this.orderinfoTableAdapter.ClearBeforeFill = true;
            // 
            // orderstas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "orderstas";
            this.Text = "订单信息统计";
            this.Load += new System.EventHandler(this.orderstas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private automobile111DataSet6 automobile111DataSet6;
        private System.Windows.Forms.BindingSource orderinfoBindingSource;
        private automobile111DataSet6TableAdapters.orderinfoTableAdapter orderinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn onoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oorderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oorderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ofinishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snoDataGridViewTextBoxColumn;
    }
}