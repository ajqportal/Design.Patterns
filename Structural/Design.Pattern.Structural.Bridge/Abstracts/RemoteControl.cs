using System;
using Design.Pattern.Structural.Bridge.Interfaces;

namespace Design.Pattern.Structural.Bridge.Abstracts
{
    public class RemoteControl
    {
        protected readonly IDevices _devices;

        public RemoteControl(IDevices devices)
        {
            _devices = devices;
        }

        public virtual void TogglePower()
        {
            if (_devices.IsEnabled())
            {
                _devices.Disabled();
                Console.WriteLine("Your device is turned off.");
            }
            else
            {
                _devices.Enabled();
                Console.WriteLine("Your device is turned on.");
            }
        }

        public virtual void VolumeUp()
        {
            _devices.SetVolume(_devices.GetVolume() + 10);
            Console.WriteLine($"Your device volume is now {_devices.GetVolume()}");
        }

        public virtual void VolumeDown()
        {
            _devices.SetVolume(_devices.GetVolume() - 10);
            Console.WriteLine($"Your device volume is now {_devices.GetVolume()}");
        }

        public virtual void ChannelUp()
        {
            _devices.SetChannel(_devices.GetChannel() + 1);
            Console.WriteLine($"Your device selected a channel {_devices.GetChannel()}");
        }

        public virtual void ChannelDown()
        {
            _devices.SetChannel(_devices.GetChannel() - 1);
            Console.WriteLine($"Your device selected a channel {_devices.GetChannel()}");
        }

        public virtual void Mute() => _devices.SetVolume(0);
    }
}
