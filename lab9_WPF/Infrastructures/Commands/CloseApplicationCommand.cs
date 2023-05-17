
using System.Windows;
using WPF_MVVM.Infrastructure.Commands.Base;

namespace lab9_WPF.Infrastructures.Commands
{
    internal class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter) => Application.Current.Shutdown();
    }
}
