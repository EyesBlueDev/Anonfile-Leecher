using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Drawing;
using Console = Colorful.Console;
using System.Text.RegularExpressions;
// This is made by Eyes Blue#0471
// If your copying and editing this make sure to put my credits!!
// Check out my profile https://discordhub.com/profile/899273223550677002
namespace EyesBlue
{
	class Program
	{
		static void Main()
		{
			Console.Title = "Anonfile Leecher 2.0 - EyesBlue Dev";
			Console.Clear();
			System.Diagnostics.Process.Start("https://github.com/EyesBlueDev");

			while (true)
			{

				Console.Write("\n");
				Console.WriteLine("		███████╗██╗   ██╗███████╗███████╗██████╗ ██╗     ██╗   ██╗███████╗", Color.Red);
				Console.WriteLine("		██╔════╝╚██╗ ██╔╝██╔════╝██╔════╝██╔══██╗██║     ██║   ██║██╔════╝", Color.Red);
				Console.WriteLine("		█████╗   ╚████╔╝ █████╗  ███████╗██████╔╝██║     ██║   ██║█████╗  ", Color.Red);
				Console.WriteLine("		██╔══╝    ╚██╔╝  ██╔══╝  ╚════██║██╔══██╗██║     ██║   ██║██╔══╝  ", Color.Red);
				Console.WriteLine("		███████╗   ██║   ███████╗███████║██████╔╝███████╗╚██████╔╝███████╗", Color.Red);
				Console.WriteLine("		╚══════╝   ╚═╝   ╚══════╝╚══════╝╚═════╝ ╚══════╝ ╚═════╝ ╚══════╝", Color.Red);
				Console.WriteLine("                                 https://github.com/EyesBlueDev", Color.DeepSkyBlue);
				Console.WriteLine("");
				Console.WriteLine("Enter your keyword(s):", Color.Red);
				Console.Write(">", Color.DeepSkyBlue);
				string resp = Console.ReadLine();
				int count = 0;
				List<string> Links = new List<string>();
				using (WebClient wc = new WebClient())
				{
					string s = wc.DownloadString("https://google.com/search?q=inurl:anonfile.com+" + resp);
					Regex r = new Regex(@"https:\/\/anonfile.com\/\w+\/\w+");
					foreach (Match m in r.Matches(s))
					{
						count++;
						Links.Add(m.ToString());
					}
				}

				using (TextWriter tw = new StreamWriter(@"links.txt"))
				{
					foreach (string line in Links)
					{
						tw.WriteLine(line.ToString());
					}
				}

				Console.WriteLine();
				Console.WriteLine("Scraped " + count.ToString() + " links!", Color.Red);
				Console.ReadLine();
				Console.Clear();
			}
		}
	}
}
