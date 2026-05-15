using UnityEngine;
using TMPro;

public class ScoreCard : MonoBehaviour
{
    public TextMeshProUGUI ScoreCardText;

    private int Score = 0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreCardText.text = "Score:0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        Score += 10;
        ScoreCardText.text = "Score: " + Score;
    }
}
