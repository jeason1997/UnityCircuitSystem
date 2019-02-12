using UnityEngine;

public class NandLogicalElement : LogicalElement
{
    protected override void ValueSet()
    {
        bool height = false;

        var i0 = inPoints[0].In != null ? inPoints[0].In.value : 0;
        var i1 = inPoints[1].In != null ? inPoints[1].In.value : 0;

        height = i0 == 1 && i1 == 1;

        if (inPoints.Length > 2)
        {
            var i2 = inPoints[2].In != null ? inPoints[2].In.value : 0;
            height = height && i2 == 1;
        }

        outPoints[0].value = (byte)(height ? 0 : 1);
    }
}
