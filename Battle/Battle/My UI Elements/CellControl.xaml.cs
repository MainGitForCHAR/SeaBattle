using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battle.My_UI_Elements
{
    /// <summary>
    /// Interaction logic for CellControl.xaml
    /// </summary>
    public partial class CellControl : UserControl
    {
        private Cell ownCell;

        public Cell OwnCell
        {
            get { return ownCell; }
            set { ownCell = value; InitPicture(); }
        }

        private void InitPicture()
        {
            CellView.Source = OwnCell.CurrentView;
        }

        public CellControl()
        {
            InitializeComponent();
        }
    }
}
