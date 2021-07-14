
namespace _18form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.List = new System.Windows.Forms.ListBox();
            this.DeleteAuto = new System.Windows.Forms.Button();
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputAge = new System.Windows.Forms.TextBox();
            this.AddNewAuto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteAllAuto = new System.Windows.Forms.Button();
            this.RenameAuto = new System.Windows.Forms.Button();
            this.RenameAge = new System.Windows.Forms.TextBox();
            this.RenameName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RenameCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InputCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 20;
            this.List.Location = new System.Drawing.Point(30, 12);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(569, 204);
            this.List.TabIndex = 0;
            this.List.SelectedIndexChanged += new System.EventHandler(this.MagazList_SelectedIndexChanged);
            // 
            // DeleteAuto
            // 
            this.DeleteAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteAuto.Location = new System.Drawing.Point(614, 12);
            this.DeleteAuto.Name = "DeleteAuto";
            this.DeleteAuto.Size = new System.Drawing.Size(129, 41);
            this.DeleteAuto.TabIndex = 1;
            this.DeleteAuto.Text = "Delite";
            this.DeleteAuto.UseVisualStyleBackColor = false;
            this.DeleteAuto.Click += new System.EventHandler(this.DeleteMagaz_Click);
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(329, 258);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(250, 27);
            this.InputName.TabIndex = 2;
            // 
            // InputAge
            // 
            this.InputAge.AccessibleName = "";
            this.InputAge.BackColor = System.Drawing.SystemColors.Window;
            this.InputAge.Location = new System.Drawing.Point(329, 320);
            this.InputAge.Name = "InputAge";
            this.InputAge.Size = new System.Drawing.Size(250, 27);
            this.InputAge.TabIndex = 3;
            this.InputAge.Tag = "";
            // 
            // AddNewAuto
            // 
            this.AddNewAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddNewAuto.Location = new System.Drawing.Point(356, 448);
            this.AddNewAuto.Name = "AddNewAuto";
            this.AddNewAuto.Size = new System.Drawing.Size(189, 34);
            this.AddNewAuto.TabIndex = 5;
            this.AddNewAuto.Text = "Add";
            this.AddNewAuto.UseVisualStyleBackColor = false;
            this.AddNewAuto.Click += new System.EventHandler(this.AddNewMagaz_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(608, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age";
            // 
            // DeleteAllAuto
            // 
            this.DeleteAllAuto.BackColor = System.Drawing.Color.Red;
            this.DeleteAllAuto.Location = new System.Drawing.Point(614, 78);
            this.DeleteAllAuto.Name = "DeleteAllAuto";
            this.DeleteAllAuto.Size = new System.Drawing.Size(129, 41);
            this.DeleteAllAuto.TabIndex = 9;
            this.DeleteAllAuto.Text = "Delite All";
            this.DeleteAllAuto.UseVisualStyleBackColor = false;
            this.DeleteAllAuto.Click += new System.EventHandler(this.DeleteAllMagaz_Click);
            // 
            // RenameAuto
            // 
            this.RenameAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RenameAuto.Location = new System.Drawing.Point(57, 449);
            this.RenameAuto.Name = "RenameAuto";
            this.RenameAuto.Size = new System.Drawing.Size(189, 32);
            this.RenameAuto.TabIndex = 12;
            this.RenameAuto.Text = "Change";
            this.RenameAuto.UseVisualStyleBackColor = false;
            this.RenameAuto.Click += new System.EventHandler(this.RenameMagaz_Click);
            // 
            // RenameAge
            // 
            this.RenameAge.AccessibleName = "";
            this.RenameAge.BackColor = System.Drawing.SystemColors.Window;
            this.RenameAge.Location = new System.Drawing.Point(28, 320);
            this.RenameAge.Name = "RenameAge";
            this.RenameAge.Size = new System.Drawing.Size(250, 27);
            this.RenameAge.TabIndex = 11;
            this.RenameAge.Tag = "";
            // 
            // RenameName
            // 
            this.RenameName.Location = new System.Drawing.Point(30, 258);
            this.RenameName.Name = "RenameName";
            this.RenameName.Size = new System.Drawing.Size(250, 27);
            this.RenameName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // RenameCost
            // 
            this.RenameCost.AccessibleName = "";
            this.RenameCost.BackColor = System.Drawing.SystemColors.Window;
            this.RenameCost.Location = new System.Drawing.Point(30, 389);
            this.RenameCost.Name = "RenameCost";
            this.RenameCost.Size = new System.Drawing.Size(250, 27);
            this.RenameCost.TabIndex = 16;
            this.RenameCost.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Cost";
            // 
            // InputCost
            // 
            this.InputCost.AccessibleName = "";
            this.InputCost.BackColor = System.Drawing.SystemColors.Window;
            this.InputCost.Location = new System.Drawing.Point(329, 389);
            this.InputCost.Name = "InputCost";
            this.InputCost.Size = new System.Drawing.Size(250, 27);
            this.InputCost.TabIndex = 21;
            this.InputCost.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 504);
            this.Controls.Add(this.InputCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RenameCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RenameAuto);
            this.Controls.Add(this.RenameAge);
            this.Controls.Add(this.RenameName);
            this.Controls.Add(this.DeleteAllAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddNewAuto);
            this.Controls.Add(this.InputAge);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.DeleteAuto);
            this.Controls.Add(this.List);
            this.Name = "Form1";
            this.Text = "Magaz V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button DeleteAuto;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.TextBox InputAge;
        private System.Windows.Forms.Button AddNewAuto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteAllAuto;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox RenameAge;
        private System.Windows.Forms.TextBox RenameName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RenameAuto;
        private System.Windows.Forms.TextBox RenameCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox InputDate;
        private System.Windows.Forms.TextBox InputCost;
    }
}

