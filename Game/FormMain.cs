using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Game;

namespace Game
{
    public partial class FormMain : Form
    {
        private int error = 0;
        private bool errorInAttempt = false;
        private HashSet<char> matchedLettersSet = new HashSet<char>();
        private HashSet<char> noMatchedLettersSet = new HashSet<char>();

        FormDefeat formDefeat = new FormDefeat();
        private string secretWord;

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
            CountingErrors.Text = "������: 0/11";
            picture.Image = Image.FromFile("Image\\0.png");

            List<string> words = LoadWordsFromXml("words.xml"); // �������� ���� �� XML
            Random rnd = new Random();
            secretWord = words[rnd.Next(words.Count)]; // �������� �����, ������� ����� ���������

            SecretWord.Text = secretWord;
            //string maskedWord = secretWord[0] + new string('_', secretWord.Length - 2)+ secretWord[secretWord.Length - 1];
            //SecretWord.Text = maskedWord;
        }
        // �������� �� ����������� ����� Words
        private List<string> LoadWordsFromXml(string filePath)
        {
            var wordsList = new List<string>();

            try
            {
                XElement xml = XElement.Load(filePath);
                foreach (var word in xml.Elements("word"))
                {
                    wordsList.Add(word.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ��� ������ XML �����: " + ex.Message);
            }

            return wordsList;
        }
        public void Check(string word)
        {
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
                    errorInAttempt = true;
                    //���� ����� ���� � ��������� ���������� �� ����������
                    if(!matchedLettersSet.Contains(inputWordChar[j]))
                    {
                        noMatchedLettersSet.Add(inputWordChar[j]); // ��������� ����� �� ��������� �����
                    }
                }
            }
            if(errorInAttempt)
            {
                error++;
                CountingErrors.Text = "������: "+ error +"/11";
                imgUpdate(error);
                errorInAttempt = false;
            }

            // ���� ����� ������, ����� �� ���������
            if (inputWordChar.Length == secretWordChar.Length)
            {
                int lenght = 0;
                // ���������� ������� �� ��������
                for (int i = 0; i < inputWordChar.Length; i++)
                {
                    if (inputWordChar[i] == secretWordChar[i])
                    {
                        lenght++;
                        if (lenght == secretWordChar.Length)
                        {
                            FormWin formWin = new FormWin();
                            FormMain formMain = new FormMain();
                            formMain.Hide();
                            Refresh();
                            Thread.Sleep(500);
                            formWin.Show();
                        }
                    }
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
                picture.Image = Image.FromFile("image\\11.png");
                Refresh();
                this.Close();
                Thread.Sleep(500);
                formDefeat.Show();
            }
            else
            {
                picture.Image = Image.FromFile("image\\" + error + ".png");
            }
        }
    }
}