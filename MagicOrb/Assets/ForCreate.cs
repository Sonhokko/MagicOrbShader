using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCreate : MonoBehaviour
{
    [SerializeField] private GameObject effect;
    [SerializeField] private Transform pointPos;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(effect, pointPos.position, pointPos.rotation);
        }
    }
}
