using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scene1t()
    {
        SceneManager.LoadScene(1);
    }
    public void scene1play()
    {
        SceneManager.LoadScene(2);
    }
    public void scene1q()
    {
        SceneManager.LoadScene(3);
    }
    public void scene2play()
    {
        SceneManager.LoadScene(4);
    }
    public void scene2q()
    {
        SceneManager.LoadScene(5);
    }
    public void scene3t()
    {
        SceneManager.LoadScene(6);
    }
    public void scene3play()
    {
        SceneManager.LoadScene(7);
    }
    public void scene3q()
    {
        SceneManager.LoadScene(8);
    }
    public void scene4t()
    {
        SceneManager.LoadScene(9);
    }
    public void scene4play()
    {
        SceneManager.LoadScene(10);
    }
    public void scene4q()
    {
        SceneManager.LoadScene(11);
    }
    public void scene5t()
    {
        SceneManager.LoadScene(12);
    }
    public void scene5play()
    {
        SceneManager.LoadScene(13);
    }
    public void scene5q()
    {
        SceneManager.LoadScene(14);
    }
    public void endscene()
    {
        SceneManager.LoadScene(15);
    }
    public void playagain()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        //print("quit");
        Application.Quit();
    }
}
