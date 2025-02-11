using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{

    public List<AudioClip> clips = new List<AudioClip>();

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(clips.Count);
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision");
     
        int randomClipIndex = Random.Range(0,clips.Count) ;
        source.PlayOneShot(clips[randomClipIndex]);
    }
}
