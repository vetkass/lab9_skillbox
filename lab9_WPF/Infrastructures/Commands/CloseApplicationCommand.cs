
using System.Windows;
using lab9_WPF.Infrastructures.Commands.Base;

namespace lab9_WPF.Infrastructures.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter) => Application.Current.Shutdown();
    }
}
