using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace AudioPlayer
{
    public class AboutAuthorWindowViewModel : INotifyPropertyChanged
    {
        private string _AboutAuthor = "";
        public string AboutAuthor { get { return _AboutAuthor; } set { _AboutAuthor = value; NotifyPropertyChanged("AboutAuthor"); } }
        public ICommand OkCommand { get; set; }
        public EventHandler? OnCloseRequest { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        public AboutAuthorWindowViewModel()
        {
            OkCommand = new RelayCommand(closeWindow);
            AboutAuthor = "Короче работу выполнила просто крутой чел Черемисина Елизавета ";
        }


        private void closeWindow()
        {
            OnCloseRequest(this, EventArgs.Empty);
        }

        private void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));  
        }
    }
}
