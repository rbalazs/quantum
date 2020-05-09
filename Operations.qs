namespace Quantum.Entaglement {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
  
    operation Entaglement() : (Result, Result) {

        mutable qubitOneState = Zero;
        mutable qubitTwoState = Zero;

        using ((qubitOne, qubitTwo) = (Qubit(), Qubit())) {
            // There are others syntax to entangle 2 qubits.
            H(qubitOne);
            CNOT(qubitOne, qubitTwo);

            set qubitOneState = M(qubitOne);
            set qubitTwoState = M(qubitTwo);

            Reset(qubitOne);
            Reset(qubitTwo);
        }

        return (qubitOneState, qubitTwoState);
    }
}