using UnityEngine;

public class whenGameComplated : MonoBehaviour
{
    public int GameNum;
    public void callThisWhenGameWin()
    {
        PlayerPrefs.SetInt("Game" + GameNum.ToString() , 1);
    }
}
