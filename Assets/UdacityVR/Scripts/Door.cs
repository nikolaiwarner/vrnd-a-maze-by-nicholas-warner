using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update()
    public bool locked = true;
    public bool opening = false;

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
        if (opening && transform.position.x < 10) {
          // TODO
          //transform.position.x = transform.position.x + 0.1;
        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
        if (!locked) {
          opening = false;
          AudioSource audio = GetComponents<AudioSource>()[1];
          audio.Play();
        } else {
          AudioSource audio = GetComponents<AudioSource>()[0];
          audio.Play();
        }
    }

    public void Unlock() {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
