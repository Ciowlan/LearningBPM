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

        // 檢查 selectedItem 是否為 null
        if (selectedItem != null)
        {
            // 執行導航操作
            await Navigation.PushAsync(new ListPage2(selectedItem.ID));

            // 設定選定項目為 null，以便下一次的選擇變更事件正確觸發
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}