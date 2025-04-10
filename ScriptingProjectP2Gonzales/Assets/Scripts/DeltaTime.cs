using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    public float speed = 8f;
    public float countdown = 3.0f;


    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0.0f)
            GetComponent<Light>().enabled = false;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);       
    }
}
