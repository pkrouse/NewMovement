using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionReporter : MonoBehaviour
{
    bool reportable = true;
    // Update is called once per frame
    void Update()
    {
        if (reportable)
        {
            Debug.Log("X is " + gameObject.transform.position.x);
            reportable = false;
            StartCoroutine(resetCoroutine());
        }
        
    }
    private IEnumerator resetCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        reportable = true;
    }
}
