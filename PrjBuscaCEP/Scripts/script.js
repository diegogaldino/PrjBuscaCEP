$(document).ready(function(){
    $('#Cep').blur(function () {
        var cep = $('#Cep').val() || '';
        if (!cep) {
            return;
        }
        
        var url = 'http://viacep.com.br/ws/' + cep + '/json';
        $.getJSON(url, function (data) {
            if ("error" in data) {
                return;
            }

            $('#Endereco').val(data.logradouro);
            $('#Bairro').val(data.bairro);
            $('#Cidade').val(data.localidade);
            $('#Estado').val(data.uf);
        });
    });
});