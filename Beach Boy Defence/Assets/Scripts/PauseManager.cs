using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour {

    public GameObject PauseMenuPrefab;

    public Vector3 MenuScale;

    public Vector3 SpawnPosition;

    public Text Buttontext;

    GameObject SpawnedPauseMenu;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Pause()
    {
        SpawnedPauseMenu = Instantiate(PauseMenuPrefab);

        SpawnedPauseMenu.transform.localScale = MenuScale;

        SpawnedPauseMenu.transform.position = SpawnPosition;

        Buttontext.text = "Back";

        Time.timeScale = 0;
    }
    void Unpause()
    {
        Time.timeScale = 1;
        Destroy(SpawnedPauseMenu);
        Buttontext.text = "Info";
    }

    public void TogglePause()
    {
        if(SpawnedPauseMenu == null)
        {
            Pause();
        }
        else
        {
            Unpause();
        }
    }

    private void OnDestroy()
    {
        Time.timeScale = 1;
    }
}
