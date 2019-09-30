/***
 *     ▄▄▄       ██ ▄█▀ ██▓ ██▓    
 *    ▒████▄     ██▄█▒ ▓██▒▓██▒    
 *    ▒██  ▀█▄  ▓███▄░ ▒██▒▒██░    
 *    ░██▄▄▄▄██ ▓██ █▄ ░██░▒██░    
 *     ▓█   ▓██▒▒██▒ █▄░██░░██████▒
 *     ▒▒   ▓▒█░▒ ▒▒ ▓▒░▓  ░ ▒░▓  ░
 *      ▒   ▒▒ ░░ ░▒ ▒░ ▒ ░░ ░ ▒  ░
 *      ░   ▒   ░ ░░ ░  ▒ ░  ░ ░   
 *          ░  ░░  ░    ░      ░  ░
 *          
 *     For code updates visit repository on https://github.com/sutaj
 */
namespace found.Recovery
{
    partial class frmMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cTopPanel = new System.Windows.Forms.Panel();
            this.lblTotalFileSize = new System.Windows.Forms.Label();
            this.lblFilesCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDelZero = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMove = new System.Windows.Forms.RadioButton();
            this.chkCopy = new System.Windows.Forms.RadioButton();
            this.btnBrowseDest = new System.Windows.Forms.Button();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.txtDestDir = new System.Windows.Forms.TextBox();
            this.txtSourceDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAbout = new System.Windows.Forms.ToolStripStatusLabel();
            this.pBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblSep = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProcessedFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblETA = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtExecTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.mnuOutCont = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportOutputLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgDirScan = new System.ComponentModel.BackgroundWorker();
            this.panelWorking = new System.Windows.Forms.Panel();
            this.picSpiner = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bgProcessFile = new System.ComponentModel.BackgroundWorker();
            this.cTopPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mnuOutCont.SuspendLayout();
            this.panelWorking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpiner)).BeginInit();
            this.SuspendLayout();
            // 
            // cTopPanel
            // 
            this.cTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cTopPanel.Controls.Add(this.lblTotalFileSize);
            this.cTopPanel.Controls.Add(this.lblFilesCount);
            this.cTopPanel.Controls.Add(this.btnStart);
            this.cTopPanel.Controls.Add(this.groupBox1);
            this.cTopPanel.Controls.Add(this.btnBrowseDest);
            this.cTopPanel.Controls.Add(this.btnBrowseSource);
            this.cTopPanel.Controls.Add(this.txtDestDir);
            this.cTopPanel.Controls.Add(this.txtSourceDir);
            this.cTopPanel.Controls.Add(this.label2);
            this.cTopPanel.Controls.Add(this.label1);
            this.cTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cTopPanel.Location = new System.Drawing.Point(3, 3);
            this.cTopPanel.Name = "cTopPanel";
            this.cTopPanel.Size = new System.Drawing.Size(615, 182);
            this.cTopPanel.TabIndex = 0;
            // 
            // lblTotalFileSize
            // 
            this.lblTotalFileSize.AutoSize = true;
            this.lblTotalFileSize.Location = new System.Drawing.Point(12, 158);
            this.lblTotalFileSize.Name = "lblTotalFileSize";
            this.lblTotalFileSize.Size = new System.Drawing.Size(13, 13);
            this.lblTotalFileSize.TabIndex = 8;
            this.lblTotalFileSize.Text = "  ";
            // 
            // lblFilesCount
            // 
            this.lblFilesCount.AutoSize = true;
            this.lblFilesCount.Location = new System.Drawing.Point(12, 135);
            this.lblFilesCount.Name = "lblFilesCount";
            this.lblFilesCount.Size = new System.Drawing.Size(13, 13);
            this.lblFilesCount.TabIndex = 8;
            this.lblFilesCount.Text = "  ";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(529, 135);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 42);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkDelZero);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chkMove);
            this.groupBox1.Controls.Add(this.chkCopy);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 49);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recovery mode";
            // 
            // chkDelZero
            // 
            this.chkDelZero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDelZero.AutoSize = true;
            this.chkDelZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkDelZero.Location = new System.Drawing.Point(477, 19);
            this.chkDelZero.Name = "chkDelZero";
            this.chkDelZero.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDelZero.Size = new System.Drawing.Size(106, 17);
            this.chkDelZero.TabIndex = 3;
            this.chkDelZero.Text = "delete 0 size files";
            this.chkDelZero.UseVisualStyleBackColor = true;
            this.chkDelZero.CheckedChanged += new System.EventHandler(this.ChkDelZero_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "How do you wish to handle files?";
            // 
            // chkMove
            // 
            this.chkMove.AutoSize = true;
            this.chkMove.Location = new System.Drawing.Point(290, 21);
            this.chkMove.Name = "chkMove";
            this.chkMove.Size = new System.Drawing.Size(78, 17);
            this.chkMove.TabIndex = 1;
            this.chkMove.Text = "Move them";
            this.chkMove.UseVisualStyleBackColor = true;
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Checked = true;
            this.chkCopy.Location = new System.Drawing.Point(187, 21);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(75, 17);
            this.chkCopy.TabIndex = 0;
            this.chkCopy.TabStop = true;
            this.chkCopy.Text = "Copy them";
            this.chkCopy.UseVisualStyleBackColor = true;
            // 
            // btnBrowseDest
            // 
            this.btnBrowseDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDest.Location = new System.Drawing.Point(529, 49);
            this.btnBrowseDest.Name = "btnBrowseDest";
            this.btnBrowseDest.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDest.TabIndex = 4;
            this.btnBrowseDest.Text = "Browse";
            this.btnBrowseDest.UseVisualStyleBackColor = true;
            this.btnBrowseDest.Click += new System.EventHandler(this.BtnBrowseDest_Click);
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSource.Location = new System.Drawing.Point(529, 13);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.BtnBrowseSource_Click);
            // 
            // txtDestDir
            // 
            this.txtDestDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDestDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtDestDir.Location = new System.Drawing.Point(124, 51);
            this.txtDestDir.Name = "txtDestDir";
            this.txtDestDir.Size = new System.Drawing.Size(399, 20);
            this.txtDestDir.TabIndex = 3;
            this.txtDestDir.Leave += new System.EventHandler(this.TxtDestDir_Leave);
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSourceDir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtSourceDir.Location = new System.Drawing.Point(124, 15);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.Size = new System.Drawing.Size(399, 20);
            this.txtSourceDir.TabIndex = 1;
            this.txtSourceDir.Leave += new System.EventHandler(this.TxtSourceDir_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destination directory:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source directory:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAbout,
            this.pBar,
            this.lblSep,
            this.lblProcessedFiles,
            this.lblETA,
            this.txtExecTime});
            this.statusStrip1.Location = new System.Drawing.Point(3, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(615, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblAbout
            // 
            this.lblAbout.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblAbout.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(22, 19);
            this.lblAbout.Text = " ? ";
            this.lblAbout.Click += new System.EventHandler(this.LblAbout_Click);
            // 
            // pBar
            // 
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(250, 18);
            this.pBar.Step = 1;
            this.pBar.Visible = false;
            // 
            // lblSep
            // 
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(16, 19);
            this.lblSep.Text = "   ";
            this.lblSep.Visible = false;
            // 
            // lblProcessedFiles
            // 
            this.lblProcessedFiles.Name = "lblProcessedFiles";
            this.lblProcessedFiles.Size = new System.Drawing.Size(113, 19);
            this.lblProcessedFiles.Text = "Processed {0} files.  |";
            this.lblProcessedFiles.Visible = false;
            // 
            // lblETA
            // 
            this.lblETA.Name = "lblETA";
            this.lblETA.Size = new System.Drawing.Size(26, 19);
            this.lblETA.Text = "ETA";
            this.lblETA.Visible = false;
            // 
            // txtExecTime
            // 
            this.txtExecTime.Name = "txtExecTime";
            this.txtExecTime.Size = new System.Drawing.Size(0, 19);
            this.txtExecTime.Visible = false;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.ContextMenuStrip = this.mnuOutCont;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(3, 185);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(615, 273);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.TabStop = false;
            this.txtOutput.WordWrap = false;
            // 
            // mnuOutCont
            // 
            this.mnuOutCont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportOutputLogToolStripMenuItem});
            this.mnuOutCont.Name = "mnuOutCont";
            this.mnuOutCont.Size = new System.Drawing.Size(168, 26);
            // 
            // exportOutputLogToolStripMenuItem
            // 
            this.exportOutputLogToolStripMenuItem.Name = "exportOutputLogToolStripMenuItem";
            this.exportOutputLogToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exportOutputLogToolStripMenuItem.Text = "Export output log";
            this.exportOutputLogToolStripMenuItem.Click += new System.EventHandler(this.ExportOutputLogToolStripMenuItem_Click);
            // 
            // bgDirScan
            // 
            this.bgDirScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgScan_DoWork);
            this.bgDirScan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgScan_RunWorkerCompleted);
            // 
            // panelWorking
            // 
            this.panelWorking.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWorking.Controls.Add(this.picSpiner);
            this.panelWorking.Controls.Add(this.label4);
            this.panelWorking.Location = new System.Drawing.Point(19, 386);
            this.panelWorking.Name = "panelWorking";
            this.panelWorking.Size = new System.Drawing.Size(584, 71);
            this.panelWorking.TabIndex = 3;
            this.panelWorking.Visible = false;
            // 
            // picSpiner
            // 
            this.picSpiner.Location = new System.Drawing.Point(14, 3);
            this.picSpiner.Name = "picSpiner";
            this.picSpiner.Size = new System.Drawing.Size(56, 64);
            this.picSpiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSpiner.TabIndex = 1;
            this.picSpiner.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(567, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "Scanning selected directory.\r\nPlease wait...";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bgProcessFile
            // 
            this.bgProcessFile.WorkerReportsProgress = true;
            this.bgProcessFile.WorkerSupportsCancellation = true;
            this.bgProcessFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgProcessFile_DoWork);
            this.bgProcessFile.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgProcessFile_ProgressChanged);
            this.bgProcessFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgProcessFile_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 485);
            this.Controls.Add(this.panelWorking);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cTopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "found.Recovery  {0}  »  https://github.com/sutaj";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.cTopPanel.ResumeLayout(false);
            this.cTopPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnuOutCont.ResumeLayout(false);
            this.panelWorking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSpiner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel cTopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestDir;
        private System.Windows.Forms.TextBox txtSourceDir;
        private System.Windows.Forms.Button btnBrowseDest;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chkMove;
        private System.Windows.Forms.RadioButton chkCopy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFilesCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pBar;
        private System.Windows.Forms.ToolStripStatusLabel lblProcessedFiles;
        private System.Windows.Forms.ToolStripStatusLabel lblETA;
        private System.Windows.Forms.Label lblTotalFileSize;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ToolStripStatusLabel lblSep;
        private System.Windows.Forms.ToolStripStatusLabel txtExecTime;
        private System.ComponentModel.BackgroundWorker bgDirScan;
        private System.Windows.Forms.Panel panelWorking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picSpiner;
        private System.ComponentModel.BackgroundWorker bgProcessFile;
        private System.Windows.Forms.CheckBox chkDelZero;
        private System.Windows.Forms.ContextMenuStrip mnuOutCont;
        private System.Windows.Forms.ToolStripMenuItem exportOutputLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblAbout;
    }
}

