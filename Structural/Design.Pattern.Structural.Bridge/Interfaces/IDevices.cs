namespace Design.Pattern.Structural.Bridge.Interfaces
{
    public interface IDevices
    {
        bool IsEnabled();
        void Enabled();
        void Disabled();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
    }
}
