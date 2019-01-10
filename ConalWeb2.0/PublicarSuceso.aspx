﻿<%@ Page Language="C#" MasterPageFile="Menu.Master" AutoEventWireup="true" CodeBehind="PublicarSuceso.aspx.cs" Inherits="ConalWeb2._0.PublicarSuceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

	<link rel="stylesheet" href="CSS/CSS_PublicarSuceso.css">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="main">
		<div class="container" id="container1">
			<h1>
				Publicar suceso
			</h1>
			<div class="container" id="container2">
				
				<form id="crearSucesoForm" action="procesarCrearSuceso.php" method="post" enctype="multipart/form-data">
				<!-- One "tab" for each step in the form: -->
				<div class="tab">
				
				
				
				<label for="nombre">Titular</label>
				<p><input placeholder="Titular" oninput="this.className = ''" name="titular"></p>
				<label for="nombre">Decripción del suceso</label>
				<p><textarea rows="4" cols="50" name="descripcionSuceso" form="crearSucesoForm" placeholder="Descripción del suceso"></textarea></p>
				<label for="nombre">Descripción de los sospechosos</label>
				<p><textarea rows="4" cols="50" name="descripcionSospechosos" form="crearSucesoForm" placeholder="Descripción de los sospechosos"></textarea></p>
				<label for="nombre">Fecha del suceso</label>
				<p><input id="date" type="date" name="fecha"></p>
				<label for="nombre">Hora del suceso</label>
				<p><input type="time" name="hora"></p>
				</div>
				<div class="tab">
					<label for="nombre">Ubicación del suceso</label>
					<p><textarea rows="4" cols="50" name="ubicacionTxt" form="crearSucesoForm" placeholder='Ubicación del acontecimiento'></textarea></p>
					<label for="nombre">aqui va el API de google maps</label>
				</div>
				<div style="overflow:auto;">
				<div style="float:right;">
				<button type="button" id="prevBtn" onclick="nextPrev(-1)">Anterior</button>
				<button type="button" id="nextBtn" onclick="nextPrev(1)">Siguiente</button>
				</div>
				</div>
				<!-- Circles which indicates the steps of the form: -->
				<div style="text-align:center;margin-top:40px;">
				<span class="step"></span>
				<span class="step"></span>
				</div>

				</form>


			</div>
		</div>
	</div>



    <script>
	/* Loop through all dropdown buttons to toggle between hiding and showing its dropdown content - This allows the user to have multiple dropdowns without any conflict */
	var dropdown = document.getElementsByClassName("dropdown-btn");
	var i;

	for (i = 0; i < dropdown.length; i++) {
	  dropdown[i].addEventListener("click", function() {
	  this.classList.toggle("active");
	  var dropdownContent = this.nextElementSibling;
	  if (dropdownContent.style.display === "block") {
	  dropdownContent.style.display = "none";
	  } else {
	  dropdownContent.style.display = "block";
	  }
	  });
	}
	
	/* ------------------ Tabs ------------------ */
	var currentTab = 0; // Current tab is set to be the first tab (0)
	showTab(currentTab); // Display the crurrent tab

	function showTab(n) {
	// This function will display the specified tab of the form...
	var x = document.getElementsByClassName("tab");
	x[n].style.display = "block";
	//... and fix the Previous/Next buttons:
	if (n == 0) {
	  document.getElementById("prevBtn").style.display = "none";
	} else {
	  document.getElementById("prevBtn").style.display = "inline";
	}
	if (n == (x.length - 1)) {
	  document.getElementById("nextBtn").innerHTML = "Publicar";
	} else {
	  document.getElementById("nextBtn").innerHTML = "Siguiente";
	}
	//... and run a function that will display the correct step indicator:
	fixStepIndicator(n)
	}

	function nextPrev(n) {
		// This function will figure out which tab to display
		var x = document.getElementsByClassName("tab");
		// Exit the function if any field in the current tab is invalid:
		if (n == 1 && !validateForm()) return false;
		// Hide the current tab:
		x[currentTab].style.display = "none";
		// Increase or decrease the current tab by 1:
		currentTab = currentTab + n;
		// if you have reached the end of the form...
		if (currentTab >= x.length) {
			// ... the form gets submitted:
			document.getElementById("crearReunionForm").submit();
			return false;
		}
		// Otherwise, display the correct tab:
		showTab(currentTab);
	}

	function validateForm() {
		// This function deals with validation of the form fields
		var x, y, i, valid = true;
		x = document.getElementsByClassName("tab");
		y = x[currentTab].getElementsByTagName("input");

		// A loop that checks every input field in the current tab:
		for (i = 0; i < y.length; i++) {
			// If a field is empty...
			if (y[i].value == "") {
				// add an "invalid" class to the field:
				y[i].className += " invalid";
				// and set the current valid status to false
				valid = false;
			}
		}
		// If the valid status is true, mark the step as finished and valid:
		if (valid) {
			document.getElementsByClassName("step")[currentTab].className += " Publicar";
		}
		return valid; // return the valid status
	}

	function fixStepIndicator(n) {
		// This function removes the "active" class of all steps...
		var i, x = document.getElementsByClassName("step");
		for (i = 0; i < x.length; i++) {
		x[i].className = x[i].className.replace(" active", "");
		}
		//... and adds the "active" class on the current step:
		x[n].className += " active";
	}
	</script>

</asp:Content>