using System.Threading;
using System.Windows.Forms;

namespace WhoisTool.Utilities
{
    public struct WhoisEngine
    {
        private static int listViewIndex = 0;
        private static volatile object obj = new object();
        public static ListView listView { get; set; }

        public static void Start(bool flag)
        {
            if (flag)
            {
                listViewIndex = 0;
            }
            var th = new Thread(() =>
            {
                lookup();
            });
            th.IsBackground = true;
            th.Start();
        }

        private static void lookup()
        {
            ListViewItem lvi = null;
            lock (obj)
            {
                if (listViewIndex == listView.Items.Count)
                {
                    return;
                }

                lvi = listView.Items[listViewIndex++];
            }
            lvi.SubItems[3].Text = "Bakılıyor...";
            var (createDate, expiryDate) = WhoisLookup.Lookup(lvi.Text);
            lvi.SubItems[1].Text = createDate;
            lvi.SubItems[2].Text = expiryDate;
            lvi.SubItems[3].Text = "Bitti";
            Start(false);
        }
    }
}
