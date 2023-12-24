namespace LearningBPM;

public partial class ExamPage1 : ContentPage
{
	public ExamPage1(string Name)
	{
		InitializeComponent();
		Title = Name;
        LoadQuestion(currentQuestionIndex);
    }
    private int currentQuestionIndex = 0;
    private int score = 0;
    private bool checkFinish = false;
    private List<Question> questions = new List<Question>
        {
            new Question("�Ĥ@�D", "wen.png", "������"),
            new Question("�ĤG�D", "huo.png", "�~������"),
            new Question("�ĤT�D", "pian.png", "�u������"),
            new Question("�ĥ|�D", "yin.png", "������"),
            new Question("�Ĥ��D", "hao.png", "�~����"),
            new Question("�Ĥ��D", "lai.png", "�{����"),
            new Question("�ĤC�D", "fa.png", "�w����"),
            new Question("�ĤK�D", "wan.png", "������"),
            new Question("�ĤE�D", "jin.png", "������"),
            new Question("�ĤQ�D", "ma.png", "�v��"),
            new Question("�ĤQ�@�D", "zhang.png", "����"),
            new Question("�ĤQ�G�D", "jue.png", "��������"),
            new Question("�ĤQ�T�D", "zhen.png", "����"),
            new Question("�ĤQ�|�D", "shi.png", "��"),
            new Question("�ĤQ���D", "xue.png", "��������"),
        };


    private void LoadQuestion(int questionIndex)
    {
        questionNumberLabel.Text = $"{questionIndex + 1}/{questions.Count}";
        scoreLabel.Text = $"Score: {score}";

        questionImage.Source = ImageSource.FromFile(questions[questionIndex].ImagePath);
        questionTextLabel.Text = $"�аݳo�Ӧr�������O�ƻ�O�H";

        answerEntry.Text = string.Empty;
    }

    private async void NextQuestion_Clicked(object sender, EventArgs e)
    {

        if(checkFinish)
        {
            currentQuestionIndex = 0;
            score = 0;
            checkFinish = false;
            btn.Text = "�U�@�D";
            questionImage.Source = ImageSource.FromFile(questions[0].ImagePath);
        }
        else
        {
            if (answerEntry.Text == questions[currentQuestionIndex].CorrectAnswer)
            {
                score += 10;
                await DisplayAlert("����", "�����_�_�A����աI", "�T�w");
            }
            else
            {
                await DisplayAlert("���׿��~", $"�_�_�n�A��V�O�ݮѳ�~���׬O�G{questions[currentQuestionIndex].CorrectAnswer}", "�T�w");
            }

            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                // ��� Quiz Finished �����ܮ�
                var quizFinishedAlert = await DisplayAlert("Quiz Finished", $"Your score: {score}\n���ߧA�����F�Ҧ��D��!", "OK", "��^�D��");

                // �ˬd���s�I�����G
                if (!quizFinishedAlert)
                {
                    // ��^�D��
                    await Navigation.PopToRootAsync();
                }
                else
                {
                    btn.Text = "�A�Ӥ@��";
                    checkFinish = true;
                }
            }
        }
        
        
    }
}