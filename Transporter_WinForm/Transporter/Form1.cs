using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporter
{
    
    public partial class Transporter : Form
    {
        private Handler handler = new Handler();
        private CancellationTokenSource cancellationTokenSource;

        public Transporter()
        {
            InitializeComponent();

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Для начала работы укажите:");
            builder.AppendLine("1) исходный каталог - откуда бы Вы хотели перенести файлы;");
            builder.AppendLine("2) форматы файлов с каталогами - куда бы Вы xотели переместить файлы.");
            builder.AppendLine();
            builder.AppendLine("Кнопка 'Start' запускает перенос файлов.");
            builder.AppendLine("Кнопка 'Stop' останавливает перенос файлов.");
            builder.AppendLine("Кнопки 'Add' добавлют параметры.");
            builder.AppendLine("Кнопка 'Reset' сбрасывает параметры переноса.");
            builder.AppendLine("Кнопка 'View' выводит текущие параметры в консоль.");
            builder.AppendLine("Кнопка 'Clear' очищает консоль.");
            builder.AppendLine("Кнопка 'Save' сохраняет текущие параметры.");
            builder.AppendLine();
            builder.AppendLine("Автор программы: Rumeet94 (https://vk.com/evgengorb)");

            tbMessage.Text = builder.ToString();
        }

        private void BtnAddDiir_Click(object sender, System.EventArgs e)
        {
            if (Regex.IsMatch(tbDir.Text, @"^.:\w*", RegexOptions.IgnoreCase))
            {
                handler.AddPath(tbDir.Text);
                tbMessage.Text = "Путь исходного каталога успешно добавлен";
            }
            else
            {
                tbMessage.Text = "Путь исходного каталога указан некорректно";
            }
        }

        private void BtnAddFormatAndDir_Click(object sender, System.EventArgs e)
        {
            if (Regex.IsMatch(tbFormatDir.Text, @"^.:\w*", RegexOptions.IgnoreCase) && !tbFormat.Text.Equals(""))
            {
                handler.AddFormat(tbFormat.Text, tbFormatDir.Text);
                tbMessage.Text = "Формат и путь каталога для переноса файлов успешно добавлены";
            }
            else
            {
                tbMessage.Text = "Не указан формат или путь каталога для переноса файлов указан некорректно";
            }

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
            if (handler.checkParametrsForStart()) {
                tbDir.ReadOnly = true;
                tbFormat.ReadOnly = true;
                tbFormatDir.ReadOnly = true;

                btnStart.Enabled = false;
                btnAddDiir.Enabled = false;
                btnAddFormatAndDir.Enabled = false;
                btnResPar.Enabled = false;

                cancellationTokenSource = new CancellationTokenSource();

                tbMessage.Text = "Выполняется перенос файлов";
                Task.Run(() => handler.MoveFiles(cancellationTokenSource.Token));
            }
            else
            {
                tbMessage.Text = "Невозможно запустить перенос файлов, т.к. исходный каталог " +
                    "или форматы и каталоги для переноса файлов не указаны";
            }
        }

        private void TbDir_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void BtnViewPar_Click(object sender, System.EventArgs e)
        {
            tbMessage.Text = handler.GetParameters();
        }

        private void BtnResPar_Click(object sender, System.EventArgs e)
        {
            handler.DelAllFormats();
        }

        private void BtnClearCon_Click(object sender, System.EventArgs e)
        {
            tbMessage.Text = "";
        }

        private void Label3_Click(object sender, System.EventArgs e)
        {

        }

        private void TbFormatDir_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            handler.SaveSetting();
        }
    }
}
