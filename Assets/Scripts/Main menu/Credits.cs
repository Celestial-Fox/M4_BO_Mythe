using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour    
{
    public GameObject camera1;
    public GameObject camera3;
    public GameObject MainMenu;
    public GameObject Creditsmenu;

    public void ReturnToMainMenu()
    {
        camera1.SetActive(true);
        camera3.SetActive(false);
        MainMenu.SetActive(true);
        Creditsmenu.SetActive(false);

    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
