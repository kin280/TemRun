using UnityEngine;

public class Gem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerPrefs.SetInt("TotalGems", PlayerPrefs.GetInt("TotalGems", 0) + 1);
            FindObjectOfType<AudioManager>().PlaySound("PickUp");
            PlayerManager.score += 2;
            gameObject.SetActive(false);
        }
    }
}
