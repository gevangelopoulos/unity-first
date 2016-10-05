using UnityEngine;
using System.Collections;

public class play_sound : MonoBehaviour {

	// Use this for initialization
	void Start () {
   
        AudioSource audio = GetComponent<AudioSource>();
        audio.PlayDelayed(1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
