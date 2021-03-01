$(document).ready(function () {
    $('#code').keyup(function () {
        var code = $(this).val();
        $.ajax('/structure/check',{
            
            method:'post',
            data: { code:code },
            dataType: 'json',
                success : function (data) {
                var divElement = $('#Status');
                    if (data==1) {
                        divElement.text(code + ' est pris');
                        divElement.css('color', 'red');
                        }
  
                  else {
                    divElement.text(code + ' est non pris');
                    divElement.css('color', 'green');}

                
            },

           
            
        });

    });
});

  

  /* </div>
            <div class="form-group">
                <label class="control-label"></label>
                <div id="Status">

                </div>

            </div>*/


