using System;

namespace Wizard_Ninja_Samurai 
{   
    public class Samurai : Human {

        public static int count = 0;
        public Samurai(string n) : base(n) {
            count++;
            health = 200;
        }

        public void death_blow(object target) {
            Human enemy = target as Human;
            if(enemy != null) {
                if(enemy.health < 50) {
                    enemy.health = 0;
                }
            }
        }

        public void meditate() {
            health = 200;
        }

        public static void how_many() {
            Console.WriteLine(count);
        }
    }
}
