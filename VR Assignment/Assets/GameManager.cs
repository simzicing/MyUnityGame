using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentLevel = 0;
    public AudioClip[] audioClips;
    // Start is called before the first frame update
  
    public void OnMouseClick()
    {   
        Application.LoadLevel("Night");
    }
    public void OnMouseClick2()
    {
         Application.LoadLevel("Day");
    } 
    public void OnMouseClick3()
    {
        PlaySound(0);
    }
    public void OnMouseClick4()
    {
        PlaySound(1);
    }
    public void OnMouseClick5()
    {
        PlaySound(2);
    }

     void PlaySound(int clip)
    {
        GetComponent<AudioSource>().clip = audioClips[clip];
        GetComponent<AudioSource>().Play();
    }   
        
    }

