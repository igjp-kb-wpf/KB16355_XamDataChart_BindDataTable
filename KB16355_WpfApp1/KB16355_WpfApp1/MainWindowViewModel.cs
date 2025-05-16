using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB16355_WpfApp1;
internal class MainWindowViewModel
{
    private DataTable _energyProductionTable;

    public DataView? EnergyProductionView
    {
        get => _energyProductionTable?.DefaultView;
    }

    public MainWindowViewModel()
    {
        _energyProductionTable = new ();

        _energyProductionTable.Columns.Add("Country");  // X軸に表示するラベル
        _energyProductionTable.Columns.Add("Coal", typeof(double));   // 値1つめ
        _energyProductionTable.Columns.Add("Gas", typeof(double));    // 値2つめ
        _energyProductionTable.Columns.Add("Hydro", typeof(double));  // 値3つめ

        _energyProductionTable.Rows.Add([ "Country1", 86.4505134, 103.2891932, 126.0406841 ]);
        _energyProductionTable.Rows.Add([ "Country2", 114.0853903, 82.48463306, 125.9912834 ]);
        _energyProductionTable.Rows.Add([ "Country3", 127.4458425, 97.7079237, 123.3935982 ]);
        _energyProductionTable.Rows.Add([ "Country4", 102.5485605, 86.98280705, 114.6298345 ]);
    }
}
