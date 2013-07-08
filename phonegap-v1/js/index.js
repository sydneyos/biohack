//-------------Pane Navigation--------------------
//depends on panes.js

// Initial pane visibility
(function ($, undefined) {
            // Initial pane visibility
            $(".main.pane").showPane();
            $(".first.pane").showPane();

            // Navigation within middle pane
            $(".first.pane button").clickOrTouch(function () {
                $(".second.pane").showPane({ slideFrom: 'right' });
            });
            $(".second.pane button").clickOrTouch(function () {
                $(".first.pane").showPane({ slideFrom: 'left' });
            });

            // Navigation of whole screen
            $(".header.row button").clickOrTouch(function () {
                $(".about.pane").showPane({ coverFrom: 'bottom' });
            });
            $(".about.pane button").clickOrTouch(function () {
                $(".main.pane").showPane({ uncoverTo: 'bottom' });
            });
        })(xui);


//--------------List Rearrangement----------------
//dependency on jquery.tinysort.js

$(function () {
    "use strict";
    $(document.body).on("click", ".delete", function (evt) {
        evt.preventDefault();
        $(this).closest("li").remove();
    });
    
    $(".append").click(function () {
        $("<li>New item</li>").insertAfter($(".items").children()[2]);
    });
    
    $(".reorder").click(function () {
        $(".items li")
            .snapshotStyles()
            .tsort({ order: "rand" })
            .releaseSnapshot();
    });
    
    $(".items").sortable({
        start: function (event, ui) {
            // Temporarily move the dragged item to the end of the list so that it doesn't offset the items
            // below it (jQuery UI adds a 'placeholder' element which creates the desired offset during dragging)
            $(ui.item).appendTo(this).addClass("dragging");
        },
        stop: function (event, ui) {
            // jQuery UI instantly moves the element to its final position, but we want it to transition there.
            // So, first convert the final top/left position into a translate3d style override
            var newTranslation = "translate3d(" + ui.position.left + "px, " + ui.position.top + "px, 0)";
            $(ui.item).css("-webkit-transform", newTranslation)
                        .css("transform", newTranslation);
            // ... then remove that override within a snapshot so that it transitions.
            $(ui.item).snapshotStyles().removeClass("dragging").releaseSnapshot();
        }
    });

    // Workaround for Webkit bug: force scroll height to be recomputed after the transition ends, not only when it starts
    $(".items").on("webkitTransitionEnd", function () {
        $(this).hide().offset();
        $(this).show();
    });
});

function createListStyles(rulePattern, rows, cols) {
    "use strict";
    var rules = [], index = 0;
    for (var rowIndex = 0; rowIndex < rows; rowIndex++) {
        for (var colIndex = 0; colIndex < cols; colIndex++) {
            var x = (colIndex * 100) + "%",
                y = (rowIndex * 100) + "%",
                transforms = "{ -webkit-transform: translate3d(" + x + ", " + y + ", 0); transform: translate3d(" + x + ", " + y + ", 0); }";
            rules.push(rulePattern.replace("{0}", ++index) + transforms);
        }
    }
    var headElem = document.getElementsByTagName("head")[0],
        styleElem = $("<style>").attr("type", "text/css").appendTo(headElem)[0];
    if (styleElem.styleSheet) {
        styleElem.styleSheet.cssText = rules.join("\n");
    } else {
        styleElem.textContent = rules.join("\n");
    }
}

createListStyles(".items li:nth-child({0})", 50, 1);

// Snapshotting utils
(function () {
    "use strict";
    var stylesToSnapshot = ["transform", "-webkit-transform"];

    $.fn.snapshotStyles = function () {
        if (window.getComputedStyle) {
            $(this).each(function () {
                for (var i = 0; i < stylesToSnapshot.length; i++)
                    this.style[stylesToSnapshot[i]] = getComputedStyle(this)[stylesToSnapshot[i]];
            });
        }
        return this;
    };

    $.fn.releaseSnapshot = function () {
        $(this).each(function () {
            this.offsetHeight; // Force position to be recomputed before transition starts
            for (var i = 0; i < stylesToSnapshot.length; i++)
                this.style[stylesToSnapshot[i]] = "";
        });
    };
})();