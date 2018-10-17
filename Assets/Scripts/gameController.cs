using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

    public static string currentSelectedCar = "myPorsche";//"myLamboConvert";//"myPorsche";//"Tocus";//"myDownloadedLambo";

    // Use this for initialization
    void Start () {
		
	}

    public void showNewCar(string nextCar)
    {
        GameObject.Find(colourSwitcher.instance.getCurrentTracked().name + "/activeItems/" + gameController.currentSelectedCar).SetActive(false);
        currentSelectedCar = nextCar;
        GameObject.Find(colourSwitcher.instance.getCurrentTracked().name + "/activeItems/" + gameController.currentSelectedCar).SetActive(true);
    }


    public void quit() {
        Application.Quit();
    }

    public void changeLevel(string scene) {
        SceneManager.LoadScene(scene);
    }
	
}
