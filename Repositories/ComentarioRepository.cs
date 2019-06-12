using System;
using System.Collections.Generic;
using System.IO;
using PontoDigital_final.Models;

namespace PontoDigital_final.Repositories
{
    public class ComentarioRepository
    {
        private const string PATH = "Database/Comentarios.csv";
        private const string PATH_APROVADOS = "Database/ComentariosAprovados.csv";
        public void Inserir(Comentario comentario)
        {
            if (!File.Exists(PATH))
            {
                comentario.Id = 1;
            } else 
            {
                comentario.Id = File.ReadAllLines(PATH).Length + 1;
            }

            comentario.DataDoComentario = DateTime.Now;
            comentario.EstaAprovado = false;

            string linha = $"{comentario.Id};{comentario.DataDoComentario};{comentario.Assunto};{comentario.Mensagem};{comentario.Autor.Nome.ToUpper()};{comentario.Autor.Telefone};{comentario.Autor.Email};{comentario.Autor.Empresa.Nome.ToUpper()};{comentario.Autor.Empresa.Cnpj};{comentario.EstaAprovado}";
            
            StreamWriter sw = new StreamWriter(PATH,true);
            sw.WriteLine(linha);
            sw.Close();
        }

        public List<Comentario> Listar()
        {
            var listaDeComentarios = new List<Comentario>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                Comentario comentario = new Comentario();
                string[] dados = item.Split(";");
                comentario.Id = int.Parse(dados[0]);
                comentario.DataDoComentario = DateTime.Parse(dados[1]);
                comentario.Assunto = dados[2];
                comentario.Mensagem = dados[3];
                comentario.Autor = new Usuario();
                comentario.Autor.Nome = dados[4];
                comentario.Autor.Telefone = dados[5];
                comentario.Autor.Email = dados[6];
                comentario.Autor.Empresa = new Empresa();
                comentario.Autor.Empresa.Nome = dados[7];
                comentario.Autor.Empresa.Cnpj = dados[8];
                comentario.EstaAprovado = bool.Parse(dados[9]);

                listaDeComentarios.Add(comentario);
            }
            return listaDeComentarios;
        }

        public void Excluir(int id)
        {
            string[] linhas = File.ReadAllLines(PATH);
            
            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty(linhas[i]))
                {
                    continue;
                }

                string[] dados = linhas[i].Split(";");

                if (id.Equals(dados[0]))
                {
                    linhas[i] = "";
                    break;
                }
            }
            File.WriteAllLines(PATH,linhas);
        }

        public Comentario ObterComentario(int id) 
        {
            Comentario comentario;
            var listaDeComentarios = Listar();

            foreach (var item in listaDeComentarios) 
            {
                if (item == null)
                {
                    continue;
                }
                
                if (item.Id.Equals(id)) 
                {
                    comentario = item;
                    return comentario;
                }
            }
            return null;
        }

        public void Aprovar(Comentario comentario)
        {
            string[] linhas = File.ReadAllLines(PATH);
            
            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty(linhas[i]))
                {
                    continue;
                }

                string[] dados = linhas[i].Split(";");

                if (comentario.Id.ToString().Equals(dados[0]))
                {
                    comentario.EstaAprovado = true;
                    linhas[i] = $"{comentario.Id};{comentario.DataDoComentario};{comentario.Assunto};{comentario.Mensagem};{comentario.Autor.Nome.ToUpper()};{comentario.Autor.Telefone};{comentario.Autor.Email};{comentario.Autor.Empresa.Nome.ToUpper()};{comentario.Autor.Empresa.Cnpj};{comentario.EstaAprovado}";
                    break;
                }
            }
            File.WriteAllLines(PATH,linhas);
        }
        
         public void Recusar(Comentario comentario)
        {
            string[] linhas = File.ReadAllLines(PATH);
            
            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty(linhas[i]))
                {
                    continue;
                }

                string[] dados = linhas[i].Split(";");

                if (comentario.Id.ToString().Equals(dados[0]))
                {
                    comentario.EstaAprovado = false;
                    linhas[i] = $"{comentario.Id};{comentario.DataDoComentario};{comentario.Assunto};{comentario.Mensagem};{comentario.Autor.Nome.ToUpper()};{comentario.Autor.Telefone};{comentario.Autor.Email};{comentario.Autor.Empresa.Nome.ToUpper()};{comentario.Autor.Empresa.Cnpj};{comentario.EstaAprovado}";
                    break;
                }
            }
            File.WriteAllLines(PATH,linhas);
        }

    }//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\   FIM  DA CLASSE  \/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\
}