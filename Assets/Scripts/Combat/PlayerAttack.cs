using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackHitbox;
    public float attackCooldown = 0.5f;

    private float lastAttackTime;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TryAttack();
        }
    }

    void TryAttack()
    {
        if (Time.time < lastAttackTime + attackCooldown)
            return;

        lastAttackTime = Time.time;
        StartCoroutine(AttackRoutine());
    }

    System.Collections.IEnumerator AttackRoutine()
    {
        attackHitbox.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        attackHitbox.SetActive(false);
    }
}
