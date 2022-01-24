namespace Launsys.Winforms.Base
{
    public partial class RawForm : Form
    {
        public RawForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
