namespace AdminPanel
{
    partial class Reiting
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
            this.filmBDDataSet2 = new AdminPanel.FilmBDDataSet2();
            this.retingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retingTableAdapter = new AdminPanel.FilmBDDataSet2TableAdapters.RetingTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userStarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allStarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 3;
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
            this.userStarDataGridViewTextBoxColumn,
            this.allStarDataGridViewTextBoxColumn,
            this.discriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.retingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(725, 376);
            this.dataGridView1.TabIndex = 4;
            // 
            // filmBDDataSet2
            // 
            this.filmBDDataSet2.DataSetName = "FilmBDDataSet2";
            this.filmBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retingBindingSource
            // 
            this.retingBindingSource.DataMember = "Reting";
            this.retingBindingSource.DataSource = this.filmBDDataSet2;
            // 
            // retingTableAdapter
            // 
            this.retingTableAdapter.ClearBeforeFill = true;
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
            // userStarDataGridViewTextBoxColumn
            // 
            this.userStarDataGridViewTextBoxColumn.DataPropertyName = "UserStar";
            this.userStarDataGridViewTextBoxColumn.HeaderText = "UserStar";
            this.userStarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userStarDataGridViewTextBoxColumn.Name = "userStarDataGridViewTextBoxColumn";
            this.userStarDataGridViewTextBoxColumn.Width = 150;
            // 
            // allStarDataGridViewTextBoxColumn
            // 
            this.allStarDataGridViewTextBoxColumn.DataPropertyName = "AllStar";
            this.allStarDataGridViewTextBoxColumn.HeaderText = "AllStar";
            this.allStarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.allStarDataGridViewTextBoxColumn.Name = "allStarDataGridViewTextBoxColumn";
            this.allStarDataGridViewTextBoxColumn.Width = 150;
            // 
            // discriptionDataGridViewTextBoxColumn
            // 
            this.discriptionDataGridViewTextBoxColumn.DataPropertyName = "Discription";
            this.discriptionDataGridViewTextBoxColumn.HeaderText = "Discription";
            this.discriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.discriptionDataGridViewTextBoxColumn.Name = "discriptionDataGridViewTextBoxColumn";
            this.discriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // Reiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Reiting";
            this.Text = "Reiting";
            this.Load += new System.EventHandler(this.Reiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FilmBDDataSet2 filmBDDataSet2;
        private System.Windows.Forms.BindingSource retingBindingSource;
        private FilmBDDataSet2TableAdapters.RetingTableAdapter retingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userStarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allStarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discriptionDataGridViewTextBoxColumn;
    }
}