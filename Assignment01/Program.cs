using System;
/*
* Student ID : 1690701758
* Name       : Ornicha pomnoi
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Gametitle = "NOCTRORIA";

            var PlayerName = "Zudan";
            var PlayerRank = 'S';
            int PlayerLevel = 53;
            float CritChance = 0.85f;
            double CriticalDamage = 50.5;
            bool isPlayable = true;

            Console.WriteLine($" .+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+. \r\n(                                                                                                                         )\r\n )          .-.                   .-._   .-._..-.;;;;;;'.-.                     .-.             .;;;;.        /\\         ( \r\n(             ;  :    .;;.    .-.: (_)`-'    (_)  .;   (_) )-.       .;;.    .-(_) )-.         ' .;'  `   _  / |          )\r\n )          .;:  :   ;;  `;`-'  ::                :      .:   \\     ;;  `;`-'    .:   \\         .;'      (  /  |  .      ( \r\n(          .;' \\ :  ;;    :.    ::   _          .:'     .::.   )   ;;    :.     .::.   )       .;'        `/.__|_.'       )\r\n )     .:'.;    \\: ;;     ;'    `: .; )       .-:._   .-:. `:-'   ;;     ;'   .-:. `:-'       .;'     .:' /    |         ( \r\n(     (__.'      `.`;.__.'        `--'       (_/  `- (_/     `:._.`;.__.'    (_/     `:._..;;;;;;;;;'(__.'     `-'        )\r\n )                                                                                                                       ( \r\n(                                                                                                                         )\r\n \"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\"+.+\" ");
            Console.WriteLine($"======================{Gametitle}======================");
            Console.WriteLine($"Player: {PlayerName}");
            Console.WriteLine($"Player Rank: {PlayerRank}");
            Console.WriteLine($"Player Level: {PlayerLevel}");
            Console.WriteLine($"Critical Chance: {CritChance}");
            Console.WriteLine($"Critical Damage: {CriticalDamage}");
            Console.WriteLine($"Is Playable: {isPlayable}");
            Console.WriteLine($"=====================================================");

            double PlayerLevelAsDouble = PlayerLevel;
            Console.WriteLine($"level as double(implicit): {PlayerLevelAsDouble}");

            int CritDamageTruncated = (int)CriticalDamage;
            int CritDamageRounded = Convert.ToInt32(CriticalDamage);

            Console.WriteLine($"Critical Damage cast (Truncated): {CritDamageTruncated}");
            Console.WriteLine($"Critical Damage Convert (Rounded): {CritDamageRounded}");
            Console.WriteLine($"=====================================================");
            Console.WriteLine($"     o      +                   .    o            .       +          .       .  \r\n.    '         +*      *              '    *        .-'\"\"'-.   +             '  \r\n    .          . *  '  .  + *     '.  '    .      .' () .   '.     *      .   .'\r\n                    +  .         .  . .++        / .      o   \\  .      .       \r\n                 ''+    * * '.              .   ; o    _   ()  ;    '       * . \r\n   o     . '   .     .:''         .       .  +  ;     (_)      ;*   +  .        \r\n                 _.::'   .     .+      .         \\ .        o /              |  \r\n         *      (_.'                           +  '.  O  .  .'    o +    ' --o--\r\n+    ++                  '       o'     .           '-....-'                 |  \r\n     |          .      '    + .          . |  .    .               .  *     +   \r\n o  -o- '           +  +     ' .  '      --o--     .  o   *              .  .  o\r\n     |     .. '     .'              +    . |          *      o           ' *    \r\n      *          '    +  . . +    _|_.    + . ' .             \\  o'        +    \r\n   *     o    .. . '          .    |              . '          \\     .          \r\n    _|_                     '   +       .                    +  *.'             \r\n     |                         '  +    .      .     .        +    +             \r\n'             *     .     '  +           '           ' '      ..          o     \r\n . *            '                ++           '  '.    | .        '+.      +    \r\n                  +     '   ' o            .   o *   --o--     '  o  .     .    \r\n         . .         **         .'o             *      |   + . .  . .  o   +    ");

        }
    }
}