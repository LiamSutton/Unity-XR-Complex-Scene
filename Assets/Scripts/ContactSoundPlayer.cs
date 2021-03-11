using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactSoundPlayer : MonoBehaviour
{
    public AudioClip[] clips; // An n sized array containing sounds for drop collisions.

    void OnCollisionEnter(Collision other)
    {
        // This prevents audio clips playing when each object is first instanciated at runtime
        if (Time.timeSinceLevelLoad < 1.0f)
            return;

        // Select a random audio clip to play
        AudioClip randomClip = clips[Random.Range(0, clips.Length)];

        // The location the sound should orignate from in the world
        Vector3 soundLocation = other.contacts[0].point;

        AudioSource.PlayClipAtPoint(randomClip, soundLocation);
    }
}
