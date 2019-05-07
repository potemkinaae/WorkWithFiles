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
        //Константа для количества элементов в StatusStrip
        const string StrAmount = "Количество элементов: ";
        //Создание списка продуктов
        static ProductList ProdList = new ProductList();
        //Тип открытого файла
        static int FileExt;
        //Путь открытого файла
        static string FilePath;
        //Был ли изменен файл
        static bool IsModified;
        public MainForm()
        {
            InitializeComponent();
            //Очистка StatusStrip и установка символа в хэдерсел
            tsslAmount.Text = "";
            dgvFile.TopLeftHeaderCell.Value = "№";
            TSFileSave.Enabled = false;
            IsModified = false;
            FilePath = "";
            FileExt = 0;
        }

        private void MS_Click(object sender, EventArgs e)
        {

        }
        //Изменение объекта
        private void TSEdit_Click(object sender, EventArgs e)
        {
            //Создание диалогового окна для поиска и изменения товара
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
                    //Поиск товара с заданным кодом
                    else if (ProdList.Exists(x => x.Code == CodeNum))
                    {
                        //Поиск индекса товара с заданным кодом
                        int prodNum = ProdList.FindIndex(x => x.Code == CodeNum);
                        using (TaskForm editForm = new TaskForm(ProdList[prodNum]))
                        {
                            editForm.Edit();
                            //Если товара с таким кодом не существует или код не менялся (изменение без кода)
                            if (!ProdList.Exists(x => x.Code == editForm.Prod.Code) || editForm.Prod.Code == prodNum)
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
            //Создание диалогового окна для поиска товара
            using (InputForm taskForm = new InputForm("Поиск товара", "Введите код товара:"))
            {
                taskForm.ShowDialog();
                if (!taskForm.isCancel)
                {
                    int CodeNum;
                    //Попытка парснуть код
                    if (!Int32.TryParse(taskForm.Info, out CodeNum))
                    {
                        MessageBox.Show("Вы ввели некорректный код!", "Ошибка");
                    }
                    //Если смогли найти товар по коду
                    else if (ProdList.Exists(x => x.Code == CodeNum))
                    {
                        int prodNum = ProdList.FindIndex(x => x.Code == CodeNum);
                        using (TaskForm findForm = new TaskForm(ProdList[prodNum]))
                        {
                            findForm.Find();
                            //Если товара с таким кодом не существует или код не менялся (изменение без кода)
                            if (!ProdList.Exists(x => x.Code == findForm.Prod.Code) || findForm.Prod.Code == prodNum)
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
                    //Если не парсится в число
                    if (!Int32.TryParse(Form.Info, out CodeNum))
                    {
                        MessageBox.Show("Вы ввели некорректный код!", "Ошибка");
                    }
                    //Если нашли товар с таким кодом
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
                    //Если товара с заданным кодом нет
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
            //MSFile.Select();
        }
        //Создание нового файла
        private void TSFileCreate_Click(object sender, EventArgs e)
        {
            if (IsModified)
            {
                if (SaveModified() == DialogResult.Cancel)
                {
                    return;
                }
            }
            ProdList.Clear();
            ProdList.ProductListToDGV(dgvFile);
            TSFileSave.Enabled = false;
            IsModified = false;
        }

        //Различные тесты
        private void Тест1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(IsModified));
        }
        private void Test2MI_Click(object sender, EventArgs e)
        {
            ProdList.ProductListToDGV(dgvFile);
        }
        //Очистка листа и таблицы
        private void TSEditClear_Click(object sender, EventArgs e)
        {
            ProdList.Clear();
            ProdList.ProductListToDGV(dgvFile);
        }

        private static DialogResult SaveModified()
        {
            if (FilePath == "")
            {
                return DialogResult.No;
            }
            DialogResult dg = MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNoCancel);
            if (dg == DialogResult.Yes)
            {
                Save();
            }
            return dg;
        }

        private static void Save()
        {
            switch (FileExt)
            {
                case 1:
                    ProdList.ProductListToTextFile(FilePath);
                    break;
                case 2:
                    ProdList.ProductListToXMLFile(FilePath);
                    break;
                case 3:
                    ProdList.ProductListToBinaryFile(FilePath);
                    break;
            }
            IsModified = false;
        }

        private void TSFileSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        //Сохранение в текстовый файл
        private void ТекстовыйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsFileDialog.FilterIndex = 1;
            saveAsFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProdList.ProductListToTextFile(saveAsFileDialog.FileName);
                TSFileSave.Enabled = true;
                FileExt = 1;
                FilePath = saveAsFileDialog.FileName;
                IsModified = false;
            }
        }
        //Сохранение в бинарный файл
        private void MenuSaveAsBinaryFile_Click(object sender, EventArgs e)
        {
            saveAsFileDialog.FilterIndex = 3;
            saveAsFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProdList.ProductListToBinaryFile(saveAsFileDialog.FileName);
                TSFileSave.Enabled = true;
                FileExt = 3;
                FilePath = saveAsFileDialog.FileName;
                IsModified = false;
            }
        }
        //Сохранение в XML файл
        private void MenuSaveAsXMLFile_Click(object sender, EventArgs e)
        {
            saveAsFileDialog.FilterIndex = 2;
            saveAsFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
            if (saveAsFileDialog.ShowDialog() == DialogResult.OK)
            {
                ProdList.ProductListToXMLFile(saveAsFileDialog.FileName);
                TSFileSave.Enabled = true;
                FileExt = 2;
                FilePath = saveAsFileDialog.FileName;
                IsModified = false;
            }
        }
        //Изменение товара при двойном клике на строку
        private void DgvFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            using (TaskForm editForm = new TaskForm(ProdList[Convert.ToInt32(dgvFile.Rows[e.RowIndex].HeaderCell.Value) - 1]))
            {
                editForm.Edit();
                if (!editForm.IsCancel)
                {
                    if (!ProdList.Exists(x => x.Code == editForm.Prod.Code) || editForm.Prod.Code == ProdList[Convert.ToInt32(dgvFile.Rows[e.RowIndex].HeaderCell.Value) - 1].Code)
                    {
                        ProdList[e.RowIndex] = editForm.Prod;
                        ProdList.ProductListToDGV(dgvFile);
                    }
                    else
                    {
                        MessageBox.Show("Товар с таким кодом уже есть в списке!");
                    }
                }
            }
        }
        //Открытие бинарного файла
        private void БинарныйФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsModified)
            {
                if (SaveModified() == DialogResult.Cancel)
                {
                    return;
                }
            }
            openFileDialog.FilterIndex = 3;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (ProdList.BinaryFileToProductList(openFileDialog.FileName))
                {
                    ProdList.ProductListToDGV(dgvFile);
                    TSFileSave.Enabled = true;
                    FileExt = 3;
                    FilePath = openFileDialog.FileName;
                    IsModified = false;
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать бинарный файл в список из товаров");
                }
            }
        }
        //Открытие текстового файла
        private void MenuOpenTextFile_Click(object sender, EventArgs e)
        {
            if (IsModified)
            {
                if (SaveModified() == DialogResult.Cancel)
                {
                    return;
                }
            }
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (ProdList.TextFileToProductList(openFileDialog.FileName))
                {
                    ProdList.ProductListToDGV(dgvFile);
                    TSFileSave.Enabled = true;
                    FileExt = 1;
                    FilePath = openFileDialog.FileName;
                    IsModified = false;
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать текстовый файл в список из товаров");
                }
            }
        }
        //Открытие XML файла
        private void MenuOpenXMLFile_Click(object sender, EventArgs e)
        {
            if (IsModified)
            {
                if (SaveModified() == DialogResult.Cancel)
                {
                    return;
                }
            }
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (ProdList.XMLFileToProductList(openFileDialog.FileName))
                {
                    ProdList.ProductListToDGV(dgvFile);
                    TSFileSave.Enabled = true;
                    FileExt = 2;
                    FilePath = openFileDialog.FileName;
                    IsModified = false;
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать текстовый файл в список из товаров");
                }
            }

        }

        private void DgvFile_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsModified = true;
            tsslAmount.Text = StrAmount + Convert.ToString(ProdList.Count);
        }

        static Random rand = new Random();
        private void TSEditRandom_Click(object sender, EventArgs e)
        {
            using (InputForm form = new InputForm("Ввод","Введите количество рандомных товаров: "))
            {
                form.ShowDialog();
                int k;
                if (!form.isCancel && Int32.TryParse(form.Info, out k))
                {
                    if (IsModified)
                    {
                        if (SaveModified() == DialogResult.Cancel)
                        {
                            return;
                        }
                    }

                    ProdList.Clear();
                    for (int i = 0; i < k; i++)
                    {
                        int Code = rand.Next(1, 1001 + k);
                        while (i > 0 && ProdList.Exists(x => x.Code == Code))
                        {
                            Code = rand.Next(1, 1001 + k);
                        };
                        SAcs Acs = new SAcs((EnumAcs)rand.Next(1, 12));
                        string Name = Acs.ToString() + Convert.ToString(i + 1);
                        double Price = rand.NextDouble() * 10000;
                        int Amount = rand.Next(0, 2001);
                        Product prod = new Product(Code, Acs, Name, Price, Amount);
                        ProdList.Add(prod);
                    }
                    ProdList.ProductListToDGV(dgvFile);
                }
            }
        }
        const int MaxAmount = 1000000;
        private static int CompareProds(Product x, Product y)
        {
            return (int)x.Kind.Acs * MaxAmount - (int)y.Kind.Acs * MaxAmount + y.Amount - x.Amount;
        }
        private void SortTask(object sender, EventArgs e)
        {
            using (InputForm form = new InputForm("Ввод количества","Введите максимальное количество товара"))
            {
                int k;
                form.ShowDialog();
                if (!form.isCancel && Int32.TryParse(form.Info, out k))
                {
                    ProdList.RemoveAll(x => x.Amount > k);
                    ProdList.Sort(CompareProds);
                    ProdList.ProductListToDGV(dgvFile);
                }
            }

        }
    }
}
