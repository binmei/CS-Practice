//. . . . . . . . . . . . . . . . . . . .________
//. . . . . .. . . . . . . . . . .,.-‘”. . . . . . .``~.,
//. . . . . . . .. . . . ..,.-”. . . . . . . . . . . . . .“-.,
//. . . . .. . . . . ...,/. . . . . . . . . . . . . . . . . . ”:,
//. . . . . . . .. .,?. . . . . . . . . . . . . . . . . . . . . .\,
//. . . . . . . .  /. . . . . . . . . . . . . . . . . . . . . . . ,}
//. . . . . . .  ./. . . . . . . . . . . . . . . . . . . . . ,:`^`.}
//. . . . . . . ./. . . . . . . . . . . . . . . . . . . . ,:”. . ./
//. . . . . . . ?. . . __. . . . . . . . . . . . . . . :`. . .  ./
//. . . . . . ./__. (. . .“~-,_. . . . . . . . . ,:`. . . . .  ./
//. . . . . ./ (_. .”~,_. . . ..“~,_. . . . . .,:`. . . . . . _/
//. . . .. . {._$;. . .”=,_. . . . “-,_. ,.-~-,}, .~”;   /. . .}
//. . .. . . ((. .  *~_. . . .”=-._. . .“;,,./`. . /” ./. .. ../
//. . . .. . .\`~,. . .“~.,. . . . . . ..`. . .}. . . . . . ../
//. . . . . . (. .`=-,,. . . .`. . . . . . . . ..(. . . ;_,,-”
//. . . . . ../.`~,. . ..`-.. . . . . . . . . . . ..\. . /\
//. . . . . . \`~.*-,. . . . . . . . . . . . . . ..|,./.....\,__
//,,_. . . . . }.>-._\. . . . . . . . . . . . . . . .|. . . . . . ..`=~-,
//. .. `=~-,_\_. . . `\,. . . . . . . . . . . . . . .\
//. . . . . . . . . .`=~-,,.\,. . . . . . . . . . .  . .\
//. . . . . . . . . . . . . . . . `:,, . . . . . . . . . . `\. . . . . . ..__
//. . . . . . . . . . . . . . . . . . .`=-,. . . . . . . . . .,%`>--==``
//. . . . . . . . . . . . . . . . . . . . _\. . . . . ._,-%. . . ..`\ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianLanderExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter plateau length: ");
            var length = Console.ReadKey();
            Console.WriteLine("\nEnter plateau width: ");
            var width = Console.ReadKey();
            int l = 0, w = 0;
            try
            {
                l = Convert.ToInt32(length);
                w = Convert.ToInt32(width);
            } catch (Exception e)
            {
                
            }

            Rover r1 = new Rover("r1", 1, 2, 'N', l, w);
            Rover r2 = new Rover("r2", 3, 3, 'E', l, w);
            r1.interpretInstruction("LMLMLMLMM".ToCharArray());
            Console.WriteLine("Final Position: {0} {1}, Final Heading: {2}\n", r1.posX, r1.posY, r1.heading);
            Console.ReadKey();

            r2.interpretInstruction("MMRMMRMRRM".ToCharArray());
            Console.WriteLine("Final Position: {0} {1}, Final Heading: {2}\n", r2.posX, r2.posY, r2.heading);
            Console.ReadKey();
        }
    }
}

