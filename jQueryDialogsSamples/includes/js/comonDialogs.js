var $comonDialogs = $comonDialogs || {};
$comonDialogs = function () {
    /**
    * Description.     Provides a modal dialog for informing the user of something.
    * @pTitle          title for dialog
    * @pText           plain or rich text for dialog
    * @pButtonText     e.g. OK
    */
    var dialogAlert = function (pTitle, pText, pButtonText) {
        var def = $.Deferred();
        $('<div />').html(pText).dialog({
            modal: true,
            title: pTitle,
            buttons: [
                {
                    text: !pButtonText ? "OK" : pButtonText,
                    "id": "btnOk",
                    click: function() {
                        $(this).dialog("close");
                        def.resolve("Yes");
                    }
                }
            ],
            fluid: true,
            resizable: false,
            height: 'auto',
            width: 'auto',
            // prevent X button in title
            closeOnEscape: false,
            open: function(event, ui) {
                $(".ui-dialog-titlebar-close", ui.dialog | ui).hide();
            }
        });

        return def.promise();

    };
    /**
    * Description.      Single button dialog for errors (above alert method is generic).
    * Remarks           Dialog title and button style have been changed for appropriate appearance for a error
     *                  within the current jQuery theme.
    */
    var dialogAlertCustom = function (pText) {

        var def = $.Deferred();

        $('<div id="warning-dialog" />').html(pText).dialog({
            modal: true,
            title: 'Error',
            dialogClass: 'alertTitleClass',
            buttons: [{
                text: 'OK',
                icon: "ui-icon-notice",
                "id": "btnOk",
                class: "btn-error-dialog-ok",
                click: function () {
                    $(this).dialog("close");
                    def.resolve("Yes");
                }
            }],
            fluid: true, //new option
            resizable: false,
            height: 'auto',
            width: '700px',
            // prevent X button in title 
            closeOnEscape: false,
            open: function (event, ui) {
                $(".ui-dialog-titlebar-close", ui.dialog | ui).hide();
            }
        });


        // override default style for dialog buttons to be on right, here the single button is centered.
        // If we were to set this up in a style it will affect other dialogs.
        $("#warning-dialog").dialog("widget").find(".ui-dialog-buttonpane").css({ "text-align": "center" });
        $("#warning-dialog").dialog("widget").find(".ui-dialog-buttonset").css({ "float": "none" });

        return def.promise();
    };

    /**
    * Description.      Single button dialog for warnings.
    * Remarks           Dialog title and button style have been changed for appropriate appearance for a warning
     *                  within the current jQuery theme.
    */
    var dialogWarning = function () {

        var def = $.Deferred();

        $('<div id="warning-dialog" />').html('<div style=\'height: 50px;text-align: center;\'>Warning message!</div>').dialog({
            modal: true,
            title:'Warning',
            dialogClass: 'warningTitleClass',
            buttons: [{
                text: 'OK',
                icon: "ui-icon-alert",
                "id": "btnOk",
                class: "btn-warn-dialog-ok",
                click: function () {
                    $(this).dialog("close");
                    def.resolve("Yes");
                }           
            }],
            fluid: true, //new option
            resizable: false,
            height: 'auto',
            width: '700px',
            // prevent X button in title 
            closeOnEscape: false,
            open: function (event, ui) {
                $(".ui-dialog-titlebar-close", ui.dialog | ui).hide();
            }
        });


        // override default style for dialog buttons to be on right, here the single button is centered.
        // If we were to set this up in a style it will affect other dialogs.
        $("#warning-dialog").dialog("widget").find(".ui-dialog-buttonpane").css({ "text-align": "center" });
        $("#warning-dialog").dialog("widget").find(".ui-dialog-buttonset").css({ "float": "none" });

        return def.promise();
    };

    /**
    * Description.  Provides a modal dialog for asking confirmation for terms of agreement
     * Remarks      Could be done by calling dialogConfirmtion but did not so that it's isolated and canned.
    */
    var dialogCannedConfirm = function () {

        var def = $.Deferred();

        $('<div />').html('<p>You must accept these terms before continuing.</p>\n<textarea readonly>This Agreement and the Request constitute the entire agreement of the parties with respect to the subject matter of the Request. This Agreement shall be governed by and construed in accordance with the laws of the State, without giving effect to principles of conflicts of law.</textarea>\n<div></div>').dialog({
            modal: true,
            title: 'Terms and conditions',
            buttons: [{
                text: 'Accept terms',
                "id": "btnOk",
                click: function () {
                    $(this).dialog("close");
                    def.resolve("Yes");
                }
            }, {
                text: 'Cancel',
                click: function () {
                    $(this).dialog("close");
                    def.resolve("No");
                }
            }],
            fluid: true, //new option
            resizable: false,
            height: 'auto',
            width: '700px',
            // prevent X button in title
            closeOnEscape: false,
            open: function (event, ui) {
                $(".ui-dialog-titlebar-close", ui.dialog | ui).hide();
            }
        });
        return def.promise();
    };

    /**
    * Description.     Provides a modal dialog for asking confirmation
    * @pTitle          title for dialog
    * @pText           plain or rich text for dialog
    * @pYesButtonText  Yes button text
    * @pNoButtonText   No button text
    */
    var dialogConfirmtion = function (pTitle, pText, pYesButtonText, pNoButtonText) {

        var def = $.Deferred();

        $('<div />').html(pText).dialog({
            modal: true,
            title: pTitle,
            buttons: [{
                text: pYesButtonText,
                "id": "btnOk",
                click: function () {
                    $(this).dialog("close");
                    def.resolve("Yes");
                }
            }, {
                text: pNoButtonText,
                click: function () {
                    $(this).dialog("close");
                    def.resolve("No");
                }
                }],
            fluid: true, //new option
            resizable: false,
            height: 'auto',
            width: 'auto',
            // prevent X button in title
            closeOnEscape: false,
            open: function (event, ui) {
                $(".ui-dialog-titlebar-close", ui.dialog | ui).hide();
            }
        });
        return def.promise();
    };



    /*
     * Here we provide a internal function name and a alias to be called.
     */
    return {
        confirmation: dialogConfirmtion,
        alert: dialogAlertCustom,
        dialogWarning: dialogWarning,
        confirmAggreementDialog: dialogCannedConfirm
    };
}(); 

// hack for fixing title styling, best to stay away from if you can.
$.widget("ui.dialog", $.extend({}, $.ui.dialog.prototype, {
    _title: function (title) {
        var $title = this.options.title || '& nbsp; ';
        if (("titleIsHtml" in this.options) && this.options.titleIsHtml === true)
        title.html($title); 
        else title.text($title); 
    } 
}));