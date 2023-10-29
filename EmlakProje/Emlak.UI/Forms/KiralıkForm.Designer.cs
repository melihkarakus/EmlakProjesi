namespace Emlak.UI.Forms
{
    partial class KiralıkForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnİnsert = new System.Windows.Forms.Button();
            this.txtKTarih = new System.Windows.Forms.TextBox();
            this.txtKAdres = new System.Windows.Forms.TextBox();
            this.txtKFiyat = new System.Windows.Forms.TextBox();
            this.txtKId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKiralık = new System.Windows.Forms.DataGridView();
            this.KiralıkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiralıkFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KiraTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralık)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnİnsert);
            this.splitContainer1.Panel1.Controls.Add(this.txtKTarih);
            this.splitContainer1.Panel1.Controls.Add(this.txtKAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtKFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.txtKId);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvKiralık);
            this.splitContainer1.Size = new System.Drawing.Size(823, 463);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Emlak.UI.Properties.Resources.refresh;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(462, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Emlak.UI.Properties.Resources.stop__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(462, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnİnsert
            // 
            this.btnİnsert.Image = global::Emlak.UI.Properties.Resources.insert;
            this.btnİnsert.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnİnsert.Location = new System.Drawing.Point(462, 19);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(95, 33);
            this.btnİnsert.TabIndex = 4;
            this.btnİnsert.Text = "Ekle";
            this.btnİnsert.UseVisualStyleBackColor = true;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // txtKTarih
            // 
            this.txtKTarih.Location = new System.Drawing.Point(186, 97);
            this.txtKTarih.Name = "txtKTarih";
            this.txtKTarih.Size = new System.Drawing.Size(140, 27);
            this.txtKTarih.TabIndex = 2;
            // 
            // txtKAdres
            // 
            this.txtKAdres.Location = new System.Drawing.Point(186, 135);
            this.txtKAdres.Name = "txtKAdres";
            this.txtKAdres.Size = new System.Drawing.Size(140, 27);
            this.txtKAdres.TabIndex = 3;
            // 
            // txtKFiyat
            // 
            this.txtKFiyat.Location = new System.Drawing.Point(186, 58);
            this.txtKFiyat.Name = "txtKFiyat";
            this.txtKFiyat.Size = new System.Drawing.Size(140, 27);
            this.txtKFiyat.TabIndex = 1;
            // 
            // txtKId
            // 
            this.txtKId.Location = new System.Drawing.Point(186, 19);
            this.txtKId.Name = "txtKId";
            this.txtKId.Size = new System.Drawing.Size(100, 27);
            this.txtKId.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "KiraTarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "KiralıkFiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "KiralıkID:";
            // 
            // dgvKiralık
            // 
            this.dgvKiralık.AllowUserToAddRows = false;
            this.dgvKiralık.AllowUserToDeleteRows = false;
            this.dgvKiralık.AllowUserToResizeColumns = false;
            this.dgvKiralık.AllowUserToResizeRows = false;
            this.dgvKiralık.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKiralık.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvKiralık.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKiralık.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KiralıkId,
            this.KiralıkFiyat,
            this.KiraTarihi,
            this.Adres});
            this.dgvKiralık.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKiralık.Location = new System.Drawing.Point(0, 0);
            this.dgvKiralık.MultiSelect = false;
            this.dgvKiralık.Name = "dgvKiralık";
            this.dgvKiralık.ReadOnly = true;
            this.dgvKiralık.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKiralık.Size = new System.Drawing.Size(823, 261);
            this.dgvKiralık.TabIndex = 0;
            this.dgvKiralık.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKiralık_RowEnter);
            // 
            // KiralıkId
            // 
            this.KiralıkId.DataPropertyName = "KiralıkId";
            this.KiralıkId.HeaderText = "Kiralık ID";
            this.KiralıkId.Name = "KiralıkId";
            this.KiralıkId.ReadOnly = true;
            // 
            // KiralıkFiyat
            // 
            this.KiralıkFiyat.DataPropertyName = "KiralıkFiyat";
            this.KiralıkFiyat.HeaderText = "Kiralık Fiyat";
            this.KiralıkFiyat.Name = "KiralıkFiyat";
            this.KiralıkFiyat.ReadOnly = true;
            // 
            // KiraTarihi
            // 
            this.KiraTarihi.DataPropertyName = "KiraTarihi";
            this.KiraTarihi.HeaderText = "Kira Tarihi";
            this.KiraTarihi.Name = "KiraTarihi";
            this.KiraTarihi.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // KiralıkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 463);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KiralıkForm";
            this.Text = "Kiralık İşlemler";
            this.Load += new System.EventHandler(this.KiralıkForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKiralık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKiralık;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.TextBox txtKTarih;
        private System.Windows.Forms.TextBox txtKAdres;
        private System.Windows.Forms.TextBox txtKFiyat;
        private System.Windows.Forms.TextBox txtKId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiralıkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiralıkFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn KiraTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
    }
}