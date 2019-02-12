using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : LogicalElement
{
    private TextMesh[] text;

    private bool isHeight = false;

    public byte Frequency = 1;

    protected override void Awake()
    {
        base.Awake();
        text = GetComponentsInChildren<TextMesh>();
        StartCoroutine(OnUpdate());
    }

    IEnumerator OnUpdate()
    {
        while(true)
        {
            isHeight = !isHeight;

            text[0].text = "F:" + Frequency;
            text[1].text = isHeight ? "1" : "0";

            for (int i = 0; i < outPoints.Length; i++)
            {
                outPoints[i].value = (byte)(isHeight ? 1 : 0);
            }

            yield return new WaitForSeconds(1.0f / Frequency);
        }
    }
}
