namespace Transmitter
{
    public class BuildStatusModel
    {
        private byte _flags;

        public byte Flags => _flags;
        public byte Index { get; set; }

        public BuildOutputKind OutputKind
        {
            get
            {
                return (BuildOutputKind)(_flags & 0b0000_1100);
            }
            set
            {
                _flags &= 0b1111_0011;
                _flags &= (byte)((byte)value >> 2);
            }
        }

        public BuildState State
        {
            get
            {
                return (BuildState)(_flags & 0b0000_0011);
            }
            set
            {
                _flags &= 0b1111_1100;
                _flags &= (byte)value;
            }
        }
    }
}