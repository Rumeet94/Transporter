using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporter
{
    
    public partial class Transporter : Form
    {
        private CancellationTokenSource cancellationTokenSource;

        public Transporter()
        {
            InitializeComponent();
            
        }

        private void BtnAddDiir_Click(object sender, System.EventArgs e)
        {
                Data.Path = tbDir.Text;
                btnAddDiir.Text = "Edit";
        }

        private void BtnAddFormatAndDir_Click(object sender, System.EventArgs e)
        {
            Handler.AddFormat(tbFormat.Text, tbFormatDir.Text);
            
        }

        private void Transporter_Load(object sender, System.EventArgs e)
        {

        }

        private void BtnStop_Click(object sender, System.EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            tbDir.ReadOnly = false;
            tbFormat.ReadOnly = false;
            tbFormatDir.ReadOnly = false;
            btnStart.Enabled = true;
            btnAddDiir.Enabled = true;
            btnAddFormatAndDir.Enabled = true;
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            tbDir.ReadOnly = true;
            tbFormat.ReadOnly = true;
            tbFormatDir.ReadOnly = true;
            btnStart.Enabled = false;
            btnAddDiir.Enabled = false;
            btnAddFormatAndDir.Enabled = false;
            cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => Handler.MoveFiles(cancellationTokenSource.Token));
        }

        private void TbDir_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void BtnViewPar_Click(object sender, System.EventArgs e)
        {
            StringBuilder builder = new StringBuilder(Handler.CreateMessage("Форматы файлов и каталоги, куда файлы будут перенесены" + "\n"));

            foreach(var format in Data.Formats)
            {
                builder.Append(string.Format("{0} : {1}", format.Key, format.Value) + "\n");
            }

            tbMessage.Text = builder.ToString();
        }
    }
}
