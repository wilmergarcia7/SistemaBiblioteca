﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBiblioteca
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDBibliotecaEntities : DbContext
    {
        public BDBibliotecaEntities()
            : base("name=BDBibliotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Administradores> Administradores { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Detalleprestamo> Detalleprestamo { get; set; }
        public DbSet<Devoluciones> Devoluciones { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Idiomas> Idiomas { get; set; }
        public DbSet<Lectores> Lectores { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}