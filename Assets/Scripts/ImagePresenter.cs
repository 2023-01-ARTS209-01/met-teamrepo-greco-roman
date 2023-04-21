using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImagePresenter : MonoBehaviour
{
    //public void DisableBoolAnimator(Animator anim)
    //{
        //anim.SetBool("IsDisplayed", false);
    //}

    public void DisableBoolAnimator(Animator anim)
    {
        anim.SetBool("IsDisplayed", true);
    }

    public void NavigateTo(int scene)
    {
        Application.LoadLevel(scene);
    }

    public void Exitgame()
    {
        Application.Quit();
    }
}