using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

	public abstract class AbstractCBScene : CreateButtonFactory
	{
        LinkedList<GameObject> list = new LinkedList<GameObject>();
        public Dictionary<string, Vector2> dicAnchor = new Dictionary<string, Vector2>();
        public Dictionary<string, CreateButtonsContents> buttonsDic = new Dictionary<string, CreateButtonsContents>();
        AudioSource audio;
        public AudioClip hardClip;
        public AudioClip paperClip;
        public AudioClip bookClip;
        public AudioClip metalClip;
        public AudioClip closeClip;
         public AudioClip lostItem;
        public CreateButton c = new CreateButton();

        public AbstractCBScene()
        {
           
            setUpDic();
            setUpAudio();
        }

        public virtual void placing(Done d, Done d2, bool sceneBool){}

       

        Dictionary<string, Vector2> setUpDic()
        {
            dicAnchor.Add("anchorMin", new Vector2(0.5f, 0f));
            dicAnchor.Add("anchorMax", new Vector2(0.5f, 0f));
            dicAnchor.Add("pivot", new Vector2(0.5f, 0.5f));
            dicAnchor.Add("buttonPos", new Vector2(0, 0));

            return dicAnchor;
        }

        void setUpAudio(){
            GameObject sfx = GameObject.FindGameObjectWithTag("sfx");
            audio = sfx.GetComponent<AudioSource>();
            hardClip = Resources.Load<AudioClip>("Audio/SFX/hardObj");
            paperClip = Resources.Load<AudioClip>("Audio/SFX/paperObj");
            bookClip = Resources.Load<AudioClip>("Audio/SFX/bookObj");
            metalClip = Resources.Load<AudioClip>("Audio/SFX/metalObj");
            closeClip = Resources.Load<AudioClip>("Audio/SFX/closeObj");
            
        }

        public LinkedList<GameObject> getButtons()
        {
            return list;        
        }


        public void setButtons(LinkedList<GameObject> list)
        {
            this.list = list;
        }

        public void stopFireAnimation()
        {
            AnimationCode animCode = c.getCanvas().GetComponent<AnimationCode>();
            animCode.beginAnimation1 = false;
        }

        public void destroyButtons()
        {
            if (getButtons().Count > 0)
            {
                int size = getButtons().Count;

                for (int i = 0; i < size; i++)
                {
                    GameObject.Destroy(getButtons().First.Value);
                    getButtons().RemoveFirst();
                }
            }
        }

        public void playClip(AudioClip clip)
        {
            audio.clip = clip;
            audio.Play();
            
        }




	}

