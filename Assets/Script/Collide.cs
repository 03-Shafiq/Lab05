using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{
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
