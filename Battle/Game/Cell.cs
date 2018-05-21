using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Game
{
    public class Cell : INotifyPropertyChanged
    {
        public StateCell State { get; private set; }
        private BitmapImage currentView;
        public BitmapImage CurrentView
        {
            get { return currentView; }
            private set { currentView = value; OnPropertyChanged("CurrentView"); }
        }

        public bool Blocked { get; set; }
        public Point coords { get; private set; }

        public Cell(int x, int y)
        {
            State = StateCell.ClearCell;
            CurrentView = new BitmapImage(new Uri(@"D:\_My\SeaWar\Mechanics\immage\Miss.jpg"));
            coords = new Point(x, y);
            Blocked = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void ChangeState(StateCell RightState)
        {
            switch ((int)RightState)
            {
                case 0:
                    CurrentView = new BitmapImage(new Uri(@"immage\Clear.jpg"));
                    State = RightState;
                    break;
                case 1:
                    CurrentView = new BitmapImage(new Uri(@"immage\Filled.jpg"));
                    State = RightState;
                    break;
                case 2:
                    CurrentView = new BitmapImage(new Uri(@"immage\Dead.jpg"));
                    State = RightState;
                    break;
                case 3:
                    CurrentView = new BitmapImage(new Uri(@"immage\Miss.jpg"));
                    State = RightState;
                    break;
            }
        }
    }

}
