namespace AdminPanel
{
    partial class BufP
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
            this.filmBDDataSet7 = new AdminPanel.FilmBDDataSet7();
            this.participantsBufferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantsBufferTableAdapter = new AdminPanel.FilmBDDataSet7TableAdapters.ParticipantsBufferTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusParticipantsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.participantsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBufferBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 5;
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
            this.statusParticipantsIdDataGridViewTextBoxColumn,
            this.participantsIdDataGridViewTextBoxColumn,
            this.filmIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.participantsBufferBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(878, 382);
            this.dataGridView1.TabIndex = 6;
            // 
            // filmBDDataSet7
            // 
            this.filmBDDataSet7.DataSetName = "FilmBDDataSet7";
            this.filmBDDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participantsBufferBindingSource
            // 
            this.participantsBufferBindingSource.DataMember = "ParticipantsBuffer";
            this.participantsBufferBindingSource.DataSource = this.filmBDDataSet7;
            // 
            // participantsBufferTableAdapter
            // 
            this.participantsBufferTableAdapter.ClearBeforeFill = true;
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
            // statusParticipantsIdDataGridViewTextBoxColumn
            // 
            this.statusParticipantsIdDataGridViewTextBoxColumn.DataPropertyName = "StatusParticipantsId";
            this.statusParticipantsIdDataGridViewTextBoxColumn.HeaderText = "StatusParticipantsId";
            this.statusParticipantsIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusParticipantsIdDataGridViewTextBoxColumn.Name = "statusParticipantsIdDataGridViewTextBoxColumn";
            this.statusParticipantsIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // participantsIdDataGridViewTextBoxColumn
            // 
            this.participantsIdDataGridViewTextBoxColumn.DataPropertyName = "ParticipantsId";
            this.participantsIdDataGridViewTextBoxColumn.HeaderText = "ParticipantsId";
            this.participantsIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.participantsIdDataGridViewTextBoxColumn.Name = "participantsIdDataGridViewTextBoxColumn";
            this.participantsIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // filmIdDataGridViewTextBoxColumn
            // 
            this.filmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.HeaderText = "FilmId";
            this.filmIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            this.filmIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // BufP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "BufP";
            this.Text = "BufP";
            this.Load += new System.EventHandler(this.BufP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBufferBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FilmBDDataSet7 filmBDDataSet7;
        private System.Windows.Forms.BindingSource participantsBufferBindingSource;
        private FilmBDDataSet7TableAdapters.ParticipantsBufferTableAdapter participantsBufferTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusParticipantsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn participantsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
    }
}