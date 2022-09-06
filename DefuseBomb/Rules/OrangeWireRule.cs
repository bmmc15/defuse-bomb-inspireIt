namespace Rules
{
    public class OrangeWireRule : IWireRule
    {
        public bool CanCutWire(string wire)
        {
            if (wire == "Red" || wire == "Black")
                return true;
            else
                return false;
        }
    }
}
