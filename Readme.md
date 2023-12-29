<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128535838/13.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20066)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# GridView for ASP.NET Web Forms - How to sort records based on selection

This example demonstrates how to handle the grid's `CustomColumnSort` event to sort records based on their selection state.

## Overview

Since [GridViewCommandColumn](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewCommandColumn) holds the command/interactive visual elements (but not column data), clicking its header does not perform any data shaping operation (such as sorting). If you need to perform data sorting based on the row's selection state (for instance, always display selected rows on top), consider implementing custom data sorting:

* Set each column's [Settings.SortMode](https://docs.devexpress.com/AspNet/DevExpress.Web.GridDataColumnSettings.SortMode) property to `Custom`.
* Handle the [CustomColumnSort](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView.CustomColumnSort) event. If both rows that should be compared have the same selection state, set the [e.Handled](https://docs.devexpress.com/AspNet/DevExpress.Web.GridCustomColumnSortEventArgs.Handled) argument property to `False` in order to apply the default data comparing/sorting rules. If not, set the `e.Handled` argument property to `True` and treat a selected row as a "stronger" one using the [e.Result](https://docs.devexpress.com/AspNet/DevExpress.Web.GridCustomColumnSortEventArgs.Result) argument property.

## Files to Review

* [Default.aspx](./CS/WebSite/Default.aspx)
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs)
