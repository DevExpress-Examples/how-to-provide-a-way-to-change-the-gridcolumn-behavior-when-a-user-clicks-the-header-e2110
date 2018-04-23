using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using DevExpress.Data;
using DevExpress.Xpf.Grid;

namespace DXGridTest {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 10; i++) {
                list.Add(new TestData() 
                    { Text = "Row" + i, Number = i });
            }

            grid.DataSource = list;
        }
    }

    public class TestData {
        public string Text { get; set; }
        public int Number { get; set; }
    }

    public class MyTableView : TableView {
        protected override void OnColumnHeaderClick(ColumnBase column, bool isShift, bool isCtrl) {
            base.OnColumnHeaderClick(column, isShift, 
                column.SortOrder == ColumnSortOrder.Descending);
        }
    }
}
