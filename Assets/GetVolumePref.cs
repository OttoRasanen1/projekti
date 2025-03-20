using UnityEngine;

public class GetVolumePref : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("musicVolume", 0.5f);
    }
}
