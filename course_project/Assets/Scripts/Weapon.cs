using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private ParticleSystem PS;

    void Awake()
    {
        PS = GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Fire1"))
        {
            PS.Play();
        }
        else if ( Input.GetButtonUp("Fire1"))
        {
            PS.Stop();
        }
    }
}
