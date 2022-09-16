class get{
    public static string getmenu()
    {
         Console.WriteLine("Choose Menu");
         Console.WriteLine("a).Infomation about Shop ");
         Console.WriteLine("b).Owner Shop");
         Console.WriteLine("c).Employee information");
         Console.WriteLine("d).The shop's income and expenses information menu.");
         Console.Write("Input Menu : ");
        return Console.ReadLine();
    }
   public static void PrintMenuA()
   {    Console.WriteLine("*********** Infomation about Shop **************");
        Console.WriteLine("Registered Money Shop : 1,000,000 Bath");
        Console.WriteLine("Branch : KFC Bang Khun Thian Branch, Chai Talay");
        Console.WriteLine("Address : Chai Talay Road, Bang Khun Thian Soi 27");
        Console.WriteLine("*****************************************************");
   }
    public static void PrintMenuB()
   {     Console.WriteLine("************** Owner Shop *******************");
         Console.WriteLine("Surname Owner 1 : Mr.Thawee");
         Console.WriteLine("Lastname Owner 1 : Chaideedee");
         Console.WriteLine("Id Card Owner 1 : 153-698-4561237");
         Console.WriteLine("*****************************************************");
         Console.WriteLine("Surname Owner 2 : Mr. Yuttadee");
         Console.WriteLine("Lastname Owner 2 : Tangchairian");
         Console.WriteLine("Id Card Owner 2 : 742-112-5687412");
         Console.WriteLine("*****************************************************");
         Console.WriteLine("Surname Owner 3 : Mr.James");
         Console.WriteLine("Lastname Owner 3 : Rakrongrian");
         Console.WriteLine("Id Card Owner 3 : 541-772-3215689");
         Console.WriteLine("*****************************************************");
   }
        public static void PrintMenuC(){
            
                Console.WriteLine("************** Employee Infomation *******************");
                Console.WriteLine("Type : Shop assistant");
                Console.WriteLine("Surname Employee1 : Mr.Chaidee ");
                Console.WriteLine("Lastname Employee1 : Jaideedee");
                Console.WriteLine("Age : 20");
                Console.WriteLine("Salary:15,000");
                Console.WriteLine("*****************************************************");
                 Console.WriteLine("Type : Shop assistant");
                Console.WriteLine("Surname Employee1 : Mr.Nondee ");
                Console.WriteLine("Lastname Employee1 : Jaidee");
                Console.WriteLine("Age : 18");
                Console.WriteLine("Salary:15,000");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Type : Shop assistant");
                Console.WriteLine("Surname Employee1 : Mr.Apaidee");
                Console.WriteLine("Lastname Employee1 : Raindee");
                Console.WriteLine("Age : 22");
                Console.WriteLine("Salary:15,000");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("Type : Delivery");
                Console.WriteLine("Surname Employee1 : Mr.Thumdee");
                Console.WriteLine("Lastname Employee1 : Ngandee");
                Console.WriteLine("Age : 25");
                Console.WriteLine("Salary:12,500");
                Console.WriteLine("*****************************************************");
                 Console.WriteLine("Type : Delivery");
                Console.WriteLine("Surname Employee1 : Mr.Nondee");
                Console.WriteLine("Lastname Employee1 : reabdee");
                Console.WriteLine("Age : 23");
                Console.WriteLine("Salary:12,500");
                Console.WriteLine("*****************************************************");
             

        
        }
   
}