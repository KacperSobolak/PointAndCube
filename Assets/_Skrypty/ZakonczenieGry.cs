using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZakonczenieGry : MonoBehaviour {

    public GameObject przegrana;
    public GameObject platforma;

	void Start () {
        przegrana.SetActive(false);       
	}
	
	void Update () {
	    
	}

    void OnCollisionEnter(Collision kolizja)
    {
        if (kolizja.gameObject.name == "ZwyklyPunkt(Clone)")
        {
            przegrana.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void JeszczeRaz()
    {
        przegrana.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Wyjdz()
    {
        Application.Quit();
    }
}
