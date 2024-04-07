using CalculatorApp.Models;

namespace CalculatorApp.Calculator.Command
{
    public class ClearCommand : ICommand
    {
        private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        private CalculatorViewModel _viewModel;
        private string _previousValue;

        public ClearCommand(CalculatorViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Invoke()
        {            
            var currentValue = _viewModel.DisplayText;
            _previousValue = currentValue;
            
            _viewModel.DisplayText = "";
            _viewModel.ExpressionText = "";

            logger.Info($"Result: {_viewModel.DisplayText}");
        }

        public void Undo()
        {
            _viewModel.DisplayText = _previousValue;
        }

        public void Redo()
        {
            Invoke();
        }
    }
}
