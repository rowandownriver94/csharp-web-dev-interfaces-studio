using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc 
    {
        public string Lyrics { get; set; }
        public string SongTitle { get; set; }
        public int TrackNumber { get; set; }

        public CD(string name, int minutesOfContent, string content, string discType, bool isSpinable, int trackNumber, string songTitle, string lyrics) : base(name, minutesOfContent, content, discType, isSpinable)
        {
            TrackNumber = trackNumber;
            SongTitle = songTitle;
            Lyrics = lyrics;
        }

        public void ReadData()
        {
            Console.WriteLine($"Track {TrackNumber}\n{SongTitle}");
            Console.WriteLine($"\n{Lyrics}");
        }

        public void SpinDisc()
        {
            if (IsSpinable == true)
            {
                ReadData();
            }
            else
            {
                Console.WriteLine("ERROR! Unable to read disc.");
            }
        }
    }
}
