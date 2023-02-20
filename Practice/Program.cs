#region Directory and File (Create,Delete,Exists) and StreamReader,StreamWriter

//Directory.CreateDirectory(@"C:/Users/HP/Desktop/Test");
//Directory.CreateDirectory(@"C:/Users/HP/Desktop/Lorem");
//Directory.CreateDirectory(@"C:/Users/HP/Desktop/Lorem/Tset");
//Directory.Delete(@"C:/Users/HP/Desktop/Lorem", true);
//if (Directory.Exists(@"C:/Users/HP/Desktop/Lorem/Tset"))
//{
//    Directory.Delete(@"C:/Users/HP/Desktop/Lorem/Tset");
//}
//string[] arr = Directory.GetFiles(@"C:/Users/HP/Desktop/Test");
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//if (File.Exists(@"C:/Users/HP/Desktop/Test/blabla.txt"))
//{
//    //File.Create(@"C:/Users/HP/Desktop/Test/blabla.txt");
//    File.Delete(@"C:/Users/HP/Desktop/Test/blabla.txt");

//}





//StreamWriter sw = new StreamWriter(@"C:/Users/HP/Desktop/Test/blabla.txt");
//sw.WriteLine("qwertyujhdgdfs");
//sw.Close();


//StreamReader sw1 = new StreamReader(@"C:/Users/HP/Desktop/Test/blabla.txt");
//string result = sw1.ReadToEnd();
//Console.WriteLine(result);

//using (StreamWriter sw = new StreamWriter(@"C:/Users/HP/Desktop/Test/blabla.txt"))
//{
//    sw.WriteLine("f3rqfwfqwd");
//}

//using (StreamReader sw1 = new StreamReader(@"C:/Users/HP/Desktop/Test/blabla.txt"))
//{
//    string result = sw1.ReadToEnd();
//    Console.WriteLine(result);
//}
#endregion


#region StremReader,StreamWriter ,Json File
using Newtonsoft.Json;
using Practice.Models;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

Product p1 = new Product { Id = 1, Name = "Iphone11", Price = 999 };
Product p2 = new Product { Id = 2, Name = "Iphone12", Price = 1999 };
Product p3 = new Product { Id = 3, Name = "Iphone13", Price = 2999 };

ProductItem ProductItem = new ProductItem { Id = 1, TotalPrice = p1.Price, Product = p1 };
ProductItem ProductItem1 = new ProductItem { Id = 2, TotalPrice = p2.Price, Product = p2 };
ProductItem ProductItem2 = new ProductItem { Id = 3, TotalPrice = p3.Price, Product = p3 };



List<ProductItem> list = new List<ProductItem>();

list.Add(ProductItem);
list.Add(ProductItem1);
list.Add(ProductItem2);

//ProductItems ProductItems = new ProductItems { Id = 1, ProductItem = list };
//string result = JsonConvert.SerializeObject(ProductItems);
//Console.WriteLine(result);


//using (StreamWriter sw = new StreamWriter(@"C:\Users\HP\Desktop\Practice\Practice\Json\file.json", true))
//{
//    sw.WriteLine(result);
//}

using (StreamReader sw1 = new StreamReader(@"C:\Users\HP\Desktop\Practice\Practice\Json\file.json", true))
{
    string result = sw1.ReadToEnd();
    Console.WriteLine(result);
}





#endregion