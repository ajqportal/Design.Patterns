using Design.Pattern.Structural.Bridge.Abstracts;
using Design.Pattern.Structural.Bridge.Clients;
using Design.Pattern.Structural.Bridge.Models;

namespace Design.Pattern.Structural.Bridge
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
