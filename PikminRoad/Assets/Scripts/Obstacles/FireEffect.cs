using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    Light light;
    public float minRange;
    public float maxRange;
    public float durationLoop;

    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(Fire(light.range));
    }

    IEnumerator Fire(float lastValue)
    {
        float rand = Random.Range(minRange, maxRange);

        for (float actualDuration = 0; actualDuration < durationLoop; actualDuration += Time.deltaTime)
        {
            light.range = Mathf.Lerp(lastValue, rand, (actualDuration) / (durationLoop / 2));

            yield return new WaitForFixedUpdate();
        }

        StartCoroutine(Fire(rand));
    }
}
