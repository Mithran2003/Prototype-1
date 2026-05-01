using System;
using JetBrains.Annotations;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject player ;
    [SerializeField]
    private Vector3 camera_offset = new Vector3(0,6,-9);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
    void Update()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {         
        transform.position = player.transform.position + camera_offset ;
    }
}
