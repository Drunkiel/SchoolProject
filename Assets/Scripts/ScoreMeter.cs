using UnityEngine;
using UnityEngine.UI;

public class ScoreMeter : MonoBehaviour
{
    public float Score;
    public float Record;
    public bool isGameRunning;

    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();

        if(isGameRunning){
            StartScore();
        }   else{
            StopScore();
        }
    }

    void StartScore(){
        Score += Time.deltaTime * 2;
        Score = Mathf.Round(Score * 100) / 100;
    }

    void StopScore(){
        if(Record < Score){
            Record = Score;
        }
        Score = 0;
    }
}
