using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePresenter : MonoBehaviour
{
    private bool atRoom = false;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Room") && atRoom)
        {
            atRoom = true;

            EnableBoolAnimator();

            //public void NavigateTo(int scene)
            //{
                //Application.LoadLevel(scene); //Scene needs to be added - if I'm understanding it correctly.  Once added, this can be uncommented.
            //}
        }

        if (trigger.gameObject.CompareTag("Environment") && !atRoom)
        {
            atRoom = false;

            //public void Exitgame()
            //{
                Application.Quit();
            //}
        }
    }

    public void DisableBoolAnimator()
    {
        anim.SetBool("IsDisplayed", false);
    }

    public void EnableBoolAnimator()
    {
        anim.SetBool("IsDisplayed", true);
    }
}