using UnityEngine;

namespace DevilsReturn
{
    public class UIManager : BaseMonoBehaviour
    {
        [SerializeField] private GameObject damageUIPrefab;

        public void InstantiateDamageUI(DamageData damageData, Vector3 position)
        {
            var damageUI = Instantiate(damageUIPrefab, position, Quaternion.identity).GetComponent<DamageUI>();
            damageUI.SetDamageData(damageData); 
        }
    }
}