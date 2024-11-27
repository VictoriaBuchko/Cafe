namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTimePickerTime.MinDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxName.Text) || string.IsNullOrWhiteSpace(TextBoxPhone.Text))
            {
                MessageBox.Show("Будь ласка, заповніть ім'я та номер телефону", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderTime = DateTimePickerTime.Value.ToString("f");
            string mainDish = comboBox1.SelectedItem?.ToString() ?? "Не обрано";
            var additionalItems = checkedListBox1.CheckedItems.Cast<string>().ToList();
            string deliveryType = GetDeliveryType();

            string summary = $"Ім'я: {TextBoxName.Text}\n" +
                             $"Телефон: {TextBoxPhone.Text}\n" +
                             $"Час отримання: {orderTime}\n" +
                             $"Основна страва: {mainDish}\n" +
                             $"Додатково: {(additionalItems.Any() ? string.Join(", ", additionalItems) : "Нічого")}\n" +
                             $"Тип замовлення: {deliveryType}";

            MessageBox.Show(summary, "Підтвердження замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetDeliveryType()
        {
            if (RadioButtonSelfPickup.Checked)
            {
                RadioButtonDelivery.Checked = false;
                return "Самовивіз";
            }
            else
            {
                RadioButtonDelivery.Checked = true;
                return "Доставка";
            }
        }
    }
}
