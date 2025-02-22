
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework2Script : MonoBehaviour
{
  
    [SerializeField] private int _SetValue;
    public List<int> _listT;
    
    
 
    [ContextMenu("Show List")]
    public void ShowList()
    {
        /*   for (int i = 0; i < _listT.Count; i=i+1)
           {Debug.Log(_listT[i]);}
      */
        Debug.Log(string.Join(", ", _listT));
        Debug.Log(_listT);
    }   
    
    
    [ContextMenu("Add SetValue")]
    private void AddElement()
    {
        if (_listT == null)
        {
            _listT = new List<int>(); // Ensure the list is initialized
        }
        _listT.Add(_SetValue);
        Debug.Log(string.Join(", ", _listT));
        Debug.Log(_listT);
    }

    [ContextMenu("Remove All SetValue")]
    private void RemoveElement()
    {
        for (int i = 0; i < _listT.Count; i++)
        {
            if (_listT[i] == _SetValue)
            {
                _listT.RemoveAt(i);
                Debug.Log("Removed an element");
            }
        }
    }
	[SerializeField] private int _SetValue;
	public List<int> _listT = new List<int>();
	public string _ListAsString => string.Join(", ", _listT);

    [ContextMenu("Remove First SetValue")]
    private void RemoveOneElement()
    {
        for (int i = 0; i < _listT.Count; i++)
        {
            if (_listT[i] == _SetValue)
            {
                _listT.RemoveAt(i);
                Debug.Log($"Removed first occurrence of {_SetValue} at index {i}");
                break; // Exit the loop after removing the first matching element
            }
        }
    }
    
    [ContextMenu("SortAscending")]
    private void SortListAscending()
    {
        if (_listT != null && _listT.Count > 1)
        {
            _listT.Sort(); // Sorts in ascending order
        }
        Debug.Log(string.Join(", ", _listT));
        Debug.Log(_listT);
    }
    
    [ContextMenu("Format and Clear List")]
    private void FormatAndClearList()
    {
        if (_listT != null)
        {
            _listT.Clear(); // Removes all elements from the list
        }

        Debug.Log("List has been cleared.");
    }

	[ContextMenu("Show List")]
	public void ShowList()
	{
		Debug.Log(_ListAsString);
	}


	[ContextMenu("Add SetValue")]
	private void AddElement()
	{
		_listT.Add(_SetValue);
		Debug.Log(_ListAsString);
	}

	[ContextMenu("Remove All SetValue")]
	private void RemoveElement()
	{
		for (int i = 0; i < _listT.Count; i++)
		{
			if (_listT[i] == _SetValue)
			{
				_listT.RemoveAt(i);
				Debug.Log("Removed an element");
			}
		}
	}

	[ContextMenu("Remove First SetValue")]
	private void RemoveOneElement()
	{
		// Much simpler and clear than loop
		var index = _listT.IndexOf(_SetValue);
		_listT.RemoveAt(index);
		Debug.Log($"Removed first occurrence of {_SetValue} at index {index}");
	}

	[ContextMenu("SortAscending")]
	private void SortListAscending()
	{
		// Calling sort an empty list is perfectly safe and will not cause any errors
		_listT.Sort();
		Debug.Log(_ListAsString);
	}

	[ContextMenu("Format and Clear List")]
	private void FormatAndClearList()
	{
		_listT.Clear(); // Removes all elements from the list

		Debug.Log("List has been cleared.");
	}
}
