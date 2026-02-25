$(document).ready(function () {

    $("#employeeForm").submit(function (e) {

        e.preventDefault();

        let isValid = true;

        // Clear old errors
        $("small").text("");

        // Username validation
        let username = $("#username").val().trim();
        if (username === "") {
            $("#userError").text("Username is required");
            isValid = false;
        } else if (username.length < 3) {
            $("#userError").text("Username must be at least 3 characters");
            isValid = false;
        }

        // Password validation
        let password = $("#password").val();
        if (password.length < 6) {
            $("#passError").text("Password must be at least 6 characters");
            isValid = false;
        }

        // Position validation
        if ($("#position").val() === "") {
            $("#posError").text("Please select a position");
            isValid = false;
        }

        // Salary validation
        // let salary = $("#salary").val();
        // if (salary === "" || salary <= 0) {
        //     $("#salaryError").text("Enter a valid salary");
        //     isValid = false;
        // }

        // Hire Date validation
        let hireDate = $("#hiredate").val();

        if (hireDate === "") {
            $("#hireDateError").text("Hire date is required");
            isValid = false;
        } else {
            let selectedDate = new Date(hireDate);
            let today = new Date();

            if (selectedDate > today) {
                $("#hireDateError").text("Hire date cannot be in the future");
                isValid = false;
            }
        }


        if (isValid) {

            let username = $("#username").val();
            let password = $("#password").val();
            let position = $("#position").val();
            let salary = $("#salary").val();
            let hiredate = $("#hiredate").val();

            let message =
                "Username: " + username + "\n" +
                "Password: " + password + "\n" +
                "Position: " + position + "\n" +
                "Salary: " + salary + "\n" +
                "Hire Date: " + hiredate;
            alert(message);
        }
    });
});