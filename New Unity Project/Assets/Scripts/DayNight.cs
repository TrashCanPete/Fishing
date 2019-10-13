using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DayNight : MonoBehaviour
{
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This line rotates the directional light to 70 degrees and back to 0 .
        transform.rotation = Quaternion.Euler(Mathf.PingPong(Time.time * 2, 70), transform.eulerAngles.y, transform.eulerAngles.z);
       
    }
}
