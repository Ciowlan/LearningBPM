
using Microsoft.Maui.Controls;
using Newtonsoft.Json;

namespace LearningBPM
{
    public class Item
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ID { get; set; }
    }

    public class LearningData
    {
        public List<Item> Bpm { get; set; }
        public List<Item> Colors { get; set; }
        
        public LearningData()
        {
            Bpm = new List<Item>()
            {
               new Item(){Name="£t", ImageUrl="alphabet_a.png", ID = "1"},
               new Item(){Name="£u", ImageUrl="alphabet_a.png", ID = "2"},
               new Item(){Name="£v", ImageUrl="alphabet_a.png", ID = "3"},
               new Item(){Name="£w", ImageUrl="alphabet_a.png", ID = "4"},
               new Item(){Name="£x", ImageUrl="alphabet_a.png", ID = "5"},
               new Item(){Name="£y", ImageUrl="alphabet_a.png", ID = "6"},
               new Item(){Name="£z", ImageUrl="alphabet_a.png", ID = "7"},
               new Item(){Name="£{", ImageUrl="alphabet_a.png", ID = "8"},
               new Item(){Name="£|", ImageUrl="alphabet_a.png", ID = "9"},
               new Item(){Name="£}", ImageUrl="alphabet_a.png", ID = "10"},
               new Item(){Name="£~", ImageUrl="alphabet_a.png", ID = "11"},
               new Item(){Name="£¡", ImageUrl="alphabet_a.png", ID = "12"},
               new Item(){Name="£¢", ImageUrl="alphabet_a.png", ID = "13"},
               new Item(){Name="££", ImageUrl="alphabet_a.png", ID = "14"},
               new Item(){Name="£¤", ImageUrl="alphabet_a.png", ID = "15"},
               new Item(){Name="£¥", ImageUrl="alphabet_a.png", ID = "16"},
               new Item(){Name="£¦", ImageUrl="alphabet_a.png", ID = "17"},
               new Item(){Name="£§", ImageUrl="alphabet_a.png", ID = "18"},
               new Item(){Name="£¨", ImageUrl="alphabet_a.png", ID = "19"},
               new Item(){Name="£©", ImageUrl="alphabet_a.png", ID = "20"},
               new Item(){Name="£ª", ImageUrl="alphabet_a.png", ID = "21"},
               new Item(){Name="£¸", ImageUrl="alphabet_a.png", ID = "22"},
               new Item(){Name="£¹", ImageUrl="alphabet_a.png", ID = "23"},
               new Item(){Name="£º", ImageUrl="alphabet_a.png", ID = "24"},
               new Item(){Name="£«", ImageUrl="alphabet_a.png", ID = "25"},
               new Item(){Name="£¬", ImageUrl="alphabet_a.png", ID = "26"},
               new Item(){Name="£­", ImageUrl="alphabet_a.png", ID = "27"},
               new Item(){Name="£®", ImageUrl="alphabet_a.png", ID = "28"},
               new Item(){Name="£¯", ImageUrl="alphabet_a.png", ID = "29"},
               new Item(){Name="£°", ImageUrl="alphabet_a.png", ID = "30"},
               new Item(){Name="£±", ImageUrl="alphabet_a.png", ID = "31"},
               new Item(){Name="£²", ImageUrl="alphabet_a.png", ID = "32"},
               new Item(){Name="£³", ImageUrl="alphabet_a.png", ID = "33"},
               new Item(){Name="£´", ImageUrl="alphabet_a.png", ID = "34"},
               new Item(){Name="£µ", ImageUrl="alphabet_a.png", ID = "35"},
               new Item(){Name="£¶", ImageUrl="alphabet_a.png", ID = "36"},
               new Item(){Name="£·", ImageUrl="alphabet_a.png", ID = "37"}
            };
               
            Colors = new List<Item>()
            {
               new Item() { Name = "Black", ImageUrl = "color_black.png" },
               new Item() { Name = "Blue", ImageUrl = "color_blue.png" },
               new Item() { Name = "Gray", ImageUrl = "color_gray.png" },
               new Item() { Name = "Green", ImageUrl = "color_green.png" },
               new Item() { Name = "Orange", ImageUrl = "color_orange.png" },
               new Item() { Name = "Purple", ImageUrl = "color_purple.png" },
               new Item() { Name = "Red", ImageUrl = "color_red.png" },
               new Item() { Name = "Yellow", ImageUrl = "color_yellow.png" },
            };


           
        }

       

    }

 
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Root
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("Word")]
        public string Word { get; set; }

        [JsonProperty("Radical")]
        public string Radical { get; set; }

        [JsonProperty("Total_number_of_strokes")]
        public string TotalNumberOfStrokes { get; set; }

        [JsonProperty("Strokes_outside_the_radical")]
        public string StrokesOutsideTheRadical { get; set; }

        [JsonProperty("Phonetic_notation")]
        public string PhoneticNotation { get; set; }

        [JsonProperty("Explain")]
        public string Explain { get; set; }
    }







}
