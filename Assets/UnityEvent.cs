

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UnityEvent : MonoBehaviour
{
    private int _clickcount;
    
    public void OnClick()
    {
        _clickcount++;
        GetComponent<Text>().text = "Click Counter:" + _clickcount;
        
    }
}
