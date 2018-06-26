namespace personelKayit_dosyaOkuma_
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRmv = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.ofdLoad = new System.Windows.Forms.OpenFileDialog();
            this.dgwListe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxType2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(205, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 41);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRmv
            // 
            this.btnRmv.Location = new System.Drawing.Point(316, 187);
            this.btnRmv.Name = "btnRmv";
            this.btnRmv.Size = new System.Drawing.Size(75, 41);
            this.btnRmv.TabIndex = 3;
            this.btnRmv.Text = "Remove";
            this.btnRmv.UseVisualStyleBackColor = true;
            this.btnRmv.Click += new System.EventHandler(this.btnRmv_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(126, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(50, 21);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ofdLoad
            // 
            this.ofdLoad.FileName = "openFileDialog1";
            // 
            // dgwListe
            // 
            this.dgwListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.SName,
            this.Column4});
            this.dgwListe.Location = new System.Drawing.Point(22, 16);
            this.dgwListe.Name = "dgwListe";
            this.dgwListe.Size = new System.Drawing.Size(442, 150);
            this.dgwListe.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Identity";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // SName
            // 
            this.SName.DataPropertyName = "SName";
            this.SName.HeaderText = "Surname";
            this.SName.Name = "SName";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Date";
            this.Column4.HeaderText = "DateofBirth";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbxType);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(31, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type";
            // 
            // cmbxType
            // 
            this.cmbxType.FormattingEnabled = true;
            this.cmbxType.Items.AddRange(new object[] {
            ".cvs",
            ".xml",
            ".json"});
            this.cmbxType.Location = new System.Drawing.Point(57, 25);
            this.cmbxType.Name = "cmbxType";
            this.cmbxType.Size = new System.Drawing.Size(49, 21);
            this.cmbxType.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbxType2);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Location = new System.Drawing.Point(242, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Load";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type";
            // 
            // cmbxType2
            // 
            this.cmbxType2.FormattingEnabled = true;
            this.cmbxType2.Items.AddRange(new object[] {
            ".cvs",
            ".xml",
            ".json"});
            this.cmbxType2.Location = new System.Drawing.Point(57, 25);
            this.cmbxType2.Name = "cmbxType2";
            this.cmbxType2.Size = new System.Drawing.Size(49, 21);
            this.cmbxType2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwListe);
            this.Controls.Add(this.btnRmv);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.dgwListe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRmv;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.OpenFileDialog ofdLoad;
        public System.Windows.Forms.DataGridView dgwListe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxType2;
    }
}

