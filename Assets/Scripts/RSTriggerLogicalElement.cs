public class RSTriggerLogicalElement : LogicalElement
{
    protected override void ValueSet()
    {
        byte set = inPoints[0].In != null ? inPoints[0].In.value : (byte)0;
        byte reset = inPoints[1].In != null ? inPoints[1].In.value : (byte)0;

        if (set == 1)
        {
            outPoints[1].value = 1;
        }
        else if (reset == 1)
        {
            outPoints[1].value = 0;
        }

        outPoints[0].value = outPoints[1].value == 1 ? (byte)0 : (byte)1;
    }
}
