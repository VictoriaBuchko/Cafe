namespace Cafe
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
            TextBoxPhone = new TextBox();
            TextBoxName = new TextBox();
            LabelName = new Label();
            LabelPhone = new Label();
            DateTimePickerTime = new DateTimePicker();
            label3 = new Label();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            RadioButtonSelfPickup = new RadioButton();
            RadioButtonDelivery = new RadioButton();
            LabelDelivery = new Label();
            button1 = new Button();
            LabelTime = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // TextBoxPhone
            // 
            TextBoxPhone.BackColor = Color.WhiteSmoke;
            TextBoxPhone.Location = new Point(34, 140);
            TextBoxPhone.Name = "TextBoxPhone";
            TextBoxPhone.Size = new Size(125, 27);
            TextBoxPhone.TabIndex = 0;
            // 
            // TextBoxName
            // 
            TextBoxName.BackColor = Color.MintCream;
            TextBoxName.Location = new Point(37, 66);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(125, 27);
            TextBoxName.TabIndex = 1;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            LabelName.Location = new Point(34, 43);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(87, 20);
            LabelName.TabIndex = 2;
            LabelName.Text = "Enter Name";
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            LabelPhone.Location = new Point(34, 117);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new Size(146, 20);
            LabelPhone.TabIndex = 3;
            LabelPhone.Text = "Enter Phone Number";
            // 
            // DateTimePickerTime
            // 
            DateTimePickerTime.Format = DateTimePickerFormat.Time;
            DateTimePickerTime.Location = new Point(41, 223);
            DateTimePickerTime.Name = "DateTimePickerTime";
            DateTimePickerTime.Size = new Size(118, 27);
            DateTimePickerTime.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label3.Location = new Point(298, 43);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Menu";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.MintCream;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "pizza", "paste", "salad", "sup" });
            comboBox1.Location = new Point(298, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.MintCream;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "cheese", "bacon", "carbonated drinks", "juice", "mineral water" });
            checkedListBox1.Location = new Point(298, 140);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 8;
            // 
            // RadioButtonSelfPickup
            // 
            RadioButtonSelfPickup.AutoSize = true;
            RadioButtonSelfPickup.Location = new Point(56, 323);
            RadioButtonSelfPickup.Name = "RadioButtonSelfPickup";
            RadioButtonSelfPickup.Size = new Size(103, 24);
            RadioButtonSelfPickup.TabIndex = 9;
            RadioButtonSelfPickup.TabStop = true;
            RadioButtonSelfPickup.Text = "self-pickup";
            RadioButtonSelfPickup.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDelivery
            // 
            RadioButtonDelivery.AutoSize = true;
            RadioButtonDelivery.Location = new Point(56, 353);
            RadioButtonDelivery.Name = "RadioButtonDelivery";
            RadioButtonDelivery.Size = new Size(82, 24);
            RadioButtonDelivery.TabIndex = 10;
            RadioButtonDelivery.TabStop = true;
            RadioButtonDelivery.Text = "delivery";
            RadioButtonDelivery.UseVisualStyleBackColor = true;
            // 
            // LabelDelivery
            // 
            LabelDelivery.AutoSize = true;
            LabelDelivery.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            LabelDelivery.Location = new Point(46, 292);
            LabelDelivery.Name = "LabelDelivery";
            LabelDelivery.Size = new Size(114, 20);
            LabelDelivery.TabIndex = 11;
            LabelDelivery.Text = "Type of delivery";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(194, 400);
            button1.Name = "button1";
            button1.Size = new Size(175, 29);
            button1.TabIndex = 12;
            button1.Text = "Confirm the order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            LabelTime.Location = new Point(37, 200);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(122, 20);
            LabelTime.TabIndex = 13;
            LabelTime.Text = "Order ready time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label6.Location = new Point(298, 117);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 14;
            label6.Text = "Additional set";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(562, 450);
            Controls.Add(label6);
            Controls.Add(LabelTime);
            Controls.Add(button1);
            Controls.Add(LabelDelivery);
            Controls.Add(RadioButtonDelivery);
            Controls.Add(RadioButtonSelfPickup);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(DateTimePickerTime);
            Controls.Add(LabelPhone);
            Controls.Add(LabelName);
            Controls.Add(TextBoxName);
            Controls.Add(TextBoxPhone);
            Name = "Form1";
            Text = "Онлайн замовлення";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxPhone;
        private TextBox TextBoxName;
        private Label LabelName;
        private Label LabelPhone;
        private DateTimePicker DateTimePickerTime;
        private Label label3;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private RadioButton RadioButtonSelfPickup;
        private RadioButton RadioButtonDelivery;
        private Label LabelDelivery;
        private Button button1;
        private Label LabelTime;
        private Label label6;
    }
}
