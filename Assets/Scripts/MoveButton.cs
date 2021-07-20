using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// needs to be aware of:
// - whether it's available to be selected
// - if selected, what value does it have?
public class MoveButton : MonoBehaviour
{
    [SerializeField]
    private Color text_color, highlight_text_color, background_color;
    string selected_value;
    void Awake()
    {
        Reset();
    }

    public void Reset()
    {
        selected_value = "";
    }
}
