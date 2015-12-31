function ContatoViewModel() {
    var self = this;

    self.ContatoId = ko.observable();
    self.Nome = ko.observable();
    self.Sobrenome = ko.observable();
    self.DataNascimento = ko.observable();
    self.Sexo = ko.observable();

    self.End = ko.observable();
    self.Tel = ko.observable();
    self.Mail = ko.observable();

    self.Enderecos = ko.observableArray([]);
    self.Telefones = ko.observableArray([]);
    self.Emails = ko.observableArray([]);
}