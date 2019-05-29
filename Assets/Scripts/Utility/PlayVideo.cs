using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour {

    
    public MovieTexture movie;
    RawImage rawImageComp;
    AudioSource audio;
    GameObject button;

    void Start(){
        rawImageComp = GetComponent<RawImage>();
        audio = GetComponent<AudioSource>();
        button = GameObject.FindGameObjectWithTag("freedemo");
        button.SetActive(false);
        PlayClip();
    }

    void Update()
    {

        if (!(movie.isPlaying))
        {
            button.SetActive(true);
            button.GetComponent<Button>().onClick.AddListener(NextSceneListener);
        }
    }

    void PlayClip()
    {
        rawImageComp.texture = movie;
        movie.Play();
        audio.clip = movie.audioClip;
        audio.Play();
       
    }

    void NextSceneListener()
    {
        SceneManager.LoadScene(1);
    }

}
