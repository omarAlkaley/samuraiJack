
// this is called a namespace, this is here to help me use The MonoBehaviour
using UnityEngine;
//this is just a box for storing some data
public class FunnyCar : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] int score = 0;
    [SerializeField] Animator anime;
    [SerializeField] int omarSpeed = 100;
    [SerializeField] int steerSpeed = 80;
    [SerializeField] Color color;
    [SerializeField] string type = "lamborgini";
    [SerializeField] Rigidbody2D rigidBody;
    [SerializeField] bool isPressingTab=true;
    // this thing occurrs only one time
    void Start()
    {
        rigidBody =this.gameObject.GetComponent<Rigidbody2D>();
        anime = this.gameObject.GetComponent<Animator>();
    }

    //This thing occurrs all time
    void FixedUpdate()
    {
        MoveCarForwardAndBackward();
        Turn();
    }
    void Update(){
        if(Input.GetAxis("Vertical")>0 || Input.GetAxis("Vertical") < 0)
        {
            Debug.Log("PlayParticalSystem");
            if(!particleSystem.isPlaying)
            particleSystem.Play();
        }
        else
        {
            Debug.Log("StopParticalSystem");
            if (particleSystem.isPlaying)
                particleSystem.Stop();
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            anime.SetBool("isChangingColor",isPressingTab);
            isPressingTab = !isPressingTab;
        }
    }
    void MoveCarForwardAndBackward()
    {
        //transform.Translate(new Vector3(0,Input.GetAxis("Vertical"),0)*omarSpeed*Time.deltaTime);
        rigidBody.MovePosition(rigidBody.position+(Vector2)transform.up * Input.GetAxis("Vertical")*omarSpeed*Time.fixedDeltaTime);
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            omarSpeed=5;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift)){
            omarSpeed=2;
        }
    }
    void Turn()
    {
        rigidBody.SetRotation(Quaternion.Euler(0,0,rigidBody.rotation+Input.GetAxis("Horizontal")*-1*steerSpeed*Time.fixedDeltaTime));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CollectableCar")
        {
            score = score + 1;
            Destroy(collision.gameObject);
        }
    }
}
