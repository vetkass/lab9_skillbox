

using lab9_WPF.Infrastructures.Commands.Base;
using lab9_WPF.ViewModels;

namespace lab9_WPF.Infrastructures.Commands
{
    internal class ShowListCommand : Command
    {
        private MainWindowViewModel _viewModel;
        public ShowListCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter)
        {
            _viewModel.WordSet?.Clear();
            string[] splitedString = StringHelpers.SplitString(_viewModel.TextWaT);
            foreach(string s in splitedString)
            {
                _viewModel.WordSet?.Add(s);
            }
            _viewModel.WordSetisVisible = true;
            _viewModel.LabelRWaTisVisible = !_viewModel.WordSetisVisible;
        }
    }
}
