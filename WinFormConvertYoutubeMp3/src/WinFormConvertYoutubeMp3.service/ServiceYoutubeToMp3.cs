using MediaToolkit;
using MediaToolkit.Model;
using System.IO;
using VideoLibrary;

namespace WinFormConvertYoutubeMp3.service
{
    public class ServiceYoutubeToMp3 : IServiceYoutubeToMp3
    {
        public void Convert(string url, string dest)
        {
            dest = dest + "\\";
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(url);
            File.WriteAllBytes(dest + vid.FullName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = dest + vid.FullName };
            var outputFile = new MediaFile { Filename = $"{dest + vid.FullName}.mp3".Replace(".mp4","") };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }
        }
    }
}
