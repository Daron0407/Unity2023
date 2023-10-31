using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    private Color start;
    private float fadeInTime = 1f;
    private float progress = 0f;
    private MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        start = mr.material.color;
        start.a = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime/fadeInTime;
        start.a = progress < 1f ? progress : 1f;
        GetComponent<MeshRenderer>().material.color = start;
        if(progress > 1f)
        {
            this.enabled = false;
        }
    }
}
