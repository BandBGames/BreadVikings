using UnityEngine;

[RequireComponent(typeof(SpaceshipMotor))]
public class SpaceshipController : MonoBehaviour
{

    public LayerMask movement;

    Camera cam;
    SpaceshipMotor motor;

    bool enablePlant;
    bool enablePickFruits;

    GameObject plot;
    GameObject tree;

    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<SpaceshipMotor>();

        enablePlant = false;
        enablePickFruits = false;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movement))
            {
                motor.MoveToPoint(hit.point);
            }
        }
    }
}