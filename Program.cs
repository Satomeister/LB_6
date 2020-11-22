using Google.GData.Extensions.MediaRss;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Media;
using LB_6.Intefaces;
using LB_6.Classes;

namespace LB_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] filePaths = Directory.GetFiles("media");

            ArrayList PIList = new ArrayList();

            foreach (string path in filePaths)
            {
                string type = path.Substring(path.Length - 4, 4);
                string name = path.Substring(6, path.Length - 10);

                PIList.Add(new PlayerItem(path, name, type));
            }

            for (int i = 0; i < PIList.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {((PlayerItem)PIList[i]).Name}{((PlayerItem)PIList[i]).Type}");
            }
            Console.WriteLine();
            Console.WriteLine("Choose the music, by index");
            byte index = Convert.ToByte(Console.ReadLine());

            PlayerItem chosen = ((PlayerItem)PIList[index - 1]);

            Mp3 mp3 = new Mp3(chosen);
            Wav wav = new Wav(chosen);
            Mkv mkv = new Mkv(chosen);
            
            switch (chosen.Type)
            {
                case ".mkv":
                    mkv.Play();
                    mkv.Pause();
                    mkv.Stop();
                    break;
                case ".mp3":
                    mp3.Play();
                    mp3.Pause();
                    mp3.Stop();
                    break;
                case ".wav":
                    wav.Play();
                    wav.Pause();
                    wav.Stop();
                    wav.Record();
                    break;
                default:
                    Console.WriteLine("extension is not supported");
                    break;
            }
            Console.ReadKey();
        }
    }
}
