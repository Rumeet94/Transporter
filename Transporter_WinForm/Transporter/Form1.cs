using System.Windows.Forms;

namespace Transporter
{
    public partial class Transporter : Form
    {
        private bool isStart = false;

        public Transporter()
        {
            InitializeComponent();
            btnAddDiir.Click += BtnAddDiir_Click;
            btnAddFormatAndDir.Click += BtnAddFormatAndDir_Click;
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            Handler.DoStart();
        }

        private void BtnAddDiir_Click(object sender, System.EventArgs e)
        {
            Handler.DoAdd(null, tbDir.Text);
        }

        private void BtnAddFormatAndDir_Click(object sender, System.EventArgs e)
        {
            Handler.DoAdd(tbFormat.Text, tbFormatDir.Text);
            lblAddFormAndPath.Text = string.Format("Добавлен каталог, для переноса файлов для формата {0}", tbFormat.Text);
        }

        private void Transporter_Load(object sender, System.EventArgs e)
        {

        }
    }
}
