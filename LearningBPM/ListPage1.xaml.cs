namespace LearningBPM;

public partial class ListPage1 : ContentPage
{
	public ListPage1(string categoryName)
	{
        InitializeComponent();
        Title = categoryName;
        LearningData learningData = new();
        CvKids.ItemsSource = learningData.Bpm;
    }

    



    private async void CvKids_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Item;

        // �ˬd selectedItem �O�_�� null
        if (selectedItem != null)
        {
            // ����ɯ�ާ@
            await Navigation.PushAsync(new ListPage2(selectedItem.ID));

            // �]�w��w���ج� null�A�H�K�U�@��������ܧ�ƥ󥿽TĲ�o
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}