using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Entidades.ObjetoDeValor;
using QuickBuy.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { 
                    Id = 1,Nome= "Boleto", 
                    Descricao = "Forma de Pagamento Boleto" 
                },

                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartao de Crédito",
                    Descricao = "Forma de Pagamento Cartao de Crédito"
                },

                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Deposito",
                    Descricao = "Forma de Pagamento Deposito"
                }

                );

            modelBuilder.Entity<Produto>().HasData(
                new Produto()
                {
                    Id = 1,
                    Nome="Produto Teste 01",
                    Descricao="Description Test",
                    Preco=50
                }

                );


            base.OnModelCreating(modelBuilder);
        }

    }
}
