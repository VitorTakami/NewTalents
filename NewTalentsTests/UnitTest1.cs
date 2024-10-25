using NewTalents;

namespace NewTalentsTests;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora c = new Calculadora();

        int resultadoEsperado = c.somar(val1,val2);

        Assert.Equal(resultadoEsperado, resultado);

    }

    
    [Theory]
    [InlineData(2,4,3)]
    [InlineData(9,5,4)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        Calculadora c = new Calculadora();

        int resultadoEsperado = c.subtrair(val1,val2);

        Assert.Equal(resultadoEsperado, resultado);

    }


    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora c = new Calculadora();

        int resultadoEsperado = c.multiplicar(val1,val2);

        Assert.Equal(resultadoEsperado, resultado);

    }

    [Theory]
    [InlineData(2,2,1)]
    [InlineData(9,3,3)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora c = new Calculadora();

        int resultadoEsperado = c.dividir(val1,val2);

        Assert.Throws<DivideByZeroException>(
            () => c.dividir(val1,val2)
        );
        //Assert.Equal(resultadoEsperado, resultado);

    }

    public void TestarHistorico()
    {
        Calculadora c = new Calculadora();

        c.somar(1,2);
        c.somar(2,8);
        c.somar(3,7);
        c.somar(4,1);

        var lista = c.historico();

        Assert.NotEmpty(c.historico());
        Assert.Equal(3, lista.Count());
        

    }

    
}