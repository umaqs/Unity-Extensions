using UnityEngine;
using System.Collections;

public class State
{
    // Delegates for state event handling
    public delegate void StateUpdate();
    public delegate void StateBegin();
    public delegate bool StateEnded(State newstate);
	public delegate void StateDelegate(object obj);

    // callback instances from delegates
    public StateUpdate Update;
	public StateUpdate FixedUpdate;
    public StateBegin OnStateBegin;
    public StateEnded OnStateEnded;
	public StateDelegate OnStateDelegate;

    // Member variable to identify state

    private readonly string name;
	private readonly int stateId;
    public string Name
    {
        get { return name; }
    }
	public int StateId
	{
		get { return stateId; }
	}

    // Constructor
    public State(string name)
    {
        this.name = name;
    }
	public State(string name,int id)
	{
		this.name = name;
		this.stateId = id;
	}
};
