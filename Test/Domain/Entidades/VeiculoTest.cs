using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "Ford Focus";
        veiculo.Marca = "Ford";
        veiculo.Ano = 2010;

        //Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Ford Focus", veiculo.Nome);
        Assert.AreEqual("Ford", veiculo.Marca);
        Assert.AreEqual(2010, veiculo.Ano);
    }
}