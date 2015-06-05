using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

    public Vector2 startPos = Vector2.zero;
    public List<Vector2> playerPos = new List<Vector2>();

    int current;

	// Use this for initialization
	void Start () {
        OnClickEventHandler.OnClickRight += OnClickEventHandler_OnClickRight;

        current = 1;
        transform.position = startPos;
	}

    private void OnDisable()
    {
        OnClickEventHandler.OnClickRight -= OnClickEventHandler_OnClickRight;
    }

    private void OnClickEventHandler_OnClickRight()
    {
        transform.position = playerPos[++current % playerPos.Count];
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
