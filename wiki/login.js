function validate()
    {
        var name = document.getElementById("txtname").value;
        var pswd = document.getElementById("txtpswd").value;
        var sharedName = sessionStorage.getItem("sharedName");
        var sharedPassword = sessionStorage.getItem("sharedPassword");
        if(name==null || name=="")
        {
            alert("please enter username.");
            return false;
        }
        if(pswd==null|| pswd=="")
        {
            alert("enter password.");
            return false;
        }
        if(sharedName !== name)
        {
            alert("username not matched with registered name.");
            return false;
        }
        if(sharedPassword !== pswd)
        {
            alert("incorrect Password.");
            return false;
        }
        alert("welcome");
        return true;
    }