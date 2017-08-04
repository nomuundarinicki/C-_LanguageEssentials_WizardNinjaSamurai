using System;

namespace Wizard_Ninja_Samurai
{
    public class Wizard : Human 
    {
        public Wizard(string n) :base(n)
        {
            health = 50;
            intelligence = 25;

        }
        public void heal()
        {
            health += 10 * intelligence;
        }
        public void fireball(object target)
        {
            Human enemy = target as Human;
            if(enemy != null)
            {
                Random rand = new Random();
                enemy.health -= rand.Next(20, 51);

            }

        }

    }

}