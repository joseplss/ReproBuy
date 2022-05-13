function checkForm(form) {
    var checkBox = document.getElementById("myCheckBox")
    if (!checkBox.checked) {
        checkFormToastr();
        return false;
    }
    else {
        $("#confirmButton").modal();
        return true;
    }
}

function confirmForm() {
    confirmFormToastr();
}

//Qill text editor format
let jdQuill = new Quill('#description', {
    theme: 'snow'
});

function handleSubmit() {
    console.info('handleSubmit called');
    document.getElementById('jdr').value = jdQuill.root.innerHTML;
};