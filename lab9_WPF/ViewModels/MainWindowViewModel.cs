using lab9_WPF.ViewModels.Base;

namespace lab9_WPF.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        #region Заголовок окна
        /// <summary>
        /// Заголовок окна
        /// </summary>
        private string _Title = "lab9 WPF";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Текст
        /// <summary>
        /// Текст в боксе "Write a text.."
        /// </summary>
        private string _TextWaT = "Текст в боксе \"Write a text..\"";
        public string TextWaT
        {
            get => _TextWaT;
            set => Set(ref _TextWaT, value);
        }
        #endregion

        #region Element reversed text
        /// <summary>
        /// Элемент с перевернутым текстом
        /// </summary>
        private string _LabelRWaT = "";
        public string LabelRWaT
        {
            get => _LabelRWaT;
            set => Set(ref _LabelRWaT, value);
        }
        #endregion
    }
}
