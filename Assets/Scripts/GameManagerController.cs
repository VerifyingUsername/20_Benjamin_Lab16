using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerController : MonoBehaviour
{
    public GameObject spaceCounterGO;
    public GameObject ScoreCounter;

    public int iCounter = 0;
    public int Score = 0;

    public static GameManagerController instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
