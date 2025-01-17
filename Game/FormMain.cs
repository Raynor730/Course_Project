using System;
using System.Windows.Forms;

namespace Game
{
    public partial class FormMain : Form
    {
        private int error = 0;
        private HashSet<char> matchedLettersSet = new HashSet<char>();
        private HashSet<char> noMatchedLettersSet = new HashSet<char>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            Check(InputWord.Text);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            picture.Image = Image.FromFile("Image\\0.png");

            Random rnd = new Random();
            string[] words =
            {
               "Пицца",
               "Сода",
               "Баба",
               "Бабушка",
               "Дедушка",
               "Мама",
               "Папа",
               "Вагон",
               "Габарит",
               "Жабо",
               "Лягушка",
               "Тигр",
               "Лев",
               "Зубр",
               "Бизон",
               "Газель",
               "Зебра",
               "Жираф",
               "Игуала",
               "Уж",
               "Питон",
               "Кобра",
               "Манитор",
               "Блок",
               "Шлакоблок",
               "Бетон",
               "Шлакбаум",
               "Вагонетка",
               "Горшок",
               "Цветок",
               "Банка",
               "Банан"
            };
            string secretWord = words[rnd.Next(words.Length)]; // выбираем слово, которое будем угадывать

            SecretWord.Text = secretWord;
        }

        public void Check(string word)
        {
            matchedLettersSet.Clear(); // Очищаем множества перед новой проверкой
            noMatchedLettersSet.Clear();

            char[] secretWordChar = SecretWord.Text.ToLower().Trim().ToCharArray();
            char[] inputWordChar = word.ToLower().Trim().ToCharArray();

            // Внешний цикл проходит по каждому символу inputWordChar
            for (int j = 0; j < inputWordChar.Length; j++)
            {
                bool matchFound = false; // Флаг для отслеживания совпадений

                for (int i = 0; i < secretWordChar.Length; i++)
                {
                    if (inputWordChar[j] == secretWordChar[i])
                    {
                        // Если совпадение найдено и буква еще не добавлена
                        if (matchedLettersSet.Add(inputWordChar[j])) // Добавляем и проверяем уникальность
                        {
                            matchFound = true; // Устанавливаем флаг, если совпадение найдено
                        }
                    }
                }

                // Если совпадений не найдено, добавляем буквы во множество несовпадений
                if (!matchFound)
                {
                    noMatchedLettersSet.Add(inputWordChar[j]); // Добавляем букву из вводимого слова
                }
            }

            // Обновление меток с использованием методов OutMatchingLetters и OutNoMatchingLetters
            OutMatchingLetters(matchedLettersSet);
            OutNoMatchingLetters(noMatchedLettersSet);
        }

        public void OutMatchingLetters(HashSet<char> matchedLettersSet)
        {
            // Очистка текстового поля перед обновлением
            labelOutMatchingLetters.Text = string.Empty;

            // Выводим буквы в текстовое поле для совпадающих букв
            foreach (char letter in matchedLettersSet)
            {
                labelOutMatchingLetters.Text += letter + ", ";
            }

            // Убираем последний символ ", " если есть буквы
            if (matchedLettersSet.Count > 0)
            {
                labelOutMatchingLetters.Text = labelOutMatchingLetters.Text.TrimEnd(',', ' ');
            }
        }

        public void OutNoMatchingLetters(HashSet<char> noMatchedLettersSet)
        {
            // Очистка текстового поля перед обновлением
            labelOutNoMatchingLetters.Text = string.Empty;

            // Выводим буквы в текстовое поле для несовпадающих букв
            foreach (char letter in noMatchedLettersSet)
            {
                labelOutNoMatchingLetters.Text += letter + ", ";
            }

            // Убираем последний символ ", " если есть буквы
            if (noMatchedLettersSet.Count > 0)
            {
                labelOutNoMatchingLetters.Text = labelOutNoMatchingLetters.Text.TrimEnd(',', ' ');
            }
        }

        public void imgUpdate(int error) // обновление картинки
        {
            if (error >= 11)
            {
                // форма поражения
            }
            else
            {
                picture.Image = Image.FromFile("image\\" + error + ".png");
            }
        }
    }
}