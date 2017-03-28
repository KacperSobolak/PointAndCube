using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Canvas menu;
    public Canvas poradnik;

	void Start () {
        poradnik.enabled = false;
        menu.enabled = true;
	}
	
	void Update () {
	    
	}

    public void GrajBTN()
    {
        SceneManager.LoadScene(1);
    }

    public void PoradnikBTN()
    {
        poradnik.enabled = true;
        menu.enabled = false;
    }

    public void WyjdzBTN()
    {
        Application.Quit();
    }

    public void PowrorBTN()
    {
        poradnik.enabled = false;
        menu.enabled = true;
    }
}
