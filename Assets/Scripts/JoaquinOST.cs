using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoaquinOST : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
