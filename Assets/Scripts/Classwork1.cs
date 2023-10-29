using UnityEngine;

public class Classwork1 : MonoBehaviour
{
    //Ex.1
    private int _a = 5;
    private int _b = 6;
    private int _c = 7;
    //Ex.2
    private int _InStock = 150;
    private string _Name = "ElfBar";
    private int _Price = 350;
    //Ex.3
    private int _OldPrice = 5;
    private int _NewPrice = 10;
    private int _temp = 0;
    //Ex.4
    private int _IphoneQuantity = 10;
    private int _PriceIphone = 900;
    
    void Start()
    {
        Debug.Log("Ex.1");
        Debug.Log($"int a: {_a}, int b; {_b}, int c {_c}");
        Debug.Log("______________________________________");
        Debug.Log("Ex.2");
        Debug.Log($"Name : {_Name}, Price : {_Price}");
        Debug.Log("______________________________________");
        Debug.Log("Ex.3");
        Debug.Log($"Min : {_OldPrice}");
        Debug.Log($"Max : {_NewPrice}");
        _temp = _NewPrice;
        _NewPrice = _OldPrice;
        _OldPrice = _temp;
        Debug.Log("Swap their values");
        Debug.Log($"Min : {_OldPrice}");
        Debug.Log($"Max : {_NewPrice}");
        Debug.Log("______________________________________");
        Debug.Log("Ex.4");
        int Difference = _IphoneQuantity - _PriceIphone;
        int Product = _IphoneQuantity * _PriceIphone;
        Debug.Log($"Difference : {Difference}");
        Debug.Log($"Product : {Product}");
    }
}
