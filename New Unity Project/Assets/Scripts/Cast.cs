using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cast : MonoBehaviour
{

    public bool castAnimation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (castAnimation == true)
        {
            GetComponent<Animation>().Play("Me_Cast_Animation");
        }
        if (Input.GetButtonDown("Space"))
        {
            castAnimation = true;
        }
    }
}
