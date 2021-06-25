using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask MovementMask;

    Camera cam;
    PlayerMotor motor;


    // Start is called before the first frame update
    void Start()
    {
        motor = GetComponent<PlayerMotor>();
        cam = Camera.main;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, MovementMask))
            {
                motor.MoveToPoint(hit.point);
            }
        }
    }
}

