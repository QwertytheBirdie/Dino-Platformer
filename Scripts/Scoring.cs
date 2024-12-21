using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Scoring : MonoBehaviour
{
    public float score = 0;
  
    public int scoreMultiplier = 1;
   
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;

        UpdateScoreText();
        
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score:" + score.ToString();
    }
}
