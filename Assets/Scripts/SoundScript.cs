using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
public AudioClip musicClipOne;

public AudioClip musicClipTwo;

public AudioSource musicSource;

Animator anim;


void Start()

{

  anim = GetComponent<Animator>();

}




// Update is called once per frame
void Update()
{
     if (Input.GetKeyDown(KeyCode.W))
        {
          musicSource.clip = musicClipOne;
          musicSource.Play();
          
          anim.SetInteger("State", 1);

         }

     if (Input.GetKeyUp(KeyCode.W))
        {
          musicSource.Stop();

          
          anim.SetInteger("State", 0);

         }

     if (Input.GetKeyDown(KeyCode.R))
        {
          musicSource.clip = musicClipTwo;
          musicSource.Play();

          
          anim.SetInteger("State", 2);
         }

     if (Input.GetKeyUp(KeyCode.R))
        {
          musicSource.Stop();
          
          anim.SetInteger("State", 0);

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
