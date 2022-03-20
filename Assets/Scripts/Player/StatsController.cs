using UnityEngine;

public class StatsController : MonoBehaviour
{
    public float Health;

    Rigidbody2D rgBody;

    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Health == 0){
            rgBody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    public void Death(){
        Health = 0;
    }
}
