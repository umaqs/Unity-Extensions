using UnityEngine;
using System.Collections;

public class StateImplementor : MonoBehaviour {

    public State currentState;
    public State prevState;

	protected virtual void Awake()
    {
    }

    // Use this for initialization
    protected virtual void Start()
    {
        SetupStateHandlers();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (currentState != null &&
         currentState.Update != null)
		{
			currentState.Update();
		}
    }

	// Update is called once per frame
	protected virtual void FixedUpdate()
	{
		if (currentState != null &&
		    currentState.FixedUpdate != null)
		{
			currentState.FixedUpdate();
		}
	}

    protected virtual void UpdateState(State newState)
    {
        // Switch case for Previous State handling
        if (!PrevStateEnd(newState))
        {
//			Debug.Log("---------------------Not going to update state::"+newState.Name+"::CurrentState::"+currentState.Name);
            // return if prev state wants to not continue further
            return;
        }
		 
        // Update state variables
        prevState = currentState;
        currentState = newState;

        CurrStateBegin(newState);
    }

    protected virtual bool PrevStateEnd(State newState)
    {
        bool retVal = true;
        if (currentState != null && currentState.OnStateEnded != null)
		{
//			Debug.Log("-- PrevStateEnd : " + currentState.Name);
			retVal = currentState.OnStateEnded(newState);
		}
        return retVal;
    }

    protected virtual void CurrStateBegin(State newState)
    {
        if (currentState != null && currentState.OnStateBegin != null)
            currentState.OnStateBegin();
    }

    protected virtual void SetupStateHandlers()
    {

    }

    protected virtual void UpdateToPrevState()
    {
        UpdateState(prevState);
    }


}
