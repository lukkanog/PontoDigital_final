using System;
using System.Collections.Generic;
using System.IO;
using PontoDigital_final.Models;

namespace PontoDigital_final.Repositories
{
    public class UsuarioRepository
    {
        private const string PATH = "Database/Usuarios.csv";
        public void Inserir(Usuario usuario)
        {
            int quantLinhas = File.ReadAllLines(PATH).Length;

            if (!File.Exists(PATH) || quantLinhas < 1 )
            {
                usuario.Id = 1;
            }else 
            {
                usuario.Id = quantLinhas + 1;
            }
            string linha = $"{usuario.Id};{usuario.Nome.ToUpper()};{usuario.Endereco.ToUpper()};{usuario.Telefone};{usuario.Genero};{usuario.DataNascimento.ToShortDateString()};{usuario.Email};{usuario.Senha};{usuario.Empresa.Nome.ToUpper()};{usuario.Empresa.Cnpj};{usuario.UrlFoto}";
            
            StreamWriter sw = new StreamWriter(PATH,true);
            sw.WriteLine(linha);
            sw.Close();
        }

        public List<Usuario> Listar()
        {
            var listaDeUsuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                string[] dados = item.Split(";");
                Usuario usuario = new Usuario();
                usuario.Id = int.Parse(dados[0]);
                usuario.Nome = dados[1];
                usuario.Endereco = dados[2];
                usuario.Telefone = dados[3];
                usuario.Genero = dados[4];
                usuario.DataNascimento = DateTime.Parse(dados[5]);
                usuario.Email = dados[6];
                usuario.Senha = dados[7];

                Empresa empresa = new Empresa();
                empresa.Nome = dados[8];
                empresa.Cnpj = dados[9];

                usuario.UrlFoto = dados[10];

                usuario.Empresa = empresa;
                listaDeUsuarios.Add(usuario);
            }
            return listaDeUsuarios;
        }

        public Usuario TentarLogin(string email, string senha)
        {
            Usuario usuario;
            var listaDeUsuarios = Listar();
            foreach (var item in listaDeUsuarios)
            {
                if (item == null)
                {
                    continue;
                }

                if (email.Equals(item.Email) && item.Senha.Equals(senha))
                {
                    usuario = item;
                    return usuario;
                } 
            }
            return null;
        }

        public Usuario ObterUsuario(string email) 
        {
            Usuario usuario;
            var listaDeUsuarios = Listar();

            foreach (var item in listaDeUsuarios) 
            {
                if (item == null)
                {
                    continue;
                }
                
                if (item.Email.Equals(email)) 
                {
                    usuario = item;
                    return usuario;
                }
            }
            return null;
        }

        public Usuario ObterUsuario(int id) 
        {
            Usuario usuario;
            var listaDeUsuarios = Listar();

            foreach (var item in listaDeUsuarios) 
            {
                if (item == null)
                {
                    continue;
                }
                
                if (item.Id.Equals(id)) 
                {
                    usuario = item;
                    return usuario;
                }
            }
            return null;
        }

        public void EditarUsuario(Usuario usuarioAntigo, Usuario usuario)
        {
            usuario.Id = usuarioAntigo.Id;
            usuario.Email = usuarioAntigo.Email;
            usuario.Genero = usuarioAntigo.Genero;
            usuario.Senha = usuarioAntigo.Senha;


            string[] linhas = File.ReadAllLines(PATH);

            for (int i=0; i < linhas.Length; i++)
            {
                string[] linha = linhas[i].Split(";");

                if (usuario.Id.ToString().Equals(linha[0]))
                {
                    linhas[i] = $"{usuario.Id};{usuario.Nome.ToUpper()};{usuario.Endereco.ToUpper()};{usuario.Telefone};{usuario.Genero};{usuario.DataNascimento.ToShortDateString()};{usuario.Email};{usuario.Senha};{usuario.Empresa.Nome.ToUpper()};{usuario.Empresa.Cnpj};{usuario.UrlFoto}";
                    break;
                }
            }
            File.WriteAllLines(PATH,linhas);
        }

        public bool VerificarEmailExistente(string email)
        {
            var listaDeUsuarios = Listar();

            foreach (var item in listaDeUsuarios)
            {

                if (item!= null && item.Email.Equals(email))
                {
                    return true;
                }
            }
            return false;
        }
    }/////////////////////////////////////////////////////////////********FIM *************////////////////////////\/////////////////////////////////////
}