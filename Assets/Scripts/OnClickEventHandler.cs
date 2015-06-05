using UnityEngine;
using System.Collections;

public class OnClickEventHandler : MonoBehaviour {

    //Event Handler
    public delegate void OnClickEvent();
    public static event OnClickEvent OnClickLeft;
    public static event OnClickEvent OnClickRight;

    public static void ClickLeft()
    {
        if (OnClickLeft != null)
            OnClickLeft();
    }

    public static void ClickRight()
    {
        if (OnClickRight != null)
            OnClickRight();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            OnClickLeft();

        if (Input.GetMouseButtonDown(1))
            OnClickRight();
    }
}
