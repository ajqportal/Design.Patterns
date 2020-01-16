using System;
using Design.Pattern.Structural.Bridge.Interfaces;

namespace Design.Pattern.Structural.Bridge.Models
{
    public class Television: IDevices
    {
        public bool IsEnabled() => true;

        public void Enabled() => Console.WriteLine("You device is now enabled.");

        public void Disabled() => Console.WriteLine("Your device is now disabled.");

        public int GetVolume() => +10;

        public void SetVolume(int volume) => Console.WriteLine($"Volume is increased to {volume}");

        public int GetChannel() => +1;

        public void SetChannel(int channel) => Console.WriteLine($"Channel is increased to {channel}");
    }
}
