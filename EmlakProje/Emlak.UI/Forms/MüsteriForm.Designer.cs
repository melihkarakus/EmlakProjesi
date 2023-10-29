namespace Emlak.UI.Forms
{
    partial class MüsteriForm
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
            this.txtMEmail = new System.Windows.Forms.TextBox();
            this.txtMTc = new System.Windows.Forms.TextBox();
            this.txtMSurname = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtMId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMüsteri = new System.Windows.Forms.DataGridView();
            this.MüsterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MüsteriAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MüsteriSoyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MüsteriTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MüsteriEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMüsteri)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.BtnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.BtnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.BtnInsert);
            this.splitContainer1.Panel1.Controls.Add(this.txtMEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtMTc);
            this.splitContainer1.Panel1.Controls.Add(this.txtMSurname);
            this.splitContainer1.Panel1.Controls.Add(this.txtMName);
            this.splitContainer1.Panel1.Controls.Add(this.txtMId);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMüsteri);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(765, 463);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtMEmail
            // 
            this.txtMEmail.Location = new System.Drawing.Point(185, 151);
            this.txtMEmail.Name = "txtMEmail";
            this.txtMEmail.Size = new System.Drawing.Size(156, 27);
            this.txtMEmail.TabIndex = 4;
            // 
            // txtMTc
            // 
            this.txtMTc.Location = new System.Drawing.Point(185, 118);
            this.txtMTc.Name = "txtMTc";
            this.txtMTc.Size = new System.Drawing.Size(156, 27);
            this.txtMTc.TabIndex = 3;
            // 
            // txtMSurname
            // 
            this.txtMSurname.Location = new System.Drawing.Point(185, 85);
            this.txtMSurname.Name = "txtMSurname";
            this.txtMSurname.Size = new System.Drawing.Size(156, 27);
            this.txtMSurname.TabIndex = 2;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(185, 52);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(156, 27);
            this.txtMName.TabIndex = 1;
            // 
            // txtMId
            // 
            this.txtMId.Location = new System.Drawing.Point(185, 19);
            this.txtMId.Name = "txtMId";
            this.txtMId.Size = new System.Drawing.Size(100, 27);
            this.txtMId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "MüsterEmail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "MüsteriTC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "MüsteriSoyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müster Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgvMüsteri
            // 
            this.dgvMüsteri.AllowUserToAddRows = false;
            this.dgvMüsteri.AllowUserToDeleteRows = false;
            this.dgvMüsteri.AllowUserToResizeColumns = false;
            this.dgvMüsteri.AllowUserToResizeRows = false;
            this.dgvMüsteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMüsteri.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMüsteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMüsteri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MüsterId,
            this.MüsteriAd,
            this.MüsteriSoyadı,
            this.MüsteriTC,
            this.MüsteriEmail});
            this.dgvMüsteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMüsteri.Location = new System.Drawing.Point(0, 0);
            this.dgvMüsteri.MultiSelect = false;
            this.dgvMüsteri.Name = "dgvMüsteri";
            this.dgvMüsteri.ReadOnly = true;
            this.dgvMüsteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMüsteri.Size = new System.Drawing.Size(765, 241);
            this.dgvMüsteri.TabIndex = 0;
            this.dgvMüsteri.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMüsteri_RowEnter);
            // 
            // MüsterId
            // 
            this.MüsterId.DataPropertyName = "MüsteriId";
            this.MüsterId.HeaderText = "Müsteri ID";
            this.MüsterId.Name = "MüsterId";
            this.MüsterId.ReadOnly = true;
            // 
            // MüsteriAd
            // 
            this.MüsteriAd.DataPropertyName = "MüsteriAdı";
            this.MüsteriAd.HeaderText = "MüsterAdı";
            this.MüsteriAd.Name = "MüsteriAd";
            this.MüsteriAd.ReadOnly = true;
            // 
            // MüsteriSoyadı
            // 
            this.MüsteriSoyadı.DataPropertyName = "MüsteriSoyadı";
            this.MüsteriSoyadı.HeaderText = "MüsteriSoyad";
            this.MüsteriSoyadı.Name = "MüsteriSoyadı";
            this.MüsteriSoyadı.ReadOnly = true;
            // 
            // MüsteriTC
            // 
            this.MüsteriTC.DataPropertyName = "MüsteriTc";
            this.MüsteriTC.HeaderText = "MüsteriTc";
            this.MüsteriTC.Name = "MüsteriTC";
            this.MüsteriTC.ReadOnly = true;
            // 
            // MüsteriEmail
            // 
            this.MüsteriEmail.DataPropertyName = "MüsteriMail";
            this.MüsteriEmail.HeaderText = "MüsteriEmail";
            this.MüsteriEmail.Name = "MüsteriEmail";
            this.MüsteriEmail.ReadOnly = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Image = global::Emlak.UI.Properties.Resources.refresh;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(427, 132);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(90, 46);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Emlak.UI.Properties.Resources.stop__1_;
            this.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDelete.Location = new System.Drawing.Point(427, 86);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 40);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Image = global::Emlak.UI.Properties.Resources.insert;
            this.BtnInsert.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnInsert.Location = new System.Drawing.Point(427, 42);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(90, 37);
            this.BtnInsert.TabIndex = 5;
            this.BtnInsert.Text = "Ekle";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // MüsteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 463);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MüsteriForm";
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MüsteriForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMüsteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.TextBox txtMEmail;
        private System.Windows.Forms.TextBox txtMTc;
        private System.Windows.Forms.TextBox txtMSurname;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtMId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMüsteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MüsterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MüsteriAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MüsteriSoyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn MüsteriTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MüsteriEmail;
    }
}