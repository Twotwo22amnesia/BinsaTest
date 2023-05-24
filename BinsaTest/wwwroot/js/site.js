// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Funciones Generales
function validaNumericos(event) {
    if (event.charCode >= 48 && event.charCode <= 57) {
        return true;
    }
    return false;
}
//Fin Funciones Generales


//Crear Contacto
$("body").on("click", "a.createContacto-dialog-window", null, function (e) { 
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#createContacto').modal('show');
    }
    else {
        $.get(url, function (data) {
            $('#createContacto .teeee').html(data);
            $('#createContacto').modal("show");
        }).success(function () { $('input:text:visible:first').focus(); });
    }
});

$("body").on("click", "a.cancelCreateContacto", null, function (e) { 
        $('#createContacto').modal('hide');
    }
); 

//Fin Crear Contacto

//Eliminar Contacto 

$("body").on("click", "a.deleteContacto-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#deleteContacto').modal('show');
    }
    else {
        $.get(url, function (data) {
            $('#deleteContacto .teeee').html(data);
            $('#deleteContacto').modal("show");
        }).success(function () { $('input:text:visible:first').focus(); });
    }
});

$("body").on("click", "a.cancelDeleteContacto", null, function (e) {
    $('#deleteContacto').modal('hide');
}
);

//Fin Eliminar contacto


//Editar Contacto
$("body").on("click", "a.editContacto-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#editarContacto').modal('show');
    }
    else {
        $.get(url, function (data) {
            $('#editarContacto .teeee').html(data);
            $('#editarContacto').modal("show");
        }).success(function () { $('input:text:visible:first').focus(); });
    }
});

$("body").on("click", "a.cancelEditarContacto", null, function (e) {
    $('#editarContacto').modal('hide');
}
);

//Fin Editar Contacto

//Crear Cliente 

$("body").on("click", "a.createCliente-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#createCliente').modal('show');
    }
    else {
        $.get(url, function (data) {
            $('#createCliente .teeee').html(data);
            $('#createCliente').modal("show");
        }).success(function () { $('input:text:visible:first').focus(); });
    }
});

$("body").on("click", "a.cancelCreateCliente", null, function (e) {
    $('#createCliente').modal('hide');
    }
);  

//Fin Crear Cliente

//Editar Contacto
$("body").on("click", "a.editCliente-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#editarCliente').modal('show');
    }
    else {
        $.get(url, function (data) {
            $('#editarCliente .teeee').html(data);
            $('#editarCliente').modal("show");
        }).success(function () { $('input:text:visible:first').focus(); });
    }
});

$("body").on("click", "a.cancelEditarCliente", null, function (e) {
    $('#editarCliente').modal('hide');
}
);

//Fin Editar Contacto

//Eliminar Cliente 

$("body").on("click", "a.deleteCliente-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#deleteCliente').modal('show');
    }
    else {
        $.get(url, function (data) {
            $('#deleteCliente .teeee').html(data);
            $('#deleteCliente').modal("show");
        }).success(function () { $('input:text:visible:first').focus(); });
    }
});

$("body").on("click", "a.cancelDeleteCliente", null, function (e) {
    $('#deleteCliente').modal('hide');
}
);

//Fin Eliminar Cliente