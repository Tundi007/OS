// List<string> a = ["1","2","3"];
// System.Console.WriteLine(a[^0]);
// using System.Diagnostics;

// List<Process> a = [];
// a.Add(new Process());
// a[^1].Start();
// Console.ReadKey();

// Process p = new Process();
// p.StartInfo = new ProcessStartInfo()
// {
//     RedirectStandardOutput = false,
//     RedirectStandardError = true,
//     UseShellExecute = false,
//     CreateNoWindow = false
// };
// p.Start();
// p.BeginErrorReadLine();


// var p1 = new Process();
// var si = p.StartInfo;
// si.CreateNoWindow = true;
// si.UseShellExecute = true;
// si.FileName = Process.GetCurrentProcess().MainModule.FileName;
// si.Verb = "runas";
// p.Start(); // UAC will show here only once

// using System.Diagnostics;

// ProcessStartInfo startInfo = new ProcessStartInfo();
// startInfo.FileName = "dotnet";
// startInfo.Arguments = "Program.dll";
// startInfo.CreateNoWindow = true;
// startInfo.UseShellExecute = false;

// Process p = new Process();
// p.StartInfo = startInfo;
// p.StartInfo.RedirectStandardOutput = true;
// p.Start();

// string output = p.StandardOutput.ReadToEnd();
// p.WaitForExit();

// ----------------------------------------------------

// using HtmlAgilityPack;

// HtmlWeb a = new();

// HtmlDocument b = a.Load(@"http://web.nit.ac.ir/~gholamirudi/");

// HtmlNode c = b.DocumentNode.SelectSingleNode("//p");

// if(c == null)
//     return;

// System.Console.WriteLine("inner text");

// System.Console.WriteLine(c.InnerText);

// System.Console.WriteLine();

// System.Console.WriteLine("inner html");

// System.Console.WriteLine(c.InnerHtml);

// HtmlNodeCollection c = b.DocumentNode.ChildNodes;

// System.Console.WriteLine("start");

// System.Console.WriteLine("----------------------------");

// foreach (HtmlNode d in c)
// {
//     System.Console.WriteLine("Parsed:");
//     System.Console.WriteLine(b.ParsedText);
//     System.Console.WriteLine("----------------------------");

// }

// System.Console.WriteLine("end");


// using HtmlAgilityPack;

// HtmlDocument a = new HtmlWeb().Load(@"http://web.nit.ac.ir/~gholamirudi/");

// HtmlNode b = a.DocumentNode.SelectSingleNode("//p");

// HtmlNode c = a.DocumentNode.SelectSingleNode("//title");

// HtmlNode d = a.DocumentNode.SelectSingleNode("//body");

// if(b == null)
//     return;

// System.Console.WriteLine("inner text");

// System.Console.WriteLine(c.InnerText);

// HttpClient client_HttpClient = new();

// string webAddress_String = "http://web.nit.ac.ir/~gholamirudi/";

// if (await ConnectHTTP_Task())
//     System.Console.WriteLine("Nice");
// else
//     return;

// async Task<bool> ConnectHTTP_Task()
// {

//     try
//     {

//         string responseBody_String = await client_HttpClient.GetStringAsync(webAddress_String);

//         Console.WriteLine(responseBody_String);

//         Thread.Sleep(3000);

//         return true;

//     }
//     catch (HttpRequestException e)
//     {

//         Console.WriteLine("\nError:");

//         Console.WriteLine(e.Message);

//         System.Console.WriteLine("\nPress Any Key To Continue");

//         Console.ReadKey(true);

//         return false;

//     }

// }

// using HttpResponseMessage response = await new HttpClient().GetAsync("http://www.contoso.com/");

// string a = response.EnsureSuccessStatusCode().ToString();

// System.Console.WriteLine(a);

// Console.Clear();

// List<int> a = [1,2,3];

// a.Remove(1);

// a.Add(4);

// foreach (int b in a)
// {

//     System.Console.WriteLine("element");

//     System.Console.WriteLine(b);

// }

// using System.Diagnostics;

// Process a = new()
// {
//     StartInfo =  new()
//     {
//         FileName = "dotnet",
//         Arguments = "OS.dll",
//     }
// };

// a.Start();

// System.Console.WriteLine(Environment.ProcessId);
// using System.IO.MemoryMappedFiles;

// MemoryMappedFile.CreateNew("update",10000);

// async Task a()
// {

//     try
//     {

//         new BinaryWriter(MemoryMappedFile.OpenExisting("update").
//             CreateViewStream()).Write(0);
//     }
//     catch(Exception exception)
//     {

//         Console.WriteLine(exception.Message);

//     }

// }

// try
// {

//     a().Wait();

//     using (MemoryMappedFile update_MemoryMappedFile = MemoryMappedFile.OpenExisting("update"))
//     {           

//         using(MemoryMappedViewStream option_MemoryMappedViewStream = update_MemoryMappedFile.CreateViewStream())
//         {

//             BinaryReader option_BinaryReader = new (option_MemoryMappedViewStream);

//             System.Console.WriteLine(option_BinaryReader.ReadInt16());
//         }            

//     }

// }catch(Exception e)
// {

//     System.Console.WriteLine(e.Message);

// }

// Mutex b = new(true, "b");

// int c = 2;

// Task.Run(new Action(a));

// System.Console.WriteLine(c);

// Thread.Sleep(1000);

// System.Console.WriteLine(c);

// b.ReleaseMutex();

// Thread.Sleep(1000);

// System.Console.WriteLine(c);

// void a()
// {

//     b.WaitOne();

//     c = 4;

//     b.ReleaseMutex();

// }

// using System.Diagnostics;

// new Process()
// {
//     StartInfo = new()
//     {
//         // FileName = "Z:\\Git Projects\\Tabs\\bin\\Debug\\net8.0\\Tabs.exe",
//         // FileName = "Z:\\Git Projects\\Tabs\\bin\\Debug\\net8.0\\Tabs.dll",
//         FileName = "dotnet",
//         Arguments = "\"Z:\\Git Projects\\Tabs\\bin\\Debug\\net8.0\\Tabs.dll\"",
//     }
// }.Start();

// using HtmlAgilityPack;
// string webAddress_String = "https://www.rrudi.ir/";

// // "http://web.nit.ac.ir/~gholamirudi/" & https://www.rudi.ir/

//     // Uri.TryCreate(webAddress_String, UriKind.RelativeOrAbsolute, out Uri webAddress_Uri);

//     HttpResponseMessage response = new();

//     string response_String = response.EnsureSuccessStatusCode().ToString();

//     string title_String = new HtmlWeb().Load(webAddress_String).DocumentNode.SelectSingleNode("//title").InnerText;

//     string body_String = new HtmlWeb().Load(webAddress_String).DocumentNode.SelectSingleNode("//body").InnerText;

//     for (int i = 0; i < 9; i++)
//     {

//         Console.Clear();        

//         System.Console.WriteLine(response_String);

//         if(i%3 == 0)
//             System.Console.WriteLine(".");

//         if(i%3 == 1)
//             System.Console.WriteLine("..");

//         if(i%3 == 2)
//             System.Console.WriteLine("...");

//         Thread.Sleep(200);

//     }

//     Thread.Sleep(1000);

//     Console.Clear();

// }

// string webAddress_String = "https://www.google.com";

// Get_Function();

// Thread.Sleep(2000);

// async void Get_Function()
// {

//     if(Uri.IsWellFormedUriString(webAddress_String,UriKind.RelativeOrAbsolute))
//     {        
//         System.Console.WriteLine("formed");
//         if(await ConnectHTTP_Task())
//             return;
//     }
//     else
//         System.Console.WriteLine("Invalid URL Format!");

//     System.Console.WriteLine("not formed");

//     async Task<bool> ConnectHTTP_Task()
//     {

//         try
//         {

//             HttpResponseMessage a = await new HttpClient().SendAsync(new HttpRequestMessage(HttpMethod.Head, webAddress_String));   

//             Thread.Sleep(1000);

//         }catch(Exception)
//         {

//             Console.WriteLine("Error:\nCouldn't Connect To Host, Make Sure To Enter An Existing URL\nPress Any Key To Continue");

//             Console.ReadKey(true);

//             return false;

//         }

//         try
//         {

//             // title_String = new HtmlWeb().Load(webAddress_String).DocumentNode.SelectSingleNode("//title").InnerText;

//             // body_String = new HtmlWeb().Load(webAddress_String).DocumentNode.SelectSingleNode("//body").InnerText;

//         }
//         catch (Exception)
//         {

//             Console.WriteLine("\nError Trying To Load Website!\nPress Any Key To Continue");

//             Console.ReadKey(true);

//             return false;

//         }

//         System.Console.WriteLine("loaded");

//         return true;

//     }

// }






// using System.Diagnostics;

// System.Console.WriteLine("hi");

// Stopwatch a = Stopwatch.StartNew();

// async_task();

// System.Console.WriteLine("tasked async function");

// Task a = new(async_function);

// a.Start();

// async_function();

// Thread.Sleep(1500);

// System.Console.WriteLine("end");

// async Task<bool> async_task() //complete async
// {

//     System.Console.WriteLine("task start: "+a.Elapsed.TotalMilliseconds);

//     Stopwatch b = Stopwatch.StartNew();

//     await Task.Delay(500);

//     b.Stop();

//     System.Console.WriteLine("task total: "+b.Elapsed.TotalMilliseconds);

//     return true;

// }

// async void async_function()
// {

//     System.Console.WriteLine("function start: "+a.Elapsed.TotalMilliseconds);

//     Stopwatch b = Stopwatch.StartNew();

//     await async_task();

//     b.Stop();

//     System.Console.WriteLine("function total: "+b.Elapsed.TotalMilliseconds);

//     return;

// }

// System.Console.WriteLine(Task.CompletedTask.Status.ToString());

// using System.Diagnostics;
// Stopwatch a = Stopwatch.StartNew();
// // await Task.Delay(0);
// Thread.Sleep(100);
// System.Console.WriteLine(a.Elapsed.Milliseconds);