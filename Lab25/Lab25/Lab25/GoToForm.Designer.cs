
namespace Lab25
{
    partial class GoToForm
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
            this.labGo = new System.Windows.Forms.Label();
            this.tbLineNum = new System.Windows.Forms.NumericUpDown();
            this.butGo = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).BeginInit();
            this.SuspendLayout();
            // 
            // labGo
            // 
            this.labGo.AutoSize = true;
            this.labGo.Location = new System.Drawing.Point(12, 9);
            this.labGo.Name = "labGo";
            this.labGo.Size = new System.Drawing.Size(169, 17);
            this.labGo.TabIndex = 0;
            this.labGo.Text = "Введите номер строчки:";
            // 
            // tbLineNum
            // 
            this.tbLineNum.Location = new System.Drawing.Point(15, 29);
            this.tbLineNum.Name = "tbLineNum";
            this.tbLineNum.Size = new System.Drawing.Size(166, 22);
            this.tbLineNum.TabIndex = 1;
            // 
            // butGo
            // 
            this.butGo.Location = new System.Drawing.Point(12, 57);
            this.butGo.Name = "butGo";
            this.butGo.Size = new System.Drawing.Size(75, 23);
            this.butGo.TabIndex = 2;
            this.butGo.Text = "Перейти";
            this.butGo.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(106, 57);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // GoToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 89);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butGo);
            this.Controls.Add(this.tbLineNum);
            this.Controls.Add(this.labGo);
            this.Name = "GoToForm";
            this.Text = "GoToForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbLineNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labGo;
        public System.Windows.Forms.NumericUpDown tbLineNum;
        public System.Windows.Forms.Button butGo;
        public System.Windows.Forms.Button butCancel;
    }
}