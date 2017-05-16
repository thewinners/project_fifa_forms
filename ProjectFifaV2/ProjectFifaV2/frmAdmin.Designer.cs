namespace ProjectFifaV2
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.btnLoadData = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.dgvAdminData = new System.Windows.Forms.DataGridView();
            this.btnAdminLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(884, 41);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(108, 25);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(189, 41);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPath.MaxLength = 256;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(685, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(73, 41);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(108, 25);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(73, 171);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuery.MaxLength = 150;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(685, 102);
            this.txtQuery.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(768, 207);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(108, 25);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgvAdminData
            // 
            this.dgvAdminData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminData.Location = new System.Drawing.Point(16, 282);
            this.dgvAdminData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAdminData.Name = "dgvAdminData";
            this.dgvAdminData.Size = new System.Drawing.Size(1247, 334);
            this.dgvAdminData.TabIndex = 6;
            // 
            // btnAdminLogOut
            // 
            this.btnAdminLogOut.Location = new System.Drawing.Point(1121, 41);
            this.btnAdminLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminLogOut.Name = "btnAdminLogOut";
            this.btnAdminLogOut.Size = new System.Drawing.Size(141, 49);
            this.btnAdminLogOut.TabIndex = 7;
            this.btnAdminLogOut.Text = "Log Out";
            this.btnAdminLogOut.UseVisualStyleBackColor = true;
            this.btnAdminLogOut.Click += new System.EventHandler(this.btnAdminLogOut_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 630);
            this.Controls.Add(this.btnAdminLogOut);
            this.Controls.Add(this.dgvAdminData);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLoadData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dgvAdminData;
        private System.Windows.Forms.Button btnAdminLogOut;
    }
}