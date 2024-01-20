 
 
//function validation()
//{
//    var name = $("#ContentPlaceHolder1_txtName").val();
//    var surname = $("#ContentPlaceHolder1_txtSurName").val();
//    var District = $("#ContentPlaceHolder1_ddlDistrict").val();
//    var mandal = $("#ContentPlaceHolder1_ddlMandal").val();
//    var gender = $("input:radio[name*='rdbGender']:checked").val();
    
   
    
//    /*********name********/
//    if (name == null || name === "") {
//        alert("Please enter Your Name");
//        $("#ContentPlaceHolder1_txtName").focus();
//        return false;
//    }
//    else if (name.length < 3) {
//        alert("Name should contain atleast 3 Characters");
//        $("#ContentPlaceHolder1_txtName").focus();
//        return false;
//    }
//    else if (!name.match(/^[a-zA-Z]+$/)) {
//        alert("Name should contain only letters (no digits or special characters).");
//        $("#ContentPlaceHolder1_txtName").focus();
//        return false;
//    }
//    /********surname********/
//    if (surname == null || surname === "") {
//        alert("Please enter Your SurName");
//        $("#ContentPlaceHolder1_txtSurName").focus();
//        return false;
//    }
//    else if (surname < 3) {
//        alert("SurName should contain atleast 3 Characters");
//        $("#ContentPlaceHolder1_txtSurName").focus();
//        return false;
//    }
//    if (!/^[a-zA-Z]+$/.test(surname)) {
//        alert("Surname should contain only letters (no digits or special characters).");
//        $("#ContentPlaceHolder1_txtSurName").focus();
//        return false;
//    }

//    if (District == null || District === " " || District === "0") {
//        alert("Please select your District.");
//        $("#ContentPlaceHolder1_ddlDistrict").focus();
//        return false;
//    }

//    if (mandal == null || mandal === " " || mandal === "0") {
//        alert("Please select your Mandal.");
//        $("#ContentPlaceHolder1_ddlMandal").focus();
//        return false;
//    }

//    if (!gender) {
//        alert("Please select a gender.");
//        $("[id*='ContentPlaceHolder1_rdbGender']").focus(); 
//        return false;
//    }
 
//    var skills = $("#ContentPlaceHolder1_lstSkills").find(":checked").length;
//    if (skills == 0) {
//        alert("Please select at least one skill.");
//        $("#ContentPlaceHolder1_lstSkills").focus();
//        return false;
//    }
//    var editSkills = $("#ContentPlaceHolder1_lstEditRoles").get(0).length;
//    if (editSkills == 0) {
//        alert("Please select at least one Role.");
//        $("#ContentPlaceHolder1_lstSkills").focus();
//        return false;
//    }
//    var hidden = $("#ContentPlaceHolder1_txtHidden").val();
//    if (hidden == "") {
//        alert("Please Select a Date");
//        return false;

//    }

//    var fileUpload = $("#ContentPlaceHolder1_Upload");
//    if (fileUpload.get(0).files.length === 0) {
//        alert("Please select a file.");
//        $("#ContentPlaceHolder1_Upload").focus();
//        return false;
//    }
//}


