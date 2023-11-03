using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake (float timer, float magnitude, float posZ)
    {
        Vector3 orignalPos = transform.localPosition;

        float timeElapsed = 0.0f;

        while (timeElapsed < timer)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, posZ);

            timeElapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = orignalPos;
    }

    public void PlayShake(float timer, float magnitude, float posZ)
    {
        StartCoroutine(Shake(timer, magnitude, posZ));
    }
}
