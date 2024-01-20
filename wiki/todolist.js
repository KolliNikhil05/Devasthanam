document.addEventListener("DOMContentLoaded", function () {
    const taskInput = document.getElementById("taskInput");
    const addTaskButton = document.getElementById("addTask");
    const taskList = document.getElementById("taskList");

    addTaskButton.addEventListener("click", function () {
        const taskText = taskInput.value.trim();
        if (taskText !== "") {
            addTask(taskText);
            taskInput.value = "";
        }
    });

    function addTask(taskText) {
        const li = document.createElement("li");
        li.innerHTML = `
            ${taskText}
            <button class="complete">Complete</button>
            <button class="delete">Delete</button>
        `;
        taskList.appendChild(li);

        const completeButton = li.querySelector(".complete");
        const deleteButton = li.querySelector(".delete");

        completeButton.addEventListener("click", function () {
            li.classList.toggle("completed");
        });

        deleteButton.addEventListener("click", function () {
            li.remove();
        });
    }
});
document.addEventListener("DOMContentLoaded", function () {
    const taskInput = document.getElementById("taskInput");
    const addTaskButton = document.getElementById("addTask");
    const taskList = document.getElementById("taskList");
    const filterSelect = document.getElementById("filter");
    const totalTasksCount = document.getElementById("totalTasks");
    const completedTasksCount = document.getElementById("completedTasks");
    const remainingTasksCount = document.getElementById("remainingTasks");

    // Load tasks from local storage on page load
    const tasks = JSON.parse(localStorage.getItem("tasks")) || [];

    // Function to update task counts
    function updateTaskCounts() {
        totalTasksCount.textContent = tasks.length;
        const completedTasks = tasks.filter(task => task.completed);
        completedTasksCount.textContent = completedTasks.length;
        remainingTasksCount.textContent = tasks.length - completedTasks.length;
    }

    // Function to render tasks
    function renderTasks() {
        taskList.innerHTML = "";
        tasks.forEach((task, index) => {
            const li = document.createElement("li");
            li.innerHTML = `
                ${task.text}
                <span class="timestamp">${task.timestamp}</span>
                <button class="complete">${task.completed ? "Undo" : "Complete"}</button>
                <button class="delete">Delete</button>
            `;
            li.classList.toggle("completed", task.completed);
            taskList.appendChild(li);

            const completeButton = li.querySelector(".complete");
            const deleteButton = li.querySelector(".delete");

            completeButton.addEventListener("click", function () {
                tasks[index].completed = !tasks[index].completed;
                localStorage.setItem("tasks", JSON.stringify(tasks));
                renderTasks();
                updateTaskCounts();
            });

            deleteButton.addEventListener("click", function () {
                tasks.splice(index, 1);
                localStorage.setItem("tasks", JSON.stringify(tasks));
                renderTasks();
                updateTaskCounts();
            });
        });
    }

    // Event listener for adding a task
    addTaskButton.addEventListener("click", function () {
        const taskText = taskInput.value.trim();
        if (taskText !== "") {
            const timestamp = new Date().toLocaleString();
            tasks.push({ text: taskText, completed: false, timestamp });
            localStorage.setItem("tasks", JSON.stringify(tasks));
            renderTasks();
            updateTaskCounts();
            taskInput.value = "";
        }
    });

    // Event listener for task filtering
    filterSelect.addEventListener("change", function () {
        const filterValue = filterSelect.value;
        if (filterValue === "completed") {
            renderTasks(tasks.filter(task => task.completed));
        } else if (filterValue === "uncompleted") {
            renderTasks(tasks.filter(task => !task.completed));
        } else {
            renderTasks(tasks);
        }
    });

    // Initial rendering of tasks and task counts
    renderTasks(tasks);
    updateTaskCounts();
});
