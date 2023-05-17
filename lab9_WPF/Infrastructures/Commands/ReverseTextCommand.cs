
using lab9_WPF.Infrastructures.Commands.Base;
using lab9_WPF.ViewModels;
using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
            _viewModel.LabelRWaT = FormText(ReversWords(_viewModel.TextWaT));
        }

        /// <summary>
        /// Обертка для Split
        /// </summary>
        /// <param name="text">Слова разделенные пробелами</param>
        /// <returns></returns>
        private static string[] SplitString(string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        /// <summary>
        /// Делит текст на слова и формирует массив из перестановленных в обратном порядке слов
        /// </summary>
        /// <param name="text">Текс с пробелами-разделителями слов</param>
        /// <returns></returns>
        private static string[] ReversWords(string text)
        {
            string[] words = SplitString(text);
            string temp;
            for (int i = 0; i < words.Length / 2; i++)
            {
                temp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = temp;
            }
            return words;
        }

        /// <summary>
        /// Собирает из слов текст, каждое слово разделено пробелом
        /// </summary>
        /// <param name="strings">Массив слов</param>
        /// <returns></returns>
        public static string FormText(string[] strings)
        {
            StringBuilder text = new StringBuilder();
            text.AppendJoin(" ", strings);
            return text.ToString();
        }




    }
}
