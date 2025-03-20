using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;



public class animScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        if (anim.GetBool("HitAnim") == true)
        {
            return;
        }

        else
        {
            anim.SetBool("HitAnim", true);
            StartCoroutine(ChangeScene(0.5f));
            StartCoroutine(FindFirstObjectByType<hitScript>().playHitSound(0.6f));
           
        }
    }

    private IEnumerator ChangeScene(float waitTime)
    {
        yield return new WaitForSeconds(waitTime + 1);
        SceneManager.LoadScene(3);
    }
   


    // have spin speed reverted to 1.0 second
    //if (HitAnim == true)
    //{
    //    anim["HitAnim"].speed = 1.0f;
    //    //HitAnim = false;
    //}
}
