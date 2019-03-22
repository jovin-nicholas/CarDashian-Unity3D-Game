using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	private AudioSource[] audioCollection = new AudioSource[0];
	
	// [SerializeField]
	// private AudioClip starCollectSound;
	// [SerializeField]
	// private AudioClip gameOverSound;

	private bool soundOn;

	void Start () {
		//UpdateAudioCollection();
        
        if (audioCollection.Length == 0)
        {
		    UpdateAudioCollection();
		}
        
		soundOn = true;
		// Debug.Log("Collection size " + audioCollection.Length);
	}
	
	void Update () {
        UpdateAudioCollection();
    }

	public void Mute () {
		soundOn = false;
        
		if (audioCollection.Length == 0) {
			UpdateAudioCollection();
		} 
        
        
		foreach (AudioSource source in audioCollection) {
			source.mute = true;
		}
	}

	public void UnMute () {
		soundOn = true;
        
		if (audioCollection.Length == 0) {
			UpdateAudioCollection();
		} 
        
		foreach (AudioSource source in audioCollection) {
			source.mute = false;
		}
	}

	public void UpdateAudioCollection () {
		audioCollection = GetComponents<AudioSource>();
	}
}
