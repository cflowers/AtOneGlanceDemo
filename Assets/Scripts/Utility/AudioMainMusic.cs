using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


	public class AudioMainMusic : MonoBehaviour
	{
        AudioClip[] clips;
        AudioSource audio;
        int index = 0;

        void Start()
        {
            audio = this.GetComponent<AudioSource>();
            clips = Resources.LoadAll<AudioClip>("Audio/Music/PianoMoods");
        }

        void Update()
        {
            if (audio.isPlaying == false)
                helperAudio();
        }

        void helperAudio()
        {
            index = UnityEngine.Random.Range(0, clips.Length);
          
            if (index < clips.Length)
            {
                audio.clip = clips[index];
                audio.Play();
               
            }

          
        }
      
	}

