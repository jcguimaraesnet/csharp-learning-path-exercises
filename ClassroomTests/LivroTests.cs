using Classroom;

namespace ClassroomTests;

public class LivroTests
{
    [Fact]
    public void Livro_AposEmprestar_IgualAFalse()
    {
        //A - arrange
        var livro = new Livro("O Senhor dos Anéis", 1954, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7");
        
        //A - act
        livro.Emprestar();

        //A - assert
        Assert.False(livro.EstahDisponivel());
    }

    [Fact]
    public void Livro_AposDevolver_IgualATrue()
    {
        //A - arrange
        var livro = new Livro("O Senhor dos Anéis", 1954, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7");

        //A - act
        livro.Emprestar();
        livro.Devolver();

        //A - assert
        Assert.True(livro.EstahDisponivel());
    }

    [Fact]
    public void Livro_AposCriacao_IgualATrue()
    {
        //A - act
        var livro = new Livro("O Senhor dos Anéis", 1954, "Martins Fontes", "J.R.R. Tolkien", "978-0-395-19395-7");

        //A - assert
        Assert.True(livro.EstahDisponivel());
    }
}
