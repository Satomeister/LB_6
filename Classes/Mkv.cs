using System;
using System.Collections.Generic;
using System.Text;
using LB_6.Intefaces;

namespace LB_6.Classes
{
    class Mkv : IPlayable
    {
        public PlayerItem ChosenItem { get; set; }
        public Mkv(PlayerItem chosen)
        {
            ChosenItem = chosen;
        }
        public void Pause()
        {
            Console.WriteLine($"{ChosenItem.Name} pause()");
        }

        public void Play()
        {
            Console.WriteLine($"{ChosenItem.Name} play()");
        }

        public void Stop()
        {
            Console.WriteLine($"{ChosenItem.Name} stop()");
        }
    }
}
