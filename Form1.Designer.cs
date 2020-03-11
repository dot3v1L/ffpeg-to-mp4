namespace ffpeg_to_mp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tFolderFile = new System.Windows.Forms.TextBox();
            this.bFolder = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tFolderSave = new System.Windows.Forms.TextBox();
            this.bConvert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSuccess = new System.Windows.Forms.ToolStripStatusLabel();
            this.tLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.tProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tFolderFile
            // 
            this.tFolderFile.Location = new System.Drawing.Point(12, 15);
            this.tFolderFile.Name = "tFolderFile";
            this.tFolderFile.Size = new System.Drawing.Size(205, 20);
            this.tFolderFile.TabIndex = 0;
            // 
            // bFolder
            // 
            this.bFolder.Location = new System.Drawing.Point(223, 13);
            this.bFolder.Name = "bFolder";
            this.bFolder.Size = new System.Drawing.Size(75, 23);
            this.bFolder.TabIndex = 1;
            this.bFolder.Text = "Add";
            this.bFolder.UseVisualStyleBackColor = true;
            this.bFolder.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(223, 39);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tFolderSave
            // 
            this.tFolderSave.Location = new System.Drawing.Point(12, 41);
            this.tFolderSave.Name = "tFolderSave";
            this.tFolderSave.Size = new System.Drawing.Size(205, 20);
            this.tFolderSave.TabIndex = 2;
            // 
            // bConvert
            // 
            this.bConvert.Location = new System.Drawing.Point(10, 322);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(286, 23);
            this.bConvert.TabIndex = 4;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.Button3_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tFiles,
            this.tSuccess,
            this.tLeft,
            this.tProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(308, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tFiles
            // 
            this.tFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tFiles.Name = "tFiles";
            this.tFiles.Size = new System.Drawing.Size(44, 17);
            this.tFiles.Text = "Files: 0";
            // 
            // tSuccess
            // 
            this.tSuccess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tSuccess.Name = "tSuccess";
            this.tSuccess.Size = new System.Drawing.Size(63, 17);
            this.tSuccess.Text = "Success: 0";
            // 
            // tLeft
            // 
            this.tLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tLeft.Name = "tLeft";
            this.tLeft.Size = new System.Drawing.Size(43, 17);
            this.tLeft.Text = "Left: 0";
            // 
            // tProgress
            // 
            this.tProgress.Name = "tProgress";
            this.tProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(298, 249);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "File";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 374);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tFolderSave);
            this.Controls.Add(this.bFolder);
            this.Controls.Add(this.tFolderFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ffpeg to mp4";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tFolderFile;
        private System.Windows.Forms.Button bFolder;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tFolderSave;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tFiles;
        private System.Windows.Forms.ToolStripStatusLabel tSuccess;
        private System.Windows.Forms.ToolStripStatusLabel tLeft;
        private System.Windows.Forms.ToolStripProgressBar tProgress;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

