using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WhoisTool.Utilities;

namespace WhoisTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            comboBoxThread.SelectedIndex = 1;
            WhoisEngine.listView = listView;
        }


        private void loadDomains(string path)
        {
            foreach (string domain in File.ReadLines(path, Encoding.Default))
            {
                var lvi = new ListViewItem();
                lvi.Text = domain;
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                lvi.SubItems.Add("");
                listView.Items.Add(lvi);
            }
        }

        private void domainListesiYukleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var file = new OpenFileDialog();
            file.Multiselect = false;
            file.Title = "Select Txt";
            file.Filter = "Txt | *.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                listView.Items.Clear();
                loadDomains(file.FileName);
            }
            file.Dispose();
        }

        private void baslaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string th = comboBoxThread.Text.Trim();
            if (th != "")
            {
                int count = int.Parse(th);
                for (int i = 0; i < count; i++)
                {
                    WhoisEngine.Start(true);
                }
            }

        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmAbout();
            frm.Show();
        }
    }
}
