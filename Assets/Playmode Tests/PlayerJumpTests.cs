using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerJumpTests
{
    [UnityTest]
    public IEnumerator PlayerGoesUpWhenJumpingTest()
    {
        GameObject go = new GameObject();
        PlayerJump jump = go.AddComponent<PlayerJump>();
        Rigidbody rb = go.AddComponent<Rigidbody>();
        jump.Initialize(rb);

        jump.Jump();
        yield return new WaitForSeconds(0.2f);

        Assert.IsTrue(rb.velocity.y > 0);
        Assert.IsTrue(rb.position.y > 0.5f);
    }
}
