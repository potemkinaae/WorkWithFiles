using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFiles
{

    [Serializable]
    public class Product
    {
        private int code { get; set; }
        public int Code
        {
            get
            {
                return code;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} - недопустимое значение кода!");
                }
                code = value;
            }
        }

        private SAcs kind;
        public SAcs Kind;

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} - недопустимое значение цены!");
                }
                price = value;
            }
        }
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} - недопустимое значение количества!");
                }
                amount = value;
            }
        }

        public Product(int ACode = 0, SAcs AKind = new SAcs(), string AName = "", double APrice = 0, int AAmount = 0)
        {
            code = ACode;
            kind = AKind;
            name = AName;
            price = APrice;
            amount = AAmount;
        }

    }
}
