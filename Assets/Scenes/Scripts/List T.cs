

using UnityEngine;
using System.Collections.Generic;


public class ListT : MonoBehaviour
{

    [SerializeField] public List<int> _listT;

    [ContextMenu("show list")]
    public void ShowList()
    {
     /*   for (int i = 0; i < _listT.Count; i=i+1)
        {Debug.Log(_listT[i]);}
   */
     Debug.Log(string.Join(", ", _listT));
     Debug.Log(_listT);
    }
    
    
    [ContextMenu("Add Specific Element (5)")]
    private void AddElement()
    {
        if (_listT == null)
        {
            _listT = new List<int>(); // Ensure the list is initialized
        }
        _listT.Add(5);
    }
    
    
    [ContextMenu("RemoveLastElement")]
    public void RemoveLastElement()
    {
        if (_listT != null && _listT.Count > 0)
        {
            _listT.RemoveAt(_listT.Count - 1);
        }
    }
    
    [ContextMenu("SortAscending")]
    private void SortListAscending()
    {
        if (_listT != null && _listT.Count > 1)
        {
            _listT.Sort(); // Sorts in ascending order
        }
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
/*
    [ContextMenu("Format List")]
    private void FormatList()
    {
        for (int i = 0; i < _listT.Count; i = i + 1)
        { public void RemoveLastElement()}
    }*/

}
