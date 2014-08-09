using HBDday.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace HBDday
{
    public class HBManager : INotifyPropertyChanged
    {
        #region ObservableCollection<HBModel> Items
        private ObservableCollection<HBModel> _Items;
        public ObservableCollection<HBModel> Items
        {
            get
            {
                return _Items;
            }
            set
            {
                _Items = value;
                OnPropertyChanged("Items");
            }
        }
        #endregion ObservableCollection<HBModel> Items

        #region ObservableCollection<string> BackgroundImages
        private ObservableCollection<string> _BackgroundImages;
        public ObservableCollection<string> BackgroundImages
        {
            get
            {
                return _BackgroundImages;
            }
            set
            {
                _BackgroundImages = value;
                OnPropertyChanged("BackgroundImages");
            }
        }
        #endregion ObservableCollection<string> BackgroundImages

        #region ObservableCollection<string> BackgroundColors
        private ObservableCollection<string> _BackgroundColors;
        public ObservableCollection<string> BackgroundColors
        {
            get
            {
                return _BackgroundColors;
            }
            set
            {
                _BackgroundColors = value;
                OnPropertyChanged("BackgroundColors");
            }
        }
        #endregion ObservableCollection<string> BackgroundColors

        public HBManager()
        {
            Items = new ObservableCollection<HBModel>();
        }

        public static async Task SaveManagerAsync(HBManager manager)
        {
            var file = await ApplicationData.Current.LocalFolder.GetFileAsync("HBManager");
            var serializedHBManager = JsonConvert.SerializeObject(manager);
            await FileIO.WriteTextAsync(file, serializedHBManager);
        }


        public static async Task<HBManager> LoadManagerAsync()
        {
            var file = await ApplicationData.Current.LocalFolder.CreateFileAsync("HBManager", CreationCollisionOption.OpenIfExists);
            if (file != null)
            {
                string managerString = await FileIO.ReadTextAsync(file);
                return JsonConvert.DeserializeObject<HBManager>(managerString);
            }
            else
            {
                return null;
            }
        }


        #region ▶ INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler == null)
            {
                return;
            }
            handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion INotifyPropertyChanged
    }
}
