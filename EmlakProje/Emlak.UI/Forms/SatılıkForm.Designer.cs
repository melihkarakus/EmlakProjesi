namespace Emlak.UI.Forms
{
    partial class SatılıkForm
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
            this.txtSatAdres = new System.Windows.Forms.TextBox();
            this.txtSatF = new System.Windows.Forms.TextBox();
            this.txtSatId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSatılık = new System.Windows.Forms.DataGridView();
            this.SatılıkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatılıkFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatılık)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtSatAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtSatF);
            this.splitContainer1.Panel1.Controls.Add(this.txtSatId);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSatılık);
            this.splitContainer1.Size = new System.Drawing.Size(831, 462);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Emlak.UI.Properties.Resources.refresh;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(572, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 37);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Emlak.UI.Properties.Resources.stop__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(572, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnİnsert
            // 
            this.btnİnsert.Image = global::Emlak.UI.Properties.Resources.insert;
            this.btnİnsert.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnİnsert.Location = new System.Drawing.Point(572, 25);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(95, 33);
            this.btnİnsert.TabIndex = 3;
            this.btnİnsert.Text = "Ekle";
            this.btnİnsert.UseVisualStyleBackColor = true;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // txtSatAdres
            // 
            this.txtSatAdres.Location = new System.Drawing.Point(181, 94);
            this.txtSatAdres.Name = "txtSatAdres";
            this.txtSatAdres.Size = new System.Drawing.Size(281, 27);
            this.txtSatAdres.TabIndex = 2;
            // 
            // txtSatF
            // 
            this.txtSatF.Location = new System.Drawing.Point(181, 56);
            this.txtSatF.Name = "txtSatF";
            this.txtSatF.Size = new System.Drawing.Size(100, 27);
            this.txtSatF.TabIndex = 1;
            // 
            // txtSatId
            // 
            this.txtSatId.Location = new System.Drawing.Point(181, 16);
            this.txtSatId.Name = "txtSatId";
            this.txtSatId.Size = new System.Drawing.Size(100, 27);
            this.txtSatId.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satılık Fiyat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satılık ID:";
            // 
            // dgvSatılık
            // 
            this.dgvSatılık.AllowUserToAddRows = false;
            this.dgvSatılık.AllowUserToDeleteRows = false;
            this.dgvSatılık.AllowUserToResizeColumns = false;
            this.dgvSatılık.AllowUserToResizeRows = false;
            this.dgvSatılık.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatılık.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSatılık.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatılık.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatılıkId,
            this.SatılıkFiyat,
            this.Adres});
            this.dgvSatılık.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSatılık.Location = new System.Drawing.Point(0, 0);
            this.dgvSatılık.MultiSelect = false;
            this.dgvSatılık.Name = "dgvSatılık";
            this.dgvSatılık.ReadOnly = true;
            this.dgvSatılık.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatılık.Size = new System.Drawing.Size(831, 275);
            this.dgvSatılık.TabIndex = 0;
            this.dgvSatılık.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatılık_RowEnter);
            // 
            // SatılıkId
            // 
            this.SatılıkId.DataPropertyName = "SatılıkId";
            this.SatılıkId.HeaderText = "Satılık Id";
            this.SatılıkId.Name = "SatılıkId";
            this.SatılıkId.ReadOnly = true;
            // 
            // SatılıkFiyat
            // 
            this.SatılıkFiyat.DataPropertyName = "SatılıkFiyat";
            this.SatılıkFiyat.HeaderText = "Satılık Fiyat";
            this.SatılıkFiyat.Name = "SatılıkFiyat";
            this.SatılıkFiyat.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // SatılıkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 462);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SatılıkForm";
            this.Text = "Satılık İşlemler";
            this.Load += new System.EventHandler(this.SatılıkForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatılık)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.TextBox txtSatAdres;
        private System.Windows.Forms.TextBox txtSatF;
        private System.Windows.Forms.TextBox txtSatId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSatılık;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatılıkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatılıkFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
    }
}