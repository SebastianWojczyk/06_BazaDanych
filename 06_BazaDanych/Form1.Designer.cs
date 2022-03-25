namespace _06_BazaDanych
{
    partial class Form1
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
            this.listBoxPersons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.radioButtonNameASC = new System.Windows.Forms.RadioButton();
            this.radioButtonBDateASC = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNameDESC = new System.Windows.Forms.RadioButton();
            this.radioButtonBDateDESC = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFilterName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPersons
            // 
            this.listBoxPersons.FormattingEnabled = true;
            this.listBoxPersons.Location = new System.Drawing.Point(12, 25);
            this.listBoxPersons.Name = "listBoxPersons";
            this.listBoxPersons.Size = new System.Drawing.Size(262, 290);
            this.listBoxPersons.TabIndex = 0;
            this.listBoxPersons.SelectedIndexChanged += new System.EventHandler(this.listBoxPersons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Persons";
            // 
            // dateTimePickerBDate
            // 
            this.dateTimePickerBDate.Location = new System.Drawing.Point(282, 209);
            this.dateTimePickerBDate.Name = "dateTimePickerBDate";
            this.dateTimePickerBDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBDate.TabIndex = 4;
            this.dateTimePickerBDate.Value = new System.DateTime(2022, 3, 25, 0, 0, 0, 0);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(282, 160);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(282, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(282, 264);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(282, 293);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // radioButtonNameASC
            // 
            this.radioButtonNameASC.AutoSize = true;
            this.radioButtonNameASC.Checked = true;
            this.radioButtonNameASC.Location = new System.Drawing.Point(6, 19);
            this.radioButtonNameASC.Name = "radioButtonNameASC";
            this.radioButtonNameASC.Size = new System.Drawing.Size(73, 17);
            this.radioButtonNameASC.TabIndex = 9;
            this.radioButtonNameASC.TabStop = true;
            this.radioButtonNameASC.Text = "Name asc";
            this.radioButtonNameASC.UseVisualStyleBackColor = true;
            this.radioButtonNameASC.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonBDateASC
            // 
            this.radioButtonBDateASC.AutoSize = true;
            this.radioButtonBDateASC.Location = new System.Drawing.Point(7, 42);
            this.radioButtonBDateASC.Name = "radioButtonBDateASC";
            this.radioButtonBDateASC.Size = new System.Drawing.Size(75, 17);
            this.radioButtonBDateASC.TabIndex = 10;
            this.radioButtonBDateASC.Text = "BDate asc";
            this.radioButtonBDateASC.UseVisualStyleBackColor = true;
            this.radioButtonBDateASC.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNameDESC);
            this.groupBox1.Controls.Add(this.radioButtonBDateDESC);
            this.groupBox1.Controls.Add(this.radioButtonNameASC);
            this.groupBox1.Controls.Add(this.radioButtonBDateASC);
            this.groupBox1.Location = new System.Drawing.Point(282, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order by";
            // 
            // radioButtonNameDESC
            // 
            this.radioButtonNameDESC.AutoSize = true;
            this.radioButtonNameDESC.Location = new System.Drawing.Point(91, 19);
            this.radioButtonNameDESC.Name = "radioButtonNameDESC";
            this.radioButtonNameDESC.Size = new System.Drawing.Size(79, 17);
            this.radioButtonNameDESC.TabIndex = 11;
            this.radioButtonNameDESC.Text = "Name desc";
            this.radioButtonNameDESC.UseVisualStyleBackColor = true;
            this.radioButtonNameDESC.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // radioButtonBDateDESC
            // 
            this.radioButtonBDateDESC.AutoSize = true;
            this.radioButtonBDateDESC.Location = new System.Drawing.Point(92, 42);
            this.radioButtonBDateDESC.Name = "radioButtonBDateDESC";
            this.radioButtonBDateDESC.Size = new System.Drawing.Size(81, 17);
            this.radioButtonBDateDESC.TabIndex = 12;
            this.radioButtonBDateDESC.Text = "BDate desc";
            this.radioButtonBDateDESC.UseVisualStyleBackColor = true;
            this.radioButtonBDateDESC.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxFilterName);
            this.groupBox2.Location = new System.Drawing.Point(282, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter name";
            // 
            // textBoxFilterName
            // 
            this.textBoxFilterName.Location = new System.Drawing.Point(7, 19);
            this.textBoxFilterName.Name = "textBoxFilterName";
            this.textBoxFilterName.Size = new System.Drawing.Size(187, 20);
            this.textBoxFilterName.TabIndex = 13;
            this.textBoxFilterName.TextChanged += new System.EventHandler(this.textBoxFilterName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dateTimePickerBDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPersons);
            this.Name = "Form1";
            this.Text = "Simple database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RadioButton radioButtonNameASC;
        private System.Windows.Forms.RadioButton radioButtonBDateASC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNameDESC;
        private System.Windows.Forms.RadioButton radioButtonBDateDESC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFilterName;
    }
}

