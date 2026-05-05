using UnityEngine;
using UnityEngine.InputSystem;
public class movpersonaje : MonoBehaviour
{




 public float velocidad = 0.5f;




public Vector3 inicioPersonaje = new Vector3 (1,2,3);
Animator controlAnimacion;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     this.transform.position = inicioPersonaje;
     controlAnimacion = GetComponent<Animator>();




   
    }




    // Update is called once per frame
    void Update()
    {
       
      Vector2 moveInput = InputSystem.actions["Move"].ReadValue<Vector2>();
     
      this.transform.Translate(moveInput.x * velocidad, moveInput.y * velocidad, 0);
     
      if(moveInput.x < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        } else if (moveInput.x > 0)
        {
           this.GetComponent<SpriteRenderer>().flipX = false;




        }


        //Animacion caminando
     if (moveInput.x != 0)
        {
            controlAnimacion.SetBool("activaCamina", true);
        }
        else
        {
            controlAnimacion.SetBool("activaCamina", false);
        }






    }
}

