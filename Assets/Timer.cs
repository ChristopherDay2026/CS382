using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public basket basket; 
    public int gameDuration = 30;
    public TextMeshProUGUI timerText;
    public GameObject gameOverScreen;

    void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
    IEnumerator CountdownTimer()
    {
        for(int i = gameDuration; i > 0; i--)
        {
            gameDuration = i;


            timerText.text = gameDuration.ToString();
            yield return new WaitForSeconds(1);
        }
        GameOver();
    }

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(CountdownTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

