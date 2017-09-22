using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PageLoader : MonoBehaviour
{
    public string sceneToLoad;

    private PauseMenu m_PauseMenu;


    private void Awake ()
    {
        m_PauseMenu = GetComponentInChildren <PauseMenu> ();
    }


    public void SceneLoad ()
	{
		//PauseMenu pauseMenu = (PauseMenu)FindObjectOfType(typeof(PauseMenu));
		//m_PauseMenu.MenuOff ();
		SceneManager.LoadScene(sceneToLoad);
	}


	public void LoadURL(string url)
	{
		Application.OpenURL(url);
	}

        public void OnMouseOver () {
           if (Input.GetMouseButtonDown(0)) {
              SceneLoad();
           }
        }

        public void Update ()

        { OnMouseOver(); }

}
		
