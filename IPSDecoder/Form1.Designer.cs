namespace IPSDecoder
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpToJson = new System.Windows.Forms.TabPage();
            this.btnToJsonClear = new System.Windows.Forms.Button();
            this.cbToJsonPeview = new System.Windows.Forms.CheckBox();
            this.btnToJson = new System.Windows.Forms.Button();
            this.tpJsonPreview = new System.Windows.Forms.TabPage();
            this.btnPrevewJsonClear = new System.Windows.Forms.Button();
            this.btnPreviewJson = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbToJsonExport = new System.Windows.Forms.CheckBox();
            this.cbToJsonClear = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpToJson.SuspendLayout();
            this.tpJsonPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.saveAsToolStripMenuItem.Text = "SaveAs";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "バージョン情報の表示";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(906, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(6, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(886, 285);
            this.textBox1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpToJson);
            this.tabControl1.Controls.Add(this.tpJsonPreview);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 393);
            this.tabControl1.TabIndex = 5;
            // 
            // tpToJson
            // 
            this.tpToJson.Controls.Add(this.cbToJsonClear);
            this.tpToJson.Controls.Add(this.cbToJsonExport);
            this.tpToJson.Controls.Add(this.btnToJsonClear);
            this.tpToJson.Controls.Add(this.cbToJsonPeview);
            this.tpToJson.Controls.Add(this.btnToJson);
            this.tpToJson.Controls.Add(this.textBox1);
            this.tpToJson.Location = new System.Drawing.Point(4, 22);
            this.tpToJson.Name = "tpToJson";
            this.tpToJson.Padding = new System.Windows.Forms.Padding(3);
            this.tpToJson.Size = new System.Drawing.Size(898, 367);
            this.tpToJson.TabIndex = 0;
            this.tpToJson.Text = "IpsToJson";
            this.tpToJson.UseVisualStyleBackColor = true;
            // 
            // btnToJsonClear
            // 
            this.btnToJsonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToJsonClear.Location = new System.Drawing.Point(800, 50);
            this.btnToJsonClear.Name = "btnToJsonClear";
            this.btnToJsonClear.Size = new System.Drawing.Size(75, 23);
            this.btnToJsonClear.TabIndex = 7;
            this.btnToJsonClear.Text = "Clear";
            this.btnToJsonClear.UseVisualStyleBackColor = true;
            this.btnToJsonClear.Click += new System.EventHandler(this.btnToJsonClear_Click);
            // 
            // cbToJsonPeview
            // 
            this.cbToJsonPeview.AutoSize = true;
            this.cbToJsonPeview.Checked = true;
            this.cbToJsonPeview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToJsonPeview.Location = new System.Drawing.Point(141, 50);
            this.cbToJsonPeview.Name = "cbToJsonPeview";
            this.cbToJsonPeview.Size = new System.Drawing.Size(106, 16);
            this.cbToJsonPeview.TabIndex = 6;
            this.cbToJsonPeview.Text = "Json結果を表示";
            this.cbToJsonPeview.UseVisualStyleBackColor = true;
            // 
            // btnToJson
            // 
            this.btnToJson.AllowDrop = true;
            this.btnToJson.Location = new System.Drawing.Point(20, 15);
            this.btnToJson.Name = "btnToJson";
            this.btnToJson.Size = new System.Drawing.Size(103, 52);
            this.btnToJson.TabIndex = 5;
            this.btnToJson.Text = "ToJson";
            this.btnToJson.UseVisualStyleBackColor = true;
            this.btnToJson.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnToJson_DragDrop);
            this.btnToJson.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnToJson_DragEnter);
            // 
            // tpJsonPreview
            // 
            this.tpJsonPreview.Controls.Add(this.btnPrevewJsonClear);
            this.tpJsonPreview.Controls.Add(this.btnPreviewJson);
            this.tpJsonPreview.Controls.Add(this.textBox2);
            this.tpJsonPreview.Location = new System.Drawing.Point(4, 22);
            this.tpJsonPreview.Name = "tpJsonPreview";
            this.tpJsonPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tpJsonPreview.Size = new System.Drawing.Size(898, 367);
            this.tpJsonPreview.TabIndex = 1;
            this.tpJsonPreview.Text = "JsonPreview";
            this.tpJsonPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrevewJsonClear
            // 
            this.btnPrevewJsonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevewJsonClear.Location = new System.Drawing.Point(800, 50);
            this.btnPrevewJsonClear.Name = "btnPrevewJsonClear";
            this.btnPrevewJsonClear.Size = new System.Drawing.Size(75, 23);
            this.btnPrevewJsonClear.TabIndex = 10;
            this.btnPrevewJsonClear.Text = "Clear";
            this.btnPrevewJsonClear.UseVisualStyleBackColor = true;
            // 
            // btnPreviewJson
            // 
            this.btnPreviewJson.AllowDrop = true;
            this.btnPreviewJson.Location = new System.Drawing.Point(20, 15);
            this.btnPreviewJson.Name = "btnPreviewJson";
            this.btnPreviewJson.Size = new System.Drawing.Size(103, 52);
            this.btnPreviewJson.TabIndex = 9;
            this.btnPreviewJson.Text = "PreviewJson";
            this.btnPreviewJson.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(6, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(886, 285);
            this.textBox2.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(898, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PatchFromJson";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbToJsonExport
            // 
            this.cbToJsonExport.AutoSize = true;
            this.cbToJsonExport.Checked = true;
            this.cbToJsonExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToJsonExport.Location = new System.Drawing.Point(141, 28);
            this.cbToJsonExport.Name = "cbToJsonExport";
            this.cbToJsonExport.Size = new System.Drawing.Size(124, 16);
            this.cbToJsonExport.TabIndex = 8;
            this.cbToJsonExport.Text = "Json結果を書き出し";
            this.cbToJsonExport.UseVisualStyleBackColor = true;
            // 
            // cbToJsonClear
            // 
            this.cbToJsonClear.AutoSize = true;
            this.cbToJsonClear.Location = new System.Drawing.Point(277, 50);
            this.cbToJsonClear.Name = "cbToJsonClear";
            this.cbToJsonClear.Size = new System.Drawing.Size(150, 16);
            this.cbToJsonClear.TabIndex = 9;
            this.cbToJsonClear.Text = "実行ごとに表示をクリアする";
            this.cbToJsonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IPSDecoder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpToJson.ResumeLayout(false);
            this.tpToJson.PerformLayout();
            this.tpJsonPreview.ResumeLayout(false);
            this.tpJsonPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpToJson;
        private System.Windows.Forms.TabPage tpJsonPreview;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnToJson;
        private System.Windows.Forms.CheckBox cbToJsonPeview;
        private System.Windows.Forms.Button btnToJsonClear;
        private System.Windows.Forms.Button btnPrevewJsonClear;
        private System.Windows.Forms.Button btnPreviewJson;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox cbToJsonExport;
        private System.Windows.Forms.CheckBox cbToJsonClear;
    }
}

