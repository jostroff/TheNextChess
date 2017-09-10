let table = $('table');

$(document).ready(function () {
    for (var i = 1; i <= 8; i++) {
        let row = $('<tr>');
        for (var j = 1; j <= 8; j++) {

            let td = $('<td>').attr('id', `${i}-${j}`);

            if (j % 2 == 0) {
                if (i % 2 == 0) {
                    td.css('background-color', '#F1F1F1').on('click', moveTo);
                } else {
                    td.css('background-color', 'brown').on('click', moveTo)
                }
            }
            else {
                if (i % 2 != 0) {
                    td.css('background-color', '#F1F1F1').on('click', moveTo);
                } else {
                    td.css('background-color', 'brown').on('click', moveTo);
                }
            }

            if (i == 2) {
                let img = $('<img src="../../Content/Images/pawn-white.png" />');
                img.on('click', mark);
                img.attr('id', `w-pawn-${j}`);
                td.append(img);
            } else if (i == 7) {
                let img = $('<img src="../../Content/Images/pawn-black.png" />');
                img.on('click', mark);
                img.attr('id', `b-pawn-${j}`);
                td.append(img);
            }

            row.append(td);
        }
        table.append(row);
    }

    $.fn.swap = function (elem) {
        elem = elem.jquery ? elem : $(elem);
        return this.each(function () {
            $(document.createTextNode('')).insertBefore(this).before(elem.before(this)).remove();
        });
    };


    //$('td').click(function () {
    //    $('.one').swap('.two');
    //});

});
let markedFigure;

function mark(e) {
    e.stopPropagation();
    table.find('img').css('opacity', '1');
    $(e.target).css('opacity', '0.5');

    if (markedFigure && checkToGet(markedFigure, e.target)) {

        getFigure(markedFigure, e.target);
        return;
    }

    markedFigure = $(e.target);
}

function moveTo(e) {

    if (markedFigure !== undefined) {
        let currentSquareIds = ($(markedFigure.parent()).attr('id')).split('-');
        let clickedSquareIds = ($(e.target).prop('id')).split('-');
        let markedFigureData = (markedFigure.attr('id')).split('-');
        console.log('move');
        if (currentSquareIds[1] === clickedSquareIds[1] && currentSquareIds[0] < clickedSquareIds[0] && markedFigureData[0] === "w") {
            $(e.target).append(markedFigure);
        }
        if (currentSquareIds[0] ) {

        }
        if (currentSquareIds[1] === clickedSquareIds[1] && currentSquareIds[0] > clickedSquareIds[0] && markedFigureData[0] === "b") {
            $(e.target).append(markedFigure);
        }

        unmark();
    }
}

function getFigure(markedFigure, getableFigure) {
    let squareToMove = $(getableFigure).parent();
    getableFigure.remove();
    squareToMove.append(markedFigure);
    unmark();
}

function checkToGet(marketFigure, getableFigure) {
    let currentSquareData = $(markedFigure).parent().attr('id').split('-').map(Number);
    let squareToMoveData = $(getableFigure).parent().attr('id').split('-').map(Number);

    if (currentSquareData[0] + 1 === squareToMoveData[0]) {
        if (currentSquareData[1] + 1 === squareToMoveData[1] || currentSquareData[1] - 1 === squareToMoveData[1]) {
            return true;
        }
    }

    return false;
}

function unmark() {
    markedFigure = undefined;
    table.find('img').css('opacity', '1');
}


