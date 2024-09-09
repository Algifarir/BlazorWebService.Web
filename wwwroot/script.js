function showAlert(message) {
    alert(message);
} 

function initializeSelect2(selector) {
    $(selector).select2({
        theme: 'bootstrap4' // Adjust theme according to your needs
    });
}

$(document).ready(function() {
    $('#CustomerIdNew').select2();
});

let formCount = 1; // Initialize index for dynamic forms

function addForm() {
    formCount++;
        
    const newFormGroup = document.createElement('div');
    newFormGroup.className = 'form-group';
    newFormGroup.id = `form-${formCount}`;
    
    newFormGroup.innerHTML = `
        <div class="form-group mb-1">
            <label for="Harga-${formCount}">Harga</label>
            <input type="number" id="Harga-${formCount}" class="form-control" name="Harga[]" />
            <label for="Sla-${formCount}">SLA</label>
            <input type="text" id="Sla-${formCount}" class="form-control" name="Sla[]" />
        </div>
    `;
    
    // Append new form group to the wrapper
    document.getElementById('form-wrapper').appendChild(newFormGroup);
}

function removeForm() {
    if (formCount <= 1) {
        alert('At least one form must be present.');
        return;
    }
    
    const formWrapper = document.getElementById('form-wrapper');
    const lastFormContainer = document.getElementById(`form-${formCount}`);
    
    // Remove the last form container
    formWrapper.removeChild(lastFormContainer);
    formCount--;
}

function printSubscriptionData(data) {
    console.log("Subscription Data:", data);
}