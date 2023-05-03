using System.ComponentModel;
using System.Windows.Input;
using RelayCommand.Command;

namespace HideControlApp.ViewModel {
    public class AppViewModel : INotifyPropertyChanged {

        private bool _isPanelVisible;
        private ICommand _showPanelCommand;
        private ICommand _hidePanelCommand;

        public AppViewModel() {
            //Set befault panel visible//
            _isPanelVisible = false;

        }

        //panel visible property//
        public bool IsPanelVisible {
            get {
                return _isPanelVisible;
            }
            set {
                _isPanelVisible = value;
                OnPropertyChanged("IsPanelVisible");
            }
        }

        // Show Panel method

        public void ShowPanel() {
            IsPanelVisible = true;
        }
        // Show Panel Command
        public ICommand ShowPanelCommand {
            get {
                if(_showPanelCommand == null) {
                    _showPanelCommand = new RelayCommand.Command.RelayCommand(p => ShowPanel());
                }
                return _showPanelCommand;
            }

        }

        //hide Panle Method

        public void HidePanel() {
            IsPanelVisible = false;
        }

        // Hide panel Command

        public ICommand HidePanelCommand {
            get {
                if(_hidePanelCommand == null) {
                    _hidePanelCommand = new RelayCommand.Command.RelayCommand(p => HidePanel());
                }
                return _hidePanelCommand;
            }
        }

        // Close App Method
        public void CloseApp(object obj) {
            MainWindow win = obj as MainWindow;
            win.Close();
        }

        //Close App Command//

        private ICommand _closeCommand;
        public ICommand CloseAppCommand {
            get {
                if(_closeCommand == null) {
                    _closeCommand = new RelayCommand.Command.RelayCommand(p => CloseApp(p));
                }
                return _closeCommand;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
