using System.Windows.Input;
using Caliburn.Core;
using WPFCaliPlatformCastle.Command;

namespace WPFCaliPlatformCastle.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IShellViewModel
    {
        private ICommand _sayHelloCommand;
        private string _message;

        public ICommand SayHelloCommand
        {
            get
            {
                if (_sayHelloCommand == null)
                    _sayHelloCommand = new DelegateCommand(SayHello);

                return _sayHelloCommand;
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange("Message");
            }
        }

        private void SayHello()
        {
            Message = "Greetings from Caliburn!";
        }
    }
}