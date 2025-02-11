using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleSoundTypesOnCollision : MonoBehaviour
{

    public List<AudioClip> clipsA = new List<AudioClip>();

    public List<AudioClip> clipsB = new List<AudioClip>();

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

    private AudioClip GetRandomAudioClip(List<AudioClip> clips)
    {
        int randomClipIndex = Random.Range(0, clips.Count);
        return clips[randomClipIndex];
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision");
        if ( collision.gameObject.CompareTag("TagA") )
        {
            AudioClip clip = GetRandomAudioClip(clipsA);
            source.PlayOneShot(clip);

        } else if (collision.gameObject.CompareTag("TagB") )
        {

            AudioClip clip = GetRandomAudioClip(clipsB);
            source.PlayOneShot(clip);

        }
     
 
    }
}
