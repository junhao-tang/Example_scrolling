using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stripbackgroundmover : MonoBehaviour {

    Vector2 startingVec;
    Vector3 startingPos;

    public float scrollingSpeed;
    float maxY;

    // Use this for initialization
    void Start()
    {
        startingVec = GetComponent<Renderer>().material.GetTextureOffset("_MainTex");
        startingPos = transform.position;
        maxY = transform.localScale.y; // quad is always 1 unit with scale
    }

    // Update is called once per frame
    void Update()
    {
        float newPosition = Time.time * scrollingSpeed;
        float offsetX = Mathf.Floor(newPosition / maxY) * 0.25f;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(startingVec.x + offsetX, startingVec.y));
        transform.position = startingPos + Vector3.back * (newPosition % maxY);
        (transform.GetChild(0).gameObject).GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(startingVec.x + offsetX, startingVec.y));
    }
}
