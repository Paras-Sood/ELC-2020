using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Camera.main.transform.forward * Time.deltaTime * speed;
    }
}
