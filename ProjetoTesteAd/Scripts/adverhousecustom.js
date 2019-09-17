$(document).ready(function () {

    Lnx_Init = function () {

        (function Search() {

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

                            var html = '<div class="col-2" id="first_colum">  </div>';

                            $(data.activitys).each(function(i,activity) {

                                html += '<div class="col-2" date="'+ moment(activity.Date).format('DD-MM-YYYY') +'"> ' + moment(activity.Date).format('DD/MM/YYYY') + ' </div>';

                            });

                            $html.append(html);

                            $html.find('#first_colum').append('<div class="col-12">  </div>');

                                $(data.activitys).each(function(i,activity) {

                                  var total_hours = 0;

                                  //dados do holder
                                  $html.find('#first_colum').append('<div class="col-12 holder_name"> +' + activity.Holding + '</div>');
                                  $html.find('[date='+moment(activity.Date).format('DD-MM-YYYY')+']').append('<div class="col-12" name="total_time"> 0 </div> ')

                                    $(activity.Client).each(function(i, client) {
                                       
                                       $html.find('#first_colum').append('<div class="col-12 client_name" clientid="'+ client.ClientId +'"> +' + client.Name + '</div>');
                                       $html.find('[date='+moment(activity.Date).format('DD-MM-YYYY')+']').append('<div class="col-12 client_time" clientid="'+ client.ClientId +'"> '+ client.Time +' </div> ');

                                        $html.find('.client_name').on('click', function(event) {
                                            if($(event.currentTarget).attr('clientid') == $html.find('[clientid='+client.ClientId+']').attr('clientid')){
                                                if($html.find('[clientid='+client.ClientId+']').hasClass('show')){
                                                      $html.find('[clientid='+client.ClientId+']').addClass('hide').removeClass('show');
                                                    if($html.find('[clientid='+client.ClientId+']').hasClass('client_name')){
                                                        $(this).removeClass('hide')
                                                    }
                                                } else {
                                                    $html.find('[clientid='+client.ClientId+']').addClass('show').removeClass('hide');
                                                }
                                            }
                                        });             
                                       total_hours = total_hours + client.Time;

                                         $(client.Product).each(function(i, product) {
                                           
                                           $html.find('#first_colum').append('<div class="col-12 product_name hide" productid="'+ product.ProductId +'" clientid="'+ client.ClientId +'"> +' + product.Name + '</div>');
                                           $html.find('[date='+moment(activity.Date).format('DD-MM-YYYY')+']').append('<div class="col-12 product_time hide" clientid="'+ client.ClientId +'"> '+ product.Time +' </div> ')              
                                           total_hours = total_hours + product.Time;

                                            $(product.Campaign).each(function(i, campaign) {
                                                         
                                               $html.find('#first_colum').append('<div class="col-12 campaign_name hide" campaignid="'+ campaign.CampaingId +'" productid="'+ product.ProductId +'" clientid="'+ client.ClientId +'"> +' + campaign.Name + '</div>');
                                               $html.find('[date='+moment(activity.Date).format('DD-MM-YYYY')+']').append('<div class="col-12 campaign_time hide" clientid="'+ client.ClientId +'"> '+ campaign.Time +' </div> ')              
                                               total_hours = total_hours + campaign.Time;

                                                $(campaign.Job).each(function(i, job) {
                                                         
                                                   $html.find('#first_colum').append('<div class="col-12 job_name hide" campaignid="'+ campaign.CampaingId +'"  productid="'+ product.ProductId +'" clientid="'+ client.ClientId +'"> ' + job.Name + '</div>');
                                                   $html.find('[date='+moment(activity.Date).format('DD-MM-YYYY')+']').append('<div class="col-12 job_time hide" clientid="'+ client.ClientId +'"> '+ job.Time +' </div> ')              
                                                   total_hours = total_hours + job.Time;
                                                                 
                                                });
                                           
                                            });

                                        });

                                    });

                                    $html.find('[name=total_time]').html(total_hours);

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