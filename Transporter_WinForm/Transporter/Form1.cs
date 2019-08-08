using System.Windows.Forms;

namespace Transporter
{
    public partial class Transporter : Form
    {

        public Transporter()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            Handler.DoStart();
        }
    }
}
