using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cemu_Graphic_Pack_Generator.UI;
using Cemu_Graphic_Pack_Generator.Classes;
using System.IO;

namespace Cemu_Graphic_Pack_Generator
{
    public partial class Main : Form
    {
        internal static List<DirectoryInfo> Folders { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tid = new TitleIDControl
            {
                Dock = DockStyle.Fill,
            };
            var f = new Form
            {
                Size = new Size(tid.Size.Width, tid.Size.Height + 40),
                BackColor = BackColor,
                ShowIcon = false,
                MaximizeBox = false,
                Name = "Add a TitleID.",
                FormBorderStyle = FormBorderStyle.FixedSingle
            };
            f.Controls.Add(tid);
            tid.Closing += (x, y) =>
            {
                if (!string.IsNullOrWhiteSpace(tid.TitleID) && tid.TitleID.Length >= 15)
                    treeView1.Nodes[0].Nodes.Add(tid.TitleID.ToUpper());
                f.Close();
            };
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Recent,
                Description = "Search for a folder to add.",
                UseDescriptionForTitle = true,
                ShowNewFolderButton = false,
                AutoUpgradeEnabled = true
            };
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (Folders == null)
                    Folders = new List<DirectoryInfo>();
                Folders.Add(new DirectoryInfo(fbd.SelectedPath));
                treeView2.Nodes[0].Nodes.Add(fbd.SelectedPath);
            }
        }

        private void TreeView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                treeView1.SelectedNode = treeView1.GetNodeAt(e.X, e.Y);

                if (treeView1.SelectedNode != null && !treeView1.SelectedNode.Equals(treeView1.Nodes[0]))
                    treeView1.SelectedNode.Remove();
            }
        }

        private void TreeView2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Select the clicked node
                treeView2.SelectedNode = treeView2.GetNodeAt(e.X, e.Y);

                if (treeView2.SelectedNode != null && !treeView2.SelectedNode.Equals(treeView2.Nodes[0]))
                    treeView2.SelectedNode.Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Generator.Generate(treeView1, treeView2, textBox2.Text, textBox1.Text, textBox3.Text);
            MessageBox.Show("Complete.");
        }
    }
}
