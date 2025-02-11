using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class SoundOnAnimationEvent : MonoBehaviour
{


    public List<AudioClip> clips = new List<AudioClip>();

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimationEvent(string s)
    {
        //Debug.Log("PrintEvent called at " + Time.time + " with a value of " + s);

        if (s == "MonParam")
        {
            int randomClipIndex = Random.Range(0, clips.Count);
            source.PlayOneShot(clips[randomClipIndex]);
        }
    }
}
