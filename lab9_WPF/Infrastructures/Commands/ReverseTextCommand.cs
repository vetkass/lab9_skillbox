﻿
using lab9_WPF.Infrastructures.Commands.Base;
using lab9_WPF.ViewModels;

namespace lab9_WPF.Infrastructures.Commands
{
    internal class ReverseTextCommand : Command
    {

        private MainWindowViewModel _viewModel;
        public ReverseTextCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter)
        {
            _viewModel.LabelRWaT = StringHelpers.FormText(StringHelpers.ReversWords(_viewModel.TextWaT));

            _viewModel.WordSetisVisible = false;
            _viewModel.LabelRWaTisVisible = !_viewModel.WordSetisVisible;
        } 
    }
}
