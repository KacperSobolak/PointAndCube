using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DodawaniePunktow : MonoBehaviour {

    public int punkty = 0;
    public Text wynik;
    public static DodawaniePunktow system;

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnCollisionEnter(Collision kolizja)
    {
        if (kolizja.gameObject.name == "ZwyklyPunkt(Clone)")
        {
            punkty++;
            wynik.text = punkty.ToString();
        }
    }

    public void reset()
    {
        punkty = 0;
    }
}
