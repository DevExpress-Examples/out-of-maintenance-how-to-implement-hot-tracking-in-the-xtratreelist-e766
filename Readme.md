<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637736/10.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E766)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to implement hot tracking in the XtraTreeList


<p>This example demonstrates how to change the appearance of grid rows when the mouse is hovered over them. For more information, please review the <a href="https://www.devexpress.com/Support/Center/p/A1099">How to implement hot tracking in the XtraTreeList</a> Knowledge Base Article.</p><p><strong>See also: </strong><br />
<a href="https://www.devexpress.com/Support/Center/p/A998">A998</a><br />
<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_NodeCellStyletopic"><u>TreeList.NodeCellStyle Event </u></a><br />
<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_CalcHitInfotopic"><u>TreeList.CalcHitInfo Method </u></a></p>


<h3>Description</h3>

<p>The behavior of the TreeList.InvalidateNode method was changed after fixing the <a data-ticket="B194074">B194074</a> bug. Starting from version v2010 vol 2.6, InvalidateNode doesn&#39;t cause node repainting anymore. To raise the NodeCellStyle event, the new method RefreshNode should be used.</p>

<br/>


