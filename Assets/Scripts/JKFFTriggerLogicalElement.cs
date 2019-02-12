public class JKFFTriggerLogicalElement : LogicalElement
{
    private byte lastC = byte.MaxValue;

    protected override void ValueSet()
    {
        byte j = inPoints[0].In != null ? inPoints[0].In.value : (byte)0;
        byte c = inPoints[1].In != null ? inPoints[1].In.value : (byte)0;
        byte k = inPoints[2].In != null ? inPoints[2].In.value : (byte)0;


        if (j == 1 && k == 0)
        {
            if (c != lastC && c == 1)
                outPoints[0].value = 1;
        }
        else if (j == 0 && k == 1)
        {
            if (c != lastC && c == 1)
                outPoints[0].value = 0;
        }
        else if (j == 1 && k == 1)
        {
            if (c != lastC && c == 1)
                outPoints[0].value = outPoints[0].value == 1 ? (byte)0 : (byte)1;
        }
        else
        {
            //keep
        }

        lastC = c;
        
        outPoints[1].value = outPoints[0].value == 1 ? (byte)0 : (byte)1;
    }
}
