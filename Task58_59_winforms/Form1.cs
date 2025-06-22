using System;

namespace Task58_59_winforms
{
    public partial class Form1 : Form
    {
        private string[] items = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        public Form1()
        {
            InitializeComponent();
        }

        private void PickRandomData_Click(object sender, EventArgs e)
        {
            // ���������� ����� PickRandom ��� ������ ���������� ��������
            string randomItem = items.PickRandom();
            txtResult.Text = randomItem; // ���������� ��������� � ��������� ����
        }
    }

    public static class RandomTools
    {
        // ��������� ������, ������������ ���� �������.
        private static Random Rand = null;
        // ���������� ��������� ��������.
        public static T PickRandom<T>(this T[] values)
        {
            // ������� ������ Random, ���� �� �� ����������.
            if (Rand == null) Rand = new Random();
            // �������� ������� � ������ ���.
            return values[Rand.Next(0, values.Length)];
        }
    }
}
