using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace WorkWithFiles
{
    /*Внутрь листа поместить лист,*/
    class ProductList : List<Product>
    {
        //public List<Product> ProdList;

        public void TextFileToProductList(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                //for (int i = 0;i < )
            }
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
                }
            }
            
        }

        public void ProductListToBinaryFile(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
                //bf.Serialize(fs, this);
                
            }
        }

        public void BinaryFileToProductList(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Clear();
                //this = bf.Deserialize(fs);
            }
        }

        public void DGVToProductList(DataGridView DGV)
        {
            for (int i = 0; i < DGV.RowCount - 1; i++)
            {
                bool OK = true;
                for (int j = 0; j < 5 && OK ; j++)
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
        }
        public void ProductListToDGV(DataGridView DGV)
        {
            DGV.Rows.Clear();
            DGV.Refresh();
            for (int i = 0; i < this.Count; i++)
            {
                DGV.Rows.Add();
                DGV.Rows[i].HeaderCell.Value = i + 1;
                DGV.Rows[i].Cells[0].Value = this[i].Code;
                DGV.Rows[i].Cells[1].Value = this[i].Kind.ToString();
                DGV.Rows[i].Cells[2].Value = this[i].Name;
                DGV.Rows[i].Cells[3].Value = this[i].Price;
                DGV.Rows[i].Cells[4].Value = this[i].Amount;
            }

        }
    }
}
