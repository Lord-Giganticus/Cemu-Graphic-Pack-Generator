using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Cemu_Graphic_Pack_Generator.Classes
{
    public class Generator
    {
        public static void Generate(TreeView view1, TreeView view2, string name, string path, string desc)
        {

            var ids = new List<string>();

            for (int i = 0; i != view1.Nodes[0].Nodes.Count; i++)
            {
                ids.Add(view1.Nodes[0].Nodes[i].Text);
            }

            var start = Directory.GetCurrentDirectory();

            var folder = new DirectoryInfo(view2.Nodes[0].FirstNode.Text).Parent;

            string tids;

            if (ids.Count > 0)
            {
                tids = string.Join(",", ids.ToArray());
            }
            else
            {
                tids = ids[0];
            }

            var output = new string[]
            {
                "[Definition]",
                $"titleIds = {tids}",
                $"name = {name}",
                $"path = \"{path}\"",
                $"description = {desc}",
                "version = 5"
            };

            File.WriteAllLines("rules.txt", output);

            var sfd = new SaveFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                AutoUpgradeEnabled = true,
                CheckPathExists = true,
                Filter = "Zip file (*.zip)|*.zip",
                FilterIndex = 1,
                Title = "Save the generated graphic pack."
            };

            if (sfd.ShowDialog() is DialogResult.OK)
            {
                var startinfo1 = new ProcessStartInfo
                {
                    Arguments = $"/c 7z a \"{sfd.FileName}\" content",
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Environment.CurrentDirectory = folder.FullName;
                Process p;
                p = Process.Start(startinfo1);
                p.WaitForExit();
                var startinfo2 = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = $"/c 7z a \"{sfd.FileName}\" rules.txt"
                };
                Environment.CurrentDirectory = start;
                p = Process.Start(startinfo2);
                p.WaitForExit();
                File.Delete("rules.txt");
                return;
            } else
            {
                return;
            }
        }
    }
}
