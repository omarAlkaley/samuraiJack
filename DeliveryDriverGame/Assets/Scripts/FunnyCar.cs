
// this is called a namespace, this is here to help me use The MonoBehaviour
using UnityEngine;
//this is just a box for storing some data
public class FunnyCar : MonoBehaviour
{
    [SerializeField] int omarSpeed = 100;
    [SerializeField] int steerSpeed = 80;
    [SerializeField] Color color;
    [SerializeField] string type = "lamborgini";
    // this thing occurrs only one time
    void Start()
    {

    }

    //This thing occurrs all time
    void Update()
    {
        MoveCarForwardAndBackward();
        Turn();
    }
    void MoveCarForwardAndBackward()
    {
        transform.Translate(new Vector3(0,Input.GetAxis("Vertical"),0)*omarSpeed*Time.deltaTime);
    }
    void Turn()
    {
        transform.Rotate(new Vector3(0, 0, Input.GetAxis("Horizontal"))*-1*steerSpeed*Time.deltaTime);
    }
}
