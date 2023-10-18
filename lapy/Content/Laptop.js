var SaveLaptop = function ()
{
    debugger;
    var Id = $("txtId").val();
    var name = $("#txtName").val();
    var product = $("#txtProduct").val();
    var price = $("#txtprice").val();
    var sprice = $("#txtSPrice").val();
    var date = $("#txtDate").val();
    var model_no = $("#txtModel_no").val();

    var model = {
        Name: name,
        Product: product,
        price: price,
        SPrice: sprice,
        Date: date,
        Model_No: model_no

    };
    $.ajax({
        url: "/Laptop/SaveLaptop",
        method: "post",
        data: JSON.stringify(model),
        dataType: "json",
        contentType: "application/json;charset=utf-8",

        success: function (response) {


            alert(response.Message);
        },
        error: function (response)
        {

            alert(response.model);
        }

        


    });


}