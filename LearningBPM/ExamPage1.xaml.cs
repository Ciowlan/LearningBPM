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
            new Question("第一題", "wen.png", "ㄨㄣˊ"),
            new Question("第二題", "huo.png", "ㄏㄨㄛˇ"),
            new Question("第三題", "pian.png", "ㄆㄧㄢˋ"),
            new Question("第四題", "yin.png", "ㄧㄣˋ"),
            new Question("第五題", "hao.png", "ㄏㄠˇ"),
            new Question("第六題", "lai.png", "ㄌㄞˊ"),
            new Question("第七題", "fa.png", "ㄈㄚˇ"),
            new Question("第八題", "wan.png", "ㄨㄢˊ"),
            new Question("第九題", "jin.png", "ㄐㄧㄣ"),
            new Question("第十題", "ma.png", "ㄇㄚ"),
            new Question("第十一題", "zhang.png", "ㄓㄤ"),
            new Question("第十二題", "jue.png", "ㄐㄩㄝˊ"),
            new Question("第十三題", "zhen.png", "ㄓㄣ"),
            new Question("第十四題", "shi.png", "ㄕ"),
            new Question("第十五題", "xue.png", "ㄒㄩㄝˊ"),
        };


    private void LoadQuestion(int questionIndex)
    {
        questionNumberLabel.Text = $"{questionIndex + 1}/{questions.Count}";
        scoreLabel.Text = $"Score: {score}";

        questionImage.Source = ImageSource.FromFile(questions[questionIndex].ImagePath);
        questionTextLabel.Text = $"請問這個字的拼音是甚麼呢？";

        answerEntry.Text = string.Empty;
    }

    private async void NextQuestion_Clicked(object sender, EventArgs e)
    {

        if(checkFinish)
        {
            currentQuestionIndex = 0;
            score = 0;
            checkFinish = false;
            btn.Text = "下一題";
            questionImage.Source = ImageSource.FromFile(questions[0].ImagePath);
        }
        else
        {
            if (answerEntry.Text == questions[currentQuestionIndex].CorrectAnswer)
            {
                score += 10;
                await DisplayAlert("恭喜", "恭喜寶寶你答對啦！", "確定");
            }
            else
            {
                await DisplayAlert("答案錯誤", $"寶寶要再更努力看書喔~答案是：{questions[currentQuestionIndex].CorrectAnswer}", "確定");
            }

            currentQuestionIndex++;

            if (currentQuestionIndex < questions.Count)
            {
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                // 顯示 Quiz Finished 的提示框
                var quizFinishedAlert = await DisplayAlert("Quiz Finished", $"Your score: {score}\n恭喜你做完了所有題目!", "OK", "返回主頁");

                // 檢查按鈕點擊結果
                if (!quizFinishedAlert)
                {
                    // 返回主頁
                    await Navigation.PopToRootAsync();
                }
                else
                {
                    btn.Text = "再來一次";
                    checkFinish = true;
                }
            }
        }
        
        
    }
}