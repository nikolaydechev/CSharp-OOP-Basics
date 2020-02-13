using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04.OnlineRadioDatabase
{
    class Program
    {
        static void Main()
        {
            var songList = new List<Song>();
            var N = int.Parse(Console.ReadLine());

            
                for (int i = 0; i < N; i++)
                {
                    try
                    {
                        var inputArgs = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                        var minAndSec = inputArgs[2].Split(':').ToList();
                        bool valid = CheckIfTimeIsValid(minAndSec);
                        if (!valid)
                        {
                            throw new ArgumentException(ExceptionMessages.InvalidSongLengthException);
                        }
                        if (inputArgs.Length < 3)
                        {
                            throw new ArgumentException(ExceptionMessages.InvalidSongException);
                        }
                        var song = new Song(inputArgs[0], inputArgs[1], inputArgs[2]);
                        songList.Add(song);
                        Console.WriteLine("Song added.");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            
            

            var totalLength = TimeSpan.Zero;

            var timeSpanList = songList
                .Select(x => TimeSpan.ParseExact(x.Length, "m\\:s", CultureInfo.InvariantCulture))
                .ToList();

            foreach (var time in timeSpanList)
            {
               
                totalLength += time;
            }

            Console.WriteLine($"Songs added: {songList.Count}");
            Console.WriteLine($"Playlist length: {totalLength.Hours}h {totalLength.Minutes}m {totalLength.Seconds}s");
        }

        private static bool CheckIfTimeIsValid(List<string> minAndSec)
        {
            int minutes;
            int seconds;
            bool isMinutes = int.TryParse(minAndSec[0], out minutes);
            bool isSeconds = int.TryParse(minAndSec[1], out seconds);
            if (isSeconds && isMinutes)
            {
                return true;
            }
            return false;
        }
    }
}
