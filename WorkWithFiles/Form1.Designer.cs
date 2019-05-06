namespace WorkWithFiles
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MSFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSFileCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenBinaryFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpenXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAsTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAsBinaryFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSaveAsXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MSChange = new System.Windows.Forms.ToolStripMenuItem();
            this.TSEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.TSEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TSEditEdObject = new System.Windows.Forms.ToolStripMenuItem();
            this.TSEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.TSEditClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MSTask = new System.Windows.Forms.ToolStripMenuItem();
            this.Test1MI = new System.Windows.Forms.ToolStripMenuItem();
            this.Test2MI = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFile = new System.Windows.Forms.DataGridView();
            this.clCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TSFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tsslAmount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).BeginInit();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSFile,
            this.MSChange,
            this.MSTask});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(720, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip";
            // 
            // MSFile
            // 
            this.MSFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSFileCreate,
            this.TSFileOpen,
            this.TSFileSave,
            this.TSFileSaveAs});
            this.MSFile.Name = "MSFile";
            this.MSFile.Size = new System.Drawing.Size(48, 20);
            this.MSFile.Text = "Файл";
            // 
            // TSFileCreate
            // 
            this.TSFileCreate.Name = "TSFileCreate";
            this.TSFileCreate.Size = new System.Drawing.Size(180, 22);
            this.TSFileCreate.Text = "Создать";
            this.TSFileCreate.Click += new System.EventHandler(this.TSFileCreate_Click);
            // 
            // TSFileOpen
            // 
            this.TSFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpenTextFile,
            this.MenuOpenBinaryFile,
            this.MenuOpenXMLFile});
            this.TSFileOpen.Name = "TSFileOpen";
            this.TSFileOpen.Size = new System.Drawing.Size(180, 22);
            this.TSFileOpen.Text = "Открыть";
            // 
            // MenuOpenTextFile
            // 
            this.MenuOpenTextFile.Name = "MenuOpenTextFile";
            this.MenuOpenTextFile.Size = new System.Drawing.Size(165, 22);
            this.MenuOpenTextFile.Text = "Текстовый файл";
            this.MenuOpenTextFile.Click += new System.EventHandler(this.MenuOpenTextFile_Click);
            // 
            // MenuOpenBinaryFile
            // 
            this.MenuOpenBinaryFile.Name = "MenuOpenBinaryFile";
            this.MenuOpenBinaryFile.Size = new System.Drawing.Size(165, 22);
            this.MenuOpenBinaryFile.Text = "Бинарный файл";
            this.MenuOpenBinaryFile.Click += new System.EventHandler(this.БинарныйФайлToolStripMenuItem_Click);
            // 
            // MenuOpenXMLFile
            // 
            this.MenuOpenXMLFile.Name = "MenuOpenXMLFile";
            this.MenuOpenXMLFile.Size = new System.Drawing.Size(165, 22);
            this.MenuOpenXMLFile.Text = "XML файл";
            this.MenuOpenXMLFile.Click += new System.EventHandler(this.MenuOpenXMLFile_Click);
            // 
            // TSFileSave
            // 
            this.TSFileSave.Name = "TSFileSave";
            this.TSFileSave.Size = new System.Drawing.Size(180, 22);
            this.TSFileSave.Text = "Сохранить";
            this.TSFileSave.Click += new System.EventHandler(this.TSFileSave_Click);
            // 
            // TSFileSaveAs
            // 
            this.TSFileSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSaveAsTextFile,
            this.MenuSaveAsBinaryFile,
            this.MenuSaveAsXMLFile});
            this.TSFileSaveAs.Name = "TSFileSaveAs";
            this.TSFileSaveAs.Size = new System.Drawing.Size(180, 22);
            this.TSFileSaveAs.Text = "Сохранить как...";
            // 
            // MenuSaveAsTextFile
            // 
            this.MenuSaveAsTextFile.Name = "MenuSaveAsTextFile";
            this.MenuSaveAsTextFile.Size = new System.Drawing.Size(165, 22);
            this.MenuSaveAsTextFile.Text = "Текстовый файл";
            this.MenuSaveAsTextFile.Click += new System.EventHandler(this.ТекстовыйФайлToolStripMenuItem_Click);
            // 
            // MenuSaveAsBinaryFile
            // 
            this.MenuSaveAsBinaryFile.Name = "MenuSaveAsBinaryFile";
            this.MenuSaveAsBinaryFile.Size = new System.Drawing.Size(165, 22);
            this.MenuSaveAsBinaryFile.Text = "Бинарный файл";
            this.MenuSaveAsBinaryFile.Click += new System.EventHandler(this.MenuSaveAsBinaryFile_Click);
            // 
            // MenuSaveAsXMLFile
            // 
            this.MenuSaveAsXMLFile.Name = "MenuSaveAsXMLFile";
            this.MenuSaveAsXMLFile.Size = new System.Drawing.Size(165, 22);
            this.MenuSaveAsXMLFile.Text = "XML файл";
            this.MenuSaveAsXMLFile.Click += new System.EventHandler(this.MenuSaveAsXMLFile_Click);
            // 
            // MSChange
            // 
            this.MSChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSEditAdd,
            this.TSEditDelete,
            this.TSEditEdObject,
            this.TSEditFind,
            this.TSEditClear});
            this.MSChange.Name = "MSChange";
            this.MSChange.Size = new System.Drawing.Size(73, 20);
            this.MSChange.Text = "Изменить";
            this.MSChange.Click += new System.EventHandler(this.MS_Click);
            // 
            // TSEditAdd
            // 
            this.TSEditAdd.Name = "TSEditAdd";
            this.TSEditAdd.Size = new System.Drawing.Size(180, 22);
            this.TSEditAdd.Text = "Добавить";
            this.TSEditAdd.Click += new System.EventHandler(this.TSEditAdd_Click);
            // 
            // TSEditDelete
            // 
            this.TSEditDelete.Name = "TSEditDelete";
            this.TSEditDelete.Size = new System.Drawing.Size(180, 22);
            this.TSEditDelete.Text = "Удалить";
            this.TSEditDelete.Click += new System.EventHandler(this.TSEditDelete_Click);
            // 
            // TSEditEdObject
            // 
            this.TSEditEdObject.Name = "TSEditEdObject";
            this.TSEditEdObject.Size = new System.Drawing.Size(180, 22);
            this.TSEditEdObject.Text = "Изменить товар";
            this.TSEditEdObject.Click += new System.EventHandler(this.TSEdit_Click);
            // 
            // TSEditFind
            // 
            this.TSEditFind.Name = "TSEditFind";
            this.TSEditFind.Size = new System.Drawing.Size(180, 22);
            this.TSEditFind.Text = "Найти";
            this.TSEditFind.Click += new System.EventHandler(this.TSEditFind_Click);
            // 
            // TSEditClear
            // 
            this.TSEditClear.Name = "TSEditClear";
            this.TSEditClear.Size = new System.Drawing.Size(180, 22);
            this.TSEditClear.Text = "Очистить таблицу";
            this.TSEditClear.Click += new System.EventHandler(this.TSEditClear_Click);
            // 
            // MSTask
            // 
            this.MSTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Test1MI,
            this.Test2MI});
            this.MSTask.Name = "MSTask";
            this.MSTask.Size = new System.Drawing.Size(70, 20);
            this.MSTask.Text = "Действие";
            // 
            // Test1MI
            // 
            this.Test1MI.Name = "Test1MI";
            this.Test1MI.Size = new System.Drawing.Size(104, 22);
            this.Test1MI.Text = "Тест1";
            this.Test1MI.Click += new System.EventHandler(this.Тест1ToolStripMenuItem_Click);
            // 
            // Test2MI
            // 
            this.Test2MI.Name = "Test2MI";
            this.Test2MI.Size = new System.Drawing.Size(104, 22);
            this.Test2MI.Text = "Тест2";
            this.Test2MI.Click += new System.EventHandler(this.Test2MI_Click);
            // 
            // dgvFile
            // 
            this.dgvFile.AllowUserToAddRows = false;
            this.dgvFile.AllowUserToDeleteRows = false;
            this.dgvFile.AllowUserToResizeColumns = false;
            this.dgvFile.AllowUserToResizeRows = false;
            this.dgvFile.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFile.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCode,
            this.clType,
            this.clName,
            this.clPrice,
            this.clAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFile.GridColor = System.Drawing.Color.Black;
            this.dgvFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvFile.Location = new System.Drawing.Point(0, 27);
            this.dgvFile.Name = "dgvFile";
            this.dgvFile.ReadOnly = true;
            this.dgvFile.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "1";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.NullValue = "1";
            this.dgvFile.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFile.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFile.Size = new System.Drawing.Size(549, 412);
            this.dgvFile.TabIndex = 1;
            this.dgvFile.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFile_CellDoubleClick);
            this.dgvFile.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFile_CellValueChanged);
            // 
            // clCode
            // 
            this.clCode.HeaderText = "Код";
            this.clCode.Name = "clCode";
            this.clCode.ReadOnly = true;
            // 
            // clType
            // 
            this.clType.HeaderText = "Вид";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            // 
            // clName
            // 
            this.clName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clName.HeaderText = "Наименование";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 108;
            // 
            // clPrice
            // 
            this.clPrice.HeaderText = "Цена";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            // 
            // clAmount
            // 
            this.clAmount.HeaderText = "Кол-во";
            this.clAmount.Name = "clAmount";
            this.clAmount.ReadOnly = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.CheckFileExists = false;
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "Текстовые файлы|*.txt|XML файлы|*.xml|Все файлы|*.*";
            // 
            // TSFileClose
            // 
            this.TSFileClose.Name = "TSFileClose";
            this.TSFileClose.Size = new System.Drawing.Size(180, 22);
            this.TSFileClose.Text = "Закрыть";
            // 
            // saveAsFileDialog
            // 
            this.saveAsFileDialog.CreatePrompt = true;
            this.saveAsFileDialog.DefaultExt = "txt";
            this.saveAsFileDialog.Filter = "Текстовые файлы|*.txt|XML файлы|*.xml|Все файлы|*.*";
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAmount});
            this.ss.Location = new System.Drawing.Point(0, 442);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(720, 22);
            this.ss.TabIndex = 2;
            this.ss.Text = "statusStrip1";
            // 
            // tsslAmount
            // 
            this.tsslAmount.Name = "tsslAmount";
            this.tsslAmount.Size = new System.Drawing.Size(140, 17);
            this.tsslAmount.Text = "Количество элементов: ";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(555, 27);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(153, 36);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.TSEditAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(555, 69);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(153, 36);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "Изменить";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.TSEdit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(555, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.TSEditFind_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(555, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 36);
            this.button4.TabIndex = 7;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.TSEditDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 464);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.dgvFile);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Работа с файлами";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFile)).EndInit();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MSFile;
        private System.Windows.Forms.ToolStripMenuItem TSFileCreate;
        private System.Windows.Forms.ToolStripMenuItem TSFileOpen;
        private System.Windows.Forms.ToolStripMenuItem TSFileSave;
        private System.Windows.Forms.ToolStripMenuItem TSFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MSChange;
        private System.Windows.Forms.ToolStripMenuItem TSEditAdd;
        private System.Windows.Forms.ToolStripMenuItem TSEditDelete;
        private System.Windows.Forms.ToolStripMenuItem TSEditEdObject;
        private System.Windows.Forms.ToolStripMenuItem TSEditFind;
        private System.Windows.Forms.ToolStripMenuItem MSTask;
        private System.Windows.Forms.DataGridView dgvFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem TSFileClose;
        private System.Windows.Forms.ToolStripMenuItem Test1MI;
        private System.Windows.Forms.ToolStripMenuItem Test2MI;
        private System.Windows.Forms.SaveFileDialog saveAsFileDialog;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tsslAmount;
        private System.Windows.Forms.ToolStripMenuItem TSEditClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAsTextFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAsBinaryFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSaveAsXMLFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenTextFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenBinaryFile;
        private System.Windows.Forms.ToolStripMenuItem MenuOpenXMLFile;
    }
}

