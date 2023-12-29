<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128535838/12.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20066)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# ASPxGridView - How to sort records by selection


<p>Since <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebGridViewCommandColumntopic">GridViewCommandColumn</a> holds the command/interactive visual elements (but not any column's data), clicking its header does not perform any data shaping operation (such as sorting). If you need to perform data sorting based on the row's selection state (for instance, always display selected rows on top), consider implementing custom data sorting:<br><br>- Set each column's <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebGridViewDataColumnSettings_SortModetopic">Settings.SortMode</a> property to <strong>Custom</strong>.<br>- Handle the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_CustomColumnSorttopic">ASPxGridView.CustomColumnSort</a> event.<br>- If both rows that should be compared have the same selection state, set the EventArgs <strong>e.Handled</strong> property to False in order to apply the default data comparing/sorting rules.<br>- If not, set the EventArgs <strong>e.Handled</strong> property to True and treat a selected row as a "stronger" one using the EventArgs <strong>e.Result</strong> property.</p>

<br/>


