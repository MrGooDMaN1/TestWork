using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionContainer<T> where T : CharacterModel
{
    private T _selectedObject;

    public T GetSelectedObject() => _selectedObject;

    public void SetSelectedObject(T gameObject)
    {
        _selectedObject = gameObject;
        _selectedObject.LoadData(); //Loading object data
    }
}
