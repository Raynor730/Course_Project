using System.Xml.Serialization;

namespace Game
{   
    public class Program
    {
        public int error = 0; //���-�� ������ (������ 11 = ���������)
        public Char[] litterMatches = new char[33]; //��������� �����
        public Char[] noLitterMatches = new char[33]; //�� ��������� �����
        //public Program program = new Program();

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
            

            /*Random rnd = new Random();
            FormMain form = new FormMain();
            
            
            string[] words =
            {
               "�����",
               "����",
               "����",
               "�������",
               "�������",
               "����",
               "����",
               "�����",
               "�������",
               "����",
               "�������",
               "����",
               "���",
               "����",
               "�����",
               "������",
               "�����",
               "�����",
               "������",
               "��",
               "�����",
               "�����",
               "�������",
               "����",
               "���������",
               "�����",
               "��������",
               "���������",
               "������",
               "������",
               "�����",
               "�����"
            };
            string secretWord = words[rnd.Next(words.Length)]; // �������� ����� ������� ����� ���������
            form.Print(secretWord);*/
         
            //�� ��������� ����� ���������� ��������
            //��� ������ ��������� � �� ��������� ���� �������� ������ �� ������� ��� � �������
            

        }
    }
}