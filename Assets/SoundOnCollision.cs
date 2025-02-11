using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{

    public List<AudioClip> clips = new List<AudioClip>();
    public List<AudioClip> clipsAutre = new List<AudioClip>();

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
        if ( collision.gameObject.CompareTag("MonTag") )
        {
            int randomClipIndex = Random.Range(0, clips.Count);
            source.PlayOneShot(clips[randomClipIndex]);

        } else if (collision.gameObject.CompareTag("MonTagAutre") )
        {

            int randomClipIndex = Random.Range(0, clipsAutre.Count);
            source.PlayOneShot(clipsAutre[randomClipIndex]);

        }
     
 
    }
}
