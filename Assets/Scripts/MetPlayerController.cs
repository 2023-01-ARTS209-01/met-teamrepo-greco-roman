using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetPlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalSpeed = 30f; //Changing this value INVERTS the controls
    [SerializeField] private float verticalSpeed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horMoveAmt = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime; //Changing verticalSpeed INVERTS the controls
        float verMoveAmt = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime; //Changes vertical movement

        transform.Rotate(0, 0, -horMoveAmt); //Making horMoveAmt POSITIVE will INVERTS the controls
        //transform.Translate(0, verMoveSpeed, 0);
        transform.Translate(0, verMoveAmt, 0);
    }
}