using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class TutorialStep
{
    public string stageLabel;
    public string text;
    public Sprite image;
}

public class Quick : MonoBehaviour
{
    
    public TextMeshProUGUI stageText;
    public TextMeshProUGUI Text;    
    public RawImage Image;            
    public Button next;          
    public Button back;
    public GameObject backB;
    public GameObject nextB;
    public Button ToMain;
    public GameObject panel;
    public GameObject Buttons;
    [Header("ируш")]
    public TutorialStep[] steps;        

    private int currentStep = 0;       

    void Start()
    {
        next.onClick.AddListener(NextStep);
        back.onClick.AddListener(PreviousStep);
        ToMain.onClick.AddListener(PressToMain);
        UpdateUI();
    }

    void PressToMain()
    {
        panel.SetActive(false);
        Buttons.SetActive(true);
    }

    void NextStep()
    {
        if (currentStep < steps.Length - 1)
        {
            currentStep++;
            UpdateUI();
        }
    }

    void PreviousStep()
    {
        if (currentStep > 0)
        {
            currentStep--;
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        TutorialStep step = steps[currentStep];

        stageText.text = step.stageLabel;
        Text.text = step.text;
        Image.texture = step.image.texture;
        backB.SetActive(currentStep > 0);
        nextB.SetActive(currentStep < steps.Length - 1);
    }
}
