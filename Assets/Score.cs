using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int score=0;
    private int scoreTemp = 0;

    public Text scoreText;

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
}
