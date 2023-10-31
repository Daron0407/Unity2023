using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    private new Camera camera;
    public Color startingColor;
    public Color endColor;

    public float progress = 0f;
    public float rate = 0.1f;

    private void Start()
    {
        camera = GetComponent<Camera>();
    }

    void Update()
    {
        if(progress > 1f)
        {
            progress = 1f;
            rate *= -1f;
        }
        if(progress < 0f)
        {
            progress = 0f;
            rate *= -1f;
        }
        camera.backgroundColor = Color.Lerp(startingColor, endColor, progress);
        progress += Time.deltaTime * rate;
    }
}
