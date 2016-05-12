using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour
{
    public GameObject musicPlayer;

    void Awake()
    {
        musicPlayer = GameObject.Find("BGMusic");
        if (musicPlayer == null)
        {
            //If this object does not exist then it does the following:
            //1. Sets the object this script is attached to as the music player
            musicPlayer = this.gameObject;
            //2. Renames THIS object for next time
            musicPlayer.name = "BGMusic";
            DontDestroyOnLoad(musicPlayer);
        }
        else
        {
            if (this.gameObject.name != "BGMusic")
            {
                //destroy itself if this is not the original
                Destroy(this.gameObject);
            }
        }
    }
}
