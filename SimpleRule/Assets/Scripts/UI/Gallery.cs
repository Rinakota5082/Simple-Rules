using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gallery : MonoBehaviour
{
    [SerializeField] Button left;
    [SerializeField] Button right;
    [SerializeField] RawImage gallery;
    [SerializeField] Button back;
    [SerializeField] TMP_Text tex;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject buttons;
    [Header("Pictures")]
    public Sprite[] images;
    int index = 0;
    string[] names = { "Подготвка к игре", "Основа для крыш", "Установка крыш", "Вариант действия игрока: 1", "Вариант действия игрока: 2", "Вариант действия игрока: 2, крыша 1", "Вариант действия игрока: 2, крыша 2", "Вариант действия игрока: 3", "Куда можно помещать плитку", "Вариант действия игрока: 4", "Вариант действия игрока: 4", "Где ловить плитку", "Получение сыра", "Без награды", "Мышка в ловушке", "Игра окончена" };
    void Start()
    {
        
        left.onClick.AddListener(PressLeft);
        right.onClick.AddListener(PressRight);
        back.onClick.AddListener(PressBack);
        ShowImage(0);
    }
    void ShowImage(int num)
    {
        gallery.texture = images[num].texture;
        tex.text=names[num];
    }

    void PressLeft()
    {
        
        if (index == 0) index = images.Length-1;
        else  index--;
        ShowImage(index);
    }
    void PressBack()
    {
        panel.SetActive(false);
        buttons.SetActive(true);
    }
    void PressRight()
    {
        if (index == images.Length - 1) index = 0;
        else index++;
        ShowImage(index);
    }
}
