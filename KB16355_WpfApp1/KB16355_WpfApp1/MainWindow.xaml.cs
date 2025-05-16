using Infragistics.Controls.Charts;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB16355_WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var chart = this.xamDataChart1;
            var xAxis = this.xAxis;
            var yAxis = this.yAxis;

            var dataView = chart.DataContext as DataView;
            if (dataView == null) return;

            var dataTable = dataView.Table;
            if (dataTable == null) return;

            foreach(DataColumn column in dataTable.Columns)
            {
                // 1列目はX軸に表示するラベルなのでスキップします。
                if (dataTable.Columns.IndexOf(column) == 0) continue;

                chart.Series.Add(new ColumnSeries()
                {
                    XAxis = xAxis,
                    YAxis = yAxis,
                    ItemsSource = dataView,
                    ValueMemberPath = column.ColumnName,
                    Title = column.ColumnName,
                });
            }
        }
    }
}