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
            this.tableSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.White;
            this.btnLoadData.Location = new System.Drawing.Point(884, 41);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(108, 25);
            this.btnLoadData.TabIndex = 0;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(189, 41);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.MaxLength = 256;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(685, 22);
            this.txtPath.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.White;
            this.btnSelectFile.Location = new System.Drawing.Point(73, 41);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(108, 25);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.BackColor = System.Drawing.Color.Black;
            this.txtQuery.ForeColor = System.Drawing.Color.White;
            this.txtQuery.Location = new System.Drawing.Point(73, 171);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuery.MaxLength = 150;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(685, 102);
            this.txtQuery.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(768, 207);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(108, 25);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgvAdminData
            // 
            this.dgvAdminData.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAdminData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminData.GridColor = System.Drawing.Color.White;
            this.dgvAdminData.Location = new System.Drawing.Point(16, 282);
            this.dgvAdminData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAdminData.Name = "dgvAdminData";
            this.dgvAdminData.Size = new System.Drawing.Size(1247, 334);
            this.dgvAdminData.TabIndex = 6;
            // 
            // btnAdminLogOut
            // 
            this.btnAdminLogOut.BackColor = System.Drawing.Color.White;
            this.btnAdminLogOut.Location = new System.Drawing.Point(1121, 41);
            this.btnAdminLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminLogOut.Name = "btnAdminLogOut";
            this.btnAdminLogOut.Size = new System.Drawing.Size(141, 49);
            this.btnAdminLogOut.TabIndex = 7;
            this.btnAdminLogOut.Text = "Log Out";
            this.btnAdminLogOut.UseVisualStyleBackColor = false;
            this.btnAdminLogOut.Click += new System.EventHandler(this.btnAdminLogOut_Click);
            // 
            // tableSelector
            // 
            this.tableSelector.FormattingEnabled = true;
            this.tableSelector.Items.AddRange(new object[] {
            "matches",
            "players",
            "teams"});
            this.tableSelector.Location = new System.Drawing.Point(1000, 41);
            this.tableSelector.Name = "tableSelector";
            this.tableSelector.Size = new System.Drawing.Size(121, 24);
            this.tableSelector.TabIndex = 8;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1279, 630);
            this.Controls.Add(this.tableSelector);
            this.Controls.Add(this.btnAdminLogOut);
            this.Controls.Add(this.dgvAdminData);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnLoadData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox tableSelector;
    }
}