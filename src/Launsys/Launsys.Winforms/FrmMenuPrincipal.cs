using Launsys.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launsys.Winforms
{
    public partial class FrmMenuPrincipal : Form
    {
        ServicioBL servicioBL = new ServicioBL();

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            var xd = servicioBL.ConsultarLista();
        }
    }
}
