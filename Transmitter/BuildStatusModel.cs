namespace Transmitter
{
    public class BuildStatusModel
    {
        private byte _flags;

        public byte Index { get; set; }

        public byte Flags => _flags;
    }
}
