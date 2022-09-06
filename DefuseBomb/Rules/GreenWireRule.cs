namespace Rules
{
    public class GreenWireRule : IWireRule
    {
        public bool CanCutWire(string wire)
        {
            if (wire == "Orange" || wire == "White")
                return true;
            else
                return false;
        }
    }
}
