function inserirRemedios()
{
  let recId = $("#rec-id").val();
  console.log("REC ID: " + recId);

  $("#receituarioId").val() = recId;
  //document.getElementById("medicationId").value = recId;
  console.log("RECEITUARIO ID: " + $("$receituarioId").val());
}

/*function inserirReceita()
{
  let recId = document.getElementById("prescriptionId").value;

  console.log("Receita Id: " + recId);

  document.getElementById("medicationId").value = recId;

  console.log("medication Id: " + document.getElementById("medicationId").value);
}*/
