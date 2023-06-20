using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _HealthPoints = 100f;
    
    public float HealthPoints
    {
        get
        {
            return _HealthPoints;
        }

        set
        {
            _HealthPoints = value;
            if (HealthPoints <= 0)
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
