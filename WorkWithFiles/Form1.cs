using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WorkWithFiles
{
    public partial class MainForm : Form
    {
        const string StrAmount = "Количество элементов: ";
        ProductList ProdList = new ProductList();
        public MainForm()
        {
            InitializeComponent();
            tsslAmount.Text = "";
            dgvFile.TopLeftHeaderCell.Value = "№";
        }

        private void MS_Click(object sender, EventArgs e)
        {

        }

        private void TSEdit_Click(object sender, EventArgs e)
        {
            using (InputForm taskForm = new InputForm("Изменение товара","Введите код изменяемого товара:"))
            {
                taskForm.ShowDialog();
                if (!taskForm.isCancel)
                {
                    int CodeNum;
                    if (!Int32.TryParse(taskForm.Info, out CodeNum))
                    {
                        MessageBox.Show("Вы ввели некорректный код!", "Ошибка");
                    }
                    else if (ProdList.Exists(x => x.Code == CodeNum))
                    {
                        int prodNum = ProdList.FindIndex(x => x.Code == CodeNum);
                        using (TaskForm editForm = new TaskForm(ProdList[prodNum]))
                        {
                            editForm.Edit();
                            if (!ProdList.Exists(x => x.Code == editForm.Prod.Code))
                            {
                                ProdList[prodNum] = editForm.Prod;
                                ProdList.ProductListToDGV(dgvFile);
                            }
                            else
                            {
                                MessageBox.Show("Товар с таким кодом уже есть в списке!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Товар с данным кодом не был найден!", "Ошибка");
                    }
                }
            }
        }
        private void TSEditFind_Click(object sender, EventArgs e)
        {
            using (InputForm taskForm = new InputForm("Поиск товара", "Введите код товара:"))
            {
                taskForm.ShowDialog();
                if (!taskForm.isCancel)
                {
                    int CodeNum;
                    if (!Int32.TryParse(taskForm.Info, out CodeNum))
                    {
                        MessageBox.Show("Вы ввели некорректный код!", "Ошибка");
                    }
                    else if (ProdList.Exists(x => x.Code == CodeNum))
                    {
                        int prodNum = ProdList.FindIndex(x => x.Code == CodeNum);
                        using (TaskForm findForm = new TaskForm(ProdList[prodNum]))
                        {
                            findForm.Find();
                            if (!ProdList.Exists(x => x.Code == findForm.Prod.Code))
                            {
                                ProdList[prodNum] = findForm.Prod;
                                ProdList.ProductListToDGV(dgvFile);
                            }
                            else
                            {
                                MessageBox.Show("Товар с таким кодом уже есть в списке!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Товар с данным кодом не был найден!", "Ошибка");
                    }
                }
            }
        }
        private void TSEditDelete_Click(object sender, EventArgs e)
        {
            using (InputForm Form = new InputForm("Удаление объекта", "Введите код удаляемого объекта:"))
            {
                Form.ShowDialog();
                if (!Form.isCancel)
                {
                    int CodeNum;
                    if (!Int32.TryParse(Form.Info, out CodeNum))
                    {
                        MessageBox.Show("Вы ввели некорректный код!", "Ошибка");
                    }
                    else if (ProdList.Exists(x => x.Code == CodeNum))
                    {
                        ProdList.Remove(ProdList.Find(x => x.Code == CodeNum));
                        ProdList.ProductListToDGV(dgvFile);
                        //MessageBox.Show(ProdList.Count.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Товар с данным кодом не был найден!", "Ошибка");
                    }
                }
            }
        }
        private void TSEditAdd_Click(object sender, EventArgs e)
        {
            using (TaskForm addForm = new TaskForm())
            {
                addForm.Add();
                if (!addForm.IsCancel)
                {
                    if (!ProdList.Exists(x => x.Code == addForm.Prod.Code))
                    {
                        ProdList.Add(addForm.Prod);
                        ProdList.ProductListToDGV(dgvFile);
                    }
                    else
                    {
                        MessageBox.Show("Товар с таким кодом уже существует!");
                    }
                }
            }
            MSFile.Select();
        }

        private void TSFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            ProdList.BinaryFileToProductList(openFileDialog.FileName);
            ProdList.ProductListToDGV(dgvFile);
        }

        private void TSFileSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void TSFileClose_Click(object sender, EventArgs e)
        {
            
        }

        private void MSFile_Click(object sender, EventArgs e)
        {

        }

        private void TSFileCreate_Click(object sender, EventArgs e)
        {

        }

        private void Тест1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvFile.Rows[0].HeaderCell.Value = "1";
        }

        private void Test2MI_Click(object sender, EventArgs e)
        {
            ProdList.ProductListToDGV(dgvFile);
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void DgvFile_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //tsslAmount.Text = StrAmount + Convert.ToString(ProdList.Count);
            //MessageBox.Show(Convert.ToString(ProdList.Count));
        }

        private void TSEditClear_Click(object sender, EventArgs e)
        {
            ProdList.Clear();
            ProdList.ProductListToDGV(dgvFile);
        }

        private void RowsChanged(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //MessageBox.Show(e.ToString());
            dgvFile.Rows[e.RowIndex].HeaderCell.Value = e.RowIndex + 1;
            tsslAmount.Text = StrAmount + Convert.ToString(ProdList.Count);
        }

        private void RowsChanged(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tsslAmount.Text = StrAmount + Convert.ToString(ProdList.Count);
        }

        private void MouseLeft(object sender, EventArgs e)
        {
            //MainForm.Select();
        }

        private void ТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProdList.ProductListToTextFile(saveAsFileDialog.FileName);
            }
        }

        private void MenuSaveAsBinaryFile_Click(object sender, EventArgs e)
        {
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProdList.ProductListToBinaryFile(saveAsFileDialog.FileName);
            }
        }

        private void DgvFile_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.HeaderCell.Value = e.Row.Index + 1;
        }
    }
}
