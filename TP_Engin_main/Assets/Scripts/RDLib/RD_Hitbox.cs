using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RD_Hitbox : MonoBehaviour
{
    [SerializeField]
    protected bool m_canGiveHit;
    [SerializeField]
    protected bool m_canReceiveHit;
    [SerializeField]
    protected EAgentType m_agentType = EAgentType.Count;
    [SerializeField]
    protected List<EAgentType> m_affectedAgentTypes = new List<EAgentType>();

    protected void OnTriggerEnter(Collider other)
    {
        var otherHitbox = other.GetComponent<RD_Hitbox>();
        if (otherHitbox == null) { return; }

        //Other has hitbox component
        if (CanHitOther(otherHitbox))
        {
            VFXManager._Instance.InstantiateVFX(eVFXType.Hit, other.ClosestPoint(transform.position));
            otherHitbox.GetHit(this); 
            
        }
    }

    protected bool CanHitOther(RD_Hitbox other)
    {
        return (m_canGiveHit && other.m_canReceiveHit && m_affectedAgentTypes.Contains(other.m_agentType));
    }

    protected void GetHit(RD_Hitbox otherHitbox)
    {

        Debug.Log(gameObject.name + " got hit by: " + otherHitbox.name);
    }

}

public enum EAgentType
{
    Ally,
    Enemy,
    Neutral,
    Count
}
