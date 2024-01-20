function FileInput() {
    var formData = new FormData();
    formData.append("file", $("#fileUpload")[0].files[0]);

    $.ajax({
        type: "POST",
        url: "../Utilities/CertificateUploadHandler.ashx",
        data: formData,
        contentType: false,
        processData: false,
        success: function (re) {
            //var data = JSON.parse(re.d);
            var Upload = re;
            validation(Upload);
        },
        error: function (error) {
            // Handle error (if needed)
            console.log("Error: " + error);
        }
    });
}

function validation(upload) {
    var name = $("#txtName").val();
    var surname = $("#txtSurname").val();
    var phone = $("#txtPhone").val();
    var email = $("#txtEmail").val();
    var gender = $("input[name='gender']:checked").val();
    var dob = $("#dateDob").val();
    var city = $("#ddlCity").val();
    var address = $("#txtArea").val();
    var qualification = $("#ddlQualification").val();
    var percentage = $("#txtPercentage").val();
    /*********name********/
    if (name == null || name === "") {
        alert("Please enter Your Name");
        $("#txtName").focus();
        return false;
    }
    else if (name.length < 3) {
        alert("Name should contain atleast 3 Characters");
        $("#txtName").focus();
        return false;
    }
    else if (!name.match(/^[a-zA-Z]+$/)) {
        alert("Name should contain only letters (no digits or special characters).");
        $("#txtName").focus();
        return false;
    }
    /********surname********/
    if (surname == null || surname === "") {
        alert("Please enter Your SurName");
        $("#txtSurname").focus();
        return false;
    }
    else if (surname < 3) {
        alert("SurName should contain atleast 3 Characters");
        $("#txtSurname").focus();
        return false;
    }
    if (!/^[a-zA-Z]+$/.test(surname)) {
        alert("Surname should contain only letters (no digits or special characters).");
        $("#txtSurname").focus();
        return false;
    }

    /*********phone*******/
    if (phone == null || phone === "") {
        alert("Please enter your Phone number.");
        $("#txtPhone").focus();
        return false;
    }
    else if (phone.length !== 10) {
        alert("Mobile Number should be exactly 10 digits.");
        $("#txtPhone").focus();
        return false;
    }
    else if (!phone.match(/^[9|8|7|6]\d/)) {
        alert("Phone number should start with 9,8,7 or 6.");
        $("#txtPhone").focus();
        return false;
    }
    else if (!phone.match(/^\d+$/)) {
        alert("Mobile number should only contain digits.");
        $("#txtPhone").focus();
        return false;
    }
    /**********email*********/
    if (email == null || email === "") {
        alert("Please enter your email address.");
        $("#txtEmail").focus();
        return false;
    }
    else if (!email.match(/^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/)) {
        alert("Please enter a valid email.");
        $("#txtEmail").focus();
        return false;
    }
    /********gender********/
    if (gender == null || gender === "") {
        alert("Please select a gender.");
        $("#gender").focus();
        return false;
    }
    /*********dob**********/
    var today = new Date();
    var dateofbirth = new Date(dob);
    var age = today.getFullYear() - dateofbirth.getFullYear();
    var monthDiff = today.getMonth() - dateofbirth.getMonth();
    if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dateofbirth.getDate())) {
        age--;
    }
    if (dob == null || dob === "") {
        alert("Please enter your date of birth.");
        $("#dateDob").focus();
        return false;
    }
    else if (dateofbirth > today) {
        alert("Invalid date of birth.");
        $("#dateDob").focus();
        return false;
    }
    if (age < 18 || age > 30) {
        alert("The age should be between 18 and 30 years.");
        $("#dateDob").focus();
        return false;
    }
    /*******city***********/
    if (city == null || city === " " || city === "0") {
        alert("Please select your city.");
        $("#ddlCity").focus();
        return false;
    }
    /*******Address********/
    if (address == null || address === "") {
        alert("Please enter your address.");
        $("#txtArea").focus();
        return false;
    }
    else if (address.length < 20) {
        alert("Address must contain 20 characters.");
        $("#txtArea").focus();
        return false;
    }
    /******qualification*****/
    if (qualification == null || qualification === "" || qualification === "0") {
        alert("Please Select your Qualification");
        $("#ddlQualification").focus();
        return false;
    }
    /*****percentage*******/
    if (percentage == null || percentage === "") {
        alert("Please enter your Percentage");
        $("#txtPercentage").focus();
        return false;
    }
    else if (percentage < 65) {
        alert("Percentage should me more than 65, if not You are ineligible");
        $("#txtPercentage").focus();
        return false;
    }
    else if (percentage > 100) {
        alert("Invalid Percentage");
        $("#txtPercentage").focus();
        return false;
    }
    /********upload*******/
 
    /*var upload = $("#fileupload")[0].files[0];*/
    var upload = upload;

    /*$("#fileUpload").val();*/
    if (upload == null || upload === "") {
        alert("Please upload a file");
        $("#fileUpload").focus();
        return false;
    }


   


    var data = {};
    data.name = name;
    data.surname = surname;
    data.phone = phone;
    data.email = email;
    data.gender = gender;
    data.dob = dob;
    data.city = city;
    data.address = address;
    data.qualification = qualification;
    data.percentage = percentage;
    data.upload = upload;


    $.ajax({
        type: "POST",
        url: "RecruiteeRegistration.aspx/InsertRegistrationData",
        data: JSON.stringify({ data: data }),
        datatype: "JSON",
        contentType: "application/json",
        success: function (res) {
            var obj = JSON.parse(res.d);
            if (obj[0] != null) {
                if (obj[0].FLAG === 0) {
                    alert(obj[0].MSG);
                          
                }
                else if (obj[0].FLAG === 1){
                  /*  alert(obj[0].MSG);*/        
                    /* window.location = "RecruiteePayment.aspx";*/
                    window.location = "../Test/OtpModalPopUp.aspx";
                    var form = $("#form");
                    form[0].reset();

                }
            }

        },
        error: function (err) {
            alert(err);
        }
    });
  
}


function onlyNumbers(evt) {
    var charcode = (evt.which) ? evt.which : evt.keyCode;
    if (charcode >= 48 && charcode <= 57) {
        var inputValue = $("#txtPhone").val();
        if (inputValue.length === 0 && (charcode < 54 || charcode > 57)) {
            evt.preventDefault();
        }
    } else {
        evt.preventDefault();
    }

    return true;
}
function noNumbers(evt) {
    var charcode = (evt.which) ? evt.which : evt.keyCode;
    if ((charcode >= 65 && charcode <= 90) || (charcode >= 97 && charcode <= 122)) {
        return true;  
    } else {
        evt.preventDefault();
        return false;  
    }
}
 
function noSpaces(evt) {
    var charcode = (evt.which) ? evt.which : evt.keyCode;
    if (charcode === 32) {
        evt.preventDefault();
    }
    return true;
}


function cities() {

    $("#ddlCity").empty();
    $.ajax({
        type: "POST",
        url: "RecruiteeRegistration.aspx/CitiesGet",
        data: "{}",
        async: true,
        contentType: "application/json",
        success: function (res) {

            if ((res.d) == "") {
                alert("No Data Found ");
                return false;
            }
            else {
                $("#ddlCity").append("<option value=" + "0" + ">" + "Select City" + "</option>");
                var obj = JSON.parse(res.d);
                $.each(obj, function (index, value) {
                    $("#ddlCity").append("<option value=" + value.cityName + ">" + value.cityName + "</option>");

                });

            }

        },
        error: function (err) {

            alert("Something went wrong! Please Try Again Later");
        },
        complete: function (data) {

        }
    });
}

function qualifications() {
    $("#ddlQualification").empty();
    $.ajax({
        type: "POST",
        url: "RecruiteeRegistration.aspx/QualificationGet",
        data: "{}",
        async: true,
        contentType: "application/json",
        success: function (result) {

            if ((result.d) == "") {
                alert("No Data Found ");
                return false;
            }
            else {
                $("#ddlQualification").append("<option value=" + "0" + ">" + "Highest Qualification" + "</option>");
                var obj1 = JSON.parse(result.d);
                $.each(obj1, function (index, value) {
                    $("#ddlQualification").append("<option value=" + value.Qualification + ">" + value.Qualification + "</option>");

                });
            }
        },
        error: function (err) {

            alert("Something went wrong! Please Try Again Later");
        },
        complete: function (data) {
        }
    });
}

 

function logout() {

    $.ajax({
        type: "POST",
        url: "RecruiteeRegistration.aspx/Logout",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function () {
            window.location.href = "../Signup/LoginPage.aspx";
        },
        error: function (xhr, status, error) {
            console.error(xhr.responseText);
        }
    });
}