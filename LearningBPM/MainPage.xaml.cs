namespace LearningBPM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            Navigation.PushAsync(new ListPage1(button.CommandParameter.ToString()));
        }
        private void ImageButton_Clicked_Exam(object sender, EventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            Navigation.PushAsync(new ExamPage1(button.CommandParameter.ToString()));
        }
        
    }
}