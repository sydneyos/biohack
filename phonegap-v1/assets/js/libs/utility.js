//see http://blog.stevensanderson.com/2013/03/15/animating-lists-with-css-3-transitions/


function createListStyles(rulePattern, rows, cols) {
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

(function () {
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

$(".reorder").click(function () {
    $(".items li")
        .snapshotStyles()
        .tsort({ order: "rand" })
        .releaseSnapshot();
});

$(".append").click(function () {
    $("<li>New item</li>").insertAfter($(".items").children()[2]);
});

$("ul.items").sortable({
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