namespace LearningBPM;

public partial class ListPage3 : ContentPage
{
    public ListPage3(Root root)
    {
        InitializeComponent();
        LblWord.Text = root.Word;
        LblRadical.Text = root.Radical+"³¡";
        LblContent.Text = root.Explain;
        LblTotalNumberOfStrokes.Text = root.TotalNumberOfStrokes+"µe";
        LblPhoneticNotation.Text = root.PhoneticNotation;
        Title = root.Word;
    }
}