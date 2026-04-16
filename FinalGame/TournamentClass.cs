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
            if(rank.Ranking == 1)
            {

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
                if (type == Enemy.Goblin)
                {
                    return new Goblin();
                }
                else if (type == Enemy.Orc)
                {
                    return new Orc();
                }
                else if (type == Enemy.Skeleton)
                {
                    return new Skeleton();
                }
                throw new ArgumentException("Not a valid type");
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
        public enum Enemy
        {
            Slime,
            Goblin,
            Skeleton,
            Orc,
            
        }
    
}
