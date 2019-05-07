using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace WorkWithFiles
{
    [Serializable]
    class ProductList : List<Product>
    {
        //public List<Product> ProdList;
        private static bool GetValueFromFile(StreamReader sr, out string Str)
        {
            bool OK = !sr.EndOfStream;
            Str = "";
            if (OK)
            {
                Str = sr.ReadLine();
                Str = Str.Substring(Str.IndexOf(':') + 2);
                //MessageBox.Show(Str);
            }
            return OK;
        }

        private static Product GetProductFromFile(StreamReader sr)
        {
            bool OK = !sr.EndOfStream;
            string StrCode = "";
            string StrAcs = "";
            string StrName = "";
            string StrPrice = "";
            string StrAmount = "";
            OK = GetValueFromFile(sr, out StrCode) && 
                 GetValueFromFile(sr, out StrAcs) &&  
                 GetValueFromFile(sr, out StrName) && 
                 GetValueFromFile(sr, out StrPrice) &&
                 GetValueFromFile(sr, out StrAmount);
            sr.ReadLine();
            if (OK)
            {
                int Code = 0;
                SAcs Acs = new SAcs();
                double Price = 0;
                int Amount = 0;
                if (OK && Int32.TryParse(StrCode, out Code) && Double.TryParse(StrPrice, out Price) && 
                          Int32.TryParse(StrAmount, out Amount) && StrName != "")
                {
                    Acs.TryStringToAcs(StrAcs);
                    Product prod = new Product(Code, Acs, StrName, Price, Amount);
                    return prod;
                }
            }
            return null;
        }


        public bool TextFileToProductList(string path)
        {
            Clear();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    Product prod = GetProductFromFile(sr);
                    if (prod != null)
                    {
                        this.Add(prod);
                    }
                }
            }
            return this.Count != 0;
        }
        public void ProductListToTextFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < this.Count; i++)
                {
                    sw.WriteLine("Код: " + Convert.ToString(this[i].Code));
                    sw.WriteLine("Вид: " + this[i].Kind.ToString());
                    sw.WriteLine("Наименование: " + this[i].Name);
                    sw.WriteLine("Цена: " + Convert.ToString(this[i].Price));
                    sw.WriteLine("Количество: " + Convert.ToString(this[i].Amount));
                    sw.WriteLine();
                }
            }
            
        }

        public void ProductListToBinaryFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
            }
        }

        public bool BinaryFileToProductList(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Clear();
                try
                {
                    foreach (Product prod in (ProductList)bf.Deserialize(fs))
                    {
                        this.Add(prod);
                    }
                }
                catch
                {
                    return false;
                }
                return true;
            }
        }

        private static void AddChildNode(string childName, string childText, XmlElement parentNode, XmlDocument doc)
        {
            XmlElement child = doc.CreateElement(childName);
            child.InnerText = childText;
            parentNode.AppendChild(child);
        }

        public void ProductListToXMLFile(string path)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(xmlDeclaration);
            XmlElement root = doc.CreateElement("ProductList");
            foreach (Product prod in this)
            {
                XmlElement prodNode = doc.CreateElement("Product");
                AddChildNode("code", prod.Code.ToString(), prodNode, doc);
                AddChildNode("kind", prod.Kind.ToString(), prodNode, doc);
                AddChildNode("name", prod.Name, prodNode, doc);
                AddChildNode("price", prod.Price.ToString(), prodNode, doc);
                AddChildNode("amount", prod.Amount.ToString(), prodNode, doc);
                root.AppendChild(prodNode);
            }
            doc.AppendChild(root);
            doc.Save(path);
        }

        public bool XMLFileToProductList(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            if (doc.DocumentElement.LocalName == "ProductList")
            {
                foreach (XmlElement elem in doc.DocumentElement.ChildNodes)
                {
                    Product prod = null;
                    try
                    {
                        int Code = Convert.ToInt32(elem.ChildNodes[0].InnerText);
                        SAcs Acs = new SAcs();
                        Acs.TryStringToAcs(elem.ChildNodes[1].InnerText);
                        //MessageBox.Show(elem.ChildNodes[1].InnerText);
                        string Name = elem.ChildNodes[2].InnerText;
                        if (Name == "")
                        {
                            continue;
                        }
                        double Price = Convert.ToDouble(elem.ChildNodes[3].InnerText);
                        int Amount = Convert.ToInt32(elem.ChildNodes[4].InnerText);
                        prod = new Product(Code, Acs, Name, Price, Amount);
                    }
                    catch
                    {
                        continue;
                    }
                    this.Add(prod);
                }
            }
            return true;
        }

        /*public void DGVToProductList(DataGridView DGV)
        {
            for (int i = 0; i < DGV.RowCount - 1; i++)
            {
                bool OK = true;
                for (int j = 0; j < 5 && OK; j++)
                {
                    OK = DGV.Rows[i].Cells[j].Value != null;
                }
                if (!OK)
                {
                    continue;
                }
                Product prod = new Product();
                prod.Code = Convert.ToInt32(DGV.Rows[i].Cells[0].Value.ToString());
                prod.Kind.TryStringToAcs(DGV.Rows[i].Cells[1].Value.ToString());
                prod.Name = DGV.Rows[i].Cells[2].Value.ToString();
                prod.Price = Convert.ToDouble(DGV.Rows[i].Cells[3].Value.ToString());
                prod.Amount = Convert.ToInt32(DGV.Rows[i].Cells[4].Value.ToString());
                Add(prod);
            }
        }*/
        public void ProductListToDGV(DataGridView DGV)
        {
            DGV.Rows.Clear();
            DGV.Refresh();
            for (int i = 0; i < this.Count; i++)
            {
                DGV.Rows.Add();
                DGV.Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
                DGV.Rows[i].Cells[0].Value = this[i].Code;
                DGV.Rows[i].Cells[1].Value = this[i].Kind.ToString();
                DGV.Rows[i].Cells[2].Value = this[i].Name;
                DGV.Rows[i].Cells[3].Value = this[i].Price.ToString("0.00");
                DGV.Rows[i].Cells[4].Value = this[i].Amount;
            }
        }
    }
}
