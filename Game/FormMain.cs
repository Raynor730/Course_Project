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
            string secretWord = words[rnd.Next(words.Length)]; // �������� �����, ������� ����� ���������

            SecretWord.Text = secretWord;
        }

        public void Check(string word)
        {
            matchedLettersSet.Clear(); // ������� ��������� ����� ����� ���������
            noMatchedLettersSet.Clear();

            char[] secretWordChar = SecretWord.Text.ToLower().Trim().ToCharArray();
            char[] inputWordChar = word.ToLower().Trim().ToCharArray();

            // ������� ���� �������� �� ������� ������� inputWordChar
            for (int j = 0; j < inputWordChar.Length; j++)
            {
                bool matchFound = false; // ���� ��� ������������ ����������

                for (int i = 0; i < secretWordChar.Length; i++)
                {
                    if (inputWordChar[j] == secretWordChar[i])
                    {
                        // ���� ���������� ������� � ����� ��� �� ���������
                        if (matchedLettersSet.Add(inputWordChar[j])) // ��������� � ��������� ������������
                        {
                            matchFound = true; // ������������� ����, ���� ���������� �������
                        }
                    }
                }

                // ���� ���������� �� �������, ��������� ����� �� ��������� ������������
                if (!matchFound)
                {
                    noMatchedLettersSet.Add(inputWordChar[j]); // ��������� ����� �� ��������� �����
                }
            }

            // ���������� ����� � �������������� ������� OutMatchingLetters � OutNoMatchingLetters
            OutMatchingLetters(matchedLettersSet);
            OutNoMatchingLetters(noMatchedLettersSet);
        }

        public void OutMatchingLetters(HashSet<char> matchedLettersSet)
        {
            // ������� ���������� ���� ����� �����������
            labelOutMatchingLetters.Text = string.Empty;

            // ������� ����� � ��������� ���� ��� ����������� ����
            foreach (char letter in matchedLettersSet)
            {
                labelOutMatchingLetters.Text += letter + ", ";
            }

            // ������� ��������� ������ ", " ���� ���� �����
            if (matchedLettersSet.Count > 0)
            {
                labelOutMatchingLetters.Text = labelOutMatchingLetters.Text.TrimEnd(',', ' ');
            }
        }

        public void OutNoMatchingLetters(HashSet<char> noMatchedLettersSet)
        {
            // ������� ���������� ���� ����� �����������
            labelOutNoMatchingLetters.Text = string.Empty;

            // ������� ����� � ��������� ���� ��� ������������� ����
            foreach (char letter in noMatchedLettersSet)
            {
                labelOutNoMatchingLetters.Text += letter + ", ";
            }

            // ������� ��������� ������ ", " ���� ���� �����
            if (noMatchedLettersSet.Count > 0)
            {
                labelOutNoMatchingLetters.Text = labelOutNoMatchingLetters.Text.TrimEnd(',', ' ');
            }
        }

        public void imgUpdate(int error) // ���������� ��������
        {
            if (error >= 11)
            {
                // ����� ���������
            }
            else
            {
                picture.Image = Image.FromFile("image\\" + error + ".png");
            }
        }
    }
}