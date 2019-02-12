using UnityEngine;

public class LogicState : LogicalElement
{
    private bool pressed = false;

    private TextMesh text;

    protected override void Awake()
    {
        text = GetComponentInChildren<TextMesh>();
        base.Awake();
    }

    private void OnMouseDown()
    {
        pressed = !pressed;

        for (int i = 0; i < outPoints.Length; i++)
        {
            outPoints[i].value = (byte)(pressed ? 1 : 0);
        }

        text.text = pressed ? "1" : "0";
    }
}
