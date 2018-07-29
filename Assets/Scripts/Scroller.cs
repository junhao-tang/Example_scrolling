using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {
    Vector2 startingVec;
    public float scrollingSpeed;

	// Use this for initialization
	void Start () {
        startingVec = GetComponent<Renderer>().material.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 updated = new Vector2(startingVec.x, Time.time * scrollingSpeed % 1); // 1 tile long
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", updated);
	}
}
