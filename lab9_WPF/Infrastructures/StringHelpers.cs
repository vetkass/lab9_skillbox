using System;
using System.Text;

namespace lab9_WPF.Infrastructures
{
    internal static class StringHelpers
    {
        /// <summary>
        /// Обертка для Split
        /// </summary>
        /// <param name="text">Слова разделенные пробелами</param>
        /// <returns></returns>
        public static string[] SplitString(string text)
        {
            string[] separators = { " ", "\t", "\n", "\r" };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }


        /// <summary>
        /// Делит текст на слова и формирует массив из перестановленных в обратном порядке слов
        /// </summary>
        /// <param name="text">Текс с пробелами-разделителями слов</param>
        /// <returns></returns>
        public static string[] ReversWords(string text)
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
