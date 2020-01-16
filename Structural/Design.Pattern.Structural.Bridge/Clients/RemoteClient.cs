using System;
using Design.Patterns.Structural.Bridge.Abstracts;

namespace Design.Patterns.Structural.Bridge.Clients
{
    public class RemoteClient
    {
        public void PerformRemoteCommand(RemoteControl remoteControl)
        {
            remoteControl.TogglePower();
            remoteControl.ChannelUp();
            remoteControl.ChannelUp();
            remoteControl.ChannelDown();
            remoteControl.VolumeUp();
            remoteControl.VolumeUp();
            remoteControl.VolumeDown();
            remoteControl.Mute();
            remoteControl.TogglePower();
        }
    }
}
