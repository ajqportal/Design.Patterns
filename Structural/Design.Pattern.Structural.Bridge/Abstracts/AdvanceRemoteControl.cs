using System;
using Design.Pattern.Structural.Bridge.Interfaces;

namespace Design.Pattern.Structural.Bridge.Abstracts
{
    public class AdvanceRemoteControl : RemoteControl
    {
        protected AdvanceRemoteControl(IDevices devices) : base(devices)
        {
        }

        public override void Mute()
        {
            _devices.SetVolume(0);
            Console.WriteLine("Your device is muted.");
        }
    }
}
