namespace AdminPanel
{
    partial class Part
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
            this.filmBDDataSet1 = new AdminPanel.FilmBDDataSet1();
            this.participantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantsTableAdapter = new AdminPanel.FilmBDDataSet1TableAdapters.ParticipantsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrefDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hrefDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.participantsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(725, 376);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // filmBDDataSet1
            // 
            this.filmBDDataSet1.DataSetName = "FilmBDDataSet1";
            this.filmBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participantsBindingSource
            // 
            this.participantsBindingSource.DataMember = "Participants";
            this.participantsBindingSource.DataSource = this.filmBDDataSet1;
            // 
            // participantsTableAdapter
            // 
            this.participantsTableAdapter.ClearBeforeFill = true;
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
            // hrefDataGridViewTextBoxColumn
            // 
            this.hrefDataGridViewTextBoxColumn.DataPropertyName = "Href";
            this.hrefDataGridViewTextBoxColumn.HeaderText = "Href";
            this.hrefDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hrefDataGridViewTextBoxColumn.Name = "hrefDataGridViewTextBoxColumn";
            this.hrefDataGridViewTextBoxColumn.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Part";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.Part_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FilmBDDataSet1 filmBDDataSet1;
        private System.Windows.Forms.BindingSource participantsBindingSource;
        private FilmBDDataSet1TableAdapters.ParticipantsTableAdapter participantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrefDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button1;
    }
}