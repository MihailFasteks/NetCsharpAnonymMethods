using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCsharpAnonymMethods
{
    delegate string GetRGBColor(string col);
    delegate void AddItem(Backpack b,BackpackItem item);
    delegate int Array1(int[] arr);
    delegate bool isWord(string word,string text);
    public class BackpackItem
    {
        public string Name { get; set; }   
        public double Volume { get; set; }

        public BackpackItem(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }
    }
    public class Backpack
    {
      public string Color { get; set; }
        public string Firm {  get; set; }
        public string ClothType { get; set; }
        public double Weight { get; set; }
        public double Volume {  get; set; }
        public List<BackpackItem> Contents { get; set; }
        public Backpack()
        {
            Color = "";
            Firm = "";
            ClothType = "";
            Weight = 0;
            Volume = 0;
            Contents = new List<BackpackItem>();
        }
        public Backpack(string col, string f, string ct, double w, double v) {
            Color = col;
            Firm = f;
            ClothType = ct;
            Weight = w;
            Volume = v;
            Contents = new List<BackpackItem>();
        }
    
    }
}
