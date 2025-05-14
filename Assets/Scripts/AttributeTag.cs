using UnityEngine;

public class AttributeTag : MonoBehaviour
{
    private string _attributeName;
    [HideInInspector] public Vector3 originalPosition;
    
    public string AttributeName => _attributeName;
    void Awake()
    {
        _attributeName = this.gameObject.name;
        originalPosition = this.gameObject.transform.position;
    }

    void OnEnable()
    {
        _attributeName = this.gameObject.name;
    }
}
