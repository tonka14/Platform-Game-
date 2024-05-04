using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakesc : MonoBehaviour
{
    public bool shake = false;
    public AnimationCurve curve;
    public float duration = 1f;

    
    void Update()
    {
        if (shake)
        {
            shake = false;
            StartCoroutine(Shaking());
        }
    }
    

    IEnumerator Shaking()
    {
        yield return new WaitForSeconds(1.5f);
        Vector3 startPosition = transform.position;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float strenght = curve.Evaluate(elapsedTime / duration);
            transform.position=startPosition + Random.insideUnitSphere* strenght;
            yield return null;
        }
        transform.position = startPosition;
    }



}
