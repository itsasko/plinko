using TMPro;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score_counter = 0;
    void Start()
    {
        scoreText = GameObject.Find("Score_text").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if((this.GetComponent<SpriteRenderer>().sprite.name == "green_target" && collision.gameObject.GetComponent<SpriteRenderer>().sprite.name == "green_ball") ||
            (this.GetComponent<SpriteRenderer>().sprite.name == "cyan_target" && collision.gameObject.GetComponent<SpriteRenderer>().sprite.name == "cyan_ball") ||
            (this.GetComponent<SpriteRenderer>().sprite.name == "blue_target" && collision.gameObject.GetComponent<SpriteRenderer>().sprite.name == "blue_ball") )
        {
            score_counter = int.Parse(scoreText.text);
            score_counter++;
            scoreText.text = score_counter.ToString();
        }
            
        
        Destroy(collision.gameObject);
    }
}
