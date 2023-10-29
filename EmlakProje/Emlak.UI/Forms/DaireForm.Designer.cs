namespace Emlak.UI.Forms
{
    partial class DaireForm
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
            this.txtONumber = new System.Windows.Forms.TextBox();
            this.txtOName = new System.Windows.Forms.TextBox();
            this.txtOId = new System.Windows.Forms.TextBox();
            this.txtDNumber = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.txtDId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDaire = new System.Windows.Forms.DataGridView();
            this.DaireId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaireAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaireSayısı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdaSayı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaire)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.txtONumber);
            this.splitContainer1.Panel1.Controls.Add(this.txtOName);
            this.splitContainer1.Panel1.Controls.Add(this.txtOId);
            this.splitContainer1.Panel1.Controls.Add(this.txtDNumber);
            this.splitContainer1.Panel1.Controls.Add(this.txtDName);
            this.splitContainer1.Panel1.Controls.Add(this.txtDId);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDaire);
            this.splitContainer1.Size = new System.Drawing.Size(830, 464);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::Emlak.UI.Properties.Resources.refresh;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(523, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Emlak.UI.Properties.Resources.stop__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(523, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnİnsert
            // 
            this.btnİnsert.Image = global::Emlak.UI.Properties.Resources.insert;
            this.btnİnsert.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnİnsert.Location = new System.Drawing.Point(523, 81);
            this.btnİnsert.Name = "btnİnsert";
            this.btnİnsert.Size = new System.Drawing.Size(109, 33);
            this.btnİnsert.TabIndex = 8;
            this.btnİnsert.Text = "Ekle";
            this.btnİnsert.UseVisualStyleBackColor = true;
            this.btnİnsert.Click += new System.EventHandler(this.btnİnsert_Click);
            // 
            // txtONumber
            // 
            this.txtONumber.Location = new System.Drawing.Point(228, 173);
            this.txtONumber.Name = "txtONumber";
            this.txtONumber.Size = new System.Drawing.Size(187, 27);
            this.txtONumber.TabIndex = 5;
            // 
            // txtOName
            // 
            this.txtOName.Location = new System.Drawing.Point(228, 140);
            this.txtOName.Name = "txtOName";
            this.txtOName.Size = new System.Drawing.Size(187, 27);
            this.txtOName.TabIndex = 4;
            // 
            // txtOId
            // 
            this.txtOId.Location = new System.Drawing.Point(228, 38);
            this.txtOId.Name = "txtOId";
            this.txtOId.Size = new System.Drawing.Size(100, 27);
            this.txtOId.TabIndex = 3;
            // 
            // txtDNumber
            // 
            this.txtDNumber.Location = new System.Drawing.Point(228, 106);
            this.txtDNumber.Name = "txtDNumber";
            this.txtDNumber.Size = new System.Drawing.Size(100, 27);
            this.txtDNumber.TabIndex = 2;
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(228, 72);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(187, 27);
            this.txtDName.TabIndex = 1;
            // 
            // txtDId
            // 
            this.txtDId.Location = new System.Drawing.Point(228, 5);
            this.txtDId.Name = "txtDId";
            this.txtDId.Size = new System.Drawing.Size(100, 27);
            this.txtDId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Oda Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Oda Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Oda Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Daire Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "DaireAdı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "DaireId:";
            // 
            // dgvDaire
            // 
            this.dgvDaire.AllowUserToAddRows = false;
            this.dgvDaire.AllowUserToDeleteRows = false;
            this.dgvDaire.AllowUserToResizeColumns = false;
            this.dgvDaire.AllowUserToResizeRows = false;
            this.dgvDaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDaire.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DaireId,
            this.DaireAdı,
            this.DaireSayısı,
            this.OdaID,
            this.OdaADI,
            this.OdaSayı});
            this.dgvDaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDaire.Location = new System.Drawing.Point(0, 0);
            this.dgvDaire.MultiSelect = false;
            this.dgvDaire.Name = "dgvDaire";
            this.dgvDaire.ReadOnly = true;
            this.dgvDaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaire.Size = new System.Drawing.Size(830, 184);
            this.dgvDaire.TabIndex = 0;
            this.dgvDaire.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaire_RowEnter);
            // 
            // DaireId
            // 
            this.DaireId.DataPropertyName = "DaireId";
            this.DaireId.HeaderText = "DaireID";
            this.DaireId.Name = "DaireId";
            this.DaireId.ReadOnly = true;
            // 
            // DaireAdı
            // 
            this.DaireAdı.DataPropertyName = "DaireAdı";
            this.DaireAdı.HeaderText = "DaireAdı";
            this.DaireAdı.Name = "DaireAdı";
            this.DaireAdı.ReadOnly = true;
            // 
            // DaireSayısı
            // 
            this.DaireSayısı.DataPropertyName = "DaireSayısı";
            this.DaireSayısı.HeaderText = "DaireSayısı";
            this.DaireSayısı.Name = "DaireSayısı";
            this.DaireSayısı.ReadOnly = true;
            // 
            // OdaID
            // 
            this.OdaID.DataPropertyName = "OdaId";
            this.OdaID.HeaderText = "OdaID";
            this.OdaID.Name = "OdaID";
            this.OdaID.ReadOnly = true;
            // 
            // OdaADI
            // 
            this.OdaADI.DataPropertyName = "OdaAdı";
            this.OdaADI.HeaderText = "OdaADI";
            this.OdaADI.Name = "OdaADI";
            this.OdaADI.ReadOnly = true;
            // 
            // OdaSayı
            // 
            this.OdaSayı.DataPropertyName = "OdaSayısı";
            this.OdaSayı.HeaderText = "OdaSayı";
            this.OdaSayı.Name = "OdaSayı";
            this.OdaSayı.ReadOnly = true;
            // 
            // DaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 464);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DaireForm";
            this.Text = "Daire İşlemleri";
            this.Load += new System.EventHandler(this.DaireForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnİnsert;
        private System.Windows.Forms.TextBox txtONumber;
        private System.Windows.Forms.TextBox txtOName;
        private System.Windows.Forms.TextBox txtOId;
        private System.Windows.Forms.TextBox txtDNumber;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtDId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaireId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaireAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaireSayısı;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdaSayı;
    }
}