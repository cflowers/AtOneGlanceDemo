 using UnityEngine;
  using System.Collections;
using UnityEngine.UI;
  
  public class TimerSC : MonoBehaviour 
 {
     // Static Instance of this Timer (since you seem to want a single Timer)
     private static TimerSC m_instance;
      
     private float m_startTime; // sets how much time the player has to start with
     private float m_timePassed;
      
     public float RemainingSeconds;
  
     public bool IsTicking;
    
  
     // Use this for initialization
     void Awake () 
     {
         // Another timer exists, kill this one
         if(m_instance != null && m_instance != this)
         {
             Destroy(this);
         }
         else
         {
            
             // assign Singleton
             m_instance = this;
             //Debug.Log("MInstance" + m_instance);
         }
         
         // Init Timer
         m_startTime = 15f;
         m_timePassed = 0f;
        RemainingSeconds = m_startTime;
        //IsTicking = true;
     }
 
     //Update is called once per frame
     void Update () 
     {
         
         if (IsTicking) // already a bool no check for true needed
         {
             // add frame time to passed time
             m_timePassed += Time.deltaTime;
             
             RemainingSeconds = m_startTime - m_timePassed;
         
             // Clamp time to start time
             if (RemainingSeconds >= m_startTime)
             {
                 RemainingSeconds = m_startTime;
             } 
             
             // No time left
             if(RemainingSeconds <= 0)
             {
                 GameObject popup = GameObject.FindGameObjectWithTag("popup");
                 GameObject hud_points = GameObject.FindGameObjectWithTag("points");
                 GameObject tb = GameObject.FindGameObjectWithTag("canvas");

                 if (popup.GetComponent<Canvas>().sortingOrder == 1)
                 {
                     popup.GetComponent<Canvas>().sortingOrder = -1;
                     int points = PlayerInfo.Points;
                     PlayerInfo.Points=points - 10;
                     hud_points.GetComponent<Text>().text = "POINTS:" + PlayerInfo.Points;
                     tb.GetComponent<TextBox>().textBool = false;
                     tb.GetComponent<PlaceButtonsMain>().d.done = false;
                     tb.GetComponent<PlaceButtonsMain>().popUpD.done = false;
                     IsTicking = false;
                 }
                 // This is Game Over
                 ResetTimer();
                 return;
             }
         }
     }
     
     // Use this Method to access your timer
     public static TimerSC getTimer()
     {   
         return m_instance;
     }
     
     // Reset your time
     public void ResetTimer()
     {
         m_timePassed = 0;
         RemainingSeconds = m_startTime;
     }
     
     // If you want to substract time, use a negative value
     public void AddTime(float _seconds)
     {
         m_timePassed -= _seconds;
     }
  }
