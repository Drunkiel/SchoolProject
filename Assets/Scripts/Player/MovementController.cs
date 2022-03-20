using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public bool OnTheGround;

    public Transform GroundTester;
    public LayerMask LayerToTest;
    
    Rigidbody2D rgBody;

    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        JumpRotate();
    }

    void Update(){
        
    }

    void Movement(){
        //Movement
        float Horizontal = Input.GetAxis("Horizontal");

        rgBody.velocity = new Vector3(Horizontal * Time.deltaTime * Speed, 0, 0);

        //Jump
        OnTheGround = Physics2D.OverlapCircle(GroundTester.position, 0.6f, LayerToTest);

        if(Input.GetKey(KeyCode.Space) && OnTheGround){
            rgBody.velocity = Vector2.up * JumpForce;
        }
    }

    void JumpRotate(){
        if(!OnTheGround){
            transform.Rotate(new Vector3(0, 0, Time.deltaTime * -Speed)); 
        }   else{
            transform.rotation = Quaternion.identity;
        }
    }
}
