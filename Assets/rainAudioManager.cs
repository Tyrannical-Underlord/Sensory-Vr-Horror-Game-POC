using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainAudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip rainOutdoorsClip;
    [SerializeField] private float volume;

    // Start is called before the first frame update
    void Start()
    {
        SoundFXManager.instance.PlayLoopingSoundFXClip(rainOutdoorsClip, transform.parent, volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
