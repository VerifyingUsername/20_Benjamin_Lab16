using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            GameManagerController.instance.Score++;
            GameManagerController.instance.ScoreCounter.GetComponent<Text>().text = "Score: " + GameManagerController.instance.Score;
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
