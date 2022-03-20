using UnityEngine;

public class StatsController : MonoBehaviour
{
    public float Health;

    Rigidbody2D rgBody;
    GameController Game;

    // Start is called before the first frame update
    void Start()
    {
        rgBody = GetComponent<Rigidbody2D> ();
        Game = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController> ();
    }

    // Update is called once per frame
    void Update()
    {  
        if(Health == 0){
            rgBody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    public void Reset(){
        Health = 1;
        transform.position = new Vector2(0, 0);
        rgBody.constraints = ~RigidbodyConstraints2D.FreezeAll;
    }

    public void Death(){
        Health = 0;
    }

    void OnTriggerEnter2D(Collider2D trig){
        if(trig.gameObject.CompareTag("InstantDeath")){
            Death();
            Game.isGameRunning = false;
            Game.OpenUI();
        }
    }
}
