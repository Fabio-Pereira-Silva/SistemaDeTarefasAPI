using System;
using System.Security.Cryptography;

namespace SistemaDeTarefas.Data

public class SistemaTarefasDBContex: Dbcontext
{
    public SistemaTarefasDBContex(DbContextOptions<SistemaDeTarefasDBContex> options): base(options)
    {
        
    }

    public DbSet<UsuarioModel> Usuarios { get; set; }
    public DbSet<TarefaModel> Tarefas { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    base.OnModelCreating(modelBuilder);
    }
}
