using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreatePlayerName : MonoBehaviour
{
    [SerializeField] private TMP_InputField _creatName;

    public void ClickJoinButton()
    {
        if (_creatName.text.Length >= 2 && _creatName.text.Length <= 10)
        {
            GameManager.Instance._playerData._name = _creatName.text;
            SceneManager.LoadScene("GameScene");
        }
    }
}
