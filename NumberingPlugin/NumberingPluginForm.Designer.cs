namespace NumberingPlugin
{
    partial class NumberingPluginForm
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
            this.numberPartsButton = new System.Windows.Forms.Button();
            this.startPartNumberTextBox = new System.Windows.Forms.TextBox();
            this.startMarkNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberMarksButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectCodeTextBox = new System.Windows.Forms.TextBox();
            this.deletePartNumbersButton = new System.Windows.Forms.Button();
            this.deleteMarkNumbersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberPartsButton
            // 
            this.structuresExtender.SetAttributeName(this.numberPartsButton, null);
            this.structuresExtender.SetAttributeTypeName(this.numberPartsButton, null);
            this.structuresExtender.SetBindPropertyName(this.numberPartsButton, null);
            this.numberPartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberPartsButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numberPartsButton.Location = new System.Drawing.Point(247, 117);
            this.numberPartsButton.Name = "numberPartsButton";
            this.numberPartsButton.Size = new System.Drawing.Size(129, 32);
            this.numberPartsButton.TabIndex = 0;
            this.numberPartsButton.Text = "Нумеровать детали";
            this.numberPartsButton.UseVisualStyleBackColor = true;
            this.numberPartsButton.Click += new System.EventHandler(this.numberPartsButton_Click);
            // 
            // startPartNumberTextBox
            // 
            this.structuresExtender.SetAttributeName(this.startPartNumberTextBox, null);
            this.structuresExtender.SetAttributeTypeName(this.startPartNumberTextBox, null);
            this.structuresExtender.SetBindPropertyName(this.startPartNumberTextBox, null);
            this.startPartNumberTextBox.Location = new System.Drawing.Point(48, 129);
            this.startPartNumberTextBox.Name = "startPartNumberTextBox";
            this.startPartNumberTextBox.Size = new System.Drawing.Size(161, 20);
            this.startPartNumberTextBox.TabIndex = 1;
            this.startPartNumberTextBox.Text = "1";
            // 
            // startMarkNumberTextBox
            // 
            this.structuresExtender.SetAttributeName(this.startMarkNumberTextBox, null);
            this.structuresExtender.SetAttributeTypeName(this.startMarkNumberTextBox, null);
            this.structuresExtender.SetBindPropertyName(this.startMarkNumberTextBox, null);
            this.startMarkNumberTextBox.Location = new System.Drawing.Point(48, 188);
            this.startMarkNumberTextBox.Name = "startMarkNumberTextBox";
            this.startMarkNumberTextBox.Size = new System.Drawing.Size(161, 20);
            this.startMarkNumberTextBox.TabIndex = 3;
            this.startMarkNumberTextBox.Text = "1";
            // 
            // numberMarksButton
            // 
            this.structuresExtender.SetAttributeName(this.numberMarksButton, null);
            this.structuresExtender.SetAttributeTypeName(this.numberMarksButton, null);
            this.structuresExtender.SetBindPropertyName(this.numberMarksButton, null);
            this.numberMarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberMarksButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numberMarksButton.Location = new System.Drawing.Point(247, 176);
            this.numberMarksButton.Name = "numberMarksButton";
            this.numberMarksButton.Size = new System.Drawing.Size(129, 32);
            this.numberMarksButton.TabIndex = 2;
            this.numberMarksButton.Text = "Нумеровать марки";
            this.numberMarksButton.UseVisualStyleBackColor = true;
            this.numberMarksButton.Click += new System.EventHandler(this.numberMarksButton_Click);
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(45, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начальный номер для деталей";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(45, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Начальный номер для марок";
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(45, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Шифр КМ";
            // 
            // projectCodeTextBox
            // 
            this.structuresExtender.SetAttributeName(this.projectCodeTextBox, null);
            this.structuresExtender.SetAttributeTypeName(this.projectCodeTextBox, null);
            this.structuresExtender.SetBindPropertyName(this.projectCodeTextBox, null);
            this.projectCodeTextBox.Location = new System.Drawing.Point(48, 73);
            this.projectCodeTextBox.Name = "projectCodeTextBox";
            this.projectCodeTextBox.Size = new System.Drawing.Size(161, 20);
            this.projectCodeTextBox.TabIndex = 6;
            // 
            // deletePartNumbersButton
            // 
            this.structuresExtender.SetAttributeName(this.deletePartNumbersButton, null);
            this.structuresExtender.SetAttributeTypeName(this.deletePartNumbersButton, null);
            this.structuresExtender.SetBindPropertyName(this.deletePartNumbersButton, null);
            this.deletePartNumbersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePartNumbersButton.ForeColor = System.Drawing.Color.Salmon;
            this.deletePartNumbersButton.Location = new System.Drawing.Point(401, 117);
            this.deletePartNumbersButton.Name = "deletePartNumbersButton";
            this.deletePartNumbersButton.Size = new System.Drawing.Size(151, 32);
            this.deletePartNumbersButton.TabIndex = 8;
            this.deletePartNumbersButton.Text = "Удалить номера деталей";
            this.deletePartNumbersButton.UseVisualStyleBackColor = true;
            this.deletePartNumbersButton.Click += new System.EventHandler(this.deletePartNumbersButton_Click);
            // 
            // deleteMarkNumbersButton
            // 
            this.structuresExtender.SetAttributeName(this.deleteMarkNumbersButton, null);
            this.structuresExtender.SetAttributeTypeName(this.deleteMarkNumbersButton, null);
            this.structuresExtender.SetBindPropertyName(this.deleteMarkNumbersButton, null);
            this.deleteMarkNumbersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMarkNumbersButton.ForeColor = System.Drawing.Color.Salmon;
            this.deleteMarkNumbersButton.Location = new System.Drawing.Point(401, 176);
            this.deleteMarkNumbersButton.Name = "deleteMarkNumbersButton";
            this.deleteMarkNumbersButton.Size = new System.Drawing.Size(151, 32);
            this.deleteMarkNumbersButton.TabIndex = 9;
            this.deleteMarkNumbersButton.Text = "Удалить номера марок";
            this.deleteMarkNumbersButton.UseVisualStyleBackColor = true;
            this.deleteMarkNumbersButton.Click += new System.EventHandler(this.deleteMarkNumbersButton_Click);
            // 
            // NumberingPluginForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(636, 243);
            this.Controls.Add(this.deleteMarkNumbersButton);
            this.Controls.Add(this.deletePartNumbersButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectCodeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startMarkNumberTextBox);
            this.Controls.Add(this.numberMarksButton);
            this.Controls.Add(this.startPartNumberTextBox);
            this.Controls.Add(this.numberPartsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NumberingPluginForm";
            this.ShowIcon = false;
            this.Text = "Нумерация марок и деталей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numberPartsButton;
        private System.Windows.Forms.TextBox startPartNumberTextBox;
        private System.Windows.Forms.TextBox startMarkNumberTextBox;
        private System.Windows.Forms.Button numberMarksButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectCodeTextBox;
        private System.Windows.Forms.Button deletePartNumbersButton;
        private System.Windows.Forms.Button deleteMarkNumbersButton;
    }
}