using TMPro;
using UnityEngine;

namespace Sample
{
    public class Hello : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text = default!;

        private void Start()
        {
            Debug.Log("Hello");
            _text.text = "Hello";
        }
    }
}
