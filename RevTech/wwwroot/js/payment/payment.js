document.addEventListener("DOMContentLoaded", function () {

    $.ajax({
        url: '/Payment/GetAllPartsForPayment',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            if (data && data.length > 0) {
                var listItems = '';

                for (var i = 0; i < data.length; i++) {
                    var partItem = '<li class="part-item">';

                    partItem += '<div class="part-info">';

                    if (data[i].partType) {
                        partItem += '<span class="part-type">' + data[i].partType + ':</span> ';
                    }

                    if (data[i].partManufacturer) {
                        partItem += '<span class="part-manufacturer">' + data[i].partManufacturer + '</span> ';
                    }

                    if (data[i].partModel) {
                        partItem += '<span class="part-model">' + data[i].partModel + '</span> ';
                    }

                    partItem += '</div>';

                    if (data[i].partPrice) {
                        partItem += '<span class="part-price">' + '$' + parseFloat(data[i].partPrice).toFixed(2) + '</span>';
                    }

                    partItem += '</li>';

                    listItems += partItem;
                }

                $('#orderedPartsList').html('<ul>' + listItems + '</ul>');
            } 
        },
        error: function (error) {
            console.error('Error fetching ordered parts:', error);
        }
    });
});
