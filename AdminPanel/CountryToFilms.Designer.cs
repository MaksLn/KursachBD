namespace AdminPanel
{
    partial class CountryToFilms
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
            this.filmBDDataSet10 = new AdminPanel.FilmBDDataSet10();
            this.filmsToCountrysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmsToCountrysTableAdapter = new AdminPanel.FilmBDDataSet10TableAdapters.FilmsToCountrysTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsToCountrysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 8;
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
            this.countryIdDataGridViewTextBoxColumn,
            this.filmIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmsToCountrysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(581, 382);
            this.dataGridView1.TabIndex = 9;
            // 
            // filmBDDataSet10
            // 
            this.filmBDDataSet10.DataSetName = "FilmBDDataSet10";
            this.filmBDDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsToCountrysBindingSource
            // 
            this.filmsToCountrysBindingSource.DataMember = "FilmsToCountrys";
            this.filmsToCountrysBindingSource.DataSource = this.filmBDDataSet10;
            // 
            // filmsToCountrysTableAdapter
            // 
            this.filmsToCountrysTableAdapter.ClearBeforeFill = true;
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
            // countryIdDataGridViewTextBoxColumn
            // 
            this.countryIdDataGridViewTextBoxColumn.DataPropertyName = "CountryId";
            this.countryIdDataGridViewTextBoxColumn.HeaderText = "CountryId";
            this.countryIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.countryIdDataGridViewTextBoxColumn.Name = "countryIdDataGridViewTextBoxColumn";
            this.countryIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // filmIdDataGridViewTextBoxColumn
            // 
            this.filmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.HeaderText = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            this.filmIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // CountryToFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "CountryToFilms";
            this.Text = "CountryToFilms";
            this.Load += new System.EventHandler(this.CountryToFilms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsToCountrysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FilmBDDataSet10 filmBDDataSet10;
        private System.Windows.Forms.BindingSource filmsToCountrysBindingSource;
        private FilmBDDataSet10TableAdapters.FilmsToCountrysTableAdapter filmsToCountrysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
    }
}