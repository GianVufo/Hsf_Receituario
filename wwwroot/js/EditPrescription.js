/*function AddPrescription() {

    let properties = {
      Id: $("#prescriptionId").val(),
      PacientName: $("#pacientName").val(),
      DoctirName: $("#doctorName").val(),
      DateOfMedicalAppoiment: $("#dataAppoiment").val(),
      MedicacaoId: $("#medicacaoId").val(),
    };
  
    $.post("/Receituario/CompletePrescription" + Id, properties)
  
      .done(function (output) {
        if (output.stats == "OK") {
          setTimeout(function () {
            $("#danger")
              .html(
                '<div class="alert alert-success"> Receita salva com sucesso! </div>'
              )
              .fadeOut(5000);
          }, 80);
        } else if (output.stats == "INVALID") {
          $("#danger").html('<div class="alert alert-danger"> Não foi possível salvar esta receita. Tente novamente mais tarde!</div>');
  
        }
      })
  
      .fail(function () {
        alert("Falha ao salvar receita!");
      });
  }

  //$(location).attr('href', '/Views/Receituario/CompletePrescription' + Id);
  
  $(document).ready(function () {
    $("#receita-form").submit(function (e) {
      e.preventDefault();
      AddPrescription();
    });
  });*/