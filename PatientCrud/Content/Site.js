﻿
// FOR DELETING A RECORD THROUGH MODAL

$('#deleteModal').on('show.bs.modal', function (event) {
    // This triggers when the modal is about to be shown
    var button = $(event.relatedTarget); // Button that triggered the modal
    var medicationId = button.data('id'); // Extract the medication ID from the button's data-id attribute
    var modal = $(this); // Reference to the modal
    modal.find('#deleteId-' + medicationId).val(medicationId); // Set the hidden input value inside the modal
});