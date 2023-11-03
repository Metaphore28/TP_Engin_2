public abstract class CharacterState : IState
{
    protected CharacterControllerStateMachine m_stateMachine;

    public virtual void OnStart()
    {
        throw new System.NotImplementedException();

    }
    public virtual void OnStart(CharacterControllerStateMachine characterControllerStateMachine)
    {
        m_stateMachine = characterControllerStateMachine;
    }

    public virtual void OnEnter()
    {
    }

    public virtual void OnExit()
    {
    }

    public virtual void OnFixedUpdate()
    {
    }

    public virtual void OnUpdate()
    {
    }

    public virtual bool CanEnter(IState currentState)
    {
        throw new System.NotImplementedException();
    }

    public virtual bool CanExit()
    {
        throw new System.NotImplementedException();
    }

}
