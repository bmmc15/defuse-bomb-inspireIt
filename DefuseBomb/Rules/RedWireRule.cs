namespace Rules
{
    public class RedWireRule : IWireRule
    {
        public bool CanCutWire(string wire)
        {
            if (wire == "Green")
                return true;
            else
                return false;
        }
    }
}
