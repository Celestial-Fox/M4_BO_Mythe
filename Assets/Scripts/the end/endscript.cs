using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class endscript : MonoBehaviour
{

    public DialogueSegment[] dialogueSegments;
    [Space]
    public Image Speakerfacedisplay;
    public Image Boxinner;
    public Image Boxouter;
    public Image faceplate;
    public Image nameplate;
    public Image Skipthing;
    [Space]
    public GameObject end1;
    public GameObject end2;
    public GameObject end3;
    public GameObject end4;
    public GameObject end5;
    public GameObject end6;
    [Space]
    public TextMeshProUGUI Speakername;
    public TextMeshProUGUI Dialoguebox;
    [Space]
    public float TextSpeed;
    public AudioSource happymusic;
    public AudioSource sadmusic;

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
            if (dialogueindex == 3)
                {
                end1.SetActive(false);
                end2.SetActive(true);
            }

            if (dialogueindex == 10)
            {
                end2.SetActive(false);
                end3.SetActive(true);
            }

            if (dialogueindex == 12)
            {
                end3.SetActive(false);
                end4.SetActive(true);
                happymusic.mute = true;
                sadmusic.mute = false;

            }

            if (dialogueindex == 15)
            {
                end4.SetActive(false);
                end6.SetActive(true);
            }

            if (dialogueindex == 22)
            {
                end6.SetActive(false);
                end5.SetActive(true);
            }


            if (dialogueindex == dialogueSegments.Length)
            {
                SceneManager.LoadScene(0);
                return;
            }

            Setstyle(dialogueSegments[dialogueindex].speaker);
            StartCoroutine(PlayDialogue(dialogueSegments[dialogueindex].dialogue));
        }
    }

    public void skipbutton()
    { 
        SceneManager.LoadScene(0);
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



