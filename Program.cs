using System;
using System.Threading;
namespace HelloWorld
{

    class Program
    {
        public static int ZycieGracza = 3;
        public static int ZyciePotwora = 3;
        public static string nickname = "";
        public static string FILE_DIRECTORY = System.IO.Directory.GetCurrentDirectory() + "\\wyniki.txt";

        public static double Score = 0;

        public static double mutliplier = 0.92;
        
        static void Main()
        {   
            Console.SetWindowSize(120,40);
            animacja();
                
            //Console.WriteLine(FILE_DIRECTORY); DEBUG
            odczytZPliku();
            Console.WriteLine("\n \nWelcome! Bold of you to come into this dark place. Brace yourself for monster-slaying carnage! \nChoose your name:");
            nickname = Console.ReadLine();
            nickname = nickname.ToUpper();
            Console.WriteLine("Welcome, o'mighty "+ nickname);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Try not to die... ");
            Thread.Sleep(1000);
            Console.WriteLine("                 ... at least not too soon..");
            Thread.Sleep(2000);
            Console.Clear();
            
            Score = 0;
            ZycieGracza = 3;
            ZyciePotwora = 3;

            graWlasciwa();
        }

        public static void animacja()
        {   
            Console.Clear();
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("######################## ###########################");
            Console.WriteLine("######################## ###########################");
            Console.WriteLine("######################## ###########################");
            Console.WriteLine("######################## ###########################");
            Console.WriteLine("####################### # ##########################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(150);
            Console.Clear();

            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("######################  ##  ########################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(140);
            Console.Clear();

            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("#####################        #######################");
            Console.WriteLine("######################  ##  ########################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(130);
            Console.Clear();

            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("########################   #########################");
            Console.WriteLine("#######################     ########################");
            Console.WriteLine("########################   #########################");
            Console.WriteLine("########################   #########################");
            Console.WriteLine("########################   #########################");
            Console.WriteLine("########################   #########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("####################          ######################");
            Console.WriteLine("#####################   ##   #######################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(120);
            Console.Clear();

            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("#######################    #########################");
            Console.WriteLine("######################       #######################");
            Console.WriteLine("####################          ######################");
            Console.WriteLine("#####################   ##   #######################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(110);
            Console.Clear();

            Console.WriteLine("####################################################");
            Console.WriteLine("########################  ##########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("#####################        #######################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("######################      ########################");
            Console.WriteLine("#####################         ######################");
            Console.WriteLine("###################            #####################");
            Console.WriteLine("####################   #  #   ######################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(90);
            Console.Clear();

            
            Console.WriteLine("####################    #     ######################");
            Console.WriteLine("####################   ###    ######################");
            Console.WriteLine("####################   ###    ######################");
            Console.WriteLine("####################   ###    ######################");
            Console.WriteLine("###################    ###     #####################");
            Console.WriteLine("###################   #####    #####################");
            Console.WriteLine("##################    #####     ####################");
            Console.WriteLine("################     #######     ###################");
            Console.WriteLine("###############      #######      ##################");
            Console.WriteLine("###############     ##     ##     ##################");
            Console.WriteLine("##############                     #################");
            Console.WriteLine("###############                   ##################");
            Console.WriteLine("################       #  #      ###################");
            Console.WriteLine("####################################################");
            Console.WriteLine("####################################################");
            Thread.Sleep(90);
            Console.Clear();

            Console.WriteLine("############# ######################## #############");
            Console.WriteLine("########## # ########### ############## # ##########");
            Console.WriteLine("######## ## ########### ############ ##### #########");
            Console.WriteLine("##### #### ####### ##### ############# #### # ######");
            Console.WriteLine("#### ####  ##### ######### ############# ### ## ####");
            Console.WriteLine("#### #### # ## ############ ####### ### #### ### ###");
            Console.WriteLine("##### ### ##### #################### ####### ## ####");
            Console.WriteLine("######### ############ #### ######## ###### ########");
            Console.WriteLine("####### # ############ # # ####### #####  ## #######");
            Console.WriteLine("###### ##  ######### ####### #########  #### #######");
            Console.WriteLine("##### #####  ####  ########### ####  ###### ########");
            Console.WriteLine("##### ########   ###############    ################");
            Console.WriteLine("############ ######################## ##############");
            Console.WriteLine("####################################### ############");
            Console.WriteLine("###################################### #############");
            Thread.Sleep(50);
            Console.Clear();
        }
        public static void graWlasciwa()
        {
            string potwor="";
            for (int i = 0; i < 30 ; i++)
            {
                potwor = GeneratorPotworow(potwor);
                walka(potwor);
                Thread.Sleep(100);
                AnimacjaSmierciPotwora(potwor);
                ZyciePotwora = (i + 2) * 3;
            }  
        }
        public static string GeneratorPotworow(string potwor)
        {
            string n = "\n";
            string[] morduchny = {"                       @@@   " + n + "           @@   ____@@@@@@@@____ @@" + n + "         #  @@@########@@@######@@   " + n + "          #  ###/   ##\\#/##/   ###   " + n + "           # ### *  ####### *  ##    " + n + "          ##@###### ## ## # #####    " + n + "          # #########  ##  #######   " + n + "             ### # ######### # ###   " + n + "              ### # # # # # # ###    " + n + "                ###############    ","          ########################## " + n + "          #                        # " + n + "        # #     x          x       # #" + n + "         ##         |   |          ##" + n + "          #    _____( _ )______    # " + n + "          #        . . . .         # " + n + "          ########################## ","          ########################## " + n + "          #@@@@@@    \\ /    @@@@@@@@# " + n + "        # #@@   (x)   v    (x)    @@# #" + n + "         ##         |   |          ##" + n + "          #    _____( _ )______    # " + n + "          #        . . . .         # " + n + "          ########################## ","          ########################## " + n + "          #        -------         # " + n + "        # #    ( @)       (@ )     # #" + n + "         ##         |   |          ##" + n + "          # .  _____( _ )______ .  # " + n + "          #   |    . . . .     |   # " + n + "          ########################## ","          ########################## " + n + "          #     ~~~~       ~~~~    # " + n + "        # #    ( X )       ( X )   # #" + n + "         ##     _____|   |______   ##" + n + "          # . |      ( _ )     |.  # " + n + "          #    \\   . @ @ .   /    # " + n + "          ########################## ","          ########################## " + n + "          #      ----    ---       # " + n + "        # #   (@  )      (@  )     # #" + n + "         ##         |   |          ##" + n + "          # .  \\____( _ )_____/ .  # " + n + "          #   |    . . . .     |   # " + n + "          ########################## ","          #########________######### " + n + "          #     ~~~~       ~~~~    # " + n + "        # #    (  .  )   (  .  )   # #" + n + "         ##     _____|   |______   ##" + n + "          # . |      ( _ )     |.  # " + n + "          #    \\    . @ @ .  /    # " + n + "          ########################## ","           _#####_____###____#####_  " + n + "          #     ~~~~       ~~~~    # " + n + "        # #    (  .  )   (  .  )   # #" + n + "         ##     _____|   |______   ##" + n + "          # . |     (  _  )    |.  # " + n + "          ###  \\   ~~~~~~~~    / ### " + n + "           ########__&   &__#######  "};
            string[] Cielska = {"                       #            [||}" + n +"                   ########          @/" + n +"                ###  \\###  ####    ##" + n +"              ##      \\##      ####" + n +"             #        /##" + n +"             #       /###" + n +"              #@   ##    ##" + n +"              @@  #        #" + n +"                  #        #" + n +"                  #        #" + n +"                 G#        #D","                   __/    \\___" + n + "              ____#           #____ " + n + "            ##                     ## " + n + "          ##       |        |        ##" + n + "         #        #          #         # " + n + "        #       # \\  . / \\ .  /#        # " + n + "        #       #              #        # " + n + " ___     #      #       @      #       # " + n + "[   ]     #    # .____________.  #     # " + n + "[   ]######[,,,]##################[,,,] " + n + "[   ]        #      ~~   \\~~        #" + n +" ^^^         #      ~~    ~~        #" + n +"             #      ~~    ~~        #" + n +"             ########      ########"  + n +"            #########      #########" + n +"            #########      #########","                   __/    \\___" + n + "              ____#           #____ " + n + "            ##                     ## " + n + "          ##       |        |        ##" + n + "         #        #          #         # " + n + "        #       # \\  . / \\ .  /#        # " + n + "        #       #              #        # " + n + "         #      #       @      #       # " + n + "          #    # .____________.  #     # " + n + "           [,,,]   .  ;^:   .    [,,,] " + n + "             #      ~~   \\~~        #" + n +"             #      ~~    ~~        #" + n +"             #      ~~    ~~        #" + n +"             ########      ########"  + n +"            #########      #########" + n +"            #########      #########","                      #### " + n + "                      #### " + n + "                     ######" + n + "                    # #### #" + n + "                   #  ####  #" + n + "                 ##   ####   ##" + n + "  ___          ##     ####    #" + n + "  ___|_______##_______####_____#____" + n + "  ___|               ##  ## " + n + "                     ##  ## " + n + "                     ##  ## " + n + "                    ##    ## " + n + "                    ##    ## " + n + "                  ####    #### ","      %               ####     @@" + n + "       %              ####      @@" + n + "        %            ######     @@@" + n + "         %          # #### #    @@@" + n + "          %        #  ####  #  #@@@" + n + "           %% %  ##   ####   ## @@@" + n + "            %% ##     ####      @@" + n + "           % ##       ####     @@" + n + "               %     ##  ## " + n + "                     ##  ## " + n + "                     ##  ## " + n + "                    ##    ## " + n + "                    ##    ## " + n + "                  ####    #### ","                      #### " + n + "                      #### " + n + "                     ######" + n + "                    # #### #" + n + "                   #  ####  #" + n + "             |   ##  ######  ##" + n + "           ['|']##  ########   ##" + n + "            \\###     ######   | ##" + n + "                     ##  ##     |||" + n + "                     ##  ## " + n + "                     ##  ## " + n + "                    ##    ## " + n + "                    ##    ## " + n + "                  ####    #### ","                      ##@@@@" + n + "                      ####@@@@@@@@#########@ " + n + "                      ####@@############### @" + n + "                      ####@@@@############# @@" + n + "                      ############### $  ##  @@" + n + "                      ##  ##           $  ##  @@" + n + "                      ##  ##            $ ## @@" + n + "                      ##  ##            $##" + n + "                      ##  ##           ##**"};
            int indexOfArray = new Random().Next(0,morduchny.Length);
            potwor =morduchny[indexOfArray];
            indexOfArray = new Random().Next(0,Cielska.Length);
            potwor = potwor + n + Cielska[indexOfArray];
            return potwor;
        }
        public static void walka(string potwor)
        {
            double czas = 0;
            int num = 0;
            double CalyCzas = 5;
            string literka = "";
            String MonName = MonstersName();
            for (int m=0;m< ZyciePotwora ;m++)
            {
                PaskiZycia(MonName);
                Console.WriteLine(potwor);
                num = new Random().Next(0,26);
                char litera = (char)('a' + num);
                literka = Char.ToString(litera);
                DateTime beginWait = DateTime.Now;
                while (!Console.KeyAvailable && DateTime.Now.Subtract(beginWait).TotalSeconds < CalyCzas)
                {
                    czas = DateTime.Now.Subtract(beginWait).TotalSeconds;
                    Console.WriteLine( "_______________________");
                    Console.WriteLine( "WCISNIJ:     " + literka.ToUpper() + "     " + Math.Ceiling((CalyCzas - czas) * 10)/10);
                    Thread.Sleep(100);
                    ClearCurrentConsoleLine(2);
                }
                Thread.Sleep(250);
                if (!Console.KeyAvailable)
                {
                    Console.WriteLine( "_______________________");
                    Console.WriteLine(" AŁA!!!");
                    ZycieGracza = ZycieGracza - 1;
                    
                    m = m - 1;                   
                }
                else
                {
                    var  input = Console.ReadKey();
                    // chinput = Convert.ToChar(input);
                    if ((input.KeyChar).ToString() == literka)
                    {
                        Console.Clear();
                        PaskiZycia(MonName);
                        Console.WriteLine(potwor.Replace("#","/").Replace("@","o").Replace("/","|").Replace("%","/").Replace("$","S").Replace("x","-").Replace("X","-"));
                        Thread.Sleep(50);
                        Console.Clear();
                        PaskiZycia(MonName);
                        Console.WriteLine(potwor);
                        Console.WriteLine( "_______________________");
                        Console.WriteLine(" JEB Z DZIDY!!!");
                        CalyCzas = CalyCzas * mutliplier;
                        ZyciePotwora = ZyciePotwora - 1;
                        m = m - 1;
                        Score = Score + 13;
                    }
                    else
                    {
                        Console.WriteLine( "_______________________");
                        Console.WriteLine(" SPAROWAŁ DRAŃ!!!");
                        ZycieGracza = ZycieGracza - 1;
                        m = m - 1;
                    }
                }  
                PaskiZycia(MonName);   
                Thread.Sleep(500);
                ClearCurrentConsoleLine(2);
                if (ZycieGracza == 0)
                {
                    ZapisDoPliku();
                    MonName = "\n \n    NIOM! NIOM! NIOM! \n    SMACZNY " + nickname + "!!!                       Zabija Cie: "+MonName+" \n \n \n   GAME OVER!  \n \n \n";
                    for (int l=0;l< 3 ;l++){
                        Console.Clear();
                        Console.WriteLine("\n           ~~~~~~~~~~                  " + "\n" + "       ## /  \\  /   \\ #     " + "\n" + "        #&|  o ^^o   |$#         " + "\n" + "           \\   @@  //             " + "\n" + "           /#\\## / _#__                " + "\n" + "      (:o)/\\\\ E&# \\##\\          " + "\n" + "          ?  |##|\\## |#|       " + "\n" + "          *   \\#/#\\###/       " + "\n" + "         /     #oo##---       " + "\n" + "        /    ### ' ##         " + "\n" + "          ####      ###,     " + "\n \n \n");
                        Console.WriteLine(MonName);
                        Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine("\n           ~~~~~~~~~~                  " + "\n" + "       ## /  \\  /   \\ #     " + "\n" + "        #&|  o ^^o   |$#         " + "\n" + "           \\  .--. //             " + "\n" + "           /#\\## / _#__                " + "\n" + "      (:o)/\\\\ E&# \\##\\          " + "\n" + "          ?  |##|\\## |#|       " + "\n" + "          *   \\#/#\\###/       " + "\n" + "         /     #oo##---       " + "\n" + "        /    ### ' ##         " + "\n" + "          ####      ###,     " + "\n \n \n");
                        Console.WriteLine(MonName);
                        Thread.Sleep(200);
                        Console.Clear();
                    }
                    
                    for (int l=0;l< 5 ;l++){
                        Console.WriteLine("\n           ~~~~~~~~~~                  " + "\n" + "       ## /  \\  /   \\ #     " + "\n" + "        #&|   o^^ o  |$#         " + "\n" + "           \\   @@  //             " + "\n" + "           /#\\## / _#__                " + "\n" + "      (;c)/\\\\ E&# \\##\\          " + "\n" + "          ?  |##|\\## |#|       " + "\n" + "          *   \\#/#\\###/       " + "\n" + "         |     #oo##---       " + "\n" + "         |   ### ' ##         " + "\n" + "          ####      ###,     " + "\n \n \n");
                        Console.WriteLine(MonName);
                        Thread.Sleep(150);
                        Console.Clear();
                        Console.WriteLine("\n           ~~~~~~~~~~                  " + "\n" + "       ## /  \\  /   \\ #     " + "\n" + "        #&|   o^^ o  |$#         " + "\n" + "           \\  .--. //             " + "\n" + "           /#\\## / _#__                " + "\n" + "      (;c)/\\\\ E&# \\##\\          " + "\n" + "          ?  |##|\\## |#|       " + "\n" + "          *   \\#/#\\###/       " + "\n" + "         |     #oo##---       " + "\n" + "         |   ### ' ##         " + "\n" + "          ####      ###,     " + "\n \n \n");
                        Console.WriteLine(MonName);
                        Thread.Sleep(150);
                        Console.Clear();
                    }
                    for (int l=0;l< 3 ;l++){
                        Console.WriteLine("\n           ~~~~~~~~~~                  " + "\n" + "       ## /  \\  /   \\ #     " + "\n" + "        #&|  o'^^o'  |$#         " + "\n" + "           \\  .--. //             " + "\n" + "           /#\\## / _#__                " + "\n" + "      (;c)/\\\\ E&# \\##\\          " + "\n" + "          ?  |##|\\## |#|       " + "\n" + "          *   \\#/#\\###/       " + "\n" + "         |     #oo##---       " + "\n" + "         |   ### ' ##         " + "\n" + "          ####      ###,     " + "\n \n \n");
                        Console.WriteLine(MonName);
                        Thread.Sleep(300);
                        Console.Clear();
                        Console.WriteLine("\n           ~~~~~~~~~~                  " + "\n" + "       ## /  \\  /   \\ #     " + "\n" + "        #&|  o'^^o'  |$#         " + "\n" + "           \\   @@  //             " + "\n" + "           /#\\## / _#__                " + "\n" + "      (;c)/\\\\ E&# \\##\\          " + "\n" + "          ?  |##|\\## |#|       " + "\n" + "          *   \\#/#\\###/       " + "\n" + "         |     #oo##---       " + "\n" + "         |   ### ' ##         " + "\n" + "          ####      ###,     " + "\n \n \n");
                        Console.WriteLine(MonName);
                        Thread.Sleep(300);
                        Console.Clear();
                    }    
                    Console.WriteLine("Press ENTER to start new game, or any other key to start new game.");
                    Console.WriteLine("           ~~~~~~~~~~                  " + "\n" + "       ## /  \\  /   \\ #     " + "\n" + "        #&|  o'^^o'  |$#         " + "\n" + "           \\  ,__, //             " + "\n" + "           /#\\## / _#__                " + "\n" + "      (;c)/\\\\ E&# \\##\\          " + "\n" + "          ?  |##|\\## |#|       " + "\n" + "          *   \\#/#\\###/       " + "\n" + "         |     #oo##---       " + "\n" + "         |   ### ' ##         " + "\n" + "          ####      ###,     " + "\n \n \n");
                    Console.WriteLine(MonName);            
                    odczytZPliku();
                    Console.ReadLine();
                    Main();
                    
                }
            }
        }

         static void AnimacjaSmierciPotwora(string potwor)
        {
                Console.Clear();
                //wybuch 1
                Console.WriteLine(potwor.Replace("#","*"));
                Thread.Sleep(100);
                Console.Clear();
                //wybuch 2
                Console.WriteLine(potwor.Replace("#",".").Replace("@","-").Replace("/","'").Replace("%","/").Replace("$","|").Replace("x","-").Replace("X","-"));
                Thread.Sleep(70);
                Console.Clear();
                //wybuch 3
                Console.WriteLine(potwor.Replace("#"," ").Replace("@"," ").Replace("/"," ").Replace("\\","'").Replace("x",".").Replace("X",".").Replace("$","'").Replace("|","'").Replace("(","'").Replace(")","'").Replace("_",".").Replace("%",","));
                Thread.Sleep(70);
                Console.Clear();
                //wybuch 4
                Console.WriteLine(potwor);
                Thread.Sleep(20);
                Console.Clear();
                Console.WriteLine(potwor.Replace("        "," ").Replace(" ","  "));
                Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine(potwor.Replace("        "," ").Replace(" ","  ").Replace("#"," ").Replace("@"," ").Replace("x","-").Replace("X","-").Replace("$","'").Replace("/"," ").Replace("\\","'").Replace("|","'").Replace("(","'").Replace(")","'").Replace("_",".").Replace("%",","));
                Thread.Sleep(30);
                Console.Clear();
                Thread.Sleep(500);
        }

         static void PaskiZycia(string MonName)
       {       
            for (int i = 0; i <2; i++) 
            {
                Console.SetCursorPosition(0,i);
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            }  
           Console.SetCursorPosition(0,0);
           Console.Write(nickname + ": ");
           for (int i = 1; i <= ZycieGracza; i++)
           {
               Console.Write("[] ");
           }
           Console.Write("   " + MonName +" : ");
            for (int i = 1; i <= ZyciePotwora; i++)
            {
                Console.Write("[] ");
            }
            Console.WriteLine("\n____________________________________________________________________________________________________________");
        }
         public static void ClearCurrentConsoleLine(int iloscLinijek)
        {
            Console.SetCursorPosition(0,Console.CursorTop);
            for (int i = 0; i < iloscLinijek; i++) 
            {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth)); 
            Console.SetCursorPosition(0, currentLineCursor);
            }  
        } 

        static string MonstersName()
        {
            string[,] tablicaImionaPotworow = {
                {"Kiepski", "Ogromny", "Przejebany", "Brzydki", "Zielony", "Bezlitosny", "Nieco Jebnięty", "Wygięty", "Brzydko-uzębiony", "Marudny", "Uprzejmy", "Orzełowy", "Pińćset letni", "Stary", "Zniewieściały", "Zkacowany", "Zalany w trupa", "Pełen nienawiści", "Smutny", "", "Nieprzyjemny", "Strajkujący", "Warszawski","Zdesperowany","Zakompleksiony","Niewyżyty","Przerośnięty","Puszysty","Mięciutki","Wymamlany","Pokryty cudzymi włosami","Zatroskany","","","" }, 
                {"Kurvinox", "Skurwol", "Chujew", "Dodupyzaur", "Nadesrał I", "Analoerektus", "Kutanoid", "Zdupiks", "Skurwodaktyl", "Mordobójca", "Bydlak", "Mgławic", "Tytus", "Kosmita", "UFOL", "Nadesrał II", "Przeciwnik" ,nickname, "Dendrofil", "Zdzisław", "Michal Dzięgiel", "Parch", "Bały, heteroseksualny młodzieniec", "Koń Rafał", "Typowy Janusz", "Dentysta", "Przyjaciel Twojej żony", "kiciuś", "Zombiak", "Penis Rozrabiaka", "Nerd", "Robotnik", "Słoik", "Łoniak","Włochaty Wyjec"},
                {"Z Galaktyki Kurwix", "Z problemami z kręgosłupem", "ze wsi", "z ropieniem odbytu", "z Krakowa", "z pippy" , "z działkiem laserowym", "z dupy", "z AF", "o randze porucznika", "filantrop", "z kosmosu", "potężny", "pełen nienawiści", "na dragach", "", "i to w dodatku wkurwiony", "z rozpietym rozporkiem", "a.k.a \"MASZ PRZEJEBANE\"","z zatwardzeniem","o OGROMNEJ potrzebie","z Sosnowca","","","","","","","","","","","","",""}
                };

            Random losowy = new Random();
            //int wierszTablicy = losowy.Next(0,2);
            int kolumnaTablicy = losowy.Next(0,35); //debug info
            string przymiotnikPotwora = (tablicaImionaPotworow[0,losowy.Next(0,35)]);
            losowy = new Random();
            kolumnaTablicy = losowy.Next(0,35); //debug info
            string nazwaPotwora = (tablicaImionaPotworow[1,losowy.Next(0,35)]);
            losowy = new Random();
            kolumnaTablicy = losowy.Next(0,35); //debug info
            string przyslowekPotwora = (tablicaImionaPotworow[2,losowy.Next(0,35)]);
            string imiePotwora = przymiotnikPotwora + " " + nazwaPotwora + " " + przyslowekPotwora;
            return imiePotwora;
        }

         static void ZapisDoPliku()
         {
             using (System.IO.StreamWriter file = 
             new System.IO.StreamWriter(@FILE_DIRECTORY, true))
             {
                 file.WriteLine(Score.ToString() + " - " + nickname + "'s score");  
             }
         }
            static void odczytZPliku()
         {
             Console.WriteLine("current scores:");

             try
             {
                string text = System.IO.File.ReadAllText(@FILE_DIRECTORY);
                Console.WriteLine(text);
             }
             catch (System.Exception)
             {                
                throw;
             }
             finally
             {
                // Console.WriteLine("aby zagrac wcisnij enter");
             }

         }

    }
}

