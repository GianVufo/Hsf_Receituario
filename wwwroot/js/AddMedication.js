/*function AddMedications() {

  let properties = {
    Id: $("#medicationId").val(),
    MedicationName: $("#medicationName").val(),
    MedicationDosage: $("#medicationDosage").val(),
    MedicationMethodUse: $("#medicationUse").val(),
    ReceituarioId: $("#receituarioId").val(),
  };

  $.post("/Medicacao/MedicationRegister", properties)

    .done(function (output) {
      if (output.stats == "OK") {
        setTimeout(function () {
          $("#alerta")
            .html(
              '<div class="alert alert-success"> Medicamento adicionado com sucesso! </div>'
            )
            .fadeOut(5000);
        }, 80);
      } else if (output.stats == "INVALID") {
        $("#alerta").html('<div class="alert alert-danger"> Não foi possível cadastrar essa medicação. Tente mais tarde!</div>');

      }
    })

    .fail(function () {
      alert("Falha ao adicionar medicamento!");
    });
}

$(document).ready(function () {
  $("#medic-form").submit(function (e) {
    e.preventDefault();
    AddMedications();
  });
});*/