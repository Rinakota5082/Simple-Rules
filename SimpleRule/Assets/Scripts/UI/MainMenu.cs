using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button quick;
    [SerializeField] Button instr;
    [SerializeField] Button gallery;
    [SerializeField] GameObject buttons;
    [SerializeField] GameObject Quick;
    [SerializeField] GameObject Picture;
    [SerializeField] GameObject ShortInstr;
    [SerializeField] GameObject MainPanel;
    void Start()
    {
        quick.onClick.AddListener(PressQuick);
        instr.onClick.AddListener(PressShort);
        gallery.onClick.AddListener(PressGallery);
        Quick.SetActive(false);
        Picture.SetActive(false);
        ShortInstr.SetActive(false);
    }

    void PressQuick()
    {
        buttons.SetActive(false);
        Quick.SetActive(true);
    }
    void PressShort()
    {
        buttons.SetActive(false);
        ShortInstr.SetActive(true);
    }
    void PressGallery()
    {
        buttons.SetActive(false);
        Picture.SetActive(true);
    }
}
