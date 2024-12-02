// See https://aka.ms/new-console-template for more information

using NetCsharpAnonymMethods;
//task1
//GetRGBColor MyColor = delegate (string col)
//{
//    switch (col.ToLower())
//    {
//        case "red": return "255, 0, 0";
//        case "green": return "0, 255, 0";
//        case "blue": return "0, 0, 255";
//        case "yellow": return "255, 255, 0";
//        case "cyan": return "0, 255, 255";
//        case "magenta": return "255, 0, 255";
//        default: return "Unknown color";
//    }
//};

//Console.WriteLine(MyColor("blue")); 
//Console.WriteLine(MyColor("red"));    


//task2
//double tempV = 0;
//AddItem add = delegate (Backpack b, BackpackItem item)
//{
//    try
//    {
//        if (tempV + item.Volume > b.Volume)
//        {
//            throw new Exception("Недостаточно места в рюкзаке!!!!");
//        }

//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Исключение: {ex.Message}");
//        return;
//    }

//    b.Contents.Add(item);
//    Console.WriteLine("Item was add");
//    tempV += item.Volume;
//};
//Backpack b1=new Backpack("brown", "Ostin&Co", "leather", 1.5, 20);
//BackpackItem book1 = new BackpackItem("Biology_book", 22);


//add(b1, book1);


//task3
Random rnd = new Random();
//int[] array = new int[10];
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = rnd.Next(1, 100);
//    Console.Write(array[i] + " ");
//}
//Console.WriteLine();

//Array1 sevenCount = arr =>
//{
//    int count = 0;
//    foreach (int item in arr)
//    {
//        if (item % 7 == 0)
//        {
//            count++;
//        }
//    }
//    return count;
//};

//Console.WriteLine("В массиве " + sevenCount(array) + " чисел кратных 7");


//task4
//int[] array2 = new int[10];
//for (int i = 0; i < array2.Length; i++)
//{
//    array2[i] = rnd.Next(-100, 100);
//    Console.Write(array2[i] + " ");
//}
//Console.WriteLine();

//Array1 signCount = arr =>
//{
//    int count = 0;
//    foreach (int item in arr)
//    {
//        if (item > 0)
//        {
//            count++;
//        }
//    }
//    return count;
//};

//Console.WriteLine("В массиве " + signCount(array2) + " положительных чисел");

//task5

//int[] array3 = new int[10];
//for (int i = 0; i < array3.Length; i++)
//{
//    array3[i] = rnd.Next(-100, 0);
//    Console.Write(array3[i] + " ");
//}
//Console.WriteLine();

//Array1 unsignCount = arr =>
//{
//    int count = 0;
//    bool isUnique;    
//   for (int i = 0; i < arr.Length; i++)
//    {
//        isUnique = true;
//        for (int j = 0; j < arr.Length; j++)
//        {
//            if (i == j)
//            {
//                continue;

//            }
//            if (arr[i] == arr[j])
//            {
//                isUnique = false;
//                break;


//            }
//        }
//        if (isUnique == true)
//        {
//            count++;
//        }
//    }
//    return count;
//};

//Console.WriteLine("В массиве " + unsignCount(array3) + " уникальных отрицательных чисел");


//task6

isWord word1 = (word, text) =>
{
    bool istext = text.ToLower().Contains(word.ToLower());
    return istext;
};

if (word1("hello", "helloworld") == true)
{
    Console.WriteLine("Yapppiiiiiiii :))");
}