using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDisplay : MonoBehaviour
{
    public Coin coin;
    public float transitionDuration = 3.0f;
    private SpriteRenderer spriteRenderer;
    private float delayFrames = 0.1f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(TransitionColors());
       
    }

    IEnumerator TransitionColors()
    {
        float elapsedTime = 0f;

        while (elapsedTime < transitionDuration)
        {
            Color currentColor = Color.Lerp(coin.color1, coin.color2, elapsedTime / transitionDuration);

            spriteRenderer.color = currentColor;

            yield return new WaitForSeconds(delayFrames);

            elapsedTime += delayFrames;
        }

        spriteRenderer.color = coin.color2;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("dinosaur"))
        {

            Destroy(gameObject);
            SMManager.score += coin.coinValue;
            Debug.Log(SMManager.score);
        }
    }
}
