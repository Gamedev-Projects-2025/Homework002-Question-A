<<<<<<< HEAD
using UnityEngine;

public class spin : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 1f;

    [SerializeField]
    private Vector3 rotationAxis = Vector3.forward;

    void Update()
    {
        //Rorating the object around its origin
        transform.Rotate(rotationAxis.normalized, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
=======
using UnityEngine;

public class spin : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 1f;

    [SerializeField]
    private Vector3 rotationAxis = Vector3.forward;

    void Update()
    {
        //Rorating the object around its origin
        transform.Rotate(rotationAxis.normalized, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
>>>>>>> 6d2ef454a76f4ace71ade67ac3bb98e775039aea
