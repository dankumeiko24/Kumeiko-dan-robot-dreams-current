using Unity.VisualScripting;
using UnityEngine;

public class Lasson2 : MonoBehaviour
{
   [SerializeField] private int _firstIntegerNumber;
   [SerializeField] private int _secondIntegerNumber;
   [SerializeField] private float _firstFloatNumber;
   [SerializeField] private string _firstString;
   [SerializeField] private bool _firstCheck;
   [SerializeField] private Vector3 _firstvenctor;

   [SerializeField] private struct MyMassive
   {
      public int x,y,z,d,e,a,b,c;
   }
   [SerializeField] int x,y,z,d,e,a,b,c;
   
   [ContextMenu("HelloWorld")] private void HelloWorld()
   {
      Debug.Log("hello world");
   }

   [ContextMenu("Add")]
   private void Add()
   {
      int result = _firstIntegerNumber + _firstIntegerNumber;
      Debug.Log(result);
   }
   
   

}
