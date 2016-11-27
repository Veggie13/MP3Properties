using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace MP3Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"E:\log.txt"))
            {
                Regex regex = new Regex("(.+) - (.+)");
                foreach (string filename in Directory.EnumerateFiles(@"E:\Veggie\Music\MP3 Files", "*.mp3"))
                {
                    TagLib.File f = TagLib.File.Create(filename);
                    string tagTitle = f.Tag.Title;
                    string tagArtist = f.Tag.FirstArtist;

                    string name = Path.GetFileNameWithoutExtension(filename);
                    if (regex.IsMatch(name))
                    {
                        var match = regex.Match(name);
                        string title = match.Groups[2].Value;
                        string artist = match.Groups[1].Value;

                        if (title != tagTitle || artist != tagArtist)
                        {
                            writer.WriteLine("{0} ::: {1} ::: {2} ::: {3}", artist, title, tagArtist, tagTitle);

                            f.Tag.Title = title;
                            f.Tag.Artists = new[] { artist };
                            if (string.IsNullOrEmpty(f.Tag.JoinedAlbumArtists))
                            {
                                f.Tag.AlbumArtists = f.Tag.Artists;
                            }
                            f.Save();
                        }
                    }
                }
            }
        }
    }
}
