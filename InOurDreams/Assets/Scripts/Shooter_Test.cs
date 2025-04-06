using UnityEngine;

public class Shooter_Test : MonoBehaviour
{
    public Transform FirePoint;

    // Update is called once per frame
    void Update()
    {
        Shooting();
    }

    public void Shooting()
    {
        RaycastHit hit;

        if (Physics.Raycast(FirePoint.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            Debug.DrawRay(FirePoint.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
    }
}
