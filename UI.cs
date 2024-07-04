namespace OS;

internal class MyUI
{
    
    public static int KeyToLine_Function(int exitCode_Int,out string return_String)
    {
        
        ConsoleKeyInfo key_ConsoleKeyInfo;

        string input_String = "";

        int stringIndex_Int = 0;

        string menu_String = "Enter Your Text, \"Enter\" To Got To Website, \"Escape\" To Exit Tab.\nWrite \"sw\" And Press Enter To Use My Input Method!";

        string userInterfaceInput_String = "";

        bool MyUI_Bool = false;

        while(true)
        {

            Console.Clear();

            if(!MyUI_Bool)
            {

                System.Console.WriteLine(menu_String);

                return_String = Console.ReadLine();

                return 1;
                
            }
            else
            {

                System.Console.WriteLine(menu_String);

                System.Console.WriteLine(userInterfaceInput_String);

                key_ConsoleKeyInfo = Console.ReadKey(true); 

                switch (key_ConsoleKeyInfo.Key)
                {

                    case ConsoleKey.Tab:
                        Console.Clear();
                        input_String = Console.ReadLine();
                        break;

                    case ConsoleKey.Enter:
                        Console.Clear();
                        return_String = input_String;
                        return 1;

                    case ConsoleKey.Escape:
                        Console.Clear();
                        return_String = exitCode_Int.ToString();
                        return 1;

                    case ConsoleKey.End:
                        stringIndex_Int = input_String.Length-1;
                        break;

                    case ConsoleKey.Home:
                        stringIndex_Int = 0;
                        break;

                    case ConsoleKey.LeftArrow:
                    {
                    
                        if(stringIndex_Int < 1)break;

                        stringIndex_Int--;

                        userInterfaceInput_String = input_String[..stringIndex_Int] + ">." +
                            input_String[stringIndex_Int..];

                    }break;

                    case ConsoleKey.RightArrow:{
                    
                        if(stringIndex_Int >= input_String.Length)break;

                        stringIndex_Int++;

                        userInterfaceInput_String = input_String[..stringIndex_Int] + ">." +
                            input_String[stringIndex_Int..];

                    }break;

                    case ConsoleKey.Delete:
                    {                    

                        if(stringIndex_Int >= input_String.Length)break;
                        
                        input_String = input_String.Remove(stringIndex_Int,1);

                        userInterfaceInput_String = input_String[..stringIndex_Int] + ">." +
                            input_String[stringIndex_Int..];
                    
                    }break;

                    case ConsoleKey.Backspace:
                    {

                        if (stringIndex_Int < 1)break;
                            
                        input_String = input_String.Remove(stringIndex_Int-1,1);

                        stringIndex_Int--;

                        userInterfaceInput_String = input_String[..stringIndex_Int] + ">." +
                            input_String[stringIndex_Int..];
                        
                    }break;

                    default:
                    {

                        if(key_ConsoleKeyInfo.Modifiers!=ConsoleModifiers.None)
                        {
    
                            System.Console.WriteLine("Sorry, Key Modifiers (shift,ctrl,alt) Are Not Implemented Yet.\nPress Any Key To Contunue.");

                            Console.ReadKey(true);
                            
                            break;
                            
                        }
                    
                        input_String = input_String[..stringIndex_Int] + key_ConsoleKeyInfo.KeyChar.ToString() +
                            input_String[stringIndex_Int..];

                        stringIndex_Int++;
                                        
                        userInterfaceInput_String = input_String[..stringIndex_Int] + ">." +
                            input_String[stringIndex_Int..];
                    
                    }break;

                }
            
            }

        }

    }

    public static bool UserInterface_Function(string menu_String, string[] options_String, string? html_String,
        int pointer_Int, out int output_Int, out bool exit_Bool)
    {

        exit_Bool = false;

        output_Int = 0;

        Console.Clear();

        System.Console.WriteLine(menu_String);

        for (int i = 0; i < options_String.Length; i++)
        {

            if(i==pointer_Int)
                System.Console.Write("->");

            System.Console.WriteLine(options_String[i]);
            
        }

        if(html_String != null)
            System.Console.WriteLine(html_String);

        switch (Console.ReadKey(true).Key)
        {

            case ConsoleKey.Enter:
                output_Int = 3;
                break;

            case ConsoleKey.Escape:
                exit_Bool = true;
                break;

            case ConsoleKey.UpArrow:
               output_Int = 0;
               break;

            case ConsoleKey.DownArrow:
                output_Int = 1;
                break;

            default:
                break;

        }

        // Return false
        return false;

    }

}
