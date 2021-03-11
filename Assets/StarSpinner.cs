using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpinner : MonoBehaviour
{
    // Start is called before the first frame update
    //adjust this to change speed
    float speed = 2f;
    //adjust this to change how high it goes
    float height = 0.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0f, 0.2f, 0.0f));
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed);
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(pos.x, newY + 5, pos.z);
    }
}
