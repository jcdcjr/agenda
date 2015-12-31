function EnderecoViewModel() {
    var self = this;

    self.TelefoneId = ko.observable();
    self.ContatoId = ko.observable();
    self.Cep = ko.observable();
    self.Logradouro = ko.observable();
    self.Numero = ko.observable();
    self.Complemento = ko.observable();
    self.Bairro = ko.observable();
    self.Cidade = ko.observable();
    self.Estado = ko.observable();
}