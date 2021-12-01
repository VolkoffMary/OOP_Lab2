
namespace Lab2
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
            this.checkBoxFaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxDepartment = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstName = new System.Windows.Forms.CheckBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.checkBoxPatronym = new System.Windows.Forms.CheckBox();
            this.checkBoxPosition = new System.Windows.Forms.CheckBox();
            this.checkBoxSalary = new System.Windows.Forms.CheckBox();
            this.checkBoxTerm = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxFirstName = new System.Windows.Forms.ComboBox();
            this.comboBoxLastName = new System.Windows.Forms.ComboBox();
            this.comboBoxPatronym = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxFaculty
            // 
            this.checkBoxFaculty.AutoSize = true;
            this.checkBoxFaculty.Location = new System.Drawing.Point(33, 29);
            this.checkBoxFaculty.Name = "checkBoxFaculty";
            this.checkBoxFaculty.Size = new System.Drawing.Size(75, 21);
            this.checkBoxFaculty.TabIndex = 0;
            this.checkBoxFaculty.Text = "Faculty";
            this.checkBoxFaculty.UseVisualStyleBackColor = true;
            // 
            // checkBoxDepartment
            // 
            this.checkBoxDepartment.AutoSize = true;
            this.checkBoxDepartment.Location = new System.Drawing.Point(33, 71);
            this.checkBoxDepartment.Name = "checkBoxDepartment";
            this.checkBoxDepartment.Size = new System.Drawing.Size(104, 21);
            this.checkBoxDepartment.TabIndex = 1;
            this.checkBoxDepartment.Text = "Departmant";
            this.checkBoxDepartment.UseVisualStyleBackColor = true;
            // 
            // checkBoxFirstName
            // 
            this.checkBoxFirstName.AutoSize = true;
            this.checkBoxFirstName.Location = new System.Drawing.Point(33, 114);
            this.checkBoxFirstName.Name = "checkBoxFirstName";
            this.checkBoxFirstName.Size = new System.Drawing.Size(94, 21);
            this.checkBoxFirstName.TabIndex = 0;
            this.checkBoxFirstName.Text = "Forename";
            this.checkBoxFirstName.UseVisualStyleBackColor = true;
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(33, 154);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(87, 21);
            this.checkBoxLastName.TabIndex = 1;
            this.checkBoxLastName.Text = "Surname";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            // 
            // checkBoxPatronym
            // 
            this.checkBoxPatronym.AutoSize = true;
            this.checkBoxPatronym.Location = new System.Drawing.Point(33, 192);
            this.checkBoxPatronym.Name = "checkBoxPatronym";
            this.checkBoxPatronym.Size = new System.Drawing.Size(90, 21);
            this.checkBoxPatronym.TabIndex = 0;
            this.checkBoxPatronym.Text = "Patronym";
            this.checkBoxPatronym.UseVisualStyleBackColor = true;
            // 
            // checkBoxPosition
            // 
            this.checkBoxPosition.AutoSize = true;
            this.checkBoxPosition.Location = new System.Drawing.Point(33, 234);
            this.checkBoxPosition.Name = "checkBoxPosition";
            this.checkBoxPosition.Size = new System.Drawing.Size(80, 21);
            this.checkBoxPosition.TabIndex = 1;
            this.checkBoxPosition.Text = "Position";
            this.checkBoxPosition.UseVisualStyleBackColor = true;
            // 
            // checkBoxSalary
            // 
            this.checkBoxSalary.AutoSize = true;
            this.checkBoxSalary.Location = new System.Drawing.Point(33, 277);
            this.checkBoxSalary.Name = "checkBoxSalary";
            this.checkBoxSalary.Size = new System.Drawing.Size(70, 21);
            this.checkBoxSalary.TabIndex = 0;
            this.checkBoxSalary.Text = "Salary";
            this.checkBoxSalary.UseVisualStyleBackColor = true;
            // 
            // checkBoxTerm
            // 
            this.checkBoxTerm.AutoSize = true;
            this.checkBoxTerm.Location = new System.Drawing.Point(33, 317);
            this.checkBoxTerm.Name = "checkBoxTerm";
            this.checkBoxTerm.Size = new System.Drawing.Size(63, 21);
            this.checkBoxTerm.TabIndex = 1;
            this.checkBoxTerm.Text = "Term";
            this.checkBoxTerm.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(409, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(379, 402);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(163, 29);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(207, 24);
            this.comboBoxFaculty.Sorted = true;
            this.comboBoxFaculty.TabIndex = 3;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(163, 71);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(207, 24);
            this.comboBoxDepartment.Sorted = true;
            this.comboBoxDepartment.TabIndex = 3;
            // 
            // comboBoxFirstName
            // 
            this.comboBoxFirstName.FormattingEnabled = true;
            this.comboBoxFirstName.Location = new System.Drawing.Point(163, 114);
            this.comboBoxFirstName.Name = "comboBoxFirstName";
            this.comboBoxFirstName.Size = new System.Drawing.Size(207, 24);
            this.comboBoxFirstName.Sorted = true;
            this.comboBoxFirstName.TabIndex = 3;
            // 
            // comboBoxLastName
            // 
            this.comboBoxLastName.FormattingEnabled = true;
            this.comboBoxLastName.Location = new System.Drawing.Point(163, 154);
            this.comboBoxLastName.Name = "comboBoxLastName";
            this.comboBoxLastName.Size = new System.Drawing.Size(207, 24);
            this.comboBoxLastName.Sorted = true;
            this.comboBoxLastName.TabIndex = 3;
            // 
            // comboBoxPatronym
            // 
            this.comboBoxPatronym.FormattingEnabled = true;
            this.comboBoxPatronym.Location = new System.Drawing.Point(163, 192);
            this.comboBoxPatronym.Name = "comboBoxPatronym";
            this.comboBoxPatronym.Size = new System.Drawing.Size(207, 24);
            this.comboBoxPatronym.Sorted = true;
            this.comboBoxPatronym.TabIndex = 3;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(163, 234);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(207, 24);
            this.comboBoxPosition.Sorted = true;
            this.comboBoxPosition.TabIndex = 3;
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Location = new System.Drawing.Point(163, 277);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(207, 24);
            this.comboBoxSalary.Sorted = true;
            this.comboBoxSalary.TabIndex = 3;
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Location = new System.Drawing.Point(163, 317);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(207, 24);
            this.comboBoxTerm.Sorted = true;
            this.comboBoxTerm.TabIndex = 3;
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Checked = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(14, 359);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(61, 21);
            this.radioButtonDOM.TabIndex = 4;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(81, 359);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(56, 21);
            this.radioButtonSAX.TabIndex = 4;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLINQ
            // 
            this.radioButtonLINQ.AutoSize = true;
            this.radioButtonLINQ.Location = new System.Drawing.Point(144, 359);
            this.radioButtonLINQ.Name = "radioButtonLINQ";
            this.radioButtonLINQ.Size = new System.Drawing.Size(109, 21);
            this.radioButtonLINQ.TabIndex = 4;
            this.radioButtonLINQ.TabStop = true;
            this.radioButtonLINQ.Text = "LINQ to XML";
            this.radioButtonLINQ.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(30, 401);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(78, 28);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(144, 401);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 28);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(259, 359);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(135, 70);
            this.buttonTransform.TabIndex = 6;
            this.buttonTransform.Text = "Трансформувати в HTML";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButtonLINQ);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.comboBoxTerm);
            this.Controls.Add(this.comboBoxSalary);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.comboBoxPatronym);
            this.Controls.Add(this.comboBoxLastName);
            this.Controls.Add(this.comboBoxFirstName);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBoxTerm);
            this.Controls.Add(this.checkBoxSalary);
            this.Controls.Add(this.checkBoxLastName);
            this.Controls.Add(this.checkBoxPosition);
            this.Controls.Add(this.checkBoxFirstName);
            this.Controls.Add(this.checkBoxPatronym);
            this.Controls.Add(this.checkBoxDepartment);
            this.Controls.Add(this.checkBoxFaculty);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFaculty;
        private System.Windows.Forms.CheckBox checkBoxDepartment;
        private System.Windows.Forms.CheckBox checkBoxFirstName;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxPatronym;
        private System.Windows.Forms.CheckBox checkBoxPosition;
        private System.Windows.Forms.CheckBox checkBoxSalary;
        private System.Windows.Forms.CheckBox checkBoxTerm;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxPatronym;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.ComboBox comboBoxSalary;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLINQ;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonTransform;
    }
}

