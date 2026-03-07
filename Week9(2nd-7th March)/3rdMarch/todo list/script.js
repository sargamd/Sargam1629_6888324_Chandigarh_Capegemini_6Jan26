const taskInput = document.getElementById("taskInput");
const addBtn = document.getElementById("addBtn");
const taskList = document.getElementById("taskList");


document.addEventListener("DOMContentLoaded", loadTasks);

addBtn.addEventListener("click", addTask);

function addTask() {
    const taskText = taskInput.value.trim();

    if (taskText === "") {
        alert("Please enter a task");
        return;
    }

    createTaskElement(taskText, false);
    saveTask(taskText, false);

    taskInput.value = "";
}

function createTaskElement(taskText, isCompleted) {
    const li = document.createElement("li");

    const checkbox = document.createElement("input");
    checkbox.type = "checkbox";
    checkbox.checked = isCompleted;

    const span = document.createElement("span");
    span.textContent = taskText;

    if (isCompleted) {
        span.classList.add("completed");
    }

    checkbox.addEventListener("change", function() {
        span.classList.toggle("completed");
        updateLocalStorage();
    });

    const deleteBtn = document.createElement("button");
    deleteBtn.textContent = "Delete";
    deleteBtn.classList.add("delete-btn");

    deleteBtn.addEventListener("click", function() {
        li.remove();
        updateLocalStorage();
    });

    li.appendChild(checkbox);
    li.appendChild(span);
    li.appendChild(deleteBtn);

    taskList.appendChild(li);
}

function saveTask(taskText, isCompleted) {
    let tasks = JSON.parse(localStorage.getItem("tasks")) || [];
    tasks.push({ text: taskText, completed: isCompleted });
    localStorage.setItem("tasks", JSON.stringify(tasks));
}

function loadTasks() {
    let tasks = JSON.parse(localStorage.getItem("tasks")) || [];
    tasks.forEach(task => {
        createTaskElement(task.text, task.completed);
    });
}

function updateLocalStorage() {
    let tasks = [];
    document.querySelectorAll("#taskList li").forEach(li => {
        const text = li.querySelector("span").textContent;
        const completed = li.querySelector("input").checked;
        tasks.push({ text, completed });
    });
    localStorage.setItem("tasks", JSON.stringify(tasks));
}