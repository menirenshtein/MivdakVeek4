using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace MivdakVeek4
{
    public partial class Form1 : Form
    {
        XmlDocument xmldocument = new XmlDocument();
        string pathName = Directory.GetCurrentDirectory() + "\\JewishDates.xml";

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(pathName))
            {
                try
                {
                    xmldocument.Load(pathName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading XML file : " + ex.Message);
                }
            }
            else
            {
                XmlNode root = xmldocument.CreateElement("queries");

                xmldocument.AppendChild(root);
                xmldocument.Save(pathName);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            XmlNode query = xmldocument.CreateElement("query");
            string result = "";
            int index = 4;
            while (index > 0)
            {
                foreach (Control ctr in Controls)
                {
                    if (ctr is ComboBox)
                    {
                        if (ctr.Name == "cmbDay")
                        {
                            string u = "";
                            switch (ctr.Text)
                            {
                                case "ראשון":
                                    u = "באחד בשבת ";
                                    break;
                                case "שני":
                                    u = " בשני בשבת";
                                    break;
                                case "שלישי ":
                                    u = "בשלישי בשבת ";
                                    break;
                                case "רביעי":
                                    u = " ברביעי בשבת";
                                    break;
                                case "חמישי":
                                    u = "בחמישי בשבת ";
                                    break;
                                case "שישי":
                                    u = "בשישי בשבת ";
                                    break;
                            }
                            result += u;
                            index -= 1;
                            query.AppendChild(xmldocument.CreateElement("day")).InnerText =u ;
                        }
                        if (ctr.Name == "cmbDate")
                        {
                            string u = ""; 
                            switch (ctr.Text)
                            {
                                case "1":
                                    u = "יום אחד לירח";
                                    break;
                                case "2":
                                    u  = "שני ימים לירח";
                                    break;
                                case "3":
                                    u = " שלושה ימים לירח";
                                    break;
                                case "4":
                                    u = "ארבעה ימים לירח";
                                    break;
                                case "5":
                                    u = "חמישה ימים לירח ";
                                    break;
                                case "6":
                                    u= "ששה ימים לירח ";
                                    break;
                                case "7":
                                    u = "שבעה ימים לירח";
                                    break;
                                case "8":
                                    u= "שמנה ימים לירח";
                                    break;
                                case "9":
                                    u= "תשעה ימים לירח ";
                                    break;
                                case "10":
                                    u= "עשרה יום לירח ";
                                    break;
                                case "11":
                                    u += "אחד עשר יום לירח ";
                                    break;
                                case "12":
                                    u += "שנים עשר יום לירח ";
                                    break;
                                case "13":
                                    u += "שלשה עשר יום לירח ";
                                    break;
                                case "14":
                                    u += "ארבע עשר יום לירח ";
                                    break;
                                case "15":
                                    u += "חמשה עשר יום לירח ";
                                    break;
                                case "16":
                                    u += "ששה עשר יום לירח ";
                                    break;
                                case "17":
                                    u += "שבעה עשר יום לירח  ";
                                    break;
                                case "18":
                                    u += "שמנה עשר יום לירח  ";
                                    break;
                                case "19":
                                    u += "תשעה עשר יום לירח ";
                                    break;
                                case "20":
                                    u += "עשרים יום לירח ";
                                    break;
                                case "21":
                                    u += "אחד ועשרים יום לירח";
                                    break;
                                case "22":
                                    u += "שנים ועשרים יום לירח ";
                                    break;
                                case "23":
                                    u += "שלשה ועשרים יום לירח ";
                                    break;
                                case "24":
                                    u += "ארבעה ועשרים יום לירח ";
                                    break;
                                case "25":
                                    u += "חמשה ועשרים יום לירח ";
                                    break;
                                case "26":
                                    u += "ששה ועשרים יום לירח ";
                                    break;
                                case "27":
                                    u += "שבעה ועשרים יום לירח ";
                                    break;
                                case "28":
                                    u += "שמנה ועשרים יום לירח ";
                                    break;
                                case "29":
                                    u += "תשעה ועשרים יום לירח ";
                                    break;
                                case "30":
                                    u += " יום שלושים שהוא ראש חודש ";
                                    break;
                            }
                            index -= 1;
                            result += u;
                            query.AppendChild(xmldocument.CreateElement("date")).InnerText = u;
                        }
                        if (ctr.Name == "cmbMounth")
                        {
                            string u = "";
                            switch (ctr.Text)
                            {
                                case "תשרי":
                                    u += "תשרי ";
                                    break;
                                case "חשוון ":
                                    u += "מרחשוון";
                                    break;
                                case "כסליו":
                                    u += "כסליו";
                                    break;
                                case "טבת":
                                    u += "טבת ";
                                    break;
                                case "אדר":
                                    u += " אדר";
                                    break;
                                case "אדר א":
                                    u += "אדר הראשון ";
                                    break;
                                case "אדר ב":
                                    u += "אדר השני ";
                                    break;
                                case "ניסן":
                                    u += "ניסן ";
                                    break;
                                case "אייר":
                                    u += "אייר";
                                    break;
                                case "סיוון":
                                    u += "סיוון";
                                    break;
                                case "תמוז":
                                    u += "תמוז ";
                                    break;
                                case "אב ":
                                    u += "אב ";
                                    break;
                                case "אלול ":
                                    u += "אלול ";
                                    break;
                            }
                            result += u;
                            index -= 1;
                            query.AppendChild(xmldocument.CreateElement("mounth")).InnerText =u;
                        }
                        if (ctr.Name == "cmbYear")
                        {
                            string u = "";
                            
                            switch (ctr.Text)
                            {
                                case "תשפד":
                                    u += " וארבע לבריאת העולם ";
                                    break;
                                case "תשפה":
                                    u += "וחמש לבריאת העולם ";
                                    break;
                                case "תשפו":
                                    u += "ושש לבריאת העולם ";
                                    break;
                                case "תשפז":
                                    u += "ושבע לבריאת העולם ";
                                    break;
                                case "תשפח":
                                    u += "ושמנה לבריאת העולם ";
                                    break;

                            }
                            result += " שנת חמשת אלפים ושבע מאות ושמנים" += u;
                            index -= 1;
                            query.AppendChild(xmldocument.CreateElement("year")).InnerText = u;
                        }
                    }
                }
            }
                query.AppendChild(xmldocument.CreateElement("result")).InnerText = result;
                xmldocument.FirstChild.AppendChild(query);
                xmldocument.Save(pathName);
                txtRES.Text = result;
        }
    }
}


//                    if (ctr == cmbDay) controls[0] = ctr;
//                    if (ctr == cmbDate) controls[1] = ctr;
//                    if (ctr == cmbMounth) controls[2] = ctr;
//                    if(ctr == cmbYear) controls[3] = ctr;
//                }
//            }
//            for (int i = 0; i < controls.Length; i++)
//{
