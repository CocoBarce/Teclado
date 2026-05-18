using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public Key[] keys;

    // Start is called before the first frame update
    void Start()
    {
        keys = GameObject.FindObjectsOfType<Key>();

            int randomIndex = Random.Range(0, keys.Length);
            Key randomKey = keys[randomIndex];

            Destroy(randomKey.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}