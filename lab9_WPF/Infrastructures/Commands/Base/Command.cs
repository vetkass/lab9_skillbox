using System;
using System.Windows.Input;

namespace WPF_MVVM.Infrastructure.Commands.Base
{
    internal abstract class Command : ICommand
    {
        /// <summary>
        /// генерируется когда функция выполнения команды начинает возвращать другое значение
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            //данной реализацие мы передаем управление обработки ивентов самому WFP
            //WPF автоматически генерирует событие для CommandManager, когда что-либо происходит
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// функция
        /// если возвр ложь то команду выполнить нельзя, и элемент будет отключаться
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns>истина или ложь</returns>
        public abstract bool CanExecute(object? parameter);

        /// <summary>
        /// основная логика команды, то что дб выполнено
        /// </summary>
        /// <param name="parameter"></param>
        public abstract void Execute(object? parameter);
    }
}
