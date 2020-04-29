<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Distinct/Form1.cs) (VB: [Form1.vb](./VB/Distinct/Form1.vb))
* **[NorthwindObjects.cs](./CS/Distinct/NorthwindObjects.cs) (VB: [NorthwindObjects.vb](./VB/Distinct/NorthwindObjects.vb))**
<!-- default file list end -->
# How to load unique (distinct) data via XPO


<p><strong>Scenario</strong></p>
<p>This example illustrates how to load unique data via XPO. It is useful when your database contains a great amount of duplicated data and you need to find only unique values.<strong><br /></strong>There are three approaches for this task:<strong><br /></strong><br /><a href="http://documentation.devexpress.com/#XPO/CustomDocument2068"><em>XPView</em></a><em> <br /></em>Use the <a href="http://documentation.devexpress.com/#XPO/CustomDocument2068">XPView</a> component, add the required <a href="http://documentation.devexpress.com/#XPO/DevExpressXpoXPView_Propertiestopic">properties</a> to it, and set the properties' <a href="http://documentation.devexpress.com/#XPO/DevExpressXpoViewProperty_Grouptopic">Group</a> attribute to True.<br /><br /><em><a href="https://documentation.devexpress.com/#XPO/CustomDocument4060">LINQ</a></em><br />Use the <a href="https://documentation.devexpress.com/XPO/clsDevExpressXpoXPQuery~T~topic.aspx">XPQuery<T></a> class to construct LINQ expressions with the <a href="http://msdn.microsoft.com/en-us/library/vstudio/bb348436(v=vs.100).aspx">Distinct</a> method.<br /><br /><em><a href="https://documentation.devexpress.com/#XPO/clsDevExpressXpoPersistentAliasAttributetopic">PersistentAlias</a></em><br />Use <a href="https://documentation.devexpress.com/#XPO/CustomDocument8130">Free Joins</a> to build criteria based on persistent objects that are not directly related.</p>
<p><br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-load-unique-distinct-data-via-xpo-e1001/13.1.4+/media/5026aab6-65b1-11e4-80ba-00155d624807.png"><br /><br /></p>
<p>For implementation details, see the <em>Form1.xx </em>and<em> NorthwindObjects.xx files.<br /><br /></em><strong>See also:</strong><br /><a href="https://documentation.devexpress.com/#XPO/CustomDocument2034">Querying a Data Store</a></p>

<br/>


