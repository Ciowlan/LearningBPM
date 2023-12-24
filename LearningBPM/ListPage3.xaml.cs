namespace LearningBPM;

public partial class ListPage3 : ContentPage
{
    public ListPage3(Root root)
    {
        InitializeComponent();
        LblWord.Text = root.Word;
        LblRadical.Text = root.Radical+"��";
        LblContent.Text = root.Explain;
        LblTotalNumberOfStrokes.Text = root.TotalNumberOfStrokes+"�e";
        LblPhoneticNotation.Text = root.PhoneticNotation;
        Title = root.Word;
    }
}