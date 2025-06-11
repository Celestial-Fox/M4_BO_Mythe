using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class dialoguebox : MonoBehaviour
{

    public DialogueSegment[] dialogueSegments;
    [Space]
    public Image Speakerfacedisplay;
    public Image Boxinner;
    public Image Boxouter;
    public Image faceplate;
    public Image nameplate;
    public Image Skipthing;
    public GameObject intro1;
    public GameObject intro2;
    public GameObject intro3;
    public GameObject intro4;
    public GameObject intro5;
    public GameObject intro6;
    [Space]
    public TextMeshProUGUI Speakername;
    public TextMeshProUGUI Dialoguebox;
    [Space]
    public float TextSpeed;

    private bool canskip;
    private int dialogueindex;


    // Start is called before the first frame update
    void Start()
    {
        Setstyle(dialogueSegments[0].speaker);
        StartCoroutine(PlayDialogue(dialogueSegments[0].dialogue));
    }

    // Update is called once per frame
    void Update()
    {
        Skipthing.enabled = canskip;
        if (Input.GetKeyDown(KeyCode.Space) && canskip)
        {
            dialogueindex++;
            if (dialogueindex==2)
            {                
                intro1.SetActive(false);
                intro2.SetActive(true);
            }
            if (dialogueindex==8)
            {
                intro2.SetActive(false);
                intro3.SetActive(true);
            }

            if (dialogueindex==13)
            {
                intro3.SetActive(false);
                intro4.SetActive(true);
            }

            if (dialogueindex==20)
            {
                intro4.SetActive(false);
                intro5.SetActive(true);
            }

            if (dialogueindex==23)
            {
                intro5.SetActive(false);
                intro6.SetActive(true);
            }

            if (dialogueindex== dialogueSegments.Length)
            {
                SceneManager.LoadScene("Steale's scene");
                intro1.SetActive(false);
               return;
            }

            Setstyle(dialogueSegments[dialogueindex].speaker);
            StartCoroutine(PlayDialogue(dialogueSegments[dialogueindex].dialogue));
        }
    }


    void Setstyle(subject Speaker)
    {
        if (Speaker.face == null)
        {
            Speakerfacedisplay.color = new Color(0, 0, 0, 0);
        }
        else 
        { 
            Speakerfacedisplay.sprite = Speaker.face;
            Speakerfacedisplay.color = Color.white;
        }

        Boxinner.color = Speaker.innerColor;
        Boxouter.color = Speaker.borderColor;
        Speakername.SetText(Speaker.subjectname);
        //Speakername.color = Speaker.nameplate;
        //Speakerfacedisplay.color = Speaker.faceplate;
    }

    IEnumerator PlayDialogue(string Dialogue)
    {
        canskip = false;
        Dialoguebox.SetText(string.Empty);

        for (int i = 0; i < Dialogue.Length; i++)
        {
            Dialoguebox.text += Dialogue[i];
            yield return new WaitForSeconds(1f / TextSpeed);
        }

        canskip = true;
    }
}

[System.Serializable]
public class DialogueSegment
{
    public string dialogue;
    public subject speaker;

}
