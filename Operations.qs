﻿namespace Quantum.Entaglement {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    

    @EntryPoint()
    operation Entaglement() : Result {
        mutable state = Zero;
        using(qubit = Qubit()) {
            H(qubit);
            set state = M(qubit);
            Reset(qubit);
        }
        return state;
    }
}

