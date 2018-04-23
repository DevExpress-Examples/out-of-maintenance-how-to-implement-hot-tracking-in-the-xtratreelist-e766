' Developer Express Code Central Example:
' How to implement hot tracking in the XtraTreeList
' 
' This example demonstrates how to change the appearance of grid rows when the
' mouse is hovered over them. For more information, please review the
' http://www.devexpress.com/scid=A1099 Knowledge Base Article.
' 
' See also:
' <kblink id = "A998"/>
' TreeList.NodeCellStyle Event
' (ms-help://MS.VSCC.v80/MS.VSIPCC.v80/DevExpress.NETv8.3/DevExpress.XtraTreeList/DevExpressXtraTreeListTreeList_NodeCellStyletopic.htm)
' TreeList.CalcHitInfo
' Method
' (ms-help://MS.VSCC.v80/MS.VSIPCC.v80/DevExpress.NETv8.3/DevExpress.XtraTreeList/DevExpressXtraTreeListTreeList_CalcHitInfotopic.htm)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E766


Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Runtime.CompilerServices

'
' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
'
<Assembly: AssemblyTitle("")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("")>
<Assembly: AssemblyCopyright("")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

'
' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:

<Assembly: AssemblyVersion("1.0.*")>

'
' In order to sign your assembly you must specify a key to use. Refer to the 
' Microsoft .NET Framework documentation for more information on assembly signing.
'
' Use the attributes below to control which key is used for signing. 
'
' Notes: 
'   (*) If no key is specified, the assembly is not signed.
'   (*) KeyName refers to a key that has been installed in the Crypto Service
'       Provider (CSP) on your machine. KeyFile refers to a file which contains
'       a key.
'   (*) If the KeyFile and the KeyName values are both specified, the 
'       following processing occurs:
'       (1) If the KeyName can be found in the CSP, that key is used.
'       (2) If the KeyName does not exist and the KeyFile does exist, the key 
'           in the KeyFile is installed into the CSP and used.
'   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
'       When specifying the KeyFile, the location of the KeyFile should be
'       relative to the project output directory which is
'       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
'       located in the project directory, you would specify the AssemblyKeyFile 
'       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
'   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
'       documentation for more information on this.
'
<Assembly: AssemblyDelaySign(False)>
<Assembly: AssemblyKeyFile("")>
<Assembly: AssemblyKeyName("")>
