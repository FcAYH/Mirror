using UnityEngine;

namespace Mirror.Examples.PredictionBenchmark
{
    public class CubeForce : NetworkBehaviour
    {
        public float force = 50;

        void OnMouseDown()
        {
            Debug.Log($"Applying force to: {name}");

            // apply force in a random direction, this looks best
            Vector3 direction = Random.insideUnitSphere;
            Vector3 impulse = direction * force;

            // apply force in that direction
            Rigidbody rb = GetComponent<PredictedRigidbody>().predictedRigidbody;
            rb.AddForce(impulse, ForceMode.Impulse);
            CmdApplyForce(direction);

        }

        // every play can apply force to this object (no authority required)
        [Command(requiresAuthority = false)]
        void CmdApplyForce(Vector3 direction)
        {
            // apply force in that direction
            Vector3 impulse = direction * force;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(impulse, ForceMode.Impulse);
        }
    }
}
