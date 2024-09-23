using UnityEngine;

public class ScriptLog : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log($"<{gameObject.name}> ha colisionado con el objeto <{hit.gameObject.name}> ");
    }

    private void Update()
    {
        // Detectar si se presionan teclas específicas
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log($"<{gameObject.name}> ha usado la tecla W");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log($"<{gameObject.name}> ha usado la tecla A");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log($"<{gameObject.name}> ha usado la tecla S");
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log($"<{gameObject.name}> ha usado la tecla D");
        }
    }
}