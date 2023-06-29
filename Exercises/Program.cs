using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Callex1();
            // Callex2();
            //  Callex3();
            //Callex3new1();
            //Callex4();
            //Callex4();
            // Callex5();
            // Callex6();
            //Callex7();
            //Callex8();
            // Callex9();
            // Callex10();
            //  Callex11();
            // Callex12();
            // Callex13();
            //Callex14();
            // Callex15();
            //Callex16();
            //Callex17();
            //Callex18();
            //Callex19();
            //Callex20();
            // Callex21();
            //Callex22();
            //Callex23();
            //Callex24();
            //Callex25();
            //Callex26();
            // Callex27();
            //Callex28();
            //Callex29();
            Callex30();
        }

        public static void Callex1()
        {
            int[] q1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nquery = from n1 in q1 where n1 % 2 == 0 select n1;
            Console.WriteLine("Exercise1:");
            foreach (int n1 in nquery)
            {
                Console.Write(n1 + ",");

            }
            Console.WriteLine(" ");
        }
        public static void Callex2()
        {
            int[] q2 = new int[10] { -2, 1, 3, 5, -8, -12, -13, 11, 12, 13 };
            var nquery = from n2 in q2 where n2 > 0 && n2 < 12 select n2;
            Console.WriteLine("Exercise2:");
            foreach (int n2 in nquery)
            {
                Console.Write(n2 + ",");
            }
            Console.WriteLine(" ");

        }
        public static void Callex3()
        {
            int[] q3 = new int[5] { 1, -2, 3, 5, 10 };
            var nquery = from n3 in q3 select n3;
            Console.WriteLine("Exercise3:");
            foreach (int n3 in nquery)
            {
                Console.WriteLine("Number=" + n3 + " Square=" + n3 * n3 + ",");
            }
            Console.WriteLine(" ");
        }
        public static void Callex3new1()
        {
            int[] q3 = new int[5] { 1, 2, 3, 5, 10 };
            var nquery = from Number in q3 let square = Number * Number where square > 0 select new { Number, square };
            foreach (var a in nquery)
                Console.WriteLine(a);


        }
        public static void Callex4()
        {
            int[] q4 = new int[13] { 1, 1, 1, 3, 3, 4, 5, 5, 5, 6, 6, 6, 6 };
            var nquery = from n4 in q4 group n4 by n4 into y select y;
            foreach (var a in nquery)
            {
                Console.WriteLine("number " + a.Key + " appears " + a.Count() + "times");
            }

        }
        public static void Callex5()
        {
            string name = "apple";
            var nquery = from n5 in name group n5 by n5 into y select y;
            foreach (var a in nquery)
            {
                Console.WriteLine("Character " + a.Key + " " + a.Count() + " times");
            }


        }
        public static void Callex6()
        {
            string[] q6 = new string[] { "Monday", "Tuesday", "Wendesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var nquery = from n6 in q6 select n6;
            foreach (var a in nquery)
            {
                Console.WriteLine(a);
            }

        }
        public static void Callex7()
        {
            int[] q7 = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var nquery = from n7 in q7 group n7 by n7 into y select y;
            foreach (var a in nquery)
            {
                Console.WriteLine(a.Key + " " + a.Sum() + " " + a.Count());
            }

        }
        public static void Callex8()
        {
            string[] q8 = new string[] { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var nquery = from n8 in q8 where n8.StartsWith('A') & n8.EndsWith('M') select n8;
            foreach (var a in nquery)
            {
                Console.WriteLine(a);
            }
        }
        public static void Callex9()
        {
            List<int> q9 = new List<int>();
            q9.Add(55);
            q9.Add(200);
            q9.Add(740);
            q9.Add(76);
            q9.Add(230);
            q9.Add(482);
            q9.Add(95);
            foreach (var a in q9)
            {
                Console.WriteLine(a);
            }
            List<int> Filterlist = q9.FindAll(x => x > 80);
            foreach (var a in Filterlist) { Console.WriteLine(a); }
        }
        public static void Callex10()
        {
            Console.WriteLine("enter your count");
            int num = Convert.ToInt32(Console.ReadLine());
            List<int> q10 = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter your number {0}", i);
                var a = Convert.ToInt32(Console.ReadLine());
                q10.Add(a);
            }
            Console.Write("\nInput the value above you want to display the members of the List : ");
            int m = Convert.ToInt32(Console.ReadLine());
            foreach (var a in q10)
            {
                Console.WriteLine("Member {0}", a);
            }
            Console.WriteLine("\nThe numbers greater than {0} are : ", m);
            List<int> Filtered = q10.FindAll(x => x > m);
            foreach (var a in Filtered)
            {
                Console.WriteLine(a);
            }

        }
        public static void Callex11()
        {
            List<int> a = new List<int>() { 5, 7, 13, 24, 6, 9, 8, 7 };
            Console.Write("How many records you want to display ? : ");
            int n = Convert.ToInt32(Console.ReadLine());

            a.Sort();
            a.Reverse();

            Console.Write("The top {0} records from the list are : \n", n);
            foreach (int topn in a.Take(n))
            {
                Console.WriteLine(topn);
            }
        }
        public static void Callex12()


        {
            Console.Write("\nLINQ : Find the uppercase words in a string : ");
            Console.Write("\n----------------------------------------------\n");

            string strNew;

            Console.Write("Input the string : ");
            strNew = Console.ReadLine();

            var ucWord = WordFilt(strNew);
            Console.Write("\nThe UPPER CASE words are :\n ");
            foreach (string strRet in ucWord)
            {
                Console.WriteLine(strRet);
            }
            Console.ReadLine();
        }

        static IEnumerable<string> WordFilt(string mystr)
        {
            // var upWord = mystr.Split(' ').Where(x => String.Equals(x, x.ToUpper(),StringComparison.Ordinal));
            var newword = mystr.Split(' ').Where(x => string.Equals(x, x.ToUpper(), StringComparison.OrdinalIgnoreCase));

            return newword;

        }
        public static void Callex13()
        {
            Console.WriteLine("Input number of strings to store in the array");
            int num = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter [{0}] strings", i);
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Here is the string below created with elements of the above array");
            //  string newstring = String.Join(", ", arr.Select(s => s.ToString()).ToArray());

            string newst = string.Join(", ", arr.Select(s => s.ToString()).ToArray());
            Console.WriteLine(newst);
        }
        public static void Callex14()
        {
            Students e = new Students();
            var stulist = e.GtstuRec();
            Console.WriteLine("Enter which grade you want");
            int Selectedgrade = Convert.ToInt32(Console.ReadLine());
            var stugrade = (from stumaxgrade in stulist group stumaxgrade by stumaxgrade.GrPoint into g orderby g.Key descending select new { sturecord = g.ToList() }).ToList();

            stugrade[Selectedgrade - 1].sturecord
                           .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.StuId, i.StuName, i.GrPoint));

        }

        public class Students
        {
            public string StuName { get; set; }
            public int StuId { get; set; }
            public int GrPoint { get; set; }

            public List<Students> GtstuRec()
            {
                List<Students> studentList = new List<Students>();
                studentList.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
                studentList.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
                studentList.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
                studentList.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
                studentList.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
                studentList.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
                studentList.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
                studentList.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
                studentList.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
                studentList.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
                return studentList;
            }
        }
        public static void Callex15()
        {
            string[] arr = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "naaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            var arrst = arr.Select(x => Path.GetExtension(x).TrimStart('.').ToLower()).GroupBy(y => y, (fExt, extCtr) => new
            {
                Extension = fExt,
                Count = extCtr.Count()
            });

            foreach (var x in arrst) { Console.WriteLine("{0} File(s) with {1} Extension ", x.Count, x.Extension); }

        }
        public static void Callex16()
        {
            //string[] Dirfiles = Directory.GetFiles(@"C:/Users/Rufane - Aliyeva/Desktop/AS.txt");
            string[] gtpath = { @"C:\\Users\\Rufane-Aliyeva\\Desktop\\AS.txt" };
            var avg = gtpath.Select(file => Path.GetFileName(file).Length).Average();

            avg = Math.Round(avg / 10, 1);
            Console.WriteLine("The Average file size is {0} MB", avg);


        }
        public static void Callex17()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            //foreach (var l in list)
            //{
            //    Console.WriteLine(l);
            //}
            // list.Remove('a');
            //Console.WriteLine("removed");
            //foreach (var f in list)
            //{
            //    Console.WriteLine(f);
            //}
            var yh = from l in list select l;
            string newstr = yh.FirstOrDefault(en => en == "a");

            list.Remove(newstr);
            var yh1 = from l in list select l;
            foreach (var g in yh1)
            {
                Console.WriteLine(g);
            }

        }
        public static void Callex18()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Remove(list.FirstOrDefault(en => en == "a"));
            foreach (var g in list) { Console.WriteLine(g); }
        }
        public static void Callex19()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.RemoveAll(en => en == "a");
            foreach (var f in list)
            {
                Console.WriteLine(f);
            }
        }
        public static void Callex20()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            Console.WriteLine("which index do u want to remove");
            int a = Convert.ToInt32(Console.ReadLine());
            list.RemoveAt(a);
            foreach (var f in list)
            {
                Console.WriteLine(f);
            }
        }
        public static void Callex21()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            Console.WriteLine("enter first index");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second index");
            int b = Convert.ToInt32(Console.ReadLine());
            list.RemoveRange(a, b);
            foreach (var f in list) { Console.WriteLine(f); }

        }
        public static void Callex22()
        {
            //string[] arr = { "this", "is", "a", "string" };
            //var farr=from a in arr where a.Length>4 select a.ToString();
            //foreach (var f in farr) { Console.WriteLine(f); }
            string[] arr1;
            int n, i, ctr;

            Console.Write("\nLINQ : Find the strings for a specific minimum length : ");
            Console.Write("\n------------------------------------------------------\n");

            Console.Write("Input number of strings to  store in the array :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("\nInput {0} strings for the array  :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] : ", i);
                arr1[i] = Console.ReadLine();
            }

            Console.Write("\nInput the minimum length of the item you want to find : ");
            ctr = Convert.ToInt32(Console.ReadLine());

            IEnumerable<string> objNew = from m in arr1
                                         where m.Length >= ctr
                                         orderby m
                                         select m;
            Console.Write("\nThe items of minimum {0} characters are : \n", ctr);
            foreach (string z in objNew)
                Console.WriteLine("Item: {0}", z);

            Console.ReadLine();

        }
        public static void Callex23()
        {
            char[] arr = { 'X', 'Y', 'Z', };
            int[] arr1 = { 1, 2, 3, };
            var newarr = from m in arr from n in arr1 select new { m, n };
            foreach (var c in newarr)
            {
                Console.WriteLine(c);
            }
        }
        public static void Callex24()
        {
            char[] arr = { 'X', 'Y' };
            int[] arr1 = { 1, 2, 3, };
            string[] arr2 = { "Green", "Orange" };
            var newarr = from m in arr1 from n in arr1 from z in arr2 select new { m, n, z };
            foreach (var c in newarr)
            {
                Console.WriteLine(c);
            }
        }
        public static void Callex25()
        {

            List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            Console.Write("\nLINQ : Generate an Inner Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchlist)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");

            var innerJoin = from e in itemlist
                            join d in purchlist on e.ItemId equals d.ItemId
                            select new
                            {
                                itid = e.ItemId,
                                itdes = e.ItemDes,
                                prqty = d.PurQty
                            };
            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in innerJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }
            Console.ReadLine();
        }
        public static void Callex26()
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };
            Console.Write("\nLINQ : Generate a Left Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchlist)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");
            var newleftjoined = from m in itemlist
                                join n in purchlist on m.ItemId equals n.ItemId into a
                                from b in a.DefaultIfEmpty(new Purchase())
                                select new
                                {
                                    itid = m.ItemId,
                                    itdes = m.ItemDes,
                                    prqty = b.PurQty
                                };
            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in newleftjoined)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }
            Console.ReadLine();

        }
        public static void Callex27()
        {
            List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

            List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 5,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

            Console.Write("\nLINQ : Generate a Right Join between two data sets : ");
            Console.Write("\n--------------------------------------------------\n");
            Console.Write("Here is the Item_mast List : ");
            Console.Write("\n-------------------------\n");

            foreach (var item in itemlist)
            {
                Console.WriteLine(
                "Item Id: {0}, Description: {1}",
                item.ItemId,
                item.ItemDes);
            }

            Console.Write("\nHere is the Purchase List : ");
            Console.Write("\n--------------------------\n");

            foreach (var item in purchlist)
            {
                Console.WriteLine(
                "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
                item.InvNo,
                item.ItemId,
                item.PurQty);
            }

            Console.Write("\nHere is the list after joining  : \n\n");


            var rightOuterJoin = from p in purchlist
                                 join i in itemlist
                                 on p.ItemId equals i.ItemId
                                 into a
                                 from b in a.DefaultIfEmpty()
                                 select new
                                 {
                                     itid = b.ItemId,
                                     itdes = b.ItemDes,
                                     prqty = p.PurQty
                                 };

            Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
            Console.WriteLine("-------------------------------------------------------");
            foreach (var data in rightOuterJoin)
            {
                Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
            }
            Console.ReadLine();
        }
        public static void Callex28()
        {
            List<string> list = new List<string>();
            list.Add("ROME");
            list.Add("PARIS");
            list.Add("LONDON");
            list.Add("ZURICH");
            list.Add("NAIROBI");
            list.Add("ABU DHABI");
            list.Add("AMSTERDAM");
            list.Add("NEW DELHI");
            list.Add("CALIFORNIA");
            var newlist=list.OrderBy(x=>x.Length).ThenBy(x => x);
            foreach (var data in newlist) { Console.WriteLine(data); }

        }
        public static void Callex29()
        {
            string[] cities =
          {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };

            Console.Write("\nLINQ : Split a collection of strings into some groups  : ");
            Console.Write("\n-------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI', \n");
            Console.Write("                   'AMSTERDAM','ABU DHABI','PARIS','NEW YORK' \n");
            Console.Write("\nHere is the group of cities : \n\n");

            var citySplit = from i in Enumerable.Range(0, cities.Length)
                            group cities[i] by i / 3;

            foreach (var city in citySplit)
                cityView(string.Join(";  ", city.ToArray()));


            Console.ReadLine();
        }
        static void cityView(string cityMetro)
        {
            Console.WriteLine(cityMetro);
            Console.WriteLine("-- here is a group of cities --\n");
        }

        public static void Callex30() 
        {
            Console.Write("\nLINQ : Arrange distinct elements in the list in ascending order : ");
            Console.Write("\n----------------------------------------------------------------\n");

            var itemlist = (from c in Item_Mast.GetItemMast()
                            select c.ItemDes)
                       .Distinct()
                       .OrderBy(x => x);

            foreach (var item in itemlist)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
    class Item_Mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }

        public static List<Item_Mast> GetItemMast()
        {
            List<Item_Mast> itemlist = new List<Item_Mast>();
            itemlist.Add(new Item_Mast() { ItemId = 1, ItemDes = "Biscuit  " });
            itemlist.Add(new Item_Mast() { ItemId = 2, ItemDes = "Honey    " });
            itemlist.Add(new Item_Mast() { ItemId = 3, ItemDes = "Butter   " });
            itemlist.Add(new Item_Mast() { ItemId = 4, ItemDes = "Brade    " });
            itemlist.Add(new Item_Mast() { ItemId = 5, ItemDes = "Honey    " });
            itemlist.Add(new Item_Mast() { ItemId = 6, ItemDes = "Biscuit  " });
            return itemlist;
        }


    }

}
    
    public class Item_mast
    {
        public int ItemId { get; set; }
        public string ItemDes { get; set; }
    }

    public class Purchase
    {
        public int InvNo { get; set; }
        public int ItemId { get; set; }
        public int PurQty { get; set; }
    }














