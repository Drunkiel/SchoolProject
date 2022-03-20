using UnityEngine;

public class FollowWall : MonoBehaviour
{
    public float Speed;
    private bool isGameRunning;

    GameController Game;

    void Start(){
        Game = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController> ();
    }

    // Update is called once per frame
    void Update()
    {
        isGameRunning = Game.isGameRunning;
        
        if(isGameRunning){
            MoveWall();   
        }   
    }

    void MoveWall(){
        transform.Translate(new Vector2(Time.deltaTime * Speed, 0));
    }

    public void Reset(){
        transform.position = new Vector3(-14, 3.6728f, 0);
    }
}