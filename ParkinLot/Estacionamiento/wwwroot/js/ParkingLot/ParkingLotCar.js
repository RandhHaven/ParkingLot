var dataTable;

$(document).ready(function () {
    //$('#tableCars').DataTable();
    LoadParkingLotCars();
});

LoadParkingLotCars = function () {
    dataTable = $("#tableCars").DataTable({
        "ajax": {
            "url": "/ParkingLot/Car/GetCars",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "patente", "width": "10%" },
            { "data": "marca", "width": "20%" },
            { "data": "modelo", "width": "20%" },
            { "data": "empleado", "width": "20%" },
            {
                "data": "idAuto",
                "render": function (data) {
                    return `<div class="text-center">
                            <a href='/ParkingLot/Car/EditCar/${data}' class='btn btn-success text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-edit'></i> Editar
                            </a>
                            &nbsp;
                            <a onclick=Delete("/ParkingLot/Car/Delete/${data}") class='btn btn-danger text-white' style='cursor:pointer; width:100px;'>
                            <i class='fas fa-trash-alt'></i> Borrar
                            </a>
                            `;
                }, "width": "30%"
            }
        ],
        "language": {
            "emptyTable": "No hay registros"
        },
        "width": "100%"
    });
};

function Delete(url) {
    swal({
        title: "Esta seguro de borrar?",
        text: "Este contenido no se puede recuperar!",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Yes!",
        closeOnconfirm: true
    }, function () {
        $.ajax({
            type: 'DELETE',
            url: url,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    dataTable.ajax.reload();
                }
                else {
                    toastr.error(data.message);
                }
            }
        });
    });
}

Prueba = function () {
    
};