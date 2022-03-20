using UnityEngine;
using UnityEngine.UI;

public class ScoreMeter : MonoBehaviour
{
    public float Score;
    public float Record;
    private bool isGameRunning;

    public Text ScoreText;
    GameController Game;

    void Start(){
        Game = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController> ();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
        isGameRunning = Game.isGameRunning;

        if(isGameRunning){
            StartScore();
        }   else{
            StopScore();
        }
    }

    public void StartScore(){
        Score += Time.deltaTime * 2;
        Score = Mathf.Round(Score * 100) / 100;
    }

    public void StopScore(){
        if(Record < Score){
            Record = Score;
        }
        Score = 0;
    }
}
