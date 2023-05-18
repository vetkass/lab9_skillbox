
using lab9_WPF.Infrastructures.Commands.Base;
using lab9_WPF.ViewModels;

namespace lab9_WPF.Infrastructures.Commands
{
    internal class ClearCommand : Command
    {

        private MainWindowViewModel _viewModel;
        public ClearCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter)
        {
            _viewModel.TextWaT = "";
            _viewModel.LabelRWaT = string.Empty;
            _viewModel.WordSet.Clear();
        }
    }
}
