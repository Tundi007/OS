using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using OS;

int mainID_Int = Environment.ProcessId;

List<string> openTabs_ListString = [];

List<int> openTabsID_ListInt = [];

MemoryMappedFile.CreateNew("Mybridge", 4096);

Semaphore update_Semaphore = new(-1, 0, "Myupdate");

Semaphore wait_Semaphore = new(-1, 0, "Mywait");

Mutex update_Mutex = new(false, "Mytabs");

int pointer_Int = 0;

Task.Run(UpdateTabs_Function);

while (!MyUI.UserInterface_Function("Menu:", ["New Tab", "Tabs", "Close"], null, pointer_Int,
    out int output_Int, out bool exit_Bool))
{

    if (exit_Bool)
        Exit_Function();

    if (output_Int == 0 & pointer_Int > 0)
        pointer_Int--;

    if (output_Int == 1 & pointer_Int < 2)
        pointer_Int++;

    if (output_Int == 3)
        switch (pointer_Int)
        {
            case 0:
                {
                    new Process()
                    {
                        StartInfo = new()
                        {
                            FileName = "dotnet",
                            Arguments = "\"Z:\\Git Projects\\Tabs\\bin\\Debug\\net8.0\\Tabs.dll\"",
                        }
                    }.Start();

                }
                break;

            case 1:
                {

                    while (Console.ReadKey().Key != ConsoleKey.Escape)
                    {

                        Console.Clear();

                        for (int i = 0; i < openTabs_ListString.Count; i++)
                            System.Console.WriteLine(openTabs_ListString[i]);

                        System.Console.WriteLine("Press \"Escape\" To Go Back");

                    }

                    Console.Clear();

                }
                break;

            case 2:
                Exit_Function();
                break;

            default:
                break;

        }

}

async void UpdateTabs_Function()
{

    while (true)
    {

        int thatProcess_Int;

        string thatTitle_String;

        int index_Int;

        await Update_Task();

        async Task Update_Task()
        {

            update_Semaphore.WaitOne();

            Thread.BeginCriticalRegion();

            thatProcess_Int =
                new BinaryReader(MemoryMappedFile.OpenExisting("Mybridge").
                    CreateViewStream()).ReadInt16();

            wait_Semaphore.Release();

            update_Semaphore.WaitOne();

            thatTitle_String =
                new BinaryReader(MemoryMappedFile.OpenExisting("Mybridge").
                    CreateViewStream()).ReadString();

            index_Int = openTabsID_ListInt.IndexOf(thatProcess_Int);

            openTabs_ListString[index_Int] = $"{index_Int + 1}. {thatTitle_String}";

            new BinaryWriter(MemoryMappedFile.OpenExisting("Mybridge").
                CreateViewStream()).Write(index_Int + 1);

            Thread.EndCriticalRegion();

            wait_Semaphore.Release();

            await Task.Delay(0);

        }

    }

}

void Exit_Function()
{

    Console.Clear();

    System.Console.WriteLine("Have A Nice Day!");

    Thread.Sleep(300);

    Environment.Exit(0);
}
