using UnityEngine;

public class MovementController : MonoBehaviour
{
    public float Speed;
    public float JumpHeight;
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
    }

    void Movement(){
        float Horizontal = Input.GetAxis("Horizontal");

        //Movement
        rgBody.velocity = new Vector3(Horizontal * Time.deltaTime * Speed, 0, 0);

        //Jump
        OnTheGround = Physics2D.OverlapCircle(GroundTester.position, 0.6f, LayerToTest);

        if(Input.GetKey(KeyCode.Space) && OnTheGround){
            rgBody.AddForce(new Vector2(0, JumpHeight));
        }
    }
}
