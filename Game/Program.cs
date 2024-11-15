using System.Xml.Serialization;

namespace Game
{   
    public class Program
    {
        public int error = 0; //кол-во ошибок (больше 11 = проигрышь)
        public Char[] litterMatches = new char[33]; //угаданные буквы
        public Char[] noLitterMatches = new char[33]; //НЕ угаданные буквы
        //public Program program = new Program();

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            

            /*Random rnd = new Random();
            FormMain form = new FormMain();
            
            
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
            string secretWord = words[rnd.Next(words.Length)]; // выбираем слово которое будем угадывать
            form.Print(secretWord);*/
         
            //не допускать ввода английских символов
            //при выводе совпавших и не совпавших букв выводить только те поторых нет в наличии
            

        }
    }
}