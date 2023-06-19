using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerContoller : MonoBehaviour
{
    public float MovementSpeed = 3f;
    public GameObject SleepCanvas = null;
    private Transform SleepArea;
    public string SleepTag = "Sleep";
    public float Distance = 1f;
    private void Awake()
    {
        
        SleepArea = GameObject.FindGameObjectWithTag(SleepTag).transform;

    }

    //public void Sleep()
    //{
        
    //}





    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        Vector3 translation = new Vector3(horiz, 0, vert);
        translation *= MovementSpeed * Time.deltaTime;
        transform.Translate(translation);


        if (Vector3.Distance(SleepArea.position, transform.position) <= Distance)
        {
            if (Input.GetKey(KeyCode.E))
            {
                SleepCanvas.SetActive(true);
                Time.timeScale = 0f;

            }

            else if (Input.GetKey(KeyCode.Q))
            {
                SleepCanvas.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }
}
