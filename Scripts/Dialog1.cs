using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialog1 : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

   // public GameObject continueButton;
    public AudioSource audioSource;

    void Start()
    {
        StartCoroutine(Type());
  
       
    }

    void Update()
    {

        if (textDisplay.text == sentences[index]) {
       //     continueButton.SetActive(true);

            NextSentence();

        }    
    }

    IEnumerator Type() {

        foreach (char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        
        }
        
    }

    public void NextSentence() {

       // continueButton.SetActive(false);
        audioSource.Play();
        if (index < sentences.Length - 1)
        {
            
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        
        }
        else {
            textDisplay.text = "";
            SceneManager.LoadScene("FirstScene");
        }
    
    }
    

}
