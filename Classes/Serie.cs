using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.series
{
  public class Serie : EntidadeBase
  {
    private Genero Genero { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private int Ano { get; set; }

    private bool Excluido { get; set; }

    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
    {
      this.Id = Id;
      this.Genero = genero;
      this.Titulo = titulo;
      this.Descricao = descricao;
      this.Ano = ano;
      this.Excluido = false;
    }
    public override string ToString()
    {
      string retorno = "";
      retorno += "Genêro " + this.Genero + Environment.NewLine;
      retorno += "Titulo " + this.Titulo + Environment.NewLine;
      retorno += "Decrição " + this.Descricao + Environment.NewLine;
      retorno += "Ano de Inicio " + this.Ano;
      return retorno;
    }
    public string retornaTitulo()
    {
      return this.Titulo;
    }

    public int retornaId()
    {
      return this.Id;
    }
    public bool Excluir()
    {
      return this.Excluido = true;
    }
    public bool retornaExcluido()
    {
      return this.Excluido;
    }
  }
}