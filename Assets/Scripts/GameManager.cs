using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    public List<Color32> colors = new List<Color32>();

    int current = 0;
    private Camera main;

	// Use this for initialization
	void Start () {
	    OnClickEventHandler.OnClickLeft += this.OnClickEventHandler_OnClick;

        main = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	}

    void OnDisable()
    {
        OnClickEventHandler.OnClickLeft += this.OnClickEventHandler_OnClick;
    }

    private void OnClickEventHandler_OnClick()
    {
        //main.backgroundColor = colors[Random.Range(0, colors.Count)];
        main.backgroundColor = colors[++current % colors.Count];
    }

	// Update is called once per frame
	void Update () {
	
	}
}
