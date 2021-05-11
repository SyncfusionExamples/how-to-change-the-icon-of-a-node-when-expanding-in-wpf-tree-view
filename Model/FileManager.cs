using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace SfTreeViewDemo
{
    public class FileManager : NotificationObject
    {
        private string fileName;
        private ImageSource imageIcon;
        private ObservableCollection<FileManager> subFiles;

        public ObservableCollection<FileManager> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                this.RaisePropertyChanged(() => this.SubFiles);
            }
        }

        public string ItemName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                this.RaisePropertyChanged(() => this.ItemName);
            }
        }

        public ImageSource ImageIcon
        {
            get { return imageIcon; }
            set
            {
                imageIcon = value;
                RaisePropertyChanged("ImageIcon");
            }
        }
    }
}



























































































//        private string fileName;
//        private ImageSource imageIcon;
//        private ObservableCollection<FileManager> subFiles;

//        public ObservableCollection<FileManager> SubFiles
//        {
//            get { return subFiles; }
//            set
//            {
//                subFiles = value;
//                RaisedOnPropertyChanged("SubFiles");
//            }
//        }

//        public string ItemName
//        {
//            get { return fileName; }
//            set
//            {
//                fileName = value;
//                RaisedOnPropertyChanged("ItemName");
//            }
//        }

//        public ImageSource ImageIcon
//        {
//            get { return imageIcon; }
//            set
//            {
//                imageIcon = value;
//                RaisedOnPropertyChanged("ImageIcon");
//            }
//        }

//        public event PropertyChangedEventHandler PropertyChanged;

//        public void RaisedOnPropertyChanged(string _PropertyName)
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
//            }
//        }
//    }
//}
