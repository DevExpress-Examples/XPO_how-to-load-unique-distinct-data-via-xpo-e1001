<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128586071/20.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1001)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XPO_how-to-load-unique-distinct-data-via-xpo-e1001&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=XPO_how-to-load-unique-distinct-data-via-xpo-e1001&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
