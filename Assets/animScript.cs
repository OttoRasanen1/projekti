using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;



public class animScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

    }

    //(Input.GetKeyDown(KeyCode.Space))
    void Update()
    {
        // leave spin or jump to complete before changing
        if (anim.GetBool("HitAnim") == true)
        {
            return;
        }

        else
        {
            //if (Input.GetKeyDown(KeyCode.Space))
            //{ 
            anim.SetBool("HitAnim", true);
            //}
        }



        public void seuraavaGame()
    {


        WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }


    // have spin speed reverted to 1.0 second
    //if (HitAnim == true)
    //{
    //    anim["HitAnim"].speed = 1.0f;
    //    //HitAnim = false;
    //}


}
}
