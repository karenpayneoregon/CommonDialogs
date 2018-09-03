$(document).ready(function () {


    $("button").button();

    // initialize each button for tool-tips
    $("button").each(function () {
        $(this).powerTip({ placement: 'e', closeDelay: 100 });
    });

    // setup each button's tool-tip
    $('#btnConfirm').data('powertip', 'Demonstration of a simple <b>confirmation</b> using jQuery UI.');
    $('#btnWarning').data('powertip', 'Warning alert with modifications to the default styling');
    $('#btnAlertCustom').data('powertip', 'Example to displaying a modal alert dialog from a catch in a try statement');
    $('#btnTermsConditions').data('powertip', 'Demonstration of a <b>confirmation</b> for \'agree to terms\' using jQuery UI.');


    /**
     * The following code subscribes event handlers for each button.
     *
     * Each modal dialog in commonDialogs is wrapped in .when which provides a way to execute callbacks, in these cases
     * deferred objects which .then handles the resolved deferred return value, true/false (Yes, No) in all methods
     *
     * Base styling is jQuery UI then various techniques to override styling ranging from embedded styles in content to
     * overrides in the initialization of a widget e.g. dialogClass and class. As jQuery UI (like many libraries) sometimes
     * will depreciate an attruibute or change how somethings works then sometimes breaks things So all this code has no
     * guarantee if used with a different version of jQuery and/or jQuery UI. For this reason one might consider a free library
     * yet a free library can break too.
     *
     * When things break or don't work as expected e.g. jQuery Tool-Tip:
     * If you don't have a good understanding of widgets, methods and css a developer may quickly find a black hole in which
     * there appears to be no easy way out. This is one reason for a developer to study this code, get a grasp on how things
     * work so that if a developer decides to work this way it will be easier and if said developer uses a third party widget
     * library they will be better off for understanding basics.
     *
     */
    $("#btnConfirm").click(function () {

        $.when($comonDialogs.confirmation('Confirm', '<div style="margin:30px">Important <strong>question</strong>, do you like to drink coffee first thing in the morning?</div>', 'Love it', 'Hate it')).then(
            function (status) {
                if (status === "Yes") {
                    $("#lblAsk").text('let\'s go to Starbucks');
                } else {
                    $("#lblAsk").text('Must be a tea lover');
                }
            }
        );
    });

    $("#btnTermsConditions").click(function () {

        $.when($comonDialogs.confirmAggreementDialog()).then(function (status) {
                if (status === "Yes") {
                    $("#lblTerms").text('Accepted');
                    $("#lblTerms").css("font-weight", "Bold");
                } else {
                    $("#lblTerms").text('Declined');
                    $("#lblTerms").css("font-weight", "normal");
                }
            }
        );
    });

    $("#btnWarning").click(function () {

        $.when($comonDialogs.dialogWarning()).then(
            function (status) {/* perform action(s) */ }
        );

    });

    $("#btnAlertCustom").click(function () {

        try {
            // myDiv does not exist which in turn throws an exception
            document.getElementById("mydiv").innerHTML = 'Success'; 
        }
        catch (e) {
            var text = "<div style='height: 50px;text-align: center;'>" + e.message + "</div>";
            $.when($comonDialogs.alert(text)).then(
                function (status) {/* perform action(s) */ }
            );
        }
    });

});