using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int ScoreValue = 1;

    void OnDestroy()
    {
        GameController.Score += ScoreValue;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
