This example is used to stabilize our prediction algorithm for stacked Rigidbodies, which is a hard problem to solve.

It's important to understand that there are two problems here:

1. Stacking Rigidbodies with Unity physics - even in single player this is not too easy.
   See this thread:
   https://forum.unity.com/threads/stacking-boxes-issue.1341128/

2. Networked Prediction for stacked Rigidbodies - this is even harder since Rigidbodies
   will occasionally need to be corrected by moving through each other into the correct
   position.

==> This demo is NOT READY for users or for production games.
==> For now, this is only for the Mirror team to debug prediction.

DO NOT USE THIS
