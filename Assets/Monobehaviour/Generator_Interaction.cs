using UnityEngine;
using TMPro;

// Generator Main Script Controls all Aspects of the Generator in the Game

public class Generator_Interaction : MonoBehaviour, IInteractable 
{
    public RMInventory playerInventory;

    public Item requiredPart;

    public int[] partsRequiredPerStage = { 8, 16, 32 };

    private int currentStage = 0;

    public TextMeshProUGUI uiText;

    public GameObject winnerScreen;

    public Door[] doorsToOpenPerStage;

    public void PlayerInteraction()
    {
        int requiredCount = partsRequiredPerStage[currentStage];

        int count = playerInventory.GetQuantity(requiredPart);

        if (count >= requiredCount) 
        {
            playerInventory.RemoveItem(requiredPart, requiredCount);

            uiText.text = "Stage {currentStage} repair complete!";

            OpenDoorForStage(currentStage);
            currentStage++;

            if (RPGGameManager.sharedInstance != null) 
            {
                RPGGameManager.sharedInstance.generatorStage = currentStage;
            }
            if (currentStage >= partsRequiredPerStage.Length) 
            {
                ShowWinnerScreen();
            }
        }
        else
        {
            uiText.text = "{requiredCount} parts are required to fix generator stage {currentstage}";
        }
    }

    private void OpenDoorForStage(int stage) 
    {
        if (stage < doorsToOpenPerStage.Length && doorsToOpenPerStage[stage] != null)
        {
            doorsToOpenPerStage[stage].Open();
        }
    }

    private void ShowWinnerScreen() 
    {
        if (winnerScreen != null) 
        {
            winnerScreen.SetActive(true);
        }
    }
}