using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent  (typeof(AudioSource))]
public class PlayVideo : MonoBehaviour {
	public MovieTexture Movie;
	private AudioSource Audio;
	
	public void PlayTheVideo () {
		GetComponent<RawImage> ( ).texture = Movie as MovieTexture;
		Audio = GetComponent<AudioSource> ( );
		Audio.clip = Movie.audioClip;
		Movie.Play ( );
		Audio.Play ( );        
	}
	
	
}
