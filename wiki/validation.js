
    function validateForm() {
        var names = document.getElementById("txt_names").value;
        var surname = document.getElementById("txt_surname").value;
        var mobile = document.getElementById("tel").value;
        var email = document.getElementById("email").value;
        var gender = document.querySelector('input[name="gender"]:checked');
        var city = document.getElementById("selectcity").value;
        var dob = document.getElementById("dob").value;
        var address = document.querySelector("textarea").value;
        var password = document.getElementById("pswd").value;
        var confirmPassword = document.getElementById("cpswd").value;
        //sessionStorage.setItem("sharedName", names);
        sessionStorage.setItem("sharedName", names);
        sessionStorage.setItem("sharedPassword",password);
        //localStorage.setItem("sharedName", names);

/****************name****************/

        if (names==null || names=="") 
        {
            alert("Please enter your name.");            
            return false;
        }
        else if(names.length<4)
        {
            alert("Name should be morethan 4 characters.");           
            return false;
        }
        else if(names.length>=15)
        { 
            alert("Name should not exceed 15 characters.");            
            return false;
        }
        else if(!names.match(/^[a-zA-Z]+$/))
         {
            alert("Name should contain only letters (no digits or special characters).");
            return false;
         }
        
 /*************surname*******************/       

        if (surname==null || surname==="") 
        {
            alert("Please enter your surname.");
            return false;
        }
        else if(surname.length < 4)
        {
            alert("Surname should be morethan 4 characters.");
            return false;
        }
        else if(surname.length >= 15)
        {
            alert("Surname should not exceed 15 characters.");
            return false;
        }
        else if(!surname.match(/^[a-zA-z]+$/))
        {
            alert("Surname should contain only letters (no digits or special characters).");
            return false;
        }
        

/*********************number******************/

        if(mobile==null || mobile==="") 
        {
            alert("Please enter your mobile number.");
            return false;
        }
        else if (mobile.length !== 10) 
        {
            alert("Mobile Number should be exactly 10 digits.");
            return false;
        }
        else if(!mobile.match(/^[9|8|7|6]\d/))
        {
            alert("Mobile number should start with 9,8,7 or 6.");
            return false;
        }
        else if(!mobile.match(/^\d+$/))
        {
            alert("Mobile number should only contain digits.");
            return false;
        }

/*******************email*********************/

        if (email==null || email==="") 
        {
            alert("Please enter your email address.");
            return false;
        }
        else if(!email.match(/^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$/))
        {
            alert("Please enter a valid email.");
            return false;
        }


/********************gender*******************/

        if (gender=== 0) 
        {
            alert("Please select a gender.");
            return false;
        }

/*******************city********************/

        if (city==null || city == "") 
        {
            alert("Please select your city.");
            return false;
        }
/*******************dob***********************/

        var today = new Date();
        var dateofbirth = new Date(dob);
        var age = today.getFullYear() - dateofbirth.getFullYear();
        var monthDiff = today.getMonth() - dateofbirth.getMonth();
        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dateofbirth.getDate())) 
        {
            age--;
        }
        if (dob == null || dob == "") 
        {
            alert("Please enter your date of birth.");
            return false;
        } 
        else if (dateofbirth > today) 
        {
            alert("Invalid date of birth.");
            return false;
        }          
        if (age < 18 || age > 30) 
        {
            alert("The age should be between 18 and 30 years.");
            return false;
        }


/********************Address******************/

        if (address==null || address=="") 
        {
            alert("Please enter your address.");
            return false;
        }
        else if(address.length < 20)
        {
            alert("Address must contain 20 characters.");
            return false;
        }

/******************password******************/
        if (password==null || password=="") 
        {
            alert("Please enter a password.");
            return false;
        }
        else if(password.length < 8)
        {
            alert("Password should contain 8 characters.");
            return false;
        }
        else if(!password.match(/[A-Z]/))
        {
            alert("Password must contain a Upper case character.");
            return false;
        }
        else if(!password.match(/[a-z]/))
        {
            alert("Password must contain a Lower case character.");
            return false;
        }
        else if(!password.match(/[0-9]/))
        {
            alert("Password must contain a Digit.");
            return false;
        }
        else if(!password.match(/[!@#$%^&*]/))
        {
            alert("Password must contain a special character.");
            return false;
        }
 /*********************confirmpassword****************/
        if(confirmPassword==null || confirmPassword=="")
        {
            alert("Please enter Confirm password.");
            return false;
        }
        else if (password !== confirmPassword) {
            alert("Password and confirm password do not match.");
            return false;
        } 
        else
        {
            alert("registered successfully");
            return true;           
        }
}


/***************************************************************************************/
function clearform()
{
    var form = document.getElementById("form");
    form.reset();
}





    