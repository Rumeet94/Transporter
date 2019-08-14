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

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Для начала работы укажите;");
            builder.AppendLine("1) исходный каталог - откуда бы Вы хотели перенести файлы;");
            builder.AppendLine("2) форматы файлов с каталами - куда бы Вы xотели переместить файлы.");

            tbMessage.Text = builder.ToString();
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
            tbMessage.Text = "Перенос файлов остановлен.";
            cancellationTokenSource?.Cancel();
            
            tbDir.ReadOnly = false;
            tbFormat.ReadOnly = false;
            tbFormatDir.ReadOnly = false;

            btnStart.Enabled = true;
            btnAddDiir.Enabled = true;
            btnAddFormatAndDir.Enabled = true;
            btnResPar.Enabled = true;
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            tbDir.ReadOnly = true;
            tbFormat.ReadOnly = true;
            tbFormatDir.ReadOnly = true;

            btnStart.Enabled = false;
            btnAddDiir.Enabled = false;
            btnAddFormatAndDir.Enabled = false;
            btnResPar.Enabled = false;
            
            cancellationTokenSource = new CancellationTokenSource();

            tbMessage.Text = "Выполняется перенос файлов";
            Task.Run(() => Handler.MoveFiles(cancellationTokenSource.Token));
        }

        private void TbDir_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void BtnViewPar_Click(object sender, System.EventArgs e)
        {
            tbMessage.Text = Handler.GetParameters();
        }

        private void BtnResPar_Click(object sender, System.EventArgs e)
        {
            Handler.DelAllFormats(Data.Formats);
        }

        private void BtnClearCon_Click(object sender, System.EventArgs e)
        {
            tbMessage.Text = "";
        }
    }
}
