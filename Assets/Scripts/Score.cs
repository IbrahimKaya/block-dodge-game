using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int score=0;
    private int scoreTemp = 0;

    public Text scoreText;
    public Text highScoreText;

    private void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
  
    // Update is called once per frame
    void FixedUpdate ()
    {
        score = scoreTemp / 4;
        scoreText.text = score.ToString();
	}

    public void ScoreCounting()
    {
        this.scoreTemp = this.scoreTemp + 1;
    }

    public void HingScoreSetter()
    {
        if (score > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScoreText.text = "0";
    }
}
