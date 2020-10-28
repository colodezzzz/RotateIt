using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityMovement : MonoBehaviour
{
    private bool boost = false;
    private float boostCoordinate = 2.5f;
    public float velocityUp = 7f;
    public float velocityDown = -10f;
    private float rotateSpeed = 1f;
    private Rigidbody _rg;

    private void Awake()
    {
        _rg = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (boost && transform.position.y >= boostCoordinate)
        {
            _rg.velocity = new Vector3(0f, velocityUp, 0f);
            boost = false;
        }
        else if (!boost && transform.position.y < boostCoordinate)
        {
            _rg.velocity = new Vector3(0f, velocityDown, 0f);
            boost = true;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.Rotate(-45f, 0f, 0f, Space.Self);
        }

        /*float rotationY = transform.rotation.eulerAngles.y;

        if (Mathf.Abs(rotationY) <= 10f && Mathf.Abs(rotationY) - 360f <= 10f && Mathf.Abs(rotationY) != 0)
        {
            transform.Rotate(-1 * (Mathf.Abs(rotationY) / rotationY) * rotateSpeed, 0f, 0f, Space.Self);
            Debug.Log(transform.rotation.eulerAngles.y);

            if (Mathf.Abs(rotationY) <= 1f)
            {
                transform.Rotate(-1 * rotationY, 0f, 0f, Space.Self);
            }

        }*/


        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            Debug.Log(transform.rotation.eulerAngles.y - 10f);
        }
    }
}
