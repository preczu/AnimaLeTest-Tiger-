using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private Text scoreText;

    private int score = 0;
    private int mistakes = 0;

    public GameObject fruitSpawner;
    public GameObject plane;
    public GameObject foodImage;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text> ();
        scoreText.text = "0";
        plane.SetActive(false);
    }

    void OnTriggerEnter( Collider target)
    {
        if ( target.tag == "Icecream" || target.tag == "Lollipop" || target.tag == "Donut" ||
            ((target.tag == "Plants" || target.tag == "Carrot" || target.tag == "Bananas" || target.tag == "Meat") && PlayerPrefs.GetString("animal").Equals("cat")) ||
            ((target.tag == "Sardine" || target.tag == "Carrot" || target.tag == "Bananas" || target.tag == "Meat") && ((PlayerPrefs.GetString("animal").Equals("giraffe")) || (PlayerPrefs.GetString("animal").Equals("elephant")))) ||
            ((target.tag == "Plants" || target.tag == "Sardine" || target.tag == "Bananas" || target.tag == "Meat") && PlayerPrefs.GetString("animal").Equals("pig")) ||
            ((target.tag == "Plants" || target.tag == "Carrot" || target.tag == "Sardine" || target.tag == "Meat") && PlayerPrefs.GetString("animal").Equals("monkey")) ||
            ((target.tag == "Plants" || target.tag == "Carrot" || target.tag == "Sardine" || target.tag == "Bananas") && PlayerPrefs.GetString("animal").Equals("tiger"))) {
            target.gameObject.SetActive(false);
            mistakes++;

            if (mistakes == 1)
            {
                Heart3.SetActive(false);
            }
            else if (mistakes == 2)
            {
                Heart2.SetActive(false);
            }
            else if(mistakes >= 3)
            {
                Heart1.SetActive(false);
                setResumeScreen();
                //StartCoroutine(RestartGame());
            }
		}
        else if ((target.tag == "Sardine" && PlayerPrefs.GetString("animal").Equals("cat")) || 
            (target.tag == "Plants" && PlayerPrefs.GetString("animal").Equals("giraffe")) || 
            (target.tag == "Plants" && PlayerPrefs.GetString("animal").Equals("elephant")) || 
            (target.tag == "Carrot" && PlayerPrefs.GetString("animal").Equals("pig")) ||
            (target.tag == "Bananas" && PlayerPrefs.GetString("animal").Equals("monkey")) ||
            (target.tag == "Meat" && PlayerPrefs.GetString("animal").Equals("tiger"))) {
            target.gameObject.SetActive (false);
            score++;
            scoreText.text = score.ToString();
            if (score >= 10)
            {
                setResumeScreen();
            }
		}
    }

    IEnumerator RestartGame() {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

    public void restartOnClick()
    {
        StartCoroutine(RestartGame());
    }

    public void exitOnClick()
    {
        Application.Quit();
    }

    void setResumeScreen()
    {
        fruitSpawner.SetActive(false);
        foodImage.SetActive(false);
        plane.SetActive(true);
    }
}
