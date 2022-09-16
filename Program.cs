// See https://aka.ms/new-console-template for more information
 /*static void Menu(){
    Console.Write("Input Menu : ");
    Console.ReadLine();
}*/
class Program{
    
    static void Main(string[]args){
        
       get info = new get();
       string Menu = get.getmenu();
       check(Menu);
      
    }
    static void check(string a){
        if(a == "a")
        {
            get.PrintMenuA();
        }
        else if (a == "b"){
          get.PrintMenuB();
        }
        else if (a == "c"){
            get.PrintMenuC();
        }
    }


}
