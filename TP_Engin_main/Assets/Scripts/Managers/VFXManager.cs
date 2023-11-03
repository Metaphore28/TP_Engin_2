using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public static VFXManager _Instance
    {
        get 
        { 
            return _Instance;
        }
        protected set { _Instance = value; }
    }

    [SerializeField]
    private GameObject m_hitPS;

    private void Awake()
    {
        if (_Instance == null)
        {
            _Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (_Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void InstantiateVFX(eVFXType vfxType, Vector3 pos)
    {
        switch (vfxType)
        {
            case eVFXType.Hit:
                Instantiate(m_hitPS, pos, Quaternion.identity, transform);
                break;
            default:
                break;
        }
    }
}

public enum eVFXType
{
    Hit,
    Count
}
