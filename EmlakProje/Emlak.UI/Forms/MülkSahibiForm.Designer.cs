namespace Emlak.UI.Forms
{
    partial class MülkSahibiForm
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.txtSTc = new System.Windows.Forms.TextBox();
            this.txtSaSoyadı = new System.Windows.Forms.TextBox();
            this.txtSAdı = new System.Windows.Forms.TextBox();
            this.txtSId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMülkSahibi = new System.Windows.Forms.DataGridView();
            this.MülkSahibiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MülkSahibiAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MülkSahibiSoyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MülkSahibiTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MülkSahibiEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMülkSahibi)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.btnInsert);
            this.splitContainer1.Panel1.Controls.Add(this.txtSEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtSTc);
            this.splitContainer1.Panel1.Controls.Add(this.txtSaSoyadı);
            this.splitContainer1.Panel1.Controls.Add(this.txtSAdı);
            this.splitContainer1.Panel1.Controls.Add(this.txtSId);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMülkSahibi);
            this.splitContainer1.Size = new System.Drawing.Size(803, 441);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Image = global::Emlak.UI.Properties.Resources.refresh;
            this.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnUpdate.Location = new System.Drawing.Point(517, 114);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(92, 34);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Emlak.UI.Properties.Resources.stop__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDelete.Location = new System.Drawing.Point(517, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Image = global::Emlak.UI.Properties.Resources.insert;
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInsert.Location = new System.Drawing.Point(517, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 34);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(227, 146);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(212, 27);
            this.txtSEmail.TabIndex = 4;
            // 
            // txtSTc
            // 
            this.txtSTc.Location = new System.Drawing.Point(227, 111);
            this.txtSTc.Name = "txtSTc";
            this.txtSTc.Size = new System.Drawing.Size(212, 27);
            this.txtSTc.TabIndex = 3;
            // 
            // txtSaSoyadı
            // 
            this.txtSaSoyadı.Location = new System.Drawing.Point(227, 77);
            this.txtSaSoyadı.Name = "txtSaSoyadı";
            this.txtSaSoyadı.Size = new System.Drawing.Size(212, 27);
            this.txtSaSoyadı.TabIndex = 2;
            // 
            // txtSAdı
            // 
            this.txtSAdı.Location = new System.Drawing.Point(227, 43);
            this.txtSAdı.Name = "txtSAdı";
            this.txtSAdı.Size = new System.Drawing.Size(212, 27);
            this.txtSAdı.TabIndex = 1;
            // 
            // txtSId
            // 
            this.txtSId.Location = new System.Drawing.Point(227, 10);
            this.txtSId.Name = "txtSId";
            this.txtSId.Size = new System.Drawing.Size(100, 27);
            this.txtSId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mülk Sahibi Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mülk Sahibi Tc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mülk Sahibi Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mülk Sahibi Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mülk Sahibi Id:";
            // 
            // dgvMülkSahibi
            // 
            this.dgvMülkSahibi.AllowUserToAddRows = false;
            this.dgvMülkSahibi.AllowUserToDeleteRows = false;
            this.dgvMülkSahibi.AllowUserToResizeColumns = false;
            this.dgvMülkSahibi.AllowUserToResizeRows = false;
            this.dgvMülkSahibi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMülkSahibi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvMülkSahibi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMülkSahibi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MülkSahibiId,
            this.MülkSahibiAdı,
            this.MülkSahibiSoyadı,
            this.MülkSahibiTc,
            this.MülkSahibiEmail});
            this.dgvMülkSahibi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMülkSahibi.Location = new System.Drawing.Point(0, 0);
            this.dgvMülkSahibi.MultiSelect = false;
            this.dgvMülkSahibi.Name = "dgvMülkSahibi";
            this.dgvMülkSahibi.ReadOnly = true;
            this.dgvMülkSahibi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMülkSahibi.Size = new System.Drawing.Size(803, 220);
            this.dgvMülkSahibi.TabIndex = 0;
            this.dgvMülkSahibi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMülkSahibi_RowEnter);
            // 
            // MülkSahibiId
            // 
            this.MülkSahibiId.DataPropertyName = "SahipId";
            this.MülkSahibiId.HeaderText = "Mülk Sahibi Id";
            this.MülkSahibiId.Name = "MülkSahibiId";
            this.MülkSahibiId.ReadOnly = true;
            // 
            // MülkSahibiAdı
            // 
            this.MülkSahibiAdı.DataPropertyName = "SahipAdı";
            this.MülkSahibiAdı.HeaderText = "Mülk Sahibi Adı";
            this.MülkSahibiAdı.Name = "MülkSahibiAdı";
            this.MülkSahibiAdı.ReadOnly = true;
            // 
            // MülkSahibiSoyadı
            // 
            this.MülkSahibiSoyadı.DataPropertyName = "SahipSoyadı";
            this.MülkSahibiSoyadı.HeaderText = "Mülk Sahibi Soyadı";
            this.MülkSahibiSoyadı.Name = "MülkSahibiSoyadı";
            this.MülkSahibiSoyadı.ReadOnly = true;
            // 
            // MülkSahibiTc
            // 
            this.MülkSahibiTc.DataPropertyName = "SahipTc";
            this.MülkSahibiTc.HeaderText = "Mülk Sahibi Tc";
            this.MülkSahibiTc.Name = "MülkSahibiTc";
            this.MülkSahibiTc.ReadOnly = true;
            // 
            // MülkSahibiEmail
            // 
            this.MülkSahibiEmail.DataPropertyName = "SahipEmail";
            this.MülkSahibiEmail.HeaderText = "MülkSahibiEmail";
            this.MülkSahibiEmail.Name = "MülkSahibiEmail";
            this.MülkSahibiEmail.ReadOnly = true;
            // 
            // MülkSahibiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 441);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MülkSahibiForm";
            this.Text = "Mülk Sahibi İşlemleri";
            this.Load += new System.EventHandler(this.MülkSahibiForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMülkSahibi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMülkSahibi;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.TextBox txtSTc;
        private System.Windows.Forms.TextBox txtSaSoyadı;
        private System.Windows.Forms.TextBox txtSAdı;
        private System.Windows.Forms.TextBox txtSId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MülkSahibiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MülkSahibiAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn MülkSahibiSoyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn MülkSahibiTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MülkSahibiEmail;
    }
}