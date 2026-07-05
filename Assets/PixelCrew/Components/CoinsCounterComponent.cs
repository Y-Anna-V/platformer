using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

namespace PixelCrew.Components
{
    public class CoinsCounterComponent : MonoBehaviour
    {
        private void Awake()
        {
            coins = 0;
            Debug.Log(coins);
        }
        public static int coins = 0;
        public void CountCoins()
        {

            if (tag == "SilverCoin")
            {
                coins++;
            }
            else if (tag == "GoldenCoin")
            {
                coins = coins + 10;
            }
            Debug.Log(coins);
        }

    }
}