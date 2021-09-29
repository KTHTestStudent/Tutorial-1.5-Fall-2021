using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
public AudioClip musicClipOne;

public AudioClip musicClipTwo;

public AudioSource musicSource;

// Update is called once per frame
void Update()
{
     if (Input.GetKeyDown(KeyCode.W))
        {
          musicSource.clip = musicClipOne;
          musicSource.Play();

         }

     if (Input.GetKeyUp(KeyCode.W))
        {
          musicSource.Stop();

         }

     if (Input.GetKeyDown(KeyCode.R))
        {
          musicSource.clip = musicClipTwo;
          musicSource.Play();
         }

     if (Input.GetKeyUp(KeyCode.R))
        {
          musicSource.Stop();

         }

     if (Input.GetKeyDown(KeyCode.L))
        {
          musicSource.loop = true;
         }

     if (Input.GetKeyUp(KeyCode.L))
        {
          musicSource.loop = false;
        }

      if (Input.GetKeyDown(KeyCode.V))

      {
        musicSource.volume = 0.5f;
      }

      if (Input.GetKeyUp(KeyCode.V))

      {
        musicSource.volume = 1.0f;

      }

      if (Input.GetKeyDown(KeyCode.P))

      {
        musicSource.pitch = 3.0f;
      }

      if (Input.GetKeyUp(KeyCode.P))

      {
        musicSource.pitch = 1.0f;
      }


   }
}
