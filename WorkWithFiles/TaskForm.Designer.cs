namespace WorkWithFiles
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btAct = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(12, 38);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(253, 20);
            this.tbCode.TabIndex = 0;
            this.tbCode.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(9, 22);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(26, 13);
            this.lbCode.TabIndex = 1;
            this.lbCode.Text = "Код";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(9, 63);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(26, 13);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Вид";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(12, 79);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(253, 20);
            this.tbType.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(9, 105);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(83, 13);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Наименование";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 121);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(253, 20);
            this.tbName.TabIndex = 4;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(9, 145);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 13);
            this.lbPrice.TabIndex = 7;
            this.lbPrice.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(12, 161);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(253, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(9, 185);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(66, 13);
            this.lbAmount.TabIndex = 9;
            this.lbAmount.Text = "Количество";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(12, 201);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(253, 20);
            this.tbAmount.TabIndex = 8;
            // 
            // btAct
            // 
            this.btAct.Location = new System.Drawing.Point(12, 238);
            this.btAct.Name = "btAct";
            this.btAct.Size = new System.Drawing.Size(122, 32);
            this.btAct.TabIndex = 10;
            this.btAct.Text = "Добавить";
            this.btAct.UseVisualStyleBackColor = true;
            this.btAct.Click += new System.EventHandler(this.BtAct_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(140, 238);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(125, 32);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // TaskForm
            // 
            this.AcceptButton = this.btAct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 291);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAct);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.lbCode);
            this.Controls.Add(this.tbCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Добавить элемент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btAct;
        private System.Windows.Forms.Button btCancel;
    }
}