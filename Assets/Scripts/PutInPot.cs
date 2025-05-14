using System;
using System.Collections.Generic;
using UnityEngine;

public class PutInBar : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _prefabsKeyWord = new();

    public List<string> PutPrefab = new();

    public int PutCount;

    // Update is called once per frame
    private void Awake()
    {
        PutCount = 0;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (PutCount >= 3)
            return;
        AttributeTag tag = other.GetComponent<AttributeTag>();
        if (tag == null)
            return;
        Vector3 spawnPos = tag.originalPosition;
        PutPrefab.Add(tag.tag);
        foreach (GameObject prefab in _prefabsKeyWord)
        {
            if (tag.AttributeName == prefab.name)
            {
                Instantiate(prefab, spawnPos, Quaternion.identity);
            }
        }
        Destroy(other);
        PutCount++;
    }
}
