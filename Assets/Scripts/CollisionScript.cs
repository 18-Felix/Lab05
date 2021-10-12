using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public int score;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + score;
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

