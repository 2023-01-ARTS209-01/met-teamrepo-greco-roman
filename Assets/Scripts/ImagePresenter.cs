using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePresenter : MonoBehaviour
{
    private bool atExhibit = false;
    
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Exhibit") && atExhibit)
        {
            atExhibit = true;

            //public void DisableBoolAnimator(Animator anim)
            //{
            //anim.SetBool("IsDisplayed", false);
            //}

            //public void DisableBoolAnimator(Animator anim)
            //{
                //anim.SetBool("IsDisplayed", true); Animation needs to be added.  Once added, this can be uncommented.
            //}

            //public void NavigateTo(int scene)
            //{
                //Application.LoadLevel(scene); Scene needs to be added - if I'm understanding it correctly.  Once added, this can be uncommented.
            //}
        }

        if (trigger.gameObject.CompareTag("Environment") && !atExhibit)
        {
            atExhibit = false;

            //public void Exitgame()
            //{
                Application.Quit();
            //}
        }
    }
}