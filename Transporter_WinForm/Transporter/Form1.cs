using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporter
{
    
    public partial class Transporter : Form
    {
        private readonly Handler handler = new Handler();
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
            if (IsDirectoryNameValid(tbDir.Text))
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
            if (IsDirectoryNameValid(tbFormat.Text, tbFormatDir.Text))
            {
                handler.AddFormat(tbFormat.Text, tbFormatDir.Text);
                tbMessage.Text = "Формат и путь каталога для переноса файлов успешно добавлены";
            }
            else
            {
                tbMessage.Text = "Не указан формат или путь каталога для переноса файлов указан некорректно";
            }
        }

        private void BtnStop_Click(object sender, System.EventArgs e)
        {
            tbMessage.Text = "Перенос файлов остановлен.";
            cancellationTokenSource?.Cancel();

            SetTexBoxReadOnly(false);
            SetButtonEnabled(true);
        }

        private void BtnStart_Click(object sender, System.EventArgs e)
        {
            if (handler.checkParametrsForStart())
            {
                SetTexBoxReadOnly(true);
                SetButtonEnabled(false);

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

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            handler.SaveSetting();
        }

        private bool IsDirectoryNameValid(string path)
        {
            return Regex.IsMatch(path, @"^.:\w*", RegexOptions.IgnoreCase);
        }

        private bool IsDirectoryNameValid(string format, string path)
        {
            return Regex.IsMatch(path, @"^.:\w*", RegexOptions.IgnoreCase) && !format.Equals("");
        }

        private void SetTexBoxReadOnly(bool readOnly)
        {
            tbDir.ReadOnly = readOnly;
            tbFormat.ReadOnly = readOnly;
            tbFormatDir.ReadOnly = readOnly;
        }

        private void SetButtonEnabled(bool enabled)
        {
            btnStart.Enabled = enabled;
            btnAddDiir.Enabled = enabled;
            btnAddFormatAndDir.Enabled = enabled;
            btnResPar.Enabled = enabled;
        }
    }
}
