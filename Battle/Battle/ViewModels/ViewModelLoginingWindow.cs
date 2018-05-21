using Battle.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Battle.ViewModels
{
    public class ViewModelLoginingWindow
    {
        public ViewModelLoginingWindow()
        {
            VSplayer = new Commands(_VSplayer, CanPlay);
            VScomputer = new Commands(_VScomputer, CanPlay);
            login = "";
        }


        private string login;

        public string Login
        {
            get { return login; }
            set { login = value;}
        }

        public ICommand VSplayer { get; set; }
        public ICommand VScomputer { get; set; }

        private void _VScomputer(object obj)
        {
            throw new NotImplementedException();
        }

        private void _VSplayer(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanPlay(object arg)
        {
            var s = arg as string;
            return !string.IsNullOrEmpty(s) && s.Length > 3;
        }
    }
}
