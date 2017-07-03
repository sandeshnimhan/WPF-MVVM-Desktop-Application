using System.Collections.Generic;
using WpfApp1.Model;
using System.Windows.Input;
using System.Collections.ObjectModel;
using WpfApp1.View;


namespace WpfApp1.ViewModel
{
    class Presenter : ObservableObject
    {
        private readonly TextDisplay _textDisplay = new TextDisplay(s => s.ToUpper());
        private string _someText;
        private string _someText2;
        private readonly ObservableCollection<string> _history = new ObservableCollection<string>();

        public string SomeText
        {
            get { return _someText; }
            set
            {
                _someText = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public string SomeText2
        {
            get { return _someText2; }
            set
            {
                _someText2 = value;
                RaisePropertyChangedEvent("SomeText2");
            }
        }

        public IEnumerable<string> History
        {
            get { return _history; }
        }

        public ICommand WelcomeCommand
        {
            get { return new DelegateCommand(DisplayText); }
        }

        public ICommand CancelCommand
        {
            get { return new DelegateCommand(CancelText); }
        }

        private void CancelText()
        {
            SomeText = string.Empty;
        }

        private void DisplayText()
        {
            if (string.IsNullOrWhiteSpace(SomeText)) return;
            AddToHistory(_textDisplay.DisplayText(SomeText));
            //SomeText = string.Empty;
            SomeText2 = "Welcome " + SomeText + "...!!!";

        }

        private void AddToHistory(string item)
        {
            if (!_history.Contains(item))
                _history.Add(item);
        }

    }
}
