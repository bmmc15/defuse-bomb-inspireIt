namespace Rules
{
    public class PurpleWireRule : IWireRule
    {
        public bool CanCutWire(string wire)
        {
            if (wire == "Purple" || wire == "Green" || wire == "Orange" || wire == "White")
                return false;
            else
                return true;
        }
    }
}
