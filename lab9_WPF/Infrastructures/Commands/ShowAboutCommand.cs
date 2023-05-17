

using System.Windows;
using lab9_WPF.Infrastructures.Commands.Base;

namespace lab9_WPF.Infrastructures.Commands
{
    internal class ShowAboutCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;
        public override void Execute(object? parameter) =>
            MessageBox.Show("Это приложение создано в рамках курса Skillbox \"C#–разработчик с нуля до PRO\"\n" +
                "Автор: Чернова Светлана\n"+
                "Дополнительные ресурсы: youtube Павел Шмачилин WPF+MVVM", /* https://www.youtube.com/watch?v=6xkbRE4KvE0 */
                "lab9 WPF", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
