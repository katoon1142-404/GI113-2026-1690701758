namespace Assignment02
{
/*
* Student ID : 1690701758
* Name       : Ornicha pomnoi
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"/==============================================================================================\\\r\n||                                                                                            ||\r\n||    .s5SSSs.  s.  .s5SSSs.  .s5SSSs.  .s    s.  .s5SSSs.  .s5SSSs.  .s    s.  .s5SSSs.      ||\r\n||          SS. SS.       SS.       SS.       SS.       SS.       SS.       SS.       SS.     ||\r\n||    sS    `:; S%S sS    S%S sS    `:; sSs.  S%S sS    `:; sS    S%S sSs.  S%S sS    `:;     ||\r\n||    SS        S%S SS    S%S SS        SS`S. S%S SS        SS    S%S SS`S. S%S SS            ||\r\n||    `:;;;;.   S%S SS .sS;:' SSSs.     SS `S.S%S `:;;;;.   SS    S%S SS `S.S%S SS            ||\r\n||          ;;. S%S SS    ;,  SS        SS  `sS%S       ;;. SS    S%S SS  `sS%S SS            ||\r\n||          `:; `:; SS    `:; SS        SS    `:;       `:; SS    `:; SS    `:; SS   ``:;     ||\r\n||    .,;   ;,. ;,. SS    ;,. SS    ;,. SS    ;,. .,;   ;,. SS    ;,. SS    ;,. SS    ;,.     ||\r\n||    `:;;;;;:' ;:' `:    ;:' `:;;;;;:' :;    ;:' `:;;;;;:' `:;;;;;:' :;    ;:' `:;;;;;:'     ||\r\n||                                                                                            ||\r\n\\==============================================================================================/");
            Console.WriteLine("==========>> SIRENSONG <<==========");
            Console.WriteLine("===THE BLACK SAPPHIC OCEAN FORGE===");
            Console.WriteLine("===================================");
            Console.WriteLine($"     '..''' | +'_|_+* | *'.+ | ++  .:' '+\\  *'.o'++. +..+o o.o.\\  ~''* |  |  | '\r\n+'*'+.+\\  .-+-'' | .o-+-  /'-+-_.::' '_|_ \\ ''+~~+~~'+ | . | +. \\ *' '-+--+--+-'\r\n' ' | ' \\ + |  | :.   |  / | | _.'  |  | | *+  /+ | .- o --o-.+'  | .  |  |  | .\r\n..+-o-+' *'o..-o- '::._'* -+-'o.*..-+- o-+-++ / --o--' | . | +~~+-+-*. _|_'+'+' \r\n+~~ | .'' ...* | +  '._)o+ |  ... + | .  | o+* +o | o'+o+.' *++'o | ''. | o++.+'");

            int figoore = 2;
            int sentoringot = 3;
            double figoorerate = 0.25;
            double sentoringotrate = 0.15;

            Console.WriteLine($"figoore{figoorerate}/sentoringot{sentoringotrate}");
            Console.WriteLine("'S' for Smelt");
            Console.WriteLine("'B' for Breakdown");
            Console.Write("choose menu S-B: ");
            bool userInput = char.TryParse(Console.ReadLine(), out char Action);

            if (!userInput || Action < 'S' || Action > 'B')
            {
            }

            if (Action == 'S' && figoore <= sentoringot)
            {
                Console.Write("How much would you like: ");
                bool figooreInput = double.TryParse(Console.ReadLine(), out double figooreamount);
                double sentoringotamount = figooreamount * 0.25 / 1;
                if (figooreInput && figooreamount >= 0)
                {
                    Console.WriteLine($"{figooreamount} figoore is equal to {sentoringotamount} sentoringot.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer for figoore.");
                }
            }
            else if (Action == 'B' && sentoringot >= figoore)
            {
                Console.Write("How much would you like: ");
                bool sentoringotInput = double.TryParse(Console.ReadLine(), out double sentoringotamount);
                double figooreamount = sentoringotamount * 0.15 / 1;
                if (sentoringotInput && sentoringotamount >= 0)
                {
                    Console.WriteLine($"{sentoringotamount} sentoringot is equal to {figooreamount} figoore.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative integer for sentoringot.");
                }
            }
            else
            {
                Console.WriteLine("Invalid action. Please choose either 'S' or 'B'.");
            }
        }
    }
}
 
    

