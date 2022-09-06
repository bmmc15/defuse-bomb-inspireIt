namespace Rules
{
    public class WhiteWireRule : IWireRule
    {
        public bool CanCutWire(string wire)
        {
            if (wire == "White" || wire == "Black")
                return false;
            else
                return true;
        }
    }
}
