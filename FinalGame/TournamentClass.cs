using System;
using System.Collections.Generic;
using System.Text;
using MyClasses;
namespace MyClasses
{
    internal class TournamentClass
    {
        public void TournamentRound(Character rank)
        {
            
            Console.WriteLine($"Round {rank.Ranking}");
            if (rank.Ranking == 1)
            {
                EnemyBaseClass firstOpponent = EnemyFactory.CreateEnemy(Enemy.Slime);
                Console.WriteLine("Type: " + firstOpponent.Name);
                Console.WriteLine("Health: " + firstOpponent.Health);
                Console.WriteLine("Damage: " + firstOpponent.Damage);
            }
            else if (rank.Ranking == 2)
            {
                EnemyBaseClass secondOpponent = EnemyFactory.CreateEnemy(Enemy.Goblin);
                Console.WriteLine("Type: " + secondOpponent.Name);
                Console.WriteLine("Health: " + secondOpponent.Health);
                Console.WriteLine("Damage: " + secondOpponent.Damage);
            }
            else if (rank.Ranking == 3)
            {
                EnemyBaseClass thirdOpponent = EnemyFactory.CreateEnemy(Enemy.Skeleton);
                Console.WriteLine("Type: " + thirdOpponent.Name);
                Console.WriteLine("Health: " + thirdOpponent.Health);
                Console.WriteLine("Damage: " + thirdOpponent.Damage);
            }
            else if (rank.Ranking == 4)
            {
                EnemyBaseClass fourthOpponent = EnemyFactory.CreateEnemy(Enemy.Orc);
                Console.WriteLine("Type: " + fourthOpponent.Name);
                Console.WriteLine("Health: " + fourthOpponent.Health);
                Console.WriteLine("Damage: " + fourthOpponent.Damage);
            }
            else if (rank.Ranking == 5)
            {
                EnemyBaseClass fifthOpponent = EnemyFactory.CreateEnemy(Enemy.Ogre);
                Console.WriteLine("Type: " + fifthOpponent.Name);
                Console.WriteLine("Health: " + fifthOpponent.Health);
                Console.WriteLine("Damage: " + fifthOpponent.Damage);
            }
            else if (rank.Ranking == 6)
            {
                EnemyBaseClass sixthOpponent = EnemyFactory.CreateEnemy(Enemy.Roc);
                Console.WriteLine("Type: " + sixthOpponent.Name);
                Console.WriteLine("Health: " + sixthOpponent.Health);
                Console.WriteLine("Damage: " + sixthOpponent.Damage);
            }
            else if (rank.Ranking == 7)
            {
                EnemyBaseClass seventhOpponent = EnemyFactory.CreateEnemy(Enemy.Wyvern);
                Console.WriteLine("Type: " + seventhOpponent.Name);
                Console.WriteLine("Health: " + seventhOpponent.Health);
                Console.WriteLine("Damage: " + seventhOpponent.Damage);
            }
            else if (rank.Ranking == 8)
            {
                EnemyBaseClass eightethOpponent = EnemyFactory.CreateEnemy(Enemy.Champion);
                Console.WriteLine("Type: " + eightethOpponent.Name);
                Console.WriteLine("Health: " + eightethOpponent.Health);
                Console.WriteLine("Damage: " + eightethOpponent.Damage);
            }
            else
            {
                Console.WriteLine("Tournament Complete! You are the champion!");
            }
        }
    }
    public abstract class EnemyBaseClass
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public Enemy Species { get; set; }
    }
    public class EnemyFactory
    {
        public static EnemyBaseClass CreateEnemy(Enemy type)
        {
            if (type == Enemy.Slime)
            {
                return new Slime();
            }
            else if (type == Enemy.Goblin)
            {
                return new Goblin();
            }
            else if (type == Enemy.Skeleton)
            {
                return new Skeleton();
            }
            else if (type == Enemy.Orc)
            {
                return new Orc();
            }
            else if (type == Enemy.Ogre)
            {
                return new Ogre();
            }
            else if (type == Enemy.Roc)
            {
                return new Roc();
            }
            else if (type == Enemy.Wyvern)
            {
                return new Wyvern();
            }
            else if (type == Enemy.Champion)
            {
                return new Champion();
            }
            throw new ArgumentException("Not a valid type");
        }
    }
    public class Slime : EnemyBaseClass
    {
        public Slime()
        {
            Name = "Slime";
            Health = 10;
            Damage = 2;
            Species = Enemy.Slime;
        }

    }
    public class Goblin : EnemyBaseClass
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 25;
            Damage = 2;
            Species = Enemy.Goblin;
        }

    }
    public class Skeleton : EnemyBaseClass
    {
        public Skeleton()
        {
            Name = "Skeleton";
            Health = 30;
            Damage = 3;
            Species = Enemy.Skeleton;
        }

    }
    public class Orc : EnemyBaseClass
    {
        public Orc()
        {
            Name = "Orc";
            Health = 50;
            Damage = 4;
            Species = Enemy.Orc;
        }

    }
    public class Ogre : EnemyBaseClass
    {
        public Ogre()
        {
            Name = "Ogre";
            Health = 75;
            Damage = 5;
            Species = Enemy.Ogre;
        }

    }
    public class Roc : EnemyBaseClass
    {
        public Roc()
        {
            Name = "Roc";
            Health = 125;
            Damage = 2;
            Species = Enemy.Roc;
        }

    }
    public class Wyvern : EnemyBaseClass
    {
        public Wyvern()
        {
            Name = "Wyvern";
            Health = 125;
            Damage = 5;
            Species = Enemy.Wyvern;
        }

    }
    public class Champion : EnemyBaseClass
    {
        public Champion()
        {
            Name = "Wyvern";
            Health = 125;
            Damage = 5;
            Species = Enemy.Champion;
        }

    }
    public enum Enemy
    {
        Slime,
        Goblin,
        Skeleton,
        Orc,
        Ogre,
        Roc,
        Wyvern,
        Champion,
    }

}
