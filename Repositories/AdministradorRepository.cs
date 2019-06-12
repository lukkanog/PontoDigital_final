using System;
using System.Collections.Generic;
using System.IO;
using PontoDigital_final.Models;

namespace PontoDigital_final.Repositories
{
    public class AdministradorRepository
    {
        UsuarioRepository usuarioRepositorio = new UsuarioRepository();
        private const string PATH = "Database/Administradores.csv";
        public void Inserir(Administrador adm)
        {
            int quantLinhas = File.ReadAllLines(PATH).Length;

            if (!File.Exists(PATH) || quantLinhas < 1 )
            {
                adm.Id = 1;
            } else 
            {
                adm.Id = quantLinhas+1;
            }

                string linha = $"{adm.Id};{adm.Nome.ToUpper()};{adm.Setor.ToUpper()};{adm.Telefone};{adm.Email};{adm.Endereco};{adm.DataNascimento.ToShortDateString()};{adm.Senha}";

            StreamWriter sw = new StreamWriter(PATH,true);
            sw.WriteLine(linha);
            sw.Close();
        }

        public List<Administrador> Listar()
        {
            var listaDeAdmins = new List<Administrador>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }

                string[] dados = item.Split(";");
                Administrador adm = new Administrador();
                adm.Id = int.Parse(dados[0]);
                adm.Nome = dados[1];
                adm.Setor = dados[2];
                adm.Telefone = dados[3];
                adm.Email = dados[4];
                adm.Endereco = dados[5];
                adm.DataNascimento = DateTime.Parse(dados[6]);
                adm.Senha = dados[7];

                listaDeAdmins.Add(adm);
            }
            return listaDeAdmins;
        }

        public bool VerificarEmailExistente(string email)
        {
            var listaDeAdmins = Listar();
            var listaDeUsuarios = usuarioRepositorio.Listar();

            foreach (var item in listaDeAdmins)
            {
                if (item!= null && item.Email.Equals(email))
                {
                    return true;
                }
            }

            foreach (var item in listaDeUsuarios)
            {

                if (item!= null && item.Email.Equals(email))
                {
                    return true;
                }
            }

            return false;
        }

        public Administrador TentarLogin(string email, string senha)
        {
            Administrador adm;
            var listaDeAdmins = Listar();
            foreach (var item in listaDeAdmins)
            {
                if (item == null)
                {
                    continue;
                }

                if (email.Equals(item.Email) && item.Senha.Equals(senha))
                {
                    adm = item;
                    return adm;
                } 
            }
            return null;
        }


    }///////////////////////////FIM//////////////////////////////FIM///////////////////////////FIM///////////////////FIM///////////////////////////////////
}