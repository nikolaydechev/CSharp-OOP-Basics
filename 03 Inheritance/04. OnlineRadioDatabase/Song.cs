using System;

namespace _04.OnlineRadioDatabase
{
    class Song
    {
        private string artist;
        private string songName;
        private string length;

        public Song(string artist, string songName, string length)
        {
            this.Artist = artist;
            this.SongName = songName;
            this.Length = length;
        }

        public string Artist
        {
            get { return this.artist; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidArtistNameException);
                }
                this.artist = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidSongNameException);
                }
                this.songName = value;
            }
        }

        public string Length
        {
            get { return this.length; }
            set
            {
                string[] time = value.Split(':');
                if (int.Parse(time[0]) < 0 || int.Parse(time[0]) > 14)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidSongMinutesException);
                }
                if (int.Parse(time[1]) < 0 || int.Parse(time[1]) > 59)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidSongSecondsException);
                }
                this.length = value;
            }
        }
    }
}
