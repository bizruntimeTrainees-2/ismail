class Cleaner {
    hasMask: boolean;
}

class House extends Cleaner {
    kichen: number;
}

class room1 extends House {
    hall: Cleaner;
}

function createInstance<A extends House>(c: new () => A): A {
    return new c();
}

createInstance(room1).kichen;   // typechecks!