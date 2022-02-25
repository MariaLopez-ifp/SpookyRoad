using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSystem : MonoBehaviour
{
    public float durationLoop;
    public Vector3 initialAngle;
    public Vector3 finalAngle;


    void Start()
    {
        StartCoroutine(Rotation());
    }

    void Update()
    {
        //transform.RotateAround(transform.position, Vector3.left, speed * Time.deltaTime);
    }

    IEnumerator Rotation(/*float duration, Vector3 initialDirection, Vector3 finalDirectiron*/)
    {
        for(float actualDuration = 0; actualDuration < durationLoop; actualDuration+=Time.deltaTime)
        {
            transform.localRotation = Quaternion.Euler(Vector3.Lerp(initialAngle, finalAngle, (actualDuration > durationLoop / 2 ? durationLoop - actualDuration : actualDuration) / (durationLoop / 2)));

            yield return new WaitForFixedUpdate();
        }

        StartCoroutine(Rotation());
    }
}
