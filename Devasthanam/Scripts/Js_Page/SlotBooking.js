function choose() {
    $("div").attr("style", "display:block");
    $("#lblslot").show();
    $("#txtslot").show();
    //$("#lblTicket").hide();
    //$("#txtTicket").hide();
    //$("#addDetails").hide();
    $("#lblName").hide();
    $("#txtName").hide();
    $("#buy").hide();

    $("#txtslot").on("change", function (event) {
        event.preventDefault();
        var selectedValue = $(this).val();
        if (selectedValue !== "") {
            //$("#lblTicket").show();
            //$("#txtTicket").show();
            //$("#addDetails").show();
            $("#lblName").show();
            $("#txtName").show();
            $("#buy").show();
        }
    });

    //$("#addDetails").on("click", function (event) {
    //    event.preventDefault();  
    //    $("#lblTicket").show();
    //    $("#txtTicket").show();
    //    $("#addDetails").show();
    //    $("#lblName").show();
    //    $("#txtName").show();
    //    $("#buy").show();
    //});
}

 
