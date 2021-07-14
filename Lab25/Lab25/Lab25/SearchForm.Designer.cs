
namespace Lab25
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.cbReg = new System.Windows.Forms.CheckBox();
            this.btFind = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btReplaceAll = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Найти: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заменить на:";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(162, 12);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(481, 22);
            this.tbFind.TabIndex = 2;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged_1);
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(162, 57);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(481, 22);
            this.tbReplace.TabIndex = 3;
            // 
            // cbReg
            // 
            this.cbReg.AutoSize = true;
            this.cbReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbReg.Location = new System.Drawing.Point(37, 95);
            this.cbReg.Name = "cbReg";
            this.cbReg.Size = new System.Drawing.Size(196, 24);
            this.cbReg.TabIndex = 4;
            this.cbReg.Text = "Учитывать регистр";
            this.cbReg.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(33, 136);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(148, 29);
            this.btFind.TabIndex = 5;
            this.btFind.Text = "Найти далее";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(187, 136);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(148, 29);
            this.btReplace.TabIndex = 6;
            this.btReplace.Text = "Заменить";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btReplaceAll
            // 
            this.btReplaceAll.Location = new System.Drawing.Point(341, 136);
            this.btReplaceAll.Name = "btReplaceAll";
            this.btReplaceAll.Size = new System.Drawing.Size(148, 29);
            this.btReplaceAll.TabIndex = 7;
            this.btReplaceAll.Text = "Заменить все";
            this.btReplaceAll.UseVisualStyleBackColor = true;
            this.btReplaceAll.Click += new System.EventHandler(this.btReplaceAll_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(495, 136);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(148, 29);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 177);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btReplaceAll);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.cbReg);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Найти и заменить...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btReplaceAll;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.TextBox tbFind;
        public System.Windows.Forms.TextBox tbReplace;
        public System.Windows.Forms.CheckBox cbReg;
    }
}