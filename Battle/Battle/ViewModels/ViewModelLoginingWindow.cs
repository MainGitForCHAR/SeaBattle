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
        }

        
        public string Login { get; set; }
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
            return !string.IsNullOrEmpty(Login) && Login.Length > 3;
        }
    }
}
