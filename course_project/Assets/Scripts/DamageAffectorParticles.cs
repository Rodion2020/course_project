using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DamageAffectorParticles : MonoBehaviour
{
    public string TagDamage = "Enemy";
    public float DamageAmount = 2f;
    private Health ThisHealth = null;
    
    public int ScoreValue = 1;
    
    void Awake()
    {
        ThisHealth = GetComponent<Health>();
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag(TagDamage))
        {
            ThisHealth.HealthPoints -= DamageAmount;
            if (ThisHealth.HealthPoints == 10)
            {
                GameController.Score += ScoreValue;
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
