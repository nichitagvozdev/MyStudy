using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ManagerScript : MonoBehaviour
{
    private int _task;
    private int playerNumber;
    [SerializeField] private Text _playerText;
    [SerializeField] private GameObject _button;
    [SerializeField] private TextMeshProUGUI _ahint;

    void Start()
    {
        _task = Random.Range(0, 100);
        Debug.Log(_task);
        _ahint.GetComponent<TextMeshPro>();
    }

    public void ReadMsg()
    {
        if (int.TryParse(_playerText.text, out playerNumber))
        {
            if (playerNumber > _task)
            {
                _ahint.text = "Your number is greater than the task";
            }
            else if (playerNumber < _task)
            {
                _ahint.text = "Your number is less than the task.";
            }
            else
            {
                _ahint.text = "Your number is equal to the task.";
            }
        }
        else
        {
            _ahint.text = "Invalid number format in the input field.";
        }
    }

}