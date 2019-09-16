$(document).ready(function () {

    Lnx_Init = function () {

        (function calendar_range() {

            /*
                var dateFormat = "dd-mm-yy",
                  from = $("#from")
                    .datepicker({
                      defaultDate: "+1w",
                      changeMonth: true,
                      dateFormat: dateFormat,
                      numberOfMonths: 3
                    })
                    .on( "change", function() {
                      to.datepicker( "option", "minDate", getDate( this ) );
                    }),
                  to = $( "#to" ).datepicker({
                    defaultDate: "+1w",
                    changeMonth: true,
                    dateFormat: dateFormat,
                    numberOfMonths: 3
                  })
                  .on( "change", function() {
                    from.datepicker( "option", "maxDate", getDate( this ) );
                  });
             
                function getDate( element ) {
                  var date;
                  try {
                    date = $.datepicker.parseDate( dateFormat, element.value );
                  } catch( error ) {
                    date = null;
                  }
             
                  return date;
                }

                */

        })();

        (function calendar_range() {

            $('#search_pre').click(function() {

                    var dates = ({
                        de: $("#from").val(),
                        to: $('#to').val()
                    });

                     $.ajax({
                        url: "/api/search",
                        type: "Get",
                        dataType: 'json',
                        contentType: "application/json",
                        data: "startdate="+ dates.de +"&enddate=" + dates.to,
                        success: function (data) {

                            var $html = $('<div class="row">')

                            $(data.activitys).each(function(i,activity) {
                                
                                var html = "<div class='col-2'> <div class='row'> </div> </div>\
                                  </div> "+ moment(activity.Date).format('DD') + ' ' + moment(activity.Date).format('MMMM') +" </td> </tr> </thead>\
                                 <tbody><tr> <td> xx </td> <tr> </tbody>";

                                 $html.append(html);

                                 $('#time_sheet').append($html);

                            });

                        },
                        error: function () {


                        }

                    });

            });

        })();


    };

     (function Init() {

        Lnx_Init();

     })();

});