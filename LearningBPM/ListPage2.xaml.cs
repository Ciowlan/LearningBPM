
using Newtonsoft.Json;
namespace LearningBPM;

public partial class ListPage2 : ContentPage
{
    public ListPage2(string categoryName)
    {
        InitializeComponent();
        //DisplayLearningResult(categoryName);
        SetTitle(categoryName);
        GetWord(categoryName);

    }

    private void SetTitle(string categoryName)
    {
        switch (categoryName)
        {
            case "1":
                Title = "ㄅ"; break;
            case "2": 
                Title = "ㄆ";break; 
            case "3":
                Title = "ㄇ";break;
            case "4": 
                Title = "ㄈ";break;
            case "5":
                Title = "ㄉ";break;
            case "6":
                Title = "ㄊ";break;
            case "7":
                Title = "ㄋ";break;
            case "8":
                Title = "ㄌ"; break;
            case "9":
                Title = "ㄍ"; break;
            case "10":
                Title = "ㄎ"; break;
            case "11":
                Title = "ㄏ"; break;
            case "12":
                Title = "ㄐ"; break;
            case "13":
                Title = "ㄑ"; break;
            case "14":
                Title = "ㄒ"; break;
            case "15":
                Title = "ㄓ"; break;
            case "16":
                Title = "ㄔ"; break;
            case "17":
                Title = "ㄕ"; break;
            case "18":
                Title = "ㄖ"; break;
            case "19":
                Title = "ㄗ"; break;
            case "20":
                Title = "ㄘ"; break;
            case "21":
                Title = "ㄙ"; break;
            case "22":
                Title = "ㄧ"; break;
            case "23":
                Title = "ㄨ"; break;
            case "24":
                Title = "ㄩ"; break;
            case "25":
                Title = "ㄚ"; break;
            case "26":
                Title = "ㄛ"; break;
            case "27":
                Title = "ㄜ"; break;
            case "28":
                Title = "ㄝ"; break;
            case "29":
                Title = "ㄞ"; break;
            case "30":
                Title = "ㄟ"; break;
            case "31":
                Title = "ㄠ"; break;
            case "32":
                Title = "ㄡ"; break;
            case "33":
                Title = "ㄢ"; break;
            case "34":
                Title = "ㄣ"; break;
            case "35":
                Title = "ㄤ"; break;
            case "36":
                Title = "ㄥ"; break;
            case "37":
                Title = "ㄦ"; break;
            default:
                break;
        }
    }

    private async void GetWord(string categoryName)
    {
        var serializer = new JsonSerializer();
        List<Root> root = new();
        using var stream = await FileSystem.OpenAppPackageFileAsync($"{categoryName}.json");
        using (var streamReader = new StreamReader(stream))
        using (var textReader = new JsonTextReader(streamReader))
        {
            root = serializer.Deserialize<List<Root>>(textReader);
        }
        CvKids.ItemsSource = root;
    }
    private async void CvKids_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Root;

        if (selectedItem != null)
        {
            // 非同步地執行導航操作
            await Navigation.PushAsync(new ListPage3(selectedItem));

            // 設定選定項目為 null，以便下一次的選擇變更事件正確觸發
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}