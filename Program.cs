using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //System.Collecitons namespace

        ArrayList list = new ArrayList();
       // list.Add("Ayşe");
        list.Add(5);
       // list.Add(true);
        //list.Add('a');

        //içindeki verilere erişme
       // Console.WriteLine(list[1]);

        foreach(var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------");
        //AddRange(birden fazla elemanı toplu halde ekleyebilmek)
        string []renkler= {"sarı","kırmızı","mavi","yesil"};
        List<int> sayılar=new List<int>(){1,99,35,12,35};
        //list.AddRange(renkler);
        list.AddRange(sayılar);

        foreach(var item in list)
        {
            Console.WriteLine(item); 
        }
        
        Console.WriteLine("--------------------");
        
        //Sort
        list.Sort();

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------");
        //Binary Search
        Console.WriteLine(list.BinarySearch(12));

        Console.WriteLine("--------------------");
        //Reverse

        list.Reverse();

        foreach (var item in list)
        {
            Console.WriteLine(item) ;   
        }
        //Clear
        Console.WriteLine("--------------------");

        list.Clear();
        foreach (var item in list)
        {
           Console.WriteLine(item); 
        }




    }
}