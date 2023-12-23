
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
                Title = "�t"; break;
            case "2": 
                Title = "�u";break; 
            case "3":
                Title = "�v";break;
            case "4": 
                Title = "�w";break;
            case "5":
                Title = "�x";break;
            case "6":
                Title = "�y";break;
            case "7":
                Title = "�z";break;
            case "8":
                Title = "�{"; break;
            case "9":
                Title = "�|"; break;
            case "10":
                Title = "�}"; break;
            case "11":
                Title = "�~"; break;
            case "12":
                Title = "��"; break;
            case "13":
                Title = "��"; break;
            case "14":
                Title = "��"; break;
            case "15":
                Title = "��"; break;
            case "16":
                Title = "��"; break;
            case "17":
                Title = "��"; break;
            case "18":
                Title = "��"; break;
            case "19":
                Title = "��"; break;
            case "20":
                Title = "��"; break;
            case "21":
                Title = "��"; break;
            case "22":
                Title = "��"; break;
            case "23":
                Title = "��"; break;
            case "24":
                Title = "��"; break;
            case "25":
                Title = "��"; break;
            case "26":
                Title = "��"; break;
            case "27":
                Title = "��"; break;
            case "28":
                Title = "��"; break;
            case "29":
                Title = "��"; break;
            case "30":
                Title = "��"; break;
            case "31":
                Title = "��"; break;
            case "32":
                Title = "��"; break;
            case "33":
                Title = "��"; break;
            case "34":
                Title = "��"; break;
            case "35":
                Title = "��"; break;
            case "36":
                Title = "��"; break;
            case "37":
                Title = "��"; break;
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
            // �D�P�B�a����ɯ�ާ@
            await Navigation.PushAsync(new ListPage3(selectedItem));

            // �]�w��w���ج� null�A�H�K�U�@��������ܧ�ƥ󥿽TĲ�o
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}