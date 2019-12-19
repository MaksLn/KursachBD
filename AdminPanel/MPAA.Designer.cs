namespace AdminPanel
{
    partial class MPAA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmBDDataSet3 = new AdminPanel.FilmBDDataSet3();
            this.mPAABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mPAATableAdapter = new AdminPanel.FilmBDDataSet3TableAdapters.MPAATableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpaaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPAABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mpaaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mPAABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(551, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // filmBDDataSet3
            // 
            this.filmBDDataSet3.DataSetName = "FilmBDDataSet3";
            this.filmBDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mPAABindingSource
            // 
            this.mPAABindingSource.DataMember = "MPAA";
            this.mPAABindingSource.DataSource = this.filmBDDataSet3;
            // 
            // mPAATableAdapter
            // 
            this.mPAATableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // mpaaDataGridViewTextBoxColumn
            // 
            this.mpaaDataGridViewTextBoxColumn.DataPropertyName = "Mpaa";
            this.mpaaDataGridViewTextBoxColumn.HeaderText = "Mpaa";
            this.mpaaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mpaaDataGridViewTextBoxColumn.Name = "mpaaDataGridViewTextBoxColumn";
            this.mpaaDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MPAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MPAA";
            this.Text = "MPAA";
            this.Load += new System.EventHandler(this.MPAA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mPAABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FilmBDDataSet3 filmBDDataSet3;
        private System.Windows.Forms.BindingSource mPAABindingSource;
        private FilmBDDataSet3TableAdapters.MPAATableAdapter mPAATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpaaDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button1;
    }
}