using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateMachineOwner { }
public class StateMachine
{
    private IStateMachineOwner owner;

    /// <summary>
    /// ≥ı ºªØ
    /// </summary>    
    public void Init(IStateMachineOwner owner)
    {
        this.owner = owner;
    }

    public bool ChangeState<T>(int newStateType)where T: StateBase,new()
    {
        Type type = typeof(T);
        return false;
    }
}
