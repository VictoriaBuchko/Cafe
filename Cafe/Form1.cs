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
                MessageBox.Show("���� �����, �������� ��'� �� ����� ��������", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderTime = DateTimePickerTime.Value.ToString("f");
            string mainDish = comboBox1.SelectedItem?.ToString() ?? "�� ������";
            var additionalItems = checkedListBox1.CheckedItems.Cast<string>().ToList();
            string deliveryType = GetDeliveryType();

            string summary = $"��'�: {TextBoxName.Text}\n" +
                             $"�������: {TextBoxPhone.Text}\n" +
                             $"��� ���������: {orderTime}\n" +
                             $"������� ������: {mainDish}\n" +
                             $"���������: {(additionalItems.Any() ? string.Join(", ", additionalItems) : "ͳ����")}\n" +
                             $"��� ����������: {deliveryType}";

            MessageBox.Show(summary, "ϳ����������� ����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetDeliveryType()
        {
            if (RadioButtonSelfPickup.Checked)
            {
                RadioButtonDelivery.Checked = false;
                return "��������";
            }
            else
            {
                RadioButtonDelivery.Checked = true;
                return "��������";
            }
        }
    }
}
