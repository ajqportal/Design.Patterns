using Design.Patterns.Structural.Bridge.Abstracts;
using Design.Patterns.Structural.Bridge.Clients;
using Design.Patterns.Structural.Bridge.Models;

namespace Design.Patterns.Structural.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RemoteClient();
            RemoteControl remoteControl;
            remoteControl = new RemoteControl(new Television());
            client.PerformRemoteCommand(remoteControl);
        }
    }
}
