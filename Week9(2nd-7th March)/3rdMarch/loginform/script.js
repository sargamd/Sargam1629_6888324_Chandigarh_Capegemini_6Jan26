function isValidEmail(email) {
    const pattern = /^[^ ]+@[^ ]+\.[a-z]{2,3}$/;
    return pattern.test(email);
}


document.getElementById("registerForm").addEventListener("submit", function(e) {
    e.preventDefault();

    const username = document.getElementById("regUsername").value;
    const email = document.getElementById("regEmail").value;
    const password = document.getElementById("regPassword").value;
    const confirmPassword = document.getElementById("regConfirmPassword").value;
    const message = document.getElementById("regMessage");

    message.innerHTML = "";

    if (!isValidEmail(email)) {
        message.innerHTML = "Invalid Email Format";
        message.className = "error";
        return;
    }

    if (password.length < 6) {
        message.innerHTML = "Password must be at least 6 characters";
        message.className = "error";
        return;
    }

    if (password !== confirmPassword) {
        message.innerHTML = "Passwords do not match";
        message.className = "error";
        return;
    }

    
    const user = { username, email, password };
    localStorage.setItem(email, JSON.stringify(user));

    message.innerHTML = "Registration Successful!";
    message.className = "success";

    document.getElementById("registerForm").reset();
});


document.getElementById("loginForm").addEventListener("submit", function(e) {
    e.preventDefault();

    const email = document.getElementById("loginEmail").value;
    const password = document.getElementById("loginPassword").value;
    const message = document.getElementById("loginMessage");

    message.innerHTML = "";

    const storedUser = localStorage.getItem(email);

    if (!storedUser) {
        message.innerHTML = "User not found";
        message.className = "error";
        return;
    }

    const user = JSON.parse(storedUser);

    if (user.password !== password) {
        message.innerHTML = "Incorrect Password";
        message.className = "error";
        return;
    }

    message.innerHTML = "Login Successful!";
    message.className = "success";

    document.getElementById("loginForm").reset();
});