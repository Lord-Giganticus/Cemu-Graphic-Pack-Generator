using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Cemu_Graphic_Pack_Generator.Classes
{
    public static class FormExt
    {
        public static Form MakeHost(this Form main, Form host)
        {
            host.Load += (x, y) =>
            {
                Rectangle? bounds = null;
                while (main != null)
                {
                    var f = main;
                    main = null;

                    f.Load += (x2, y2) =>
                    {
                        if (bounds != null)
                            f.SetBounds(bounds.Value.X, bounds.Value.Y, bounds.Value.Width, bounds.Value.Height);
                    };

                    f.Shown += (x2, y2) => f.TopLevel = true;

                    f.ShowDialog(host);
                    bounds = f.DesktopBounds;
                }
                host.Close();
            };

            return host;
        }
    }
}
