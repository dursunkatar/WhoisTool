namespace WhoisTool
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripIslemler = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainListesiYukleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baslaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIslemler = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIslemlerListLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.başlatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxThread = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.menuStripIslemler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 463);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domainler";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(6, 23);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(544, 434);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Domain";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oluşturulma Tarihi";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bitiş Tarihi";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Durum";
            this.columnHeader4.Width = 100;
            // 
            // menuStripIslemler
            // 
            this.menuStripIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.hakkindaToolStripMenuItem});
            this.menuStripIslemler.Location = new System.Drawing.Point(0, 0);
            this.menuStripIslemler.Name = "menuStripIslemler";
            this.menuStripIslemler.Size = new System.Drawing.Size(574, 28);
            this.menuStripIslemler.TabIndex = 3;
            this.menuStripIslemler.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domainListesiYukleToolStripMenuItem,
            this.baslaToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // domainListesiYukleToolStripMenuItem
            // 
            this.domainListesiYukleToolStripMenuItem.Name = "domainListesiYukleToolStripMenuItem";
            this.domainListesiYukleToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.domainListesiYukleToolStripMenuItem.Text = "Domain Listesi Yükle";
            this.domainListesiYukleToolStripMenuItem.Click += new System.EventHandler(this.domainListesiYukleToolStripMenuItem_Click);
            // 
            // baslaToolStripMenuItem
            // 
            this.baslaToolStripMenuItem.Name = "baslaToolStripMenuItem";
            this.baslaToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.baslaToolStripMenuItem.Text = "Başla";
            this.baslaToolStripMenuItem.Click += new System.EventHandler(this.baslaToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hakkindaToolStripMenuItem.Text = "Hakkında";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // mnuIslemler
            // 
            this.mnuIslemler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIslemlerListLoad,
            this.başlatToolStripMenuItem1});
            this.mnuIslemler.Name = "mnuIslemler";
            this.mnuIslemler.Size = new System.Drawing.Size(73, 24);
            this.mnuIslemler.Text = "İşlemler";
            // 
            // mnuIslemlerListLoad
            // 
            this.mnuIslemlerListLoad.Name = "mnuIslemlerListLoad";
            this.mnuIslemlerListLoad.Size = new System.Drawing.Size(69, 22);
            // 
            // başlatToolStripMenuItem1
            // 
            this.başlatToolStripMenuItem1.Name = "başlatToolStripMenuItem1";
            this.başlatToolStripMenuItem1.Size = new System.Drawing.Size(69, 22);
            // 
            // menuHakkinda
            // 
            this.menuHakkinda.Name = "menuHakkinda";
            this.menuHakkinda.Size = new System.Drawing.Size(32, 19);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxThread);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thread Sayısı : ";
            // 
            // comboBoxThread
            // 
            this.comboBoxThread.FormattingEnabled = true;
            this.comboBoxThread.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxThread.Location = new System.Drawing.Point(433, 14);
            this.comboBoxThread.Name = "comboBoxThread";
            this.comboBoxThread.Size = new System.Drawing.Size(117, 26);
            this.comboBoxThread.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 560);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStripIslemler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripIslemler;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whois Tool";
            this.groupBox1.ResumeLayout(false);
            this.menuStripIslemler.ResumeLayout(false);
            this.menuStripIslemler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStripIslemler;
        private System.Windows.Forms.ToolStripMenuItem mnuIslemler;
        private System.Windows.Forms.ToolStripMenuItem menuHakkinda;
        private System.Windows.Forms.ToolStripMenuItem mnuIslemlerListLoad;
        private System.Windows.Forms.ToolStripMenuItem başlatToolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxThread;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domainListesiYukleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baslaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
    }
}

