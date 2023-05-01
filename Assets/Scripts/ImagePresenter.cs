using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePresenter : MonoBehaviour
{
    private bool atRoom = false;
    private bool doneReading = false;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.CompareTag("Environment") && atRoom)
        {
            atRoom = true;

            EnableBoolAnimator();
        }

        if (trigger.gameObject.CompareTag("Environment") && !atRoom)
        {
            atRoom = false;
        }
    }

    public void DisableBoolAnimator()
    {
        anim.SetBool("IsDisplayed", false);

        if(gameObject.CompareTag("Environment") && doneReading)
        {
            anim.SetBool("IsDisplayed", false);
        }
    }

    public void EnableBoolAnimator()
    {
        anim.SetBool("IsDisplayed", true);

        if (gameObject.CompareTag("Environment") && !doneReading)
        {
            anim.SetBool("IsDisplayed", true);
        }
    }
}