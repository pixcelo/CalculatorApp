using System.Runtime.InteropServices;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        private CalculatorViewModel _viewModel;

        public CalculatorForm()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            _viewModel = new CalculatorViewModel();
            TextBoxDisplay.DataBindings.Add(nameof(TextBoxDisplay.Text), _viewModel, nameof(_viewModel.DisplayText));
            TextBoxExpression.DataBindings.Add(nameof(TextBoxExpression.Text), _viewModel, nameof(_viewModel.ExpressionText));

            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {

        }

        private void DotButton_Click(object sender, EventArgs e)
        {

        }

        private void EqualButton_Click(object sender, EventArgs e)
        {

        }

        private void OperationButton_Click(object sender, EventArgs e)
        {

        }

        private void UndoButton_Click(object sender, EventArgs e)
        {

        }

        private void RedoButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Move Form window

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        #endregion
    }
}
