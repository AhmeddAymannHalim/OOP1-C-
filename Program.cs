using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace OOP1
{
    
    
    internal class Program
    {
        
        static void Main(string[] args)
        {

            #region -1
            //enum Days
            //    {
            //        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
            //    } 

            //        foreach (var item in Enum.GetNames(typeof(Days)))
            //        {
            //            Console.WriteLine(item);
            //        } 
            #endregion

            //********************************************************************\\
            #region -2
            //Person[] arrOfObjects = new Person[3];

            //for (int i = 0; i < arrOfObjects.Length; i++)
            //{
            //    Console.WriteLine($"Enter Please The Name");
            //    arrOfObjects[i].name = Console.ReadLine();
            //    Console.WriteLine($"Enter Please The Age");
            //    arrOfObjects[i].age = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arrOfObjects.Length; i++)
            //{
            //    Console.WriteLine("Name");
            //    Console.WriteLine(arrOfObjects[i].name);
            //    Console.WriteLine("Age");
            //    Console.WriteLine(arrOfObjects[i].age);

            //} 
            #endregion

            //********************************************************************\\

            #region -3
            //    enum Seasons
            //{
            //    Spring, Summer, Autumn, Winter
            //}
            //Console.WriteLine("Please Enter Season Name");
            //string Name = Console.ReadLine();

            //Seasons seasonsName;

            //Enum.TryParse<Seasons>(Name, false, out seasonsName);
            //switch (seasonsName)
            //{
            //    case Seasons.Spring:
            //        Console.WriteLine("march to may");
            //        break;
            //    case Seasons.Summer:
            //        Console.WriteLine("june to august");
            //        break;
            //    case Seasons.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //    case Seasons.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //} 
            #endregion

            //********************************************************************\\

            #region -4
            //    [Flags]
            //enum Permissions
            //{
            //    Read = 1, Write = 2, Delete = 4, Exceute = 8
            //}
            //Permissions permissions = (Permissions)2;

            ////To Add Permission
            //permissions = permissions | Permissions.Exceute;

            ////To Remove Permission
            //permissions &= ~(Permissions.Delete);
            //permissions &= ~(Permissions.Write);
            //permissions &= ~(Permissions.Exceute);

            ////To Add Or Remove Permission, if its exist it will be removed , if its not exist it will be added
            //permissions ^= Permissions.Exceute;





            //Console.WriteLine(permissions);

            //if ((permissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read Exist");
            //}
            //else if ((permissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write Exist");
            //}
            //else if ((permissions & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Delete Exist");
            //}
            //else if ((permissions & Permissions.Exceute) == Permissions.Exceute)

            //{
            //    Console.WriteLine("Exceute Exist");
            //}
            //else
            //{
            //    Console.WriteLine("Permission is not exist");
            //} 
            #endregion


            //********************************************************************\\

            #region -5
            //    enum Colors
            //{
            //    Red, Green, Blue
            //}
            //Console.WriteLine("Please Enter a Color !");
            //string color = Console.ReadLine();

            //Colors colors;
            //if (Enum.TryParse<Colors>(color, false, out colors))
            //{
            //    switch (colors)
            //    {
            //        case Colors.Red:
            //        case Colors.Green:
            //        case Colors.Blue:
            //            Console.WriteLine("Its a Primary Color ");
            //            break;
            //        default:
            //            Console.WriteLine("its Not Primary Color");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter Color In (Red,Green,Blue)");
            //} 
            #endregion

            //********************************************************************\\
            #region -6
            //Console.WriteLine("Please Enter Two Points To Calculate distance Between Them\n");
            //Console.WriteLine("****************************\n");
            //Console.WriteLine("Start With x1 and x2 Points");

            //int x1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Now Enter  y1 and y2 Points");
            //int y1 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Now We Calculate Distance Betwwen Them");

            //Point.CaluclateDistance(x1, x2, y1, y2); 
            #endregion



            //********************************************************************\\


            #region -7
            //Person_7[] arrOfObjects = new Person_7[3];
            //bool flag;
            //for (int i = 0; i < arrOfObjects.Length; i++)
            //{
            //    Console.WriteLine($"Enter Please The Name");
            //    arrOfObjects[i].Name = Console.ReadLine();
            //    Console.WriteLine($"Enter Please The Age");
            //    arrOfObjects[i].Age = int.Parse(Console.ReadLine());

            //}
            //Person_7 OldestPerson = arrOfObjects[0];
            //for (int i = 0; i < arrOfObjects.Length; i++)
            //{
            //    if (arrOfObjects[i].Age > OldestPerson.Age)
            //    {
            //        OldestPerson = arrOfObjects[i];
            //    }



            //}
            //Console.WriteLine(OldestPerson); 
            #endregion

        }
        


    }
}
