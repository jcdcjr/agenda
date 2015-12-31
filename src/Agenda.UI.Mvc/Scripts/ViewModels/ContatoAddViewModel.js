function ContatoAddViewModel() {
    var self = this;
    var idx = "";

    self.Contato = new ContatoViewModel();
    self.Endereco = new EnderecoViewModel();
    self.Telefone = new TelefoneViewModel();
    self.Email = new EmailViewModel();

    var contato = {
        ContatoId: self.Contato.ContatoId,
        Nome: self.Contato.Nome,
        SobreNome: self.Contato.Sobrenome,
        DataNascimento: self.Contato.DataNascimento,
        Sexo: self.Contato.Sexo,
        Enderecos: self.Contato.Enderecos,
        Telefones: self.Contato.Telefones,
        Emails: self.Contato.Emails
    };

    self.geraEnderecoId = function() {
        $.ajax({
            url: "/Contatos/GeraEnderecoId",
            type: "GET",
            contentType: "application/json",
            data: "",
            success: function(data) {
                self.Endereco.EnderecoId(data);
            }
        });
    }

    self.NovoEndereco = function() {
        self.geraEnderecoId();
        $("#novoEndereco").show();
    }
}