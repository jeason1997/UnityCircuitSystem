using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitalDisplay : LogicalElement
{
    private TextMesh text;

    protected override void Awake()
    {
        text = GetComponentInChildren<TextMesh>();
        base.Awake();
    }

    protected override void ValueSet()
    {
        base.ValueSet();

        var v0 = inPoints[0].In == null ? 0 : inPoints[0].In.value;
        var v1 = inPoints[1].In == null ? 0 : inPoints[1].In.value;
        var v2 = inPoints[2].In == null ? 0 : inPoints[2].In.value;
        var v3 = inPoints[3].In == null ? 0 : inPoints[3].In.value;

        string str = v0.ToString() + v1.ToString() + v2.ToString() + v3.ToString();
        text.text = string.Format("{0:X}", System.Convert.ToInt32(str, 2)); ;
    }
}
