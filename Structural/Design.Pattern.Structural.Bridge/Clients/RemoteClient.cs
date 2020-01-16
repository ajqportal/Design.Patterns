using System;
using Design.Pattern.Structural.Bridge.Abstracts;

namespace Design.Pattern.Structural.Bridge.Clients
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
