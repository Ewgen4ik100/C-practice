
namespace Lab33
{
    partial class Form1
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
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sudnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowlyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mestLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sudnoToolStripMenuItem,
            this.lowlyaToolStripMenuItem,
            this.mestLowToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // sudnoToolStripMenuItem
            // 
            this.sudnoToolStripMenuItem.Name = "sudnoToolStripMenuItem";
            this.sudnoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sudnoToolStripMenuItem.Text = "Sudno";
            this.sudnoToolStripMenuItem.Click += new System.EventHandler(this.sudnoToolStripMenuItem_Click);
            // 
            // lowlyaToolStripMenuItem
            // 
            this.lowlyaToolStripMenuItem.Name = "lowlyaToolStripMenuItem";
            this.lowlyaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lowlyaToolStripMenuItem.Text = "Lowlya";
            this.lowlyaToolStripMenuItem.Click += new System.EventHandler(this.lowlyaToolStripMenuItem_Click);
            // 
            // mestLowToolStripMenuItem
            // 
            this.mestLowToolStripMenuItem.Name = "mestLowToolStripMenuItem";
            this.mestLowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mestLowToolStripMenuItem.Text = "MestLow";
            this.mestLowToolStripMenuItem.Click += new System.EventHandler(this.mestLowToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sudnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowlyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mestLowToolStripMenuItem;
    }
}

