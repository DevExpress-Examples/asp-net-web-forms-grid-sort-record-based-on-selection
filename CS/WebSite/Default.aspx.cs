using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {

    protected void ASPxGridView1_CustomColumnSort(object sender, DevExpress.Web.CustomColumnSortEventArgs e) {
        ASPxGridView grid = sender as ASPxGridView;
        bool isRow1Selected = grid.Selection.IsRowSelectedByKey(e.GetRow1Value(grid.KeyFieldName));
        bool isRow2Selected = grid.Selection.IsRowSelectedByKey(e.GetRow2Value(grid.KeyFieldName));
        e.Handled = isRow1Selected != isRow2Selected;
        if(e.Handled) {
            if(e.SortOrder == DevExpress.Data.ColumnSortOrder.Descending)
                e.Result = isRow1Selected ? 1 : -1;
            else
                e.Result = isRow1Selected ? -1 : 1;
        }
    }
}