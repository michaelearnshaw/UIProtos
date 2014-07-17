using System.Windows.Input;

namespace WPFCaliPlatformCastle.ViewModels
{
    public interface IShellViewModel
    {
        /// <summary>
        /// A command that says hello when invoked.
        /// </summary>
        ICommand SayHelloCommand { get; }

        /// <summary>
        /// Message
        /// </summary>
        string Message { get; set; }
    }
}