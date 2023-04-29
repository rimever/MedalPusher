using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Pusher : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private Vector3 _origin;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _origin = _rigidBody.position;
    }

    // Update is called once per frame
    void Update()
    {
        var offsets = new Vector3(0, 0, Mathf.Sin(Time.time));
        _rigidBody.MovePosition(_origin + offsets);
    }
}
