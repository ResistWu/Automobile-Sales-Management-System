namespace Automobile1
{
    partial class autostas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autostas));
            this.automobile111DataSet4 = new Automobile1.automobile111DataSet4();
            this.automobileinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobileinfoTableAdapter = new Automobile1.automobile111DataSet4TableAdapters.automobileinfoTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.anoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.astatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileinfoBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // automobile111DataSet4
            // 
            this.automobile111DataSet4.DataSetName = "automobile111DataSet4";
            this.automobile111DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automobileinfoBindingSource
            // 
            this.automobileinfoBindingSource.DataMember = "automobileinfo";
            this.automobileinfoBindingSource.DataSource = this.automobile111DataSet4;
            // 
            // automobileinfoTableAdapter
            // 
            this.automobileinfoTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 395);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "饼状图";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "报表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anoDataGridViewTextBoxColumn,
            this.anameDataGridViewTextBoxColumn,
            this.mnoDataGridViewTextBoxColumn,
            this.apriceDataGridViewTextBoxColumn,
            this.astatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.automobileinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(546, 266);
            this.dataGridView1.TabIndex = 7;
            // 
            // anoDataGridViewTextBoxColumn
            // 
            this.anoDataGridViewTextBoxColumn.DataPropertyName = "ano";
            this.anoDataGridViewTextBoxColumn.HeaderText = "ano";
            this.anoDataGridViewTextBoxColumn.Name = "anoDataGridViewTextBoxColumn";
            // 
            // anameDataGridViewTextBoxColumn
            // 
            this.anameDataGridViewTextBoxColumn.DataPropertyName = "aname";
            this.anameDataGridViewTextBoxColumn.HeaderText = "aname";
            this.anameDataGridViewTextBoxColumn.Name = "anameDataGridViewTextBoxColumn";
            // 
            // mnoDataGridViewTextBoxColumn
            // 
            this.mnoDataGridViewTextBoxColumn.DataPropertyName = "mno";
            this.mnoDataGridViewTextBoxColumn.HeaderText = "mno";
            this.mnoDataGridViewTextBoxColumn.Name = "mnoDataGridViewTextBoxColumn";
            // 
            // apriceDataGridViewTextBoxColumn
            // 
            this.apriceDataGridViewTextBoxColumn.DataPropertyName = "aprice";
            this.apriceDataGridViewTextBoxColumn.HeaderText = "aprice";
            this.apriceDataGridViewTextBoxColumn.Name = "apriceDataGridViewTextBoxColumn";
            // 
            // astatusDataGridViewTextBoxColumn
            // 
            this.astatusDataGridViewTextBoxColumn.DataPropertyName = "astatus";
            this.astatusDataGridViewTextBoxColumn.HeaderText = "astatus";
            this.astatusDataGridViewTextBoxColumn.Name = "astatusDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "导出报表";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // autostas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.tabControl1);
            this.Name = "autostas";
            this.Text = "汽车信息统计";
            this.Load += new System.EventHandler(this.autostas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.automobile111DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobileinfoBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private automobile111DataSet4 automobile111DataSet4;
        private System.Windows.Forms.BindingSource automobileinfoBindingSource;
        private automobile111DataSet4TableAdapters.automobileinfoTableAdapter automobileinfoTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn astatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}