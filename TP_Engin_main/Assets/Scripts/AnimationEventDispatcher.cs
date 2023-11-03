using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventDispatcher : MonoBehaviour
{
    private CharacterControllerStateMachine m_stateMachineRef;
    private void Awake()
    {
        m_stateMachineRef = GetComponent<CharacterControllerStateMachine>();
    }
    public void ActivateHitBox()
    {
        m_stateMachineRef.OnEnableAttackHitbox(true);
    }
    public void DeactivateHitBox()
    {
        m_stateMachineRef.OnEnableAttackHitbox(false);
    }
}
