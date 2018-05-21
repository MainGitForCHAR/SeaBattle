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
    /// Interaction logic for FieldControl.xaml
    /// </summary>
    public partial class FieldControl : UserControl
    {


        public Cell[,] CellsField
        {
            get { return (Cell[,])GetValue(CellsFieldProperty); }
            set { SetValue(CellsFieldProperty, value); AddCells(); }
        }

        private void AddCells()
        {
            for (int row = 0; row < 10; row++)
            {
                for (int column = 0; column < 10; column++)
                {
                    FieldUG.Children.Add(new CellControl() { OwnCell = CellsField[row, column] });
                }
            }
        }

        public static readonly DependencyProperty CellsFieldProperty = DependencyProperty.Register("CellsField", typeof(Cell[,]), typeof(FieldControl), new PropertyMetadata(0));


        public FieldControl()
        {
            InitializeComponent();
        }
    }
}
