using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithFiles
{

    public partial class TaskForm : Form
    {
        public Product Prod;
        public bool IsCancel;
        public TaskForm(Product prod = null)
        {
            InitializeComponent();
            IsCancel = true;
            if (prod != null)
            {
                tbCode.Text = prod.Code.ToString();
                tbType.Text = prod.Kind.ToString();
                tbName.Text = prod.Name;
                tbPrice.Text = prod.Price.ToString();
                tbAmount.Text = prod.Amount.ToString();
            }
        }

        public void ReadOnly()
        {
            tbCode.ReadOnly = false;
            tbType.ReadOnly = false;
            tbName.ReadOnly = false;
            tbPrice.ReadOnly = false;
            tbAmount.ReadOnly = false;
            btAct.Text = "Изменить";
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Add()
        {
            btAct.Text = "Добавить";
            ShowDialog();
        }

        public void Edit()
        {
            btAct.Text = "Изменить";
            ShowDialog();

        }

        public void Find()
        {
            tbCode.ReadOnly = true;
            tbType.ReadOnly = true;
            tbName.ReadOnly = true;
            tbPrice.ReadOnly = true;
            tbAmount.ReadOnly = true;
            btAct.Text = "Начать изменение";
            ShowDialog();
        }

        private void BtAct_Click(object sender, EventArgs e)
        {
            int Code;
            string Name;
            double Price;
            int Amount;
            if (tbCode.ReadOnly == true)
            {
                tbCode.ReadOnly = false;
                tbType.ReadOnly = false;
                tbName.ReadOnly = false;
                tbPrice.ReadOnly = false;
                tbAmount.ReadOnly = false;
                btAct.Text = "Изменить";
            }
            else if (Int32.TryParse(tbCode.Text,out Code) && tbName.Text != "" &&
                     Double.TryParse(tbPrice.Text,out Price) && Int32.TryParse(tbAmount.Text,out Amount))
            {
                SAcs Acs = new SAcs(EnumAcs.None);
                Acs.TryStringToAcs(tbType.Text);
                Name = tbName.Text;
                Prod = new Product(Code, Acs, Name, Price, Amount);
                IsCancel = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ошибка", "Вы ввели некорректные данные, повторите ввод.", MessageBoxButtons.OK);
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
