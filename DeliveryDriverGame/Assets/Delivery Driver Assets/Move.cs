using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // For my friend abdelsalam this thing occurrs only one time
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, 3*Time.deltaTime);
        Destroy(this.gameObject, 3);
    }
    
}
