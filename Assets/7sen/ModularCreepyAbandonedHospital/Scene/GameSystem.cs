using UnityEngine;

public class GameSystem : MonoBehaviour
{
    // home scene 1


    public GameObject[] GameBlocks;
    public GameObject[] GameMedal;
    //public GameObject camAnim;
    //public AudioSource mazeSound;
    Vector3 posGame1;
    //public GameObject dancer;
    void Start()
    {
        // test
        //PlayerPrefs.DeleteAll();
        posGame1 = GameBlocks[0].transform.position;


        // cam anim 
       /* if (PlayerPrefs.HasKey("game0"))
        {
            Destroy(camAnim);
        }
        else
        {
            Destroy(camAnim, 14f);
        }
       */
        // remove game complated
        for (int i = 0; i < GameBlocks.Length; i++)
        {
            if( LoadIsGameComplated(i))
            {
                GameMedal[i].SetActive(true);
                Destroy(GameBlocks[i]);
            }
        }


        // respawn pos..fix
        if(LoadIsGameComplated(0) && !LoadIsGameComplated(1))
        {
            Invoke("setPos1", 0.2f);
        }
        else if(LoadIsGameComplated(1))
        {
            GameEnd();
        }
    }

    void setPos1()
    {
        FindObjectOfType<Rigidbody>().transform.position = posGame1;
    }

    void GameEnd()
    {
        Destroy(FindObjectOfType<Rigidbody>().gameObject);
        //dancer.SetActive(true);

        // reset Game to zero
        //PlayerPrefs.DeleteAll();
    }
    
    bool LoadIsGameComplated(int thisGameNum)
    {
        // check
        return PlayerPrefs.GetInt("Game" +  thisGameNum.ToString()) == 1;
    }

    public void playSound()
    {
        //mazeSound.Play();
        Debug.Log("sound on");
    }
}
