using System.Windows.Forms;

namespace Transporter
{
    
    public partial class Transporter : Form
    {
        bool che = false;

        public Transporter()
        {
            InitializeComponent();
            btnAddDiir.Click += BtnAddDiir_Click;
            btnAddFormatAndDir.Click += BtnAddFormatAndDir_Click;
            btnStart.Click += BtnStart_Click;
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            Data.IsStart = true;
            tbDir.ReadOnly = true;
            Handler.DoStart();
        }

        private void BtnAddDiir_Click(object sender, System.EventArgs e)
        {
                Handler.DoAdd(null, tbDir.Text);
                btnAddDiir.Text = "Edit";
        }

        private void BtnAddFormatAndDir_Click(object sender, System.EventArgs e)
        {
            Handler.DoAdd(tbFormat.Text, tbFormatDir.Text);
            lblAddFormAndPath.Text = string.Format("Добавлен каталог, для переноса файлов для формата {0}", tbFormat.Text);
        }

        private void Transporter_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnStop_Click(object sender, System.EventArgs e)
        {
            Data.IsStart = false;
            tbDir.ReadOnly = false;
           // InitializeComponent();
        }

        private void TbDir_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
