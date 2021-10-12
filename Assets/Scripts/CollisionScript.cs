using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public int score;
    public Text Score;
    public Text Timetxt;
    private float time = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        Score.text = "Score: " + score;

        Timetxt.text = "Time: " + time;
        if (time <= 0 && score != 60)
        {
            SceneManager.LoadScene("Lose");
        }

        if (score == 60 && time > 0)
        {
            SceneManager.LoadScene("Win");
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "coins")
        {
            score += 10;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "water")
        {
            SceneManager.LoadScene("Lose");
        }
    }

}

