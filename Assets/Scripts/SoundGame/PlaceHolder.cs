using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlaceHolder : MonoBehaviour
{
    public GameObject[] animals;
    public GameObject[] placeholders;
    public Button[] buttons;
    public Image soundButtonImage;
    public Image finishBckg;

    public Sprite green;
    public Sprite red;

    public GameObject brownPlane;
    public Animator soundAnim;
    public Animator bckgAnim;

    public AudioSource[] sounds;

    private string correctTag;
    private bool isFirst = false;
    private AudioSource source;

    private void Awake()
    {
        finishBckg.gameObject.SetActive(false);
        animalsShuffle(animals);
        setAnimals(animals);
        setAnswer(animals);
        brownPlane.SetActive(true);
    }

    public void soundButtonClicked()
    {
        StartCoroutine(waitForSound());
    }

    IEnumerator waitForSound()
    {        
        for (int i = 0; i < sounds.Length; i++)
        {
            if (correctTag == sounds[i].tag)
            {
                source = sounds[i];
                sounds[i].Play();
            }
        }
        if (isFirst == false)
        {
            yield return new WaitForSecondsRealtime(1.3f);
                soundAnim.SetBool("open", true);
                bckgAnim.SetBool("open", true);
                isFirst = true;
        }
    }

    private GameObject[] animalsShuffle(GameObject[] animalsArray)
    {
        for (int i = 0; i < animalsArray.Length; i++)
        {
            GameObject temp = animalsArray[i];
            int randomIndex = Random.Range(i, animalsArray.Length);
            animalsArray[i] = animalsArray[randomIndex];
            animalsArray[randomIndex] = temp;
        }
        return animalsArray;
    }
    private void setAnimals(GameObject[] animalsArray)
    {
        for (int i = 0; i < placeholders.Length; i++)
        {
            Instantiate(animalsArray[i], placeholders[i].transform.position + animalsArray[i].transform.position, animalsArray[i].transform.rotation);
        }
    }

    private void setAnswer(GameObject[] animalsArray)
    {
        GameObject correct = animalsArray[Random.Range(0, placeholders.Length)];
        correctTag = correct.tag;
    }

    public void placeClicked()
    {
        checkTag(animals[0].tag, correctTag, 0);
    }
    public void place1Clicked()
    {
        checkTag(animals[1].tag, correctTag, 1);
    }
    public void place2Clicked()
    {
        checkTag(animals[2].tag, correctTag, 2);
    }
    public void place3Clicked()
    {
        checkTag(animals[3].tag, correctTag, 3);
    }

    private void checkTag(string placeTag, string correct, int num)
    {
        if (placeTag.Equals(correct))
        {
            buttons[num].image.sprite = green;
            StartCoroutine(finishScreen(2f));
        }
        else
        {
            buttons[num].image.sprite = red;
            StartCoroutine(finishScreen(3f));
        }
        highlightCorrectAnswer();
    }
    public void highlightCorrectAnswer()
    {
        for(int i = 0; i < placeholders.Length; i++)
        {
            if (animals[i].tag.Equals(correctTag))
            {
                buttons[i].image.sprite = green;
            }
            buttons[i].interactable = false;
        }
    }
    IEnumerator finishScreen(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        source.Stop();
        finishBckg.gameObject.SetActive(true);
    }

    public void startAgainButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void homeButton()
    {
        SceneManager.LoadScene("01 - StartScene");
    }
}