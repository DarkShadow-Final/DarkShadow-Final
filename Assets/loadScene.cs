using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public int GameNum;
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Rigidbody>() != null) 
        {
            LoadScene(GameNum);
        }
    }

    public void play()
    {
        PlayerPrefs.DeleteAll();
        LoadScene(1);
    }
}
