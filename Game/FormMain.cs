using System.Windows.Forms;

namespace Game
{
    public partial class FormMain : Form
    {
        private int error = 0;
        private int toNewLineMatchingLetters = 0;
        private int toNewLineNoMatchingLetters = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonCheck_Click(object sender, EventArgs e)//���������
        {
            Check(InputWord.Text);
        }

        private void FormMain_Load(object sender, EventArgs e)//���������
        {
            picture.Image = Image.FromFile("image\\0.png");

            Random rnd = new Random();
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

            SecretWord.Text = secretWord;
        }
        
        public void Print(string secretWord)//���������
        {
            SecretWord.Text = secretWord;
        }

        public void Check(string word)//��������
        {
            //Program program = new Program();

            char[] secretWordChar = SecretWord.Text.ToLower().Trim().ToCharArray();
            char[] inputWordChar = InputWord.Text.ToLower().Trim().ToCharArray();
            int matching = 0;
            


            // 
            for (int i = 0; i < secretWordChar.Length;i++)
            {
                for(int j = 0; j< inputWordChar.Length;j++)
                {
                    if (inputWordChar[j] == secretWordChar[i])
                    {
                        OutMatchingLetters(inputWordChar, j);
                        matching++;
                    }
                    else
                    {
                        OutNoMatchingLetters(inputWordChar, j);
                    }
                    
                    
                }
                
            }
            if(matching == 0)
            {
                error++;
                imgUpdate(error);
            }
        }

        public void OutMatchingLetters(char[] inputWordChar, int index)
        {
            labelOutMatchingLetters.Text += inputWordChar[index] + ", ";
            toNewLineMatchingLetters++;
            if (toNewLineMatchingLetters >= 16)
            {
                labelOutMatchingLetters.Text += "\n";
                toNewLineMatchingLetters = 0;
            }
        }

        public void OutNoMatchingLetters(char[] inputWordChar, int index)
        {
            labelOutNoMatchingLetters.Text += inputWordChar[index] + ", ";
            toNewLineNoMatchingLetters++;
            if (toNewLineNoMatchingLetters >= 16)
            {
                labelOutNoMatchingLetters.Text += "\n";
                toNewLineNoMatchingLetters = 0;
            }
        }
        public void imgUpdate(int error)//���������
        {
            picture.Image = Image.FromFile("image\\" + error + ".png");
        }

        
    }
}
