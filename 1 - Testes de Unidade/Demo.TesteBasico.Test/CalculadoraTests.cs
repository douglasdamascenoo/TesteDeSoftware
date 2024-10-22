namespace Demo.TesteBasico.Test;

public class CalculadoraTests
{
    [Fact]
    public void Calculadora_Somar_RetornarValorSoma()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Somar(2, 3);

        // Assert
        Assert.Equal(5, resultado);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(2, 4, 6)]
    [InlineData(5, 3, 8)]
    [InlineData(8, 2, 10)]
    [InlineData(6, 7, 13)]
    public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double v3)
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Somar(v1, v2);

        // Assert
        Assert.Equal(v3, resultado);
    }
}