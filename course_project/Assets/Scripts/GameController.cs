using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using UnityEngine.Text;
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController ThisInstance = null;

    public static int Score = -20;
    public string ScorePrefix = string.Empty;
    public Text ScoreText = null;
    public Text GameOverText = null;
    public GameObject canvas;
    void Awake()
    {
        ThisInstance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreText != null)
        {
            ScoreText.text = ScorePrefix +Score.ToString();
        }
        if (Score > 0)
        {
            canvas.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }


    }
    public static void GameOver()
    {
        if (ThisInstance.GameOverText != null)
        {
            ThisInstance.GameOverText.gameObject.SetActive(true);
        }
    }

}
