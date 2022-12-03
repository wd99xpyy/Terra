using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public void TitleScreen() {  
        SceneManager.LoadScene("0 Title Screen 1");  
    }  
    public void AddNameScreen() {  
        SceneManager.LoadScene("1 Add Name Screen");  
    }  
    public void GameScreen() {  
        SceneManager.LoadScene("2 Game Screen");  
    } 
    public void exitgame() {  
        Debug.Log("exitgame");  
        Application.Quit();  
    }  

}
