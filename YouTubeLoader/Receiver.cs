using AngleSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace YouTubeLoader
{
    class Receiver
    {
        public void InfoOperation()
        {
            

            Console.Write("Введите URL видео\n");

            var url = Console.ReadLine().ToString();

            YoutubeClient youtube = new YoutubeClient();

            var video = youtube.Videos.GetAsync(url).Result;
            Console.WriteLine(video.Title);
            Console.WriteLine(video.Duration);
            Console.WriteLine(video.Author);
        }

        public async void LoadOperation()
        {
            Console.Write("Введите URL видео\n");

            var url = Console.ReadLine().ToString();

            Console.WriteLine("\nЗагрузка начата!");
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            Console.WriteLine("Загрузка окончена!");



        }
    }
}
