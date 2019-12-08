using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using BRY;

using Codeplex.Data;
/// <summary>
/// 基本となるアプリのスケルトン
/// </summary>
namespace IPSDecoder
{
    public partial class Form1 : Form
    {
        //-------------------------------------------------------------
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            btnToJson.AllowDrop = true;
        }
        /// <summary>
        /// コントロールの初期化はこっちでやる
        /// </summary>
        protected override void InitLayout()
        {
            base.InitLayout();
        }
        //-------------------------------------------------------------
        /// <summary>
        /// フォーム作成時に呼ばれる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //設定ファイルの読み込み
            JsonPref pref = new JsonPref();
            if (pref.Load())
            {
                bool ok = false;
                Size sz = pref.GetSize("Size", out ok);
                if (ok) this.Size = sz;
                Point p = pref.GetPoint("Point", out ok);
                if (ok) this.Location = p;
            }
            this.Text = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
        }
        //-------------------------------------------------------------
        /// <summary>
        /// フォームが閉じられた時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //設定ファイルの保存
            JsonPref pref = new JsonPref();
            pref.SetSize("Size", this.Size);
            pref.SetPoint("Point", this.Location);

            pref.SetIntArray("IntArray", new int[] { 8, 9, 7 });
            pref.Save();

        }
        //-------------------------------------------------------------
        /// <summary>
        /// ドラッグ＆ドロップの準備
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
        }
        // *********************************************************************
        private void btnToJson_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        // *********************************************************************
        private void btnToJson_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //ここでは単純にファイルをリストアップするだけ
            IpsToJson(files);
        }
        // *********************************************************************
        /// <summary>
        /// ドラッグ＆ドロップの本体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
        }
        //-------------------------------------------------------------
        /// <summary>
        /// ダミー関数
        /// </summary>
        /// <param name="cmd"></param>
        public void IpsToJson(string[] cmd)
        {
            if (cmd.Length > 0)
            {
                foreach (string s in cmd)
                {
                    IPS ips = new IPS();
                    if(ips.InportIPSFile(s))
                    {
                        if(cbToJsonClear.Checked == true)
                        {
                            textBox1.Text = "";
                        }
                        if (cbToJsonExport.Checked==true)
                        {
                            if (ips.ExportJson(Path.ChangeExtension(s, ".json")) == true)
                            {
                                textBox1.Text += "// **********************************\r\n";
                                textBox1.Text += "// Export " + ips.FilePath + "\r\n";
                            }

                        }
                        if (cbToJsonPeview.Checked == true)
                        {
                            textBox1.Text += ips.ToJson();
                        }
                    }
                }
            }
        }
        // ********************************************************************************
        public bool IpsToJson(string s)
        {
            bool ret = false;
            IPS ips = new IPS();
            if (cbToJsonClear.Checked == true)
            {
                textBox1.Text = "";
            }
            if (ips.InportIPSFile(s))
            {
                if (cbToJsonExport.Checked == true)
                {
                    if (ips.ExportJson(Path.ChangeExtension(s, ".json")) == true)
                    {
                        textBox1.Text += "// **********************************\r\n";
                        textBox1.Text += "// Export " + ips.FilePath + "\r\n";
                        ret = true;
                    }

                }
                if (cbToJsonPeview.Checked == true)
                {
                    textBox1.Text += ips.ToJson();
                    ret = true;
                }
            }
            if ((cbToJsonClear.Checked == true)&&(ret==false))
            {
                textBox1.Text += "ERRER!\r\n";
                textBox1.Text += s + "\r\n";
            }
            return ret;
        }
        /// <summary>
        /// メニューの終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //-------------------------------------------------------------
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppInfoDialog.ShowAppInfoDialog();
        }

        private void btnToJsonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

    }
}
