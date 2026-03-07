const questions = [
    {
        question: "Which language is used for web styling?",
        options: ["HTML", "CSS", "Java", "Python"],
        answer: "CSS"
    },
    {
        question: "Which company developed Java?",
        options: ["Microsoft", "Sun Microsystems", "Google", "Apple"],
        answer: "Sun Microsystems"
    },
    {
        question: "Which keyword is used to declare a variable in JavaScript?",
        options: ["int", "var", "string", "float"],
        answer: "var"
    }
];

let currentQuestion = 0;
let score = 0;
let timeLeft = 10;
let timer;

const questionElement = document.getElementById("question");
const optionsElement = document.getElementById("options");
const resultElement = document.getElementById("result");
const nextBtn = document.getElementById("nextBtn");
const timerElement = document.getElementById("timer");

function startTimer() {
    timeLeft = 10;
    timerElement.textContent = "Time Left: " + timeLeft + "s";

    timer = setInterval(() => {
        timeLeft--;
        timerElement.textContent = "Time Left: " + timeLeft + "s";

        if (timeLeft === 0) {
            clearInterval(timer);
            nextBtn.style.display = "block";
        }
    }, 1000);
}

function loadQuestion() {
    clearInterval(timer);
    startTimer();

    const q = questions[currentQuestion];
    questionElement.textContent = q.question;
    optionsElement.innerHTML = "";
    nextBtn.style.display = "none";

    q.options.forEach(option => {
        const button = document.createElement("button");
        button.textContent = option;

        button.addEventListener("click", () => checkAnswer(button, q.answer));

        optionsElement.appendChild(button);
    });
}

function checkAnswer(button, correctAnswer) {
    clearInterval(timer);

    const buttons = optionsElement.querySelectorAll("button");

    buttons.forEach(btn => {
        if (btn.textContent === correctAnswer) {
            btn.classList.add("correct");
        } else {
            btn.classList.add("wrong");
        }
        btn.disabled = true;
    });

    if (button.textContent === correctAnswer) {
        score++;
    }

    nextBtn.style.display = "block";
}

nextBtn.addEventListener("click", () => {
    currentQuestion++;

    if (currentQuestion < questions.length) {
        loadQuestion();
    } else {
        showResult();
    }
});

function showResult() {
    questionElement.textContent = "Quiz Completed!";
    optionsElement.innerHTML = "";
    nextBtn.style.display = "none";
    timerElement.style.display = "none";

    resultElement.textContent = "Your Score: " + score + " / " + questions.length;
}

loadQuestion();