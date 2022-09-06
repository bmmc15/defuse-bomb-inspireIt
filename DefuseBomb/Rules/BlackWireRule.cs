namespace Rules
{
    public class BlackWireRule : IWireRule
    {
        public bool CanCutWire(string wire)
        {
            if (wire == "White" || wire == "Green" || wire == "Orange")
                return false;
            else
                return true;
        }
    }
}
