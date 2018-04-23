# How to implement hot tracking in the XtraTreeList


<p>This example demonstrates how to change the appearance of grid rows when the mouse is hovered over them. For more information, please review the <a href="https://www.devexpress.com/Support/Center/p/A1099">How to implement hot tracking in the XtraTreeList</a> Knowledge Base Article.</p><p><strong>See also: </strong><br />
<a href="https://www.devexpress.com/Support/Center/p/A998">A998</a><br />
<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_NodeCellStyletopic"><u>TreeList.NodeCellStyle Event </u></a><br />
<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraTreeListTreeList_CalcHitInfotopic"><u>TreeList.CalcHitInfo Method </u></a></p>


<h3>Description</h3>

<p>The behavior of the TreeList.InvalidateNode method was changed after fixing the <a data-ticket="B194074">B194074</a> bug. Starting from version v2010 vol 2.6, InvalidateNode doesn&#39;t cause node repainting anymore. To raise the NodeCellStyle event, the new method RefreshNode should be used.</p>

<br/>


