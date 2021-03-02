using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalBehavior : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Game Ended");
        player1.GetComponent<PrototypeHeroDemo>().isDisabled = true;
        player2.GetComponent<PrototypeHeroDemo>().isDisabled = true;

        // Wait before loading back to menu.
        StartCoroutine(OnGoal());
    }

    private IEnumerator OnGoal()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        SceneManager.LoadScene("Menu");
    }
}
