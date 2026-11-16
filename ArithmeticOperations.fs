

function kosu(a, b) {
    if (!Number.isFinite(a) || !Number.isFinite(b)) {
        return "Қате: екі сан енгізу қажет.";
    }
    return a + b;
}

function azaitu(a, b) {
    if (!Number.isFinite(a) || !Number.isFinite(b)) {
        return "Қате: екі сан енгізу қажет.";
    }
    return a - b;
}

function kobeitu(a, b) {
    if (!Number.isFinite(a) || !Number.isFinite(b)) {
        return "Қате: екі сан енгізу қажет.";
    }
    return a * b;
}

function bolu(a, b) {
    if (!Number.isFinite(a) || !Number.isFinite(b)) {
        return "Қате: екі сан енгізу қажет.";
    }

    if (b === 0) {
        return "Қате: нөлге бөлуге болмайды.";
    }

    return a / b;
}

// Функцияларды тексеру
console.log("Қосу:", kosu(10, 5));
console.log("Қосуды тексеру:", kosu("а", 5));

console.log("Азайту:", azaitu(10, 5));
console.log("Азайтуды тексеру:", azaitu(10, "б"));

console.log("Көбейту:", kobeitu(10, 5));
console.log("Көбейтуді тексеру:", kobeitu("в", 5));

console.log("Бөлу:", bolu(10, 5));
console.log("Бөлуді тексеру:", bolu(10, "г"));
console.log("Нөлге бөлу:", bolu(10, 0));
