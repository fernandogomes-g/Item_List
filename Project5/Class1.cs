using System;
using System.Collections.Generic;
using System.Linq;

public class program{
    public static void Main(){
        List<string> weapons = new List<string>();
        weapons.Add("1 Knife: 120 gold");
        weapons.Add("2 Laser Pistol: 1000 gold");
        weapons.Add("3 Yah Mom: 5 gold");
        weapons.Add("4 Sword: 300 gold");
        weapons.Add("5 Shield: 500 gold");
        double gold = 0, result = 0;
        int choseWeap = 0;
        string input = "";
        
        Console.WriteLine("How many gold do you have? ");
        gold = double.Parse(Console.ReadLine());

        for (int i = 0; i < weapons.Count; i++)
            Console.WriteLine(weapons[i]);        

        do{
            Console.WriteLine("What weapon do you want to buy?");
            choseWeap = int.Parse(Console.ReadLine());

            if (choseWeap == 1){                
                if (gold >= 120){
                    Console.WriteLine(" Knife acquired");
                    gold = gold - 120;
                    Console.WriteLine(gold + " gold left.");
                }
                else{                    
                    result = gold - 120;
                    result = result * (-1);
                    Console.WriteLine(" Not Gold enough");
                    Console.WriteLine(" You need " + result + " more gold to buy this item");
                }
            }else if(choseWeap == 2){
                if(gold >= 1000){
                    Console.WriteLine(" laser Pistol acquired");
                    gold = gold - 1000;
                    Console.WriteLine(gold+" gold left.");
                }else{
                    result = gold - 120;
                    result = result * (-1);
                    Console.WriteLine(" Not Gold enough");
                    Console.WriteLine(" You need " + result + " more gold to buy this item");
                }
            }else if(choseWeap == 3){
                if(gold >= 5){
                    Console.WriteLine(" Yah Mom acquired.");
                    gold = gold - 5;
                    Console.WriteLine(gold + " gold left.");
                }else{
                    result = gold - 5;
                    result = result * (-1);
                    Console.WriteLine(" Not Gold enough");
                    Console.WriteLine("You need "+ result +" more gold to buy this item.");
                }
            }else if(choseWeap == 4){
                if(gold >= 300){
                    Console.WriteLine(" Sword acquired.");
                    gold = gold - 300;
                    Console.WriteLine(gold + " gold left.");
                }else{
                    result = gold - 300;
                    result = result * (-1);
                    Console.WriteLine(" Not gold enough");
                    Console.WriteLine(" You need "+result+" more gold to buy this item.");
                }
            }else if(choseWeap == 5){
                if(gold >= 500){
                    Console.WriteLine(" Shield acquired.");
                    gold = gold - 500;
                    Console.WriteLine(gold + " gold left.");
                }else{
                    result = gold - 300;
                    result = result * (-1);
                    Console.WriteLine(" Not gold enough.");
                    Console.WriteLine(" you need"+result+" more gold to buy this item.");
                }
            }

            Console.WriteLine("Write 'Exit' to close program or 'Buy' to purshise antoher weapon.");
            input = Console.ReadLine();            

            if (input == "Exit" || input == "exit"){               
                Console.WriteLine("shuting down program.");                
                Environment.Exit(0);//Fechando o programa.
            }
            
        } while (1 > 0);
    }
}