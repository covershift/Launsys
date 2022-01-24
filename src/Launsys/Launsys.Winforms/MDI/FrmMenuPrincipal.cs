using Launsys.Winforms.Base;
using Launsys.Winforms.Maestros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launsys.Winforms.MDI
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            ParametrosIniciales();
            EventosMenu();
        }

        private void ParametrosIniciales()
        {
            Text = Text + Application.ProductVersion + " - Menú Principal";
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void EventosMenu()
        {
            atencionesToolStripMenuItem.Click += ToolStripMenuItem_Click;
            clientesToolStripMenuItem.Click += ToolStripMenuItem_Click;
            serviciosToolStripMenuItem.Click += ToolStripMenuItem_Click;
            productosToolStripMenuItem.Click += ToolStripMenuItem_Click;
            promocionesToolStripMenuItem.Click += ToolStripMenuItem_Click;
        }

        private void ToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            bool exist = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FrmServicio")
                {
                    exist = true;
                    f.BringToFront();
                    break;
                }
            }

            if (exist == false)
            {
                FrmServicio fm = new FrmServicio();
                fm.MdiParent = this;
                fm.Show();
            }
        }
    }
}
