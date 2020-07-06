namespace AdminPanel
{
    partial class Films
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createYearIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPAAIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBDDataSet = new AdminPanel.FilmBDDataSet();
            this.filmsTableAdapter = new AdminPanel.FilmBDDataSetTableAdapters.FilmsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.budgetDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.createYearIdDataGridViewTextBoxColumn,
            this.mPAAIdDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn,
            this.retingIdDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 632);
            this.dataGridView1.TabIndex = 0;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // budgetDataGridViewTextBoxColumn
            // 
            this.budgetDataGridViewTextBoxColumn.DataPropertyName = "Budget";
            this.budgetDataGridViewTextBoxColumn.HeaderText = "Budget";
            this.budgetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.budgetDataGridViewTextBoxColumn.Name = "budgetDataGridViewTextBoxColumn";
            this.budgetDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 150;
            // 
            // createYearIdDataGridViewTextBoxColumn
            // 
            this.createYearIdDataGridViewTextBoxColumn.DataPropertyName = "CreateYearId";
            this.createYearIdDataGridViewTextBoxColumn.HeaderText = "CreateYearId";
            this.createYearIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createYearIdDataGridViewTextBoxColumn.Name = "createYearIdDataGridViewTextBoxColumn";
            this.createYearIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // mPAAIdDataGridViewTextBoxColumn
            // 
            this.mPAAIdDataGridViewTextBoxColumn.DataPropertyName = "MPAAId";
            this.mPAAIdDataGridViewTextBoxColumn.HeaderText = "MPAAId";
            this.mPAAIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mPAAIdDataGridViewTextBoxColumn.Name = "mPAAIdDataGridViewTextBoxColumn";
            this.mPAAIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // retingIdDataGridViewTextBoxColumn
            // 
            this.retingIdDataGridViewTextBoxColumn.DataPropertyName = "RetingId";
            this.retingIdDataGridViewTextBoxColumn.HeaderText = "RetingId";
            this.retingIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.retingIdDataGridViewTextBoxColumn.Name = "retingIdDataGridViewTextBoxColumn";
            this.retingIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.Width = 150;
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.filmBDDataSet;
            // 
            // filmBDDataSet
            // 
            this.filmBDDataSet.DataSetName = "FilmBDDataSet";
            this.filmBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Участники";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ррейтинг";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(876, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Страниц";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1043, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Год";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1218, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "Статус Уч.";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1384, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 38);
            this.button7.TabIndex = 7;
            this.button7.Text = "Жанры";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1539, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 38);
            this.button8.TabIndex = 8;
            this.button8.Text = "Уч. и статусы";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1704, 13);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 38);
            this.button9.TabIndex = 9;
            this.button9.Text = "Жар. книг";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(372, 12);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(136, 37);
            this.button10.TabIndex = 10;
            this.button10.Text = "Страны книги";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(220, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 37);
            this.button11.TabIndex = 11;
            this.button11.Text = "Страны";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 724);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Books";
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Films_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FilmBDDataSet filmBDDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private FilmBDDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createYearIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPAAIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button11;
    }
}