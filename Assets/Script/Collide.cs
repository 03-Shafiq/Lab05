using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{
    private float scorevalue;

    public float totalcoins;

    public float timeleft;

    public int timeRemaining;

    public Text ScoreText;
    public Text TimerText;

    private float TimerValue;

    int score;
    public Rigidbody PlayerRigidbody;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeleft % 60);
        TimerText.text = "Timer : " + timeRemaining.ToString();
        if (scorevalue == totalcoins)
        {
            if (timeleft <= TimerValue)
            {
                SceneManager.LoadScene("GameWin");
            }
            else if (timeleft <= 0)
            {
                SceneManager.LoadScene("GameLose");
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {

            score += 10;
            Destroy(other.gameObject);

            Text.GetComponent<Text>().text = "Score : " + score;
        }
        if (other.gameObject.tag == "water")
        {

            SceneManager.LoadScene("GameLose");



        }


    }
}
