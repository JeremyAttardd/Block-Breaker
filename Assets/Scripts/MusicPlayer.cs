using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer myMusicPlayer = null;

    private void Awake()
    {
        //If myMusicPlayer is the 1st instance 
        if (myMusicPlayer == null)
        {
            //myMusicPlayer = 1st Sound Object
            myMusicPlayer = this;

            //this.gameobject = the gameObject attached to this 
            //Script, in our case SoundObject
            //DontDestroyOnLoad = do not destroy the gameObject when changing scenes
            GameObject.DontDestroyOnLoad(this.gameObject);
        }

        //If myMusicPlayer != null
        //if SoundObject already exists
        else
        {
            print("Sound Object " + this.gameObject.GetInstanceID().ToString());

            //Destroy the 2nd gameObject created
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
