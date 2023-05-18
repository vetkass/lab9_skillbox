using lab9_WPF.ViewModels.Base;
using System.Collections.ObjectModel;
using System;

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
        private string _TextWaT = "";
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

        #region Element reversed text visibility
        /// <summary>
        /// Видимость элемента с перевернутым текстом
        /// </summary>
        private bool _LabelRWaTisVisible;
        public bool LabelRWaTisVisible
        {
            get => _LabelRWaTisVisible;
            set => Set(ref _LabelRWaTisVisible, value);
        }
        #endregion


        #region Element for separate words showing
        /// <summary>
        /// Элемент для отображения набора слов
        /// </summary>
        private ObservableCollection<string>? _wordSet;

        public ObservableCollection<string>? WordSet
        {
            get => _wordSet;
            set => Set(ref _wordSet, value);
        }
        #endregion

        #region Element for separate words showing visibility
        /// <summary>
        /// Видимость для отображения набора слов
        /// </summary>
        private bool _WordSetisVisible;
        public bool WordSetisVisible
        {
            get => _WordSetisVisible;
            set => Set(ref _WordSetisVisible, value);
        }
        #endregion

        public MainWindowViewModel()
        {
            // Initialize the collection
            WordSet = new ObservableCollection<string>();
            LabelRWaTisVisible = false;
            WordSetisVisible = !LabelRWaTisVisible;
        }
    }
}
