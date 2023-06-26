using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationWithDB
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateXml_Click(object sender, EventArgs e)
        {
            //create a new, empty docuement
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            System.Xml.XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            //create and insert a new element
            System.Xml.XmlNode productsNode = doc.CreateElement("products");
            doc.AppendChild(productsNode);


            //Create a nested element (with an attribute)
            System.Xml.XmlNode productNode = doc.CreateElement("product");
            System.Xml.XmlAttribute productAttribute = doc.CreateAttribute("id");
            productAttribute.Value = "1001";
            productNode.Attributes.Append(productAttribute);
            productsNode.AppendChild(productNode);


            //create and add the sub-elements for this product node
            //(with contained text data)

            System.Xml.XmlNode nameNode = doc.CreateElement("productName");
            nameNode.AppendChild(doc.CreateTextNode("3 in 1 coffee"));
            productNode.AppendChild(nameNode);
            System.Xml.XmlNode priceNode = doc.CreateElement("ProductPrice");
            productNode.AppendChild(doc.CreateTextNode("6.99"));
            productNode.AppendChild(priceNode);

            //save the document
            doc.Save(Server.MapPath("first.xml"));
        }
        protected void Insert_Click(object sender, EventArgs e)
        {
            //load Xml document
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.Load(Server.MapPath("first.xml"));

            //create a nested eleement (with an attribute).
            System.Xml.XmlNode productNode = doc.CreateElement("product");
            System.Xml.XmlAttribute productAttribute = doc.CreateAttribute("id");
            productAttribute.Value = this.RegNum.Text;
            productNode.Attributes.Append(productAttribute);
            doc.DocumentElement.AppendChild(productNode);

            //create and add the subelements for this product node (with contained text data.)
            System.Xml.XmlNode nameNode = doc.CreateElement("productName");
            nameNode.AppendChild(doc.CreateTextNode(this.PName.Text));
            productNode.AppendChild(nameNode);

            //create and add the subelements for this product node
            //(with contained text data.)
            System.Xml.XmlNode priceNode = doc.CreateElement("price");
            priceNode.AppendChild(doc.CreateTextNode(this.PPrice.Text));
            productNode.AppendChild(priceNode) ;

            //Save document
            doc.Save(Server.MapPath("first.xml"));



        }

    }
}