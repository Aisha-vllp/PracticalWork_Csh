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
            // Используем метод PickRandom для выбора случайного элемента
            string randomItem = items.PickRandom();
            txtResult.Text = randomItem; // Отображаем результат в текстовом поле
        }
    }

    public static class RandomTools
    {
        // Случайный объект, используемый этим методом.
        private static Random Rand = null;
        // Возвращает случайное значение.
        public static T PickRandom<T>(this T[] values)
        {
            // Создаем объект Random, если он не существует.
            if (Rand == null) Rand = new Random();
            // Выберите элемент и вернем его.
            return values[Rand.Next(0, values.Length)];
        }
    }
}
