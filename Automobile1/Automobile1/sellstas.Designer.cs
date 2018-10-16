namespace Automobile1
{
    partial class sellstas
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
            this.asnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ascountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ascostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aspriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asprofitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autosellinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobile111DataSet7 = new Automobile1.automobile111DataSet7();
            this.autosellinfoTableAdapter = new Automobile1.automobile111DataSet7TableAdapters.autosellinfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosellinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(566, 382);
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
            this.asnoDataGridViewTextBoxColumn,
            this.anoDataGridViewTextBoxColumn,
            this.mnoDataGridViewTextBoxColumn,
            this.ascountDataGridViewTextBoxColumn,
            this.ascostDataGridViewTextBoxColumn,
            this.aspriceDataGridViewTextBoxColumn,
            this.asprofitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.autosellinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(650, 343);
            this.dataGridView1.TabIndex = 6;
            // 
            // asnoDataGridViewTextBoxColumn
            // 
            this.asnoDataGridViewTextBoxColumn.DataPropertyName = "asno";
            this.asnoDataGridViewTextBoxColumn.HeaderText = "asno";
            this.asnoDataGridViewTextBoxColumn.Name = "asnoDataGridViewTextBoxColumn";
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // mnoDataGridViewTextBoxColumn
            // 
            this.mnoDataGridViewTextBoxColumn.DataPropertyName = "mno";
            this.mnoDataGridViewTextBoxColumn.HeaderText = "mno";
            this.mnoDataGridViewTextBoxColumn.Name = "mnoDataGridViewTextBoxColumn";
            // 
            // ascountDataGridViewTextBoxColumn
            // 
            this.ascountDataGridViewTextBoxColumn.DataPropertyName = "ascount";
            this.ascountDataGridViewTextBoxColumn.HeaderText = "ascount";
            this.ascountDataGridViewTextBoxColumn.Name = "ascountDataGridViewTextBoxColumn";
            // 
            // ascostDataGridViewTextBoxColumn
            // 
            this.ascostDataGridViewTextBoxColumn.DataPropertyName = "ascost";
            this.ascostDataGridViewTextBoxColumn.HeaderText = "ascost";
            this.ascostDataGridViewTextBoxColumn.Name = "ascostDataGridViewTextBoxColumn";
            // 
            // aspriceDataGridViewTextBoxColumn
            // 
            this.aspriceDataGridViewTextBoxColumn.DataPropertyName = "asprice";
            this.aspriceDataGridViewTextBoxColumn.HeaderText = "asprice";
            this.aspriceDataGridViewTextBoxColumn.Name = "aspriceDataGridViewTextBoxColumn";
            // 
            // asprofitDataGridViewTextBoxColumn
            // 
            this.asprofitDataGridViewTextBoxColumn.DataPropertyName = "asprofit";
            this.asprofitDataGridViewTextBoxColumn.HeaderText = "asprofit";
            this.asprofitDataGridViewTextBoxColumn.Name = "asprofitDataGridViewTextBoxColumn";
            // 
            // autosellinfoBindingSource
            // 
            this.autosellinfoBindingSource.DataMember = "autosellinfo";
            this.autosellinfoBindingSource.DataSource = this.automobile111DataSet7;
            // 
            // automobile111DataSet7
            // 
            this.automobile111DataSet7.DataSetName = "automobile111DataSet7";
            this.automobile111DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autosellinfoTableAdapter
            // 
            this.autosellinfoTableAdapter.ClearBeforeFill = true;
            // 
            // sellstas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "sellstas";
            this.Text = "销售信息统计";
            this.Load += new System.EventHandler(this.sellstas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autosellinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private automobile111DataSet7 automobile111DataSet7;
        private System.Windows.Forms.BindingSource autosellinfoBindingSource;
        private automobile111DataSet7TableAdapters.autosellinfoTableAdapter autosellinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ascountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ascostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aspriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asprofitDataGridViewTextBoxColumn;
    }
}