$(document).ready(function () {
    //alertify.defaults.glossary.ok = '';
    //alertify.defaults.glossary.cancel = '';

    $("#home").click(function () {
        document.location.href = "index.html";
    });

    $("#btnConfirm").click(function () {
        alertify.confirm("Question","Confirm Message",
            function() {
                alertify.success("Ok");
            },
            function() {
                alertify.error("Cancel");
            }).set({ 'pinnable': false, 'modal': false }).set({ labels: { ok: 'Leave', cancel: 'Stay' }, padding: false });
    });
    $("#btnAlert").click(function () {
        alertify.alert("Alert Title", "Alert Message!", function() { alertify.success("Ok"); });
    });
});