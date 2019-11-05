namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;
    using VRTK.Controllables;

    public class TogglePointerInteraction : MonoBehaviour
    {
        public enum OptionType
        {
            InteractWithObjects,
            GrabToPointerTip
        }

        public OptionType optionType = OptionType.InteractWithObjects;
        public VRTK_Pointer[] pointers = new VRTK_Pointer[0];
     


        /*protected virtual void OnEnable()
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = audioClip;
            audio.Play();
        }*/

        protected virtual void OnDisable()
        {
       
          
        }

      
    }
}