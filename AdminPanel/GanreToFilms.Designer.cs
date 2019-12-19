namespace AdminPanel
{
    partial class GanreToFilms
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
            this.filmBDDataSet8 = new AdminPanel.FilmBDDataSet8();
            this.filmsToGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsToGenresTableAdapter = new AdminPanel.FilmBDDataSet8TableAdapters.FilmsToGenresTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsToGenresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.filmIdDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmsToGenresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(668, 373);
            this.dataGridView1.TabIndex = 7;
            // 
            // filmBDDataSet8
            // 
            this.filmBDDataSet8.DataSetName = "FilmBDDataSet8";
            this.filmBDDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsToGenresBindingSource
            // 
            this.filmsToGenresBindingSource.DataMember = "FilmsToGenres";
            this.filmsToGenresBindingSource.DataSource = this.filmBDDataSet8;
            // 
            // filmsToGenresTableAdapter
            // 
            this.filmsToGenresTableAdapter.ClearBeforeFill = true;
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
            // filmIdDataGridViewTextBoxColumn
            // 
            this.filmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.HeaderText = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            this.filmIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            this.genreIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // GanreToFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "GanreToFilms";
            this.Text = "GanreToFilms";
            this.Load += new System.EventHandler(this.GanreToFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsToGenresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FilmBDDataSet8 filmBDDataSet8;
        private System.Windows.Forms.BindingSource filmsToGenresBindingSource;
        private FilmBDDataSet8TableAdapters.FilmsToGenresTableAdapter filmsToGenresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
    }
}