using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackController : MonoBehaviour
{
    [SerializeField] StackPartController[] stackPartControllers = null;
    
    public void ShatterAllPart()
    {
        if(transform.parent != null)
        {
            transform.parent = null;
            FindFirstObjectByType<Ball>().IncreaseBronkenStacks();
        }

        foreach(StackPartController item in stackPartControllers)
        {
            item.Shatter();
        }
        StartCoroutine(RemoveParts());
    }
    IEnumerator RemoveParts()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
