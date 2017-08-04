using System;

namespace Wizard_Ninja_Samurai{
    public class Human
    {   
        public string name;

        public int health { get; set; } 
        public int strenght { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human (string person)
        {

            name = person;
            strenght = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
       public Human(string person, int str, int intel, int dex, int hp)
       {
           name = person;
           strenght = str;
           intelligence = intel;
           dexterity = dex;
           health = hp;
        
       }
       public void attack(object obj)
       {
           Human enemy = obj as Human;
           if(enemy == null)
           {
               Console.WriteLine("Failllllllled Attack");
            
           }
           else 
           {
               enemy.health -= strenght *5;

           }

        }
    }
 }
