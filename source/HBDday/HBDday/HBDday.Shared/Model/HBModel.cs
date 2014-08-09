using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace HBDday.Model
{
    public enum BackgroundTypes
    {
        Image = 0,
        Color = 1
    }

    public class HBModel : INotifyPropertyChanged
    {
        #region string Title
        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                OnPropertyChanged("Title");
            }
        }
        #endregion string Title

        #region DateTime DDay
        private DateTime _DDay;
        public DateTime DDay
        {
            get
            {
                return _DDay;
            }
            set
            {
                _DDay = value;
                OnPropertyChanged("DDay");
            }
        }
        #endregion DateTime DDay

        #region bool UseAlarm
        private bool _UseAlarm;
        public bool UseAlarm
        {
            get
            {
                return _UseAlarm;
            }
            set
            {
                _UseAlarm = value;
                OnPropertyChanged("UseAlarm");
            }
        }
        #endregion bool UseAlarm

        #region string ImagePath
        private string _ImagePath;
        public string ImagePath
        {
            get
            {
                return _ImagePath;
            }
            set
            {
                _ImagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }
        #endregion string ImagePath

        #region Color BackgroundColor
        private Color _BackgroundColor;
        public Color BackgroundColor
        {
            get
            {
                return _BackgroundColor;
            }
            set
            {
                _BackgroundColor = value;
                OnPropertyChanged("BackgroundColor");
            }
        }
        #endregion Color BackgroundColor

        #region BackgroundTypes BackgroundType
        private BackgroundTypes _BackgroundType;
        public BackgroundTypes BackgroundType
        {
            get
            {
                return _BackgroundType;
            }
            set
            {
                _BackgroundType = value;
                OnPropertyChanged("BackgroundType");
            }
        }
        #endregion BackgroundTypes BackgroundType




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
