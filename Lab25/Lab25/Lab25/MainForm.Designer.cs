
namespace Lab25
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePageParam = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGo = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditGiveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mView = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewStatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.приветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gjrfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLinesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusWordsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.notebox = new System.Windows.Forms.TextBox();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mFormat,
            this.mView,
            this.mHelp,
            this.приветToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFileOpen,
            this.mFileSave,
            this.mFileSaveAs,
            this.mFilePageParam,
            this.mFilePrint,
            this.mFileExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(59, 24);
            this.mFile.Text = "Файл";
            // 
            // mFileNew
            // 
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.Size = new System.Drawing.Size(236, 26);
            this.mFileNew.Text = "Создать";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.Size = new System.Drawing.Size(236, 26);
            this.mFileOpen.Text = "Открыть";
            this.mFileOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // mFileSave
            // 
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.Size = new System.Drawing.Size(236, 26);
            this.mFileSave.Text = "Сохранить";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // mFileSaveAs
            // 
            this.mFileSaveAs.Name = "mFileSaveAs";
            this.mFileSaveAs.Size = new System.Drawing.Size(236, 26);
            this.mFileSaveAs.Text = "Сохранить как...";
            this.mFileSaveAs.Click += new System.EventHandler(this.mFileSaveAs_Click);
            // 
            // mFilePageParam
            // 
            this.mFilePageParam.Name = "mFilePageParam";
            this.mFilePageParam.Size = new System.Drawing.Size(236, 26);
            this.mFilePageParam.Text = "Параметры страниы";
            // 
            // mFilePrint
            // 
            this.mFilePrint.Name = "mFilePrint";
            this.mFilePrint.Size = new System.Drawing.Size(236, 26);
            this.mFilePrint.Text = "Печать";
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.Size = new System.Drawing.Size(236, 26);
            this.mFileExit.Text = "Выход";
            this.mFileExit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditCancel,
            this.mEditCut,
            this.mEditCopy,
            this.mEditPaste,
            this.mEditDel,
            this.mEditFind,
            this.mEditGo,
            this.mEditGiveAll,
            this.mEditTime});
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(74, 24);
            this.mEdit.Text = "Правка";
            this.mEdit.Click += new System.EventHandler(this.mEdit_Click);
            // 
            // mEditCancel
            // 
            this.mEditCancel.Name = "mEditCancel";
            this.mEditCancel.Size = new System.Drawing.Size(218, 26);
            this.mEditCancel.Text = "Отменить";
            this.mEditCancel.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // mEditCut
            // 
            this.mEditCut.Name = "mEditCut";
            this.mEditCut.Size = new System.Drawing.Size(218, 26);
            this.mEditCut.Text = "Вырезать";
            this.mEditCut.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // mEditCopy
            // 
            this.mEditCopy.Name = "mEditCopy";
            this.mEditCopy.Size = new System.Drawing.Size(218, 26);
            this.mEditCopy.Text = "Копировать";
            this.mEditCopy.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // mEditPaste
            // 
            this.mEditPaste.Name = "mEditPaste";
            this.mEditPaste.Size = new System.Drawing.Size(218, 26);
            this.mEditPaste.Text = "Вставить";
            this.mEditPaste.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // mEditDel
            // 
            this.mEditDel.Name = "mEditDel";
            this.mEditDel.Size = new System.Drawing.Size(218, 26);
            this.mEditDel.Text = "Удалить";
            this.mEditDel.Click += new System.EventHandler(this.mEditDel_Click);
            // 
            // mEditFind
            // 
            this.mEditFind.Name = "mEditFind";
            this.mEditFind.Size = new System.Drawing.Size(218, 26);
            this.mEditFind.Text = "Найти и заменить";
            this.mEditFind.Click += new System.EventHandler(this.mEditFind_Click);
            // 
            // mEditGo
            // 
            this.mEditGo.Name = "mEditGo";
            this.mEditGo.Size = new System.Drawing.Size(218, 26);
            this.mEditGo.Text = "Перейти";
            this.mEditGo.Click += new System.EventHandler(this.mEditGo_Click);
            // 
            // mEditGiveAll
            // 
            this.mEditGiveAll.Name = "mEditGiveAll";
            this.mEditGiveAll.Size = new System.Drawing.Size(218, 26);
            this.mEditGiveAll.Text = "Выделить все";
            this.mEditGiveAll.Click += new System.EventHandler(this.mEditGiveAll_Click);
            // 
            // mEditTime
            // 
            this.mEditTime.Name = "mEditTime";
            this.mEditTime.Size = new System.Drawing.Size(218, 26);
            this.mEditTime.Text = "Время и дата";
            this.mEditTime.Click += new System.EventHandler(this.mEditTime_Click);
            // 
            // mFormat
            // 
            this.mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatTransfer,
            this.mFormatFont});
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(77, 24);
            this.mFormat.Text = "Формат";
            // 
            // mFormatTransfer
            // 
            this.mFormatTransfer.Name = "mFormatTransfer";
            this.mFormatTransfer.Size = new System.Drawing.Size(230, 26);
            this.mFormatTransfer.Text = "Перенос по словам";
            this.mFormatTransfer.CheckStateChanged += new System.EventHandler(this.mFormatTransfer_CheckStateChanged);
            // 
            // mFormatFont
            // 
            this.mFormatFont.Name = "mFormatFont";
            this.mFormatFont.Size = new System.Drawing.Size(230, 26);
            this.mFormatFont.Text = "Шрифт";
            this.mFormatFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewStatusStrip});
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(49, 24);
            this.mView.Text = "Вид";
            // 
            // mViewStatusStrip
            // 
            this.mViewStatusStrip.Checked = true;
            this.mViewStatusStrip.CheckOnClick = true;
            this.mViewStatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewStatusStrip.Name = "mViewStatusStrip";
            this.mViewStatusStrip.Size = new System.Drawing.Size(216, 26);
            this.mViewStatusStrip.Text = "Строка состояния";
            this.mViewStatusStrip.Click += new System.EventHandler(this.mViewStatusStrip_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpAboutProgram});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(81, 24);
            this.mHelp.Text = "Справка";
            // 
            // mHelpAboutProgram
            // 
            this.mHelpAboutProgram.Name = "mHelpAboutProgram";
            this.mHelpAboutProgram.Size = new System.Drawing.Size(187, 26);
            this.mHelpAboutProgram.Text = "О программе";
            // 
            // приветToolStripMenuItem
            // 
            this.приветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gjrfToolStripMenuItem});
            this.приветToolStripMenuItem.Name = "приветToolStripMenuItem";
            this.приветToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.приветToolStripMenuItem.Text = "Привет";
            // 
            // gjrfToolStripMenuItem
            // 
            this.gjrfToolStripMenuItem.Name = "gjrfToolStripMenuItem";
            this.gjrfToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gjrfToolStripMenuItem.Text = "gjrf";
            this.gjrfToolStripMenuItem.Click += new System.EventHandler(this.gjrfToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLinesCount,
            this.toolStripStatusLabel3,
            this.statusWordsCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 424);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 20);
            this.toolStripStatusLabel1.Text = "Количество строк: ";
            // 
            // statusLinesCount
            // 
            this.statusLinesCount.Name = "statusLinesCount";
            this.statusLinesCount.Size = new System.Drawing.Size(17, 20);
            this.statusLinesCount.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(133, 20);
            this.toolStripStatusLabel3.Text = "Количество слов: ";
            // 
            // statusWordsCount
            // 
            this.statusWordsCount.Name = "statusWordsCount";
            this.statusWordsCount.Size = new System.Drawing.Size(17, 20);
            this.statusWordsCount.Text = "0";
            // 
            // notebox
            // 
            this.notebox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notebox.Location = new System.Drawing.Point(0, 28);
            this.notebox.Multiline = true;
            this.notebox.Name = "notebox";
            this.notebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.notebox.Size = new System.Drawing.Size(800, 396);
            this.notebox.TabIndex = 2;
            this.notebox.TextChanged += new System.EventHandler(this.notebox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notebox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mFileSave;
        private System.Windows.Forms.ToolStripMenuItem mFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mFilePageParam;
        private System.Windows.Forms.ToolStripMenuItem mFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.ToolStripMenuItem mEditCancel;
        private System.Windows.Forms.ToolStripMenuItem mEditCut;
        private System.Windows.Forms.ToolStripMenuItem mEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mEditDel;
        private System.Windows.Forms.ToolStripMenuItem mEditFind;
        private System.Windows.Forms.ToolStripMenuItem mEditGo;
        private System.Windows.Forms.ToolStripMenuItem mEditGiveAll;
        private System.Windows.Forms.ToolStripMenuItem mEditTime;
        private System.Windows.Forms.ToolStripMenuItem mFormat;
        private System.Windows.Forms.ToolStripMenuItem mFormatTransfer;
        private System.Windows.Forms.ToolStripMenuItem mFormatFont;
        private System.Windows.Forms.ToolStripMenuItem mHelpAboutProgram;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.TextBox notebox;
        private System.Windows.Forms.FontDialog FontDialog;
        public System.Windows.Forms.ToolStripMenuItem mViewStatusStrip;
        public System.Windows.Forms.ToolStripStatusLabel statusLinesCount;
        public System.Windows.Forms.ToolStripStatusLabel statusWordsCount;
        private System.Windows.Forms.ToolStripMenuItem приветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gjrfToolStripMenuItem;
    }
}

