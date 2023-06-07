namespace exercise_2
{
    partial class Form2
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
            this.iDPendudukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaLengkapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendudukBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kTPDataSet = new exercise_2.KTPDataSet();
            this.pendudukTableAdapter = new exercise_2.KTPDataSetTableAdapters.PendudukTableAdapter();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendudukBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPendudukDataGridViewTextBoxColumn,
            this.namaLengkapDataGridViewTextBoxColumn,
            this.tempatLahirDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pendudukBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1128, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDPendudukDataGridViewTextBoxColumn
            // 
            this.iDPendudukDataGridViewTextBoxColumn.DataPropertyName = "ID_Penduduk";
            this.iDPendudukDataGridViewTextBoxColumn.HeaderText = "ID_Penduduk";
            this.iDPendudukDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDPendudukDataGridViewTextBoxColumn.Name = "iDPendudukDataGridViewTextBoxColumn";
            this.iDPendudukDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPendudukDataGridViewTextBoxColumn.Width = 200;
            // 
            // namaLengkapDataGridViewTextBoxColumn
            // 
            this.namaLengkapDataGridViewTextBoxColumn.DataPropertyName = "Nama_Lengkap";
            this.namaLengkapDataGridViewTextBoxColumn.HeaderText = "Nama_Lengkap";
            this.namaLengkapDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.namaLengkapDataGridViewTextBoxColumn.Name = "namaLengkapDataGridViewTextBoxColumn";
            this.namaLengkapDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaLengkapDataGridViewTextBoxColumn.Width = 200;
            // 
            // tempatLahirDataGridViewTextBoxColumn
            // 
            this.tempatLahirDataGridViewTextBoxColumn.DataPropertyName = "Tempat_Lahir";
            this.tempatLahirDataGridViewTextBoxColumn.HeaderText = "Tempat_Lahir";
            this.tempatLahirDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tempatLahirDataGridViewTextBoxColumn.Name = "tempatLahirDataGridViewTextBoxColumn";
            this.tempatLahirDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempatLahirDataGridViewTextBoxColumn.Width = 200;
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            this.tanggalLahirDataGridViewTextBoxColumn.ReadOnly = true;
            this.tanggalLahirDataGridViewTextBoxColumn.Width = 200;
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis_Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            this.jenisKelaminDataGridViewTextBoxColumn.ReadOnly = true;
            this.jenisKelaminDataGridViewTextBoxColumn.Width = 200;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            this.alamatDataGridViewTextBoxColumn.Width = 200;
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "No_Telp";
            this.noTelpDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            this.noTelpDataGridViewTextBoxColumn.ReadOnly = true;
            this.noTelpDataGridViewTextBoxColumn.Width = 200;
            // 
            // pendudukBindingSource
            // 
            this.pendudukBindingSource.DataMember = "Penduduk";
            this.pendudukBindingSource.DataSource = this.kTPDataSet;
            // 
            // kTPDataSet
            // 
            this.kTPDataSet.DataSetName = "KTPDataSet";
            this.kTPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pendudukTableAdapter
            // 
            this.pendudukTableAdapter.ClearBeforeFill = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(46, 563);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(190, 99);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 694);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pendudukBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kTPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KTPDataSet kTPDataSet;
        private System.Windows.Forms.BindingSource pendudukBindingSource;
        private KTPDataSetTableAdapters.PendudukTableAdapter pendudukTableAdapter;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPendudukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaLengkapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
    }
}