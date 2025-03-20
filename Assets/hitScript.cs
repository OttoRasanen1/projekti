using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hitScript : MonoBehaviour
{
    public AudioClip Hitsound;

    public IEnumerator playHitSound(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        GetComponent<AudioSource>().PlayOneShot(Hitsound);
    }
}
