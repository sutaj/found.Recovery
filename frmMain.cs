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
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static found.Recovery.Code;

/*
           *** SORRY, NO COMMENT YET IN CODE ***
        *** WILL ADD COMMENTS LATER, FOR NOW ENJOY ***
               *** and rescue your files! ***
*/

namespace found.Recovery
{
    public partial class frmMain : Form
    {
        #region [ PINVOKE ]
        public const Int32 WM_SYSCOMMAND = 0x112;
        public const Int32 MF_BYPOSITION = 0x400;
        public const Int32 MNU_ABOUT = 1000;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern bool InsertMenu(IntPtr hMenu, Int32 wPosition, Int32 wFlags, Int32 wIDNewItem, string lpNewItem);

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND)
            {
                switch (msg.WParam.ToInt32())
                {
                    case MNU_ABOUT:
                        new frmAbout().ShowDialog(this);
                        return;
                    default:
                        break;
                }
            }
            base.WndProc(ref msg);
        }
        #endregion

        FolderBrowserDialog fDlgSource = new FolderBrowserDialog();
        FolderBrowserDialog fDlgDest = new FolderBrowserDialog();
        Timer spinAnim = new Timer();
        Timer bgTicker = new Timer(); 
        float _angle = 0;

        int _total = 0;
        int _done = 0;
        int _good = 0;

        public frmMain()
        {
            InitializeComponent();
            spinAnim.Interval = 50;
            spinAnim.Tick += AnimFrame;
            bgTicker.Interval = 250;
            bgTicker.Tick += bgTick;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IntPtr MenuHandle = GetSystemMenu(this.Handle, false);
            InsertMenu(MenuHandle, 5, MF_BYPOSITION, MNU_ABOUT, "About...");
            Text = string.Format(Text, Application.ProductVersion);
            fDlgSource.Description = "Select directory with chk files";
            fDlgSource.ShowNewFolderButton = false;
            fDlgDest.Description = "Select destination directory";
            txtOutput.Font = Program.cascadia;
            bgTicker.Start();
            fixPanelPos();
        }

        private void _validateSource(string dir)
        {
            if (Directory.Exists(dir))
            {
                this.Invoke((Action)delegate{
                txtSourceDir.Text = dir; });
                ScanDirectory(dir);
                this.Invoke((Action)delegate
                {
                    btnStart.Enabled = true;
                    lblFilesCount.Text = $"Found {FileScanResult.Length} files.";
                    lblTotalFileSize.Text = $"Total size: {ParseFileSizes(ScanSize)}.";
                    txtExecTime.Text = $"Last task execution time: {TimeSpan.FromMilliseconds(TimeElpased).TotalSeconds}sec";
                });
            }
            else
            {
                this.Invoke((Action)delegate
                {
                    txtSourceDir.Text = string.Empty;
                    btnStart.Enabled = false;
                    MessageBox.Show($"Selected directory ({dir}) does not exists.{Environment.NewLine}" +
                        $"Please check it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                });
            }
        }

        private void BgProcessFile_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                txtOutput.ResetText();
                lblProcessedFiles.Visible = true;
                lblETA.Visible = true;
                lblProcessedFiles.Text = string.Empty;
                lblETA.Text = string.Empty;
                pBar.Visible = true;
            });


            FileTypeChecker fileChecker = new FileTypeChecker();
            _total = FileScanResult.Length;
            _sw.Reset();
            _sw.Start();
            foreach (string item in FileScanResult)
            {
                _done++;
                if (bgProcessFile.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    if (chkDelZero.Checked && new FileInfo(item).Length < 1)
                    {
                        File.Delete(item);
                    }
                    else
                    {

                        using (FileStream fileStream = File.OpenRead(item))
                        {
                            FileType result = fileChecker.GetFileType(fileStream);
                            bgProcessFile.ReportProgress(CalculateProgresPercentage(_done, _total));
                            this.Invoke((Action)delegate
                            {
                                lblProcessedFiles.Text = $"Processed {_done} / {_total} files ({CalculateProgresPercentage(_done, _total)}%)";
                            });

                            if (result != FileType.Unknown)
                            {
                                _good++;
                                this.Invoke((Action)delegate
                                {
                                    txtOutput.AppendText($"{PrintTS()}{Path.GetFileName(item)} is {result.Name}.{Environment.NewLine}");
                                });
                                if (chkCopy.Checked)
                                {
                                    this.Invoke((Action)delegate
                                    {
                                        txtOutput.AppendText($"\t[copy] {item}  ==>  {Path.Combine(DestinationFolder, Path.GetFileName(item).Replace(Path.GetExtension(item), result.Extension))}.{Environment.NewLine}");
                                    });
                                    CopyFile(item, $"{Path.Combine(DestinationFolder, Path.GetFileName(item).Replace(Path.GetExtension(item), result.Extension))}");
                                }
                                else
                                {
                                    this.Invoke((Action)delegate
                                    {
                                        txtOutput.AppendText($"\t[move] {item}  ==>  {Path.Combine(DestinationFolder, Path.GetFileName(item).Replace(Path.GetExtension(item), result.Extension))}.{Environment.NewLine}");
                                    });
                                    //MoveFile(item, $"{Path.Combine(DestinationFolder, Path.GetFileName(item).Replace(Path.GetExtension(item), result.Extension))}");
                                    CopyFile(item, $"{Path.Combine(DestinationFolder, Path.GetFileName(item).Replace(Path.GetExtension(item), result.Extension))}");
                                }
                            }
                            else
                            {
                                this.Invoke((Action)delegate
                                {
                                    txtOutput.AppendText($"{PrintTS()}{Path.GetFileName(item)} cannot be recognized (maybe text file?){Environment.NewLine}");
                                });
                                if (chkCopy.Checked)
                                {
                                    this.Invoke((Action)delegate
                                    {
                                        txtOutput.AppendText($"\t[copy] {item}  ==>  {Path.Combine(DestinationFolder, Path.GetFileName(item))}.{Environment.NewLine}");
                                    });
                                    CopyFile(item, $"{Path.Combine(DestinationFolder, Path.GetFileName(item))}", true);
                                }
                                else
                                {
                                    this.Invoke((Action)delegate
                                    {
                                        txtOutput.AppendText($"\t[move] {item}  ==>  {Path.Combine(DestinationFolder, Path.GetFileName(item))}.{Environment.NewLine}");
                                    });
                                    //MoveFile(item, $"{Path.Combine(DestinationFolder, Path.GetFileName(item))}", true);
                                    CopyFile(item, $"{Path.Combine(DestinationFolder, Path.GetFileName(item))}", true);
                                }
                            }
                        }
                    }
                }
            }

            _sw.Stop();
            this.Invoke((Action)delegate
            {
                txtExecTime.Text = $"Last task execution time: " +
                $"{TimeSpan.FromMilliseconds(TimeElpased).Minutes}min " +
                $"{TimeSpan.FromMilliseconds(TimeElpased).Seconds}sec";
            });
        }

        private void BgProcessFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtOutput.AppendText($"{Environment.NewLine}-----------------------------------------{Environment.NewLine}" +
                $"Total processed files {_done} in { decimal.Round((decimal)_sw.Elapsed.TotalMinutes, 3)} minute(s).{Environment.NewLine}" +
                $"Recognized {_good} files, {(_total - _good)} are still unknown.");
            lblETA.Visible = false;
            _done = 0;
            _sw.Reset();
            ToggleElements();
            btnStart.Text = "START";
            txtExecTime.Text = $"Last task execution time: {TimeSpan.FromMilliseconds(TimeElpased).TotalSeconds}sec";

            // "move file" workaround...
            if (chkMove.Checked)
            {
                foreach (string item in FileScanResult)
                {
                    try
                    {
                        File.Delete(item);
                    }
                    catch { }
                }
            }

        }

        #region [ SMALL CODE ]

        private void BgScan_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                btnStart.Enabled = false;
            });
            _validateSource((string)e.Argument);
        }

        private void BgScan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _angle = 0;
            spinAnim.Stop();
            panelWorking.Visible = false;
            this.Invoke((Action)delegate
            {
                btnStart.Enabled = true;
            });
        }

        private void BgProcessFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                pBar.Value = e.ProgressPercentage;
            });
        }

        private void TxtSourceDir_Leave(object sender, EventArgs e)
        {
            if (txtSourceDir.Text.Length > 5 && txtSourceDir.Text != SourceFolder)
            {
                string _pth = txtSourceDir.Text.EndsWith(@"\") ? txtSourceDir.Text : $@"{txtSourceDir.Text}\";
                spinAnim.Start();
                panelWorking.Visible = true;
                bgDirScan.RunWorkerAsync(_pth);
            }
        }

        private void TxtDestDir_Leave(object sender, EventArgs e)
        {
            if(txtDestDir.Text.Length > 5)
            {
                string _pth = txtDestDir.Text.EndsWith(@"\") ? txtDestDir.Text : $@"{txtDestDir.Text}\";
                //DestinationFolder = _pth;
                if (!Directory.Exists(_pth))
                {
                    MessageBox.Show($"Selected directory ({_pth}) does not exists.{Environment.NewLine}" +
                        $"Please check it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DestinationFolder = _pth;
                }
            }
        }

        private void AnimFrame(object sender, EventArgs e)
        {
            picSpiner.Image = SpinnMeAround(_angle);

            if (_angle >= 360)
            {
                _angle = 0;
            }
            _angle += 18;
        }

        private void ToggleElements()
        {
            pBar.Visible = !pBar.Visible;
            lblSep.Visible = !lblSep.Visible;
            txtDestDir.Enabled = !txtDestDir.Enabled;
            txtSourceDir.Enabled = !txtSourceDir.Enabled;
            btnBrowseDest.Enabled = !btnBrowseDest.Enabled;
            btnBrowseSource.Enabled = !btnBrowseSource.Enabled;
            chkCopy.Enabled = !chkCopy.Enabled;
            chkMove.Enabled = !chkMove.Enabled;
            chkDelZero.Enabled = !chkDelZero.Enabled;
            btnStart.Enabled = !btnStart.Enabled;
        }

        private void fixPanelPos()
        {
            panelWorking.Location = new Point((Width - panelWorking.Width) / 2 - Padding.Horizontal, (Height - panelWorking.Height) / 2);
        }
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            fixPanelPos();
        }

        private void bgTick(object sender, EventArgs e)
        {
            if (bgProcessFile.IsBusy)
            {
                if (_sw.Elapsed.TotalSeconds >= 5) // let it set for 5 sec...
                {
                    double _s = CalculateETA(_sw.Elapsed, _done, _total);
                    lblETA.Text = $"ETA: {TimeSpan.FromSeconds(_s).Minutes}min {TimeSpan.FromSeconds(_s).Seconds}sec";
                }
                else
                {
                    lblETA.Text = "ETA: calculating...";
                }
                mnuOutCont.Enabled = false;
            }
            else
            {
                mnuOutCont.Enabled = true;
            }

            if(txtDestDir.Text.Length > 5 && txtSourceDir.Text.Length > 5)
            {
                if (Directory.Exists(txtDestDir.Text) && Directory.Exists(txtSourceDir.Text) && !bgDirScan.IsBusy)
                {
                    if(btnStart.Enabled == false)
                    btnStart.Enabled = true;
                }
                else
                {
                    if(btnStart.Enabled == true)
                    btnStart.Enabled = false;
                }
            }
            else
            {
                if (btnStart.Enabled == true)
                    btnStart.Enabled = false;

            }
        }

        #endregion

        #region [ CONTROLS CLICKS ]
        private void BtnStart_Click(object sender, EventArgs e)
        {
            ToggleElements();

            if(btnStart.Text == "START")
            {
                btnStart.Text = "STOP";
                bgProcessFile.RunWorkerAsync();
            }
            else if(btnStart.Text == "STOP")
            {
                btnStart.Text = "START";
                bgProcessFile.CancelAsync();
            }
            
        }

        private void ChkDelZero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDelZero.Checked)
            {
                if (MessageBox.Show($"This option will delete all 0b size files.{Environment.NewLine}Are you sure?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    chkDelZero.Checked = false;
                }
            }
        }

        private void BtnBrowseSource_Click(object sender, EventArgs e)
        {
            if (fDlgSource.ShowDialog() == DialogResult.OK)
            {
                panelWorking.Visible = true;
                spinAnim.Start();
                bgDirScan.RunWorkerAsync(fDlgSource.SelectedPath);
            }
        }

        private void BtnBrowseDest_Click(object sender, EventArgs e)
        {
            if (fDlgDest.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(fDlgDest.SelectedPath))
                {
                    txtDestDir.Text = fDlgDest.SelectedPath.EndsWith(@"\") ? fDlgDest.SelectedPath : $@"{fDlgDest.SelectedPath}\";
                    DestinationFolder = txtDestDir.Text;
                }
                else
                {
                    MessageBox.Show($"Selected directory ({fDlgDest.SelectedPath}) does not exists.{Environment.NewLine}" +
                        $"Please check it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ExportOutputLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file|*.txt";
            saveFileDialog.Title = "Export output log";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.ShowHelp = false;

            if(saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, txtOutput.Text);
            }
        }

        private void LblAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog(this);
        }

        #endregion

    }
}
