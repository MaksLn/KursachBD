namespace AdminPanel
{
    partial class Ganre
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
            this.filmBDDataSet6 = new AdminPanel.FilmBDDataSet6();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new AdminPanel.FilmBDDataSet6TableAdapters.GenreTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genersNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.genersNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.genreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(508, 380);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filmBDDataSet6
            // 
            this.filmBDDataSet6.DataSetName = "FilmBDDataSet6";
            this.filmBDDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.filmBDDataSet6;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
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
            // genersNameDataGridViewTextBoxColumn
            // 
            this.genersNameDataGridViewTextBoxColumn.DataPropertyName = "GenersName";
            this.genersNameDataGridViewTextBoxColumn.HeaderText = "GenersName";
            this.genersNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genersNameDataGridViewTextBoxColumn.Name = "genersNameDataGridViewTextBoxColumn";
            this.genersNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ganre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Ganre";
            this.Text = "Ganre";
            this.Load += new System.EventHandler(this.Ganre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private FilmBDDataSet6 filmBDDataSet6;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private FilmBDDataSet6TableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genersNameDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button1;
    }
}