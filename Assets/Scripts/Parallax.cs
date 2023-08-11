using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startPos;
    [SerializeField] new GameObject camera;
    [SerializeField] float parallax;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float temp = (camera.transform.position.x * (1 - parallax));
        float distance = (camera.transform.position.x * parallax);
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        if (temp > startPos + length) {
            startPos += length;
        }
        else if (temp < startPos - length) {
            startPos-= length;
        }
    }
}
