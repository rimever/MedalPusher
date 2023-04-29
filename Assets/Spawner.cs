using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform prefab;
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var offset = new Vector3(Mathf.Sin(Time.time), 0, 0);
            ScoreManager.Score--;
            Instantiate(prefab, transform.position + offset, transform.rotation);
        }
    }
}
