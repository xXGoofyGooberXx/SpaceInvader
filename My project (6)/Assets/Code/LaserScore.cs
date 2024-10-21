using UnityEngine;
using UnityEngine.SceneManagement;

public class LaserScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Invader1"))
        {
         
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(10); 
            }

           
            Destroy(collision.gameObject); 
            Destroy(gameObject); 
        }

        if (collision.CompareTag("Invader2"))
        {

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(20);
            }


            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.CompareTag("Invader3"))
        {

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(30);
            }


            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.CompareTag("MysteryShip"))
        {
           
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(50);
            }


            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
