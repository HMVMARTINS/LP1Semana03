using System;

namespace HeroPerks
{
    [Flags]
    public enum PlayerPerks
    {
        None = 0,
        WaterBreathing = 1,
        Stealth = 2,
        Autoheal = 4,
        DoubleJump = 8
    }

    class Program
    {
        static void Main(string[]args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: dotnet run -- project HeroPerks <perks>");
                return;
            }

            PlayerPerks playerPerks = PlayerPerks.None;

            foreach (char c in args[0])
            {
                switch (c)
                {
                    case 'W':
                        playerPerks ^= PlayerPerks.WaterBreathing;
                        break;
                    case 'a':
                        playerPerks ^= PlayerPerks.Stealth;
                        break;
                    case 's':
                        playerPerks ^= PlayerPerks.Autoheal;
                        break;
                    case 'd':
                        playerPerks ^= PlayerPerks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown perk!");
                        return;
                }
            }

            if (playerPerks == PlayerPerks.None)    
            {
                Console.WriteLine("No perks at all")
                return;        
            }

            Console.WriteLine("Player perks: " + playerPerks);

            if ((playerPerks & PlayerPerks) == PlayerPerks.Stealth && (playerPerks & PlayerPerks.DoubleJump) == PlayerPerks.DoubleJump)
            {
                Console.WriteLine("Silent jumper!");
            }


            if ((playerPerks & PlayerPerks.Autoheal) != PlayerPerks.Autoheal)
            {
                Console.WriteLine("Not gonna make it!");
            }
        }
    }
}