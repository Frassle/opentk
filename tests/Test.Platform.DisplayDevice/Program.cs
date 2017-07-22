using System;

namespace Test.Platform.DisplayDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            var indices = new OpenTK.DisplayIndex[]
            {
                OpenTK.DisplayIndex.Primary,

                OpenTK.DisplayIndex.First,
                OpenTK.DisplayIndex.Second,
                OpenTK.DisplayIndex.Third,
                OpenTK.DisplayIndex.Fourth,
                OpenTK.DisplayIndex.Fifth,
                OpenTK.DisplayIndex.Sixth,
            };

            while (!Console.KeyAvailable)
            {
                Console.Clear();

                foreach (var index in indices)
                {
                    Console.WriteLine("================================================================================");
                    Console.WriteLine(index);

                    var display = OpenTK.DisplayDevice.GetDisplay(index);
                    if (display != null)
                    {
                        Console.WriteLine(display);
                        Console.WriteLine("Primary: {0}", display.IsPrimary);
                        Console.WriteLine("Current Resolution: {0}", display.CurrentResolution);
                    }
                    else
                    {
                        Console.WriteLine("GetDisplay returned null");
                    }
                }

                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            }
        }
    }
}
