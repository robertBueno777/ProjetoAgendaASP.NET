using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProjetoAgenda.Models
{
    public class EstadoCidade
    {
        public List<Estado> GetEstados()
        {
            return new List<Estado>{
                new Estado
                {
                    EstadoId = 1,
                    NomeEstado = "Acre",
                    Sigla = "AC",
                    Cidades = new List<Cidade>
                    {
                        new Cidade { CidadeId = 1, NomeCidade = "Acrelândia", EstadoId = 1 },
                        new Cidade { CidadeId = 2, NomeCidade = "Assis Brasil", EstadoId = 1 },
                        new Cidade { CidadeId = 3, NomeCidade = "Brasiléia", EstadoId = 1 },
                        new Cidade { CidadeId = 4, NomeCidade = "Bujari", EstadoId = 1 },
                        new Cidade { CidadeId = 5, NomeCidade = "Capixaba", EstadoId = 1 },
                        new Cidade { CidadeId = 6, NomeCidade = "Cruzeiro do Sul", EstadoId = 1 },
                        new Cidade { CidadeId = 7, NomeCidade = "Epitaciolândia", EstadoId = 1 },
                        new Cidade { CidadeId = 8, NomeCidade = "Feijó", EstadoId = 1 },
                        new Cidade { CidadeId = 9, NomeCidade = "Jordão", EstadoId = 1 },
                        new Cidade { CidadeId = 10, NomeCidade = "Mâncio Lima", EstadoId = 1 },
                        new Cidade { CidadeId = 11, NomeCidade = "Manoel Urbano", EstadoId = 1 },
                        new Cidade { CidadeId = 12, NomeCidade = "Marechal Thaumaturgo", EstadoId = 1 },
                        new Cidade { CidadeId = 13, NomeCidade = "Plácido de Castro", EstadoId = 1 },
                        new Cidade { CidadeId = 14, NomeCidade = "Porto Acre", EstadoId = 1 },
                        new Cidade { CidadeId = 15, NomeCidade = "Porto Walter", EstadoId = 1 },
                        new Cidade { CidadeId = 16, NomeCidade = "Rio Branco", EstadoId = 1 },
                        new Cidade { CidadeId = 17, NomeCidade = "Rodrigues Alves", EstadoId = 1 },
                        new Cidade { CidadeId = 18, NomeCidade = "Santa Rosa do Purus", EstadoId = 1 },
                        new Cidade { CidadeId = 19, NomeCidade = "Sena Madureira", EstadoId = 1 },
                        new Cidade { CidadeId = 20, NomeCidade = "Senador Guiomard", EstadoId = 1 },
                        new Cidade { CidadeId = 21, NomeCidade = "Tarauacá", EstadoId = 1 },
                        new Cidade { CidadeId = 22, NomeCidade = "Xapuri", EstadoId = 1 }
                    }
                },


            new Estado
            {
                EstadoId = 2,
                NomeEstado = "Alagoas",
                Sigla = "AL",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 23, NomeCidade = "Água Branca", EstadoId = 2 },
                    new Cidade { CidadeId = 24, NomeCidade = "Anadia", EstadoId = 2 },
                    new Cidade { CidadeId = 25, NomeCidade = "Arapiraca", EstadoId = 2 },
                    new Cidade { CidadeId = 26, NomeCidade = "Atalaia", EstadoId = 2 },
                    new Cidade { CidadeId = 27, NomeCidade = "Barra de Santo Antônio", EstadoId = 2 },
                    new Cidade { CidadeId = 28, NomeCidade = "Barra de São Miguel", EstadoId = 2 },
                    new Cidade { CidadeId = 29, NomeCidade = "Batalha", EstadoId = 2 },
                    new Cidade { CidadeId = 30, NomeCidade = "Belém", EstadoId = 2 },
                    new Cidade { CidadeId = 31, NomeCidade = "Belo Monte", EstadoId = 2 },
                    new Cidade { CidadeId = 32, NomeCidade = "Boca da Mata", EstadoId = 2 },
                    new Cidade { CidadeId = 33, NomeCidade = "Branquinha", EstadoId = 2 },
                    new Cidade { CidadeId = 34, NomeCidade = "Cacimbinhas", EstadoId = 2 },
                    new Cidade { CidadeId = 35, NomeCidade = "Cajueiro", EstadoId = 2 },
                    new Cidade { CidadeId = 36, NomeCidade = "Campestre", EstadoId = 2 },
                    new Cidade { CidadeId = 37, NomeCidade = "Campo Alegre", EstadoId = 2 },
                    new Cidade { CidadeId = 38, NomeCidade = "Campo Grande", EstadoId = 2 },
                    new Cidade { CidadeId = 39, NomeCidade = "Canapi", EstadoId = 2 },
                    new Cidade { CidadeId = 40, NomeCidade = "Capela", EstadoId = 2 },
                    new Cidade { CidadeId = 41, NomeCidade = "Carneiros", EstadoId = 2 },
                    new Cidade { CidadeId = 42, NomeCidade = "Chã Preta", EstadoId = 2 },
                    new Cidade { CidadeId = 43, NomeCidade = "Coité do Nóia", EstadoId = 2 },
                    new Cidade { CidadeId = 44, NomeCidade = "Colônia Leopoldina", EstadoId = 2 },
                    new Cidade { CidadeId = 45, NomeCidade = "Coqueiro Seco", EstadoId = 2 },
                    new Cidade { CidadeId = 46, NomeCidade = "Coruripe", EstadoId = 2 },
                    new Cidade { CidadeId = 47, NomeCidade = "Craíbas", EstadoId = 2 },
                    new Cidade { CidadeId = 48, NomeCidade = "Delmiro Gouveia", EstadoId = 2 },
                    new Cidade { CidadeId = 49, NomeCidade = "Dois Riachos", EstadoId = 2 },
                    new Cidade { CidadeId = 50, NomeCidade = "Estrela de Alagoas", EstadoId = 2 },
                    new Cidade { CidadeId = 51, NomeCidade = "Feira Grande", EstadoId = 2 },
                    new Cidade { CidadeId = 52, NomeCidade = "Feliz Deserto", EstadoId = 2 },
                    new Cidade { CidadeId = 53, NomeCidade = "Flexeiras", EstadoId = 2 },
                    new Cidade { CidadeId = 54, NomeCidade = "Girau do Ponciano", EstadoId = 2 },
                    new Cidade { CidadeId = 55, NomeCidade = "Ibateguara", EstadoId = 2 },
                    new Cidade { CidadeId = 56, NomeCidade = "Igaci", EstadoId = 2 },
                    new Cidade { CidadeId = 57, NomeCidade = "Igreja Nova", EstadoId = 2 },
                    new Cidade { CidadeId = 58, NomeCidade = "Inhapi", EstadoId = 2 },
                    new Cidade { CidadeId = 59, NomeCidade = "Jacaré dos Homens", EstadoId = 2 },
                    new Cidade { CidadeId = 60, NomeCidade = "Jacuípe", EstadoId = 2 },
                    new Cidade { CidadeId = 61, NomeCidade = "Japaratinga", EstadoId = 2 },
                    new Cidade { CidadeId = 62, NomeCidade = "Jaramataia", EstadoId = 2 },
                    new Cidade { CidadeId = 63, NomeCidade = "Jequiá da Praia", EstadoId = 2 },
                    new Cidade { CidadeId = 64, NomeCidade = "Joaquim Gomes", EstadoId = 2 },
                    new Cidade { CidadeId = 65, NomeCidade = "Jundiá", EstadoId = 2 },
                    new Cidade { CidadeId = 66, NomeCidade = "Junqueiro", EstadoId = 2 },
                    new Cidade { CidadeId = 67, NomeCidade = "Lagoa da Canoa", EstadoId = 2 },
                    new Cidade { CidadeId = 68, NomeCidade = "Limoeiro de Anadia", EstadoId = 2 },
                    new Cidade { CidadeId = 69, NomeCidade = "Maceió", EstadoId = 2 },
                    new Cidade { CidadeId = 70, NomeCidade = "Major Isidoro", EstadoId = 2 },
                    new Cidade { CidadeId = 71, NomeCidade = "Mar Vermelho", EstadoId = 2 },
                    new Cidade { CidadeId = 72, NomeCidade = "Maragogi", EstadoId = 2 },
                    new Cidade { CidadeId = 73, NomeCidade = "Maravilha", EstadoId = 2 },
                    new Cidade { CidadeId = 74, NomeCidade = "Marechal Deodoro", EstadoId = 2 },
                    new Cidade { CidadeId = 75, NomeCidade = "Maribondo", EstadoId = 2 },
                    new Cidade { CidadeId = 76, NomeCidade = "Mata Grande", EstadoId = 2 },
                    new Cidade { CidadeId = 77, NomeCidade = "Matriz de Camaragibe", EstadoId = 2 },
                    new Cidade { CidadeId = 78, NomeCidade = "Messias", EstadoId = 2 },
                    new Cidade { CidadeId = 79, NomeCidade = "Minador do Negrão", EstadoId = 2 },
                    new Cidade { CidadeId = 80, NomeCidade = "Monteirópolis", EstadoId = 2 },
                    new Cidade { CidadeId = 81, NomeCidade = "Murici", EstadoId = 2 },
                    new Cidade { CidadeId = 82, NomeCidade = "Novo Lino", EstadoId = 2 },
                    new Cidade { CidadeId = 83, NomeCidade = "Olho d'Água das Flores", EstadoId = 2 },
                    new Cidade { CidadeId = 84, NomeCidade = "Olho d'Água do Casado", EstadoId = 2 },
                    new Cidade { CidadeId = 85, NomeCidade = "Olho d'Água Grande", EstadoId = 2 },
                    new Cidade { CidadeId = 86, NomeCidade = "Olivença", EstadoId = 2 },
                    new Cidade { CidadeId = 87, NomeCidade = "Ouro Branco", EstadoId = 2 },
                    new Cidade { CidadeId = 88, NomeCidade = "Palestina", EstadoId = 2 },
                    new Cidade { CidadeId = 89, NomeCidade = "Palmeira dos Índios", EstadoId = 2 },
                    new Cidade { CidadeId = 90, NomeCidade = "Pão de Açúcar", EstadoId = 2 },
                    new Cidade { CidadeId = 91, NomeCidade = "Pariconha", EstadoId = 2 },
                    new Cidade { CidadeId = 92, NomeCidade = "Paripueira", EstadoId = 2 },
                    new Cidade { CidadeId = 93, NomeCidade = "Passo de Camaragibe", EstadoId = 2 },
                    new Cidade { CidadeId = 94, NomeCidade = "Paulo Jacinto", EstadoId = 2 },
                    new Cidade { CidadeId = 95, NomeCidade = "Penedo", EstadoId = 2 },
                    new Cidade { CidadeId = 96, NomeCidade = "Piaçabuçu", EstadoId = 2 },
                    new Cidade { CidadeId = 97, NomeCidade = "Pilar", EstadoId = 2 },
                    new Cidade { CidadeId = 98, NomeCidade = "Pindoba", EstadoId = 2 },
                    new Cidade { CidadeId = 99, NomeCidade = "Piranhas", EstadoId = 2 },
                    new Cidade { CidadeId = 100, NomeCidade = "Poço das Trincheiras", EstadoId = 2 },
                    new Cidade { CidadeId = 101, NomeCidade = "Porto Calvo", EstadoId = 2 },
                    new Cidade { CidadeId = 102, NomeCidade = "Porto de Pedras", EstadoId = 2 },
                    new Cidade { CidadeId = 103, NomeCidade = "Porto Real do Colégio", EstadoId = 2 },
                    new Cidade { CidadeId = 104, NomeCidade = "Quebrangulo", EstadoId = 2 },
                    new Cidade { CidadeId = 105, NomeCidade = "Rio Largo", EstadoId = 2 },
                    new Cidade { CidadeId = 106, NomeCidade = "Roteiro", EstadoId = 2 },
                    new Cidade { CidadeId = 107, NomeCidade = "Santa Luzia do Norte", EstadoId = 2 },
                    new Cidade { CidadeId = 108, NomeCidade = "Santana do Ipanema", EstadoId = 2 },
                    new Cidade { CidadeId = 109, NomeCidade = "Santana do Mundaú", EstadoId = 2 },
                    new Cidade { CidadeId = 110, NomeCidade = "São Brás", EstadoId = 2 },
                    new Cidade { CidadeId = 111, NomeCidade = "São José da Laje", EstadoId = 2 },
                    new Cidade { CidadeId = 112, NomeCidade = "São José da Tapera", EstadoId = 2 },
                    new Cidade { CidadeId = 113, NomeCidade = "São Luís do Quitunde", EstadoId = 2 },
                    new Cidade { CidadeId = 114, NomeCidade = "São Miguel dos Campos", EstadoId = 2 },
                    new Cidade { CidadeId = 115, NomeCidade = "São Miguel dos Milagres", EstadoId = 2 },
                    new Cidade { CidadeId = 116, NomeCidade = "São Sebastião", EstadoId = 2 },
                    new Cidade { CidadeId = 117, NomeCidade = "Satuba", EstadoId = 2 },
                    new Cidade { CidadeId = 118, NomeCidade = "Senador Rui Palmeira", EstadoId = 2 },
                    new Cidade { CidadeId = 119, NomeCidade = "Tanque d'Arca", EstadoId = 2 },
                    new Cidade { CidadeId = 120, NomeCidade = "Taquarana", EstadoId = 2 },
                    new Cidade { CidadeId = 121, NomeCidade = "Teotônio Vilela", EstadoId = 2 },
                    new Cidade { CidadeId = 122, NomeCidade = "Traipu", EstadoId = 2 },
                    new Cidade { CidadeId = 123, NomeCidade = "União dos Palmares", EstadoId = 2 },
                    new Cidade { CidadeId = 124, NomeCidade = "Viçosa", EstadoId = 2 }
                }
            },

            new Estado
            {
                EstadoId = 3,
                NomeEstado = "Amapá",
                Sigla = "AP",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 125, NomeCidade = "Amapá", EstadoId = 3 },
                    new Cidade { CidadeId = 126, NomeCidade = "Calçoene", EstadoId = 3 },
                    new Cidade { CidadeId = 127, NomeCidade = "Cutias", EstadoId = 3 },
                    new Cidade { CidadeId = 128, NomeCidade = "Ferreira Gomes", EstadoId = 3 },
                    new Cidade { CidadeId = 129, NomeCidade = "Itaubal", EstadoId = 3 },
                    new Cidade { CidadeId = 130, NomeCidade = "Laranjal do Jari", EstadoId = 3 },
                    new Cidade { CidadeId = 131, NomeCidade = "Macapá", EstadoId = 3 },
                    new Cidade { CidadeId = 132, NomeCidade = "Mazagão", EstadoId = 3 },
                    new Cidade { CidadeId = 133, NomeCidade = "Oiapoque", EstadoId = 3 },
                    new Cidade { CidadeId = 134, NomeCidade = "Pedra Branca do Amapari", EstadoId = 3 },
                    new Cidade { CidadeId = 135, NomeCidade = "Porto Grande", EstadoId = 3 },
                    new Cidade { CidadeId = 136, NomeCidade = "Pracuúba", EstadoId = 3 },
                    new Cidade { CidadeId = 137, NomeCidade = "Santana", EstadoId = 3 },
                    new Cidade { CidadeId = 138, NomeCidade = "Serra do Navio", EstadoId = 3 },
                    new Cidade { CidadeId = 139, NomeCidade = "Tartarugalzinho", EstadoId = 3 },
                    new Cidade { CidadeId = 140, NomeCidade = "Vitória do Jari", EstadoId = 3 }
                }
            },

            new Estado
            {
                EstadoId = 4,
                NomeEstado = "Amazonas",
                Sigla = "AM",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 141, NomeCidade = "Alvarães", EstadoId = 4 },
                    new Cidade { CidadeId = 142, NomeCidade = "Amaturá", EstadoId = 4 },
                    new Cidade { CidadeId = 143, NomeCidade = "Anamã", EstadoId = 4 },
                    new Cidade { CidadeId = 144, NomeCidade = "Anori", EstadoId = 4 },
                    new Cidade { CidadeId = 145, NomeCidade = "Apuí", EstadoId = 4 },
                    new Cidade { CidadeId = 146, NomeCidade = "Atalaia do Norte", EstadoId = 4 },
                    new Cidade { CidadeId = 147, NomeCidade = "Autazes", EstadoId = 4 },
                    new Cidade { CidadeId = 148, NomeCidade = "Barcelos", EstadoId = 4 },
                    new Cidade { CidadeId = 149, NomeCidade = "Barreirinha", EstadoId = 4 },
                    new Cidade { CidadeId = 150, NomeCidade = "Benjamin Constant", EstadoId = 4 },
                    new Cidade { CidadeId = 151, NomeCidade = "Beruri", EstadoId = 4 },
                    new Cidade { CidadeId = 152, NomeCidade = "Boa Vista do Ramos", EstadoId = 4 },
                    new Cidade { CidadeId = 153, NomeCidade = "Boca do Acre", EstadoId = 4 },
                    new Cidade { CidadeId = 154, NomeCidade = "Borba", EstadoId = 4 },
                    new Cidade { CidadeId = 155, NomeCidade = "Caapiranga", EstadoId = 4 },
                    new Cidade { CidadeId = 156, NomeCidade = "Canutama", EstadoId = 4 },
                    new Cidade { CidadeId = 157, NomeCidade = "Carauari", EstadoId = 4 },
                    new Cidade { CidadeId = 158, NomeCidade = "Careiro", EstadoId = 4 },
                    new Cidade { CidadeId = 159, NomeCidade = "Careiro da Várzea", EstadoId = 4 },
                    new Cidade { CidadeId = 160, NomeCidade = "Coari", EstadoId = 4 },
                    new Cidade { CidadeId = 161, NomeCidade = "Codajás", EstadoId = 4 },
                    new Cidade { CidadeId = 162, NomeCidade = "Eirunepé", EstadoId = 4 },
                    new Cidade { CidadeId = 163, NomeCidade = "Envira", EstadoId = 4 },
                    new Cidade { CidadeId = 164, NomeCidade = "Fonte Boa", EstadoId = 4 },
                    new Cidade { CidadeId = 165, NomeCidade = "Guajará", EstadoId = 4 },
                    new Cidade { CidadeId = 166, NomeCidade = "Humaitá", EstadoId = 4 },
                    new Cidade { CidadeId = 167, NomeCidade = "Ipixuna", EstadoId = 4 },
                    new Cidade { CidadeId = 168, NomeCidade = "Iranduba", EstadoId = 4 },
                    new Cidade { CidadeId = 169, NomeCidade = "Itacoatiara", EstadoId = 4 },
                    new Cidade { CidadeId = 170, NomeCidade = "Itamarati", EstadoId = 4 },
                    new Cidade { CidadeId = 171, NomeCidade = "Itapiranga", EstadoId = 4 },
                    new Cidade { CidadeId = 172, NomeCidade = "Japurá", EstadoId = 4 },
                    new Cidade { CidadeId = 173, NomeCidade = "Juruá", EstadoId = 4 },
                    new Cidade { CidadeId = 174, NomeCidade = "Jutaí", EstadoId = 4 },
                    new Cidade { CidadeId = 175, NomeCidade = "Lábrea", EstadoId = 4 },
                    new Cidade { CidadeId = 176, NomeCidade = "Manacapuru", EstadoId = 4 },
                    new Cidade { CidadeId = 177, NomeCidade = "Manaquiri", EstadoId = 4 },
                    new Cidade { CidadeId = 178, NomeCidade = "Manaus", EstadoId = 4 },
                    new Cidade { CidadeId = 179, NomeCidade = "Manicoré", EstadoId = 4 },
                    new Cidade { CidadeId = 180, NomeCidade = "Maraã", EstadoId = 4 },
                    new Cidade { CidadeId = 181, NomeCidade = "Maués", EstadoId = 4 },
                    new Cidade { CidadeId = 182, NomeCidade = "Nhamundá", EstadoId = 4 },
                    new Cidade { CidadeId = 183, NomeCidade = "Nova Olinda do Norte", EstadoId = 4 },
                    new Cidade { CidadeId = 184, NomeCidade = "Novo Airão", EstadoId = 4 },
                    new Cidade { CidadeId = 185, NomeCidade = "Novo Aripuanã", EstadoId = 4 },
                    new Cidade { CidadeId = 186, NomeCidade = "Parintins", EstadoId = 4 },
                    new Cidade { CidadeId = 187, NomeCidade = "Pauini", EstadoId = 4 },
                    new Cidade { CidadeId = 188, NomeCidade = "Presidente Figueiredo", EstadoId = 4 },
                    new Cidade { CidadeId = 189, NomeCidade = "Rio Preto da Eva", EstadoId = 4 },
                    new Cidade { CidadeId = 190, NomeCidade = "Santa Isabel do Rio Negro", EstadoId = 4 },
                    new Cidade { CidadeId = 191, NomeCidade = "Santo Antônio do Içá", EstadoId = 4 },
                    new Cidade { CidadeId = 192, NomeCidade = "São Gabriel da Cachoeira", EstadoId = 4 },
                    new Cidade { CidadeId = 193, NomeCidade = "São Paulo de Olivença", EstadoId = 4 },
                    new Cidade { CidadeId = 194, NomeCidade = "São Sebastião do Uatumã", EstadoId = 4 },
                    new Cidade { CidadeId = 195, NomeCidade = "Silves", EstadoId = 4 },
                    new Cidade { CidadeId = 196, NomeCidade = "Tabatinga", EstadoId = 4 },
                    new Cidade { CidadeId = 197, NomeCidade = "Tapauá", EstadoId = 4 },
                    new Cidade { CidadeId = 198, NomeCidade = "Tefé", EstadoId = 4 },
                    new Cidade { CidadeId = 199, NomeCidade = "Tonantins", EstadoId = 4 },
                    new Cidade { CidadeId = 200, NomeCidade = "Uarini", EstadoId = 4 },
                    new Cidade { CidadeId = 201, NomeCidade = "Urucará", EstadoId = 4 },
                    new Cidade { CidadeId = 202, NomeCidade = "Urucurituba", EstadoId = 4 }
                }
            },
            new Estado
            {
                EstadoId = 5,
                NomeEstado = "Bahia",
                Sigla = "BA",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 203, NomeCidade = "Salvador", EstadoId = 5 },
                    new Cidade { CidadeId = 204, NomeCidade = "Feira de Santana", EstadoId = 5 },
                    new Cidade { CidadeId = 205, NomeCidade = "Vitória da Conquista", EstadoId = 5 },
                    new Cidade { CidadeId = 206, NomeCidade = "Camaçari", EstadoId = 5 },
                    new Cidade { CidadeId = 207, NomeCidade = "Itabuna", EstadoId = 5 },
                    new Cidade { CidadeId = 208, NomeCidade = "Juazeiro", EstadoId = 5 },
                    new Cidade { CidadeId = 209, NomeCidade = "Lauro de Freitas", EstadoId = 5 },
                    new Cidade { CidadeId = 210, NomeCidade = "Ilhéus", EstadoId = 5 },
                    new Cidade { CidadeId = 211, NomeCidade = "Jequié", EstadoId = 5 },
                    new Cidade { CidadeId = 212, NomeCidade = "Teixeira de Freitas", EstadoId = 5 },
                    new Cidade { CidadeId = 213, NomeCidade = "Barreiras", EstadoId = 5 },
                    new Cidade { CidadeId = 214, NomeCidade = "Alagoinhas", EstadoId = 5 },
                    new Cidade { CidadeId = 215, NomeCidade = "Porto Seguro", EstadoId = 5 },
                    new Cidade { CidadeId = 216, NomeCidade = "Simões Filho", EstadoId = 5 },
                    new Cidade { CidadeId = 217, NomeCidade = "Paulo Afonso", EstadoId = 5 },
                }
            },
            new Estado
            {
                EstadoId = 6,
                NomeEstado = "Ceará",
                Sigla = "CE",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 301, NomeCidade = "Fortaleza", EstadoId = 6 },
                    new Cidade { CidadeId = 302, NomeCidade = "Caucaia", EstadoId = 6 },
                    new Cidade { CidadeId = 303, NomeCidade = "Juazeiro do Norte", EstadoId = 6 },
                    new Cidade { CidadeId = 304, NomeCidade = "Maracanaú", EstadoId = 6 },
                    new Cidade { CidadeId = 305, NomeCidade = "Sobral", EstadoId = 6 },
                    new Cidade { CidadeId = 306, NomeCidade = "Crato", EstadoId = 6 },
                    new Cidade { CidadeId = 307, NomeCidade = "Itapipoca", EstadoId = 6 },
                    new Cidade { CidadeId = 308, NomeCidade = "Maranguape", EstadoId = 6 },
                    new Cidade { CidadeId = 309, NomeCidade = "Iguatu", EstadoId = 6 },
                    new Cidade { CidadeId = 310, NomeCidade = "Quixadá", EstadoId = 6 },
                    new Cidade { CidadeId = 311, NomeCidade = "Aquiraz", EstadoId = 6 },
                    new Cidade { CidadeId = 312, NomeCidade = "Quixeramobim", EstadoId = 6 },
                    new Cidade { CidadeId = 313, NomeCidade = "Canindé", EstadoId = 6 },
                    new Cidade { CidadeId = 314, NomeCidade = "Pacatuba", EstadoId = 6 },
                    new Cidade { CidadeId = 315, NomeCidade = "Russas", EstadoId = 6 },
                    new Cidade { CidadeId = 316, NomeCidade = "Crateús", EstadoId = 6 },
                    new Cidade { CidadeId = 317, NomeCidade = "Aracati", EstadoId = 6 },
                    new Cidade { CidadeId = 318, NomeCidade = "Tianguá", EstadoId = 6 },
                    new Cidade { CidadeId = 319, NomeCidade = "Icó", EstadoId = 6 },
                    new Cidade { CidadeId = 320, NomeCidade = "Horizonte", EstadoId = 6 }
                }
            },

            new Estado
            {
                EstadoId = 7,
                NomeEstado = "Distrito Federal",
                Sigla = "DF",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 401, NomeCidade = "Brasília", EstadoId = 7 },
                    new Cidade { CidadeId = 402, NomeCidade = "Ceilândia", EstadoId = 7 },
                    new Cidade { CidadeId = 403, NomeCidade = "Taguatinga", EstadoId = 7 },
                    new Cidade { CidadeId = 404, NomeCidade = "Samambaia", EstadoId = 7 },
                    new Cidade { CidadeId = 405, NomeCidade = "Planaltina", EstadoId = 7 },
                    new Cidade { CidadeId = 406, NomeCidade = "Águas Claras", EstadoId = 7 },
                    new Cidade { CidadeId = 407, NomeCidade = "Gama", EstadoId = 7 },
                    new Cidade { CidadeId = 408, NomeCidade = "Santa Maria", EstadoId = 7 },
                    new Cidade { CidadeId = 409, NomeCidade = "Recanto das Emas", EstadoId = 7 },
                    new Cidade { CidadeId = 410, NomeCidade = "Sobradinho", EstadoId = 7 },
                    new Cidade { CidadeId = 411, NomeCidade = "Guará", EstadoId = 7 },
                    new Cidade { CidadeId = 412, NomeCidade = "São Sebastião", EstadoId = 7 }
                }
            },

            new Estado
            {
                EstadoId = 8,
                NomeEstado = "Espírito Santo",
                Sigla = "ES",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 501, NomeCidade = "Serra", EstadoId = 8 },
                    new Cidade { CidadeId = 502, NomeCidade = "Vila Velha", EstadoId = 8 },
                    new Cidade { CidadeId = 503, NomeCidade = "Cariacica", EstadoId = 8 },
                    new Cidade { CidadeId = 504, NomeCidade = "Vitória", EstadoId = 8 },
                    new Cidade { CidadeId = 505, NomeCidade = "Cachoeiro de Itapemirim", EstadoId = 8 },
                    new Cidade { CidadeId = 506, NomeCidade = "Linhares", EstadoId = 8 },
                    new Cidade { CidadeId = 507, NomeCidade = "Guarapari", EstadoId = 8 },
                    new Cidade { CidadeId = 508, NomeCidade = "São Mateus", EstadoId = 8 },
                    new Cidade { CidadeId = 509, NomeCidade = "Colatina", EstadoId = 8 },
                    new Cidade { CidadeId = 510, NomeCidade = "Aracruz", EstadoId = 8 },
                    new Cidade { CidadeId = 511, NomeCidade = "Viana", EstadoId = 8 },
                    new Cidade { CidadeId = 512, NomeCidade = "Nova Venécia", EstadoId = 8 },
                    new Cidade { CidadeId = 513, NomeCidade = "Barra de São Francisco", EstadoId = 8 },
                    new Cidade { CidadeId = 514, NomeCidade = "Santa Maria de Jetibá", EstadoId = 8 },
                    new Cidade { CidadeId = 515, NomeCidade = "Domingos Martins", EstadoId = 8 },
                    new Cidade { CidadeId = 516, NomeCidade = "Alegre", EstadoId = 8 },
                    new Cidade { CidadeId = 517, NomeCidade = "Anchieta", EstadoId = 8 },
                    new Cidade { CidadeId = 518, NomeCidade = "Baixo Guandu", EstadoId = 8 },
                    new Cidade { CidadeId = 519, NomeCidade = "Castelo", EstadoId = 8 },
                    new Cidade { CidadeId = 520, NomeCidade = "Itapemirim", EstadoId = 8 }
                }
            },
            new Estado
            {
                EstadoId = 9,
                NomeEstado = "Goiás",
                Sigla = "GO",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 601, NomeCidade = "Goiânia", EstadoId = 9 },
                    new Cidade { CidadeId = 602, NomeCidade = "Aparecida de Goiânia", EstadoId = 9 },
                    new Cidade { CidadeId = 603, NomeCidade = "Anápolis", EstadoId = 9 },
                    new Cidade { CidadeId = 604, NomeCidade = "Rio Verde", EstadoId = 9 },
                    new Cidade { CidadeId = 605, NomeCidade = "Águas Lindas de Goiás", EstadoId = 9 },
                    new Cidade { CidadeId = 606, NomeCidade = "Luziânia", EstadoId = 9 },
                    new Cidade { CidadeId = 607, NomeCidade = "Valparaíso de Goiás", EstadoId = 9 },
                    new Cidade { CidadeId = 608, NomeCidade = "Senador Canedo", EstadoId = 9 },
                    new Cidade { CidadeId = 609, NomeCidade = "Trindade", EstadoId = 9 },
                    new Cidade { CidadeId = 610, NomeCidade = "Formosa", EstadoId = 9 },
                    new Cidade { CidadeId = 611, NomeCidade = "Catalão", EstadoId = 9 },
                    new Cidade { CidadeId = 612, NomeCidade = "Itumbiara", EstadoId = 9 },
                    new Cidade { CidadeId = 613, NomeCidade = "Planaltina", EstadoId = 9 },
                    new Cidade { CidadeId = 614, NomeCidade = "Jataí", EstadoId = 9 },
                    new Cidade { CidadeId = 615, NomeCidade = "Novo Gama", EstadoId = 9 },
                    new Cidade { CidadeId = 616, NomeCidade = "Caldas Novas", EstadoId = 9 },
                    new Cidade { CidadeId = 617, NomeCidade = "Goianésia", EstadoId = 9 },
                    new Cidade { CidadeId = 618, NomeCidade = "Inhumas", EstadoId = 9 },
                    new Cidade { CidadeId = 619, NomeCidade = "Morrinhos", EstadoId = 9 },
                    new Cidade { CidadeId = 620, NomeCidade = "Jaraguá", EstadoId = 9 }
                }
            },
            new Estado
            {
                EstadoId = 10,
                NomeEstado = "Maranhão",
                Sigla = "MA",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 701, NomeCidade = "São Luís", EstadoId = 10 },
                    new Cidade { CidadeId = 702, NomeCidade = "Imperatriz", EstadoId = 10 },
                    new Cidade { CidadeId = 703, NomeCidade = "São José de Ribamar", EstadoId = 10 },
                    new Cidade { CidadeId = 704, NomeCidade = "Timon", EstadoId = 10 },
                    new Cidade { CidadeId = 705, NomeCidade = "Caxias", EstadoId = 10 },
                    new Cidade { CidadeId = 706, NomeCidade = "Paço do Lumiar", EstadoId = 10 },
                    new Cidade { CidadeId = 707, NomeCidade = "Codó", EstadoId = 10 },
                    new Cidade { CidadeId = 708, NomeCidade = "Açailândia", EstadoId = 10 },
                    new Cidade { CidadeId = 709, NomeCidade = "Bacabal", EstadoId = 10 },
                    new Cidade { CidadeId = 710, NomeCidade = "Balsas", EstadoId = 10 },
                    new Cidade { CidadeId = 711, NomeCidade = "Barra do Corda", EstadoId = 10 },
                    new Cidade { CidadeId = 712, NomeCidade = "Pinheiro", EstadoId = 10 },
                    new Cidade { CidadeId = 713, NomeCidade = "Santa Inês", EstadoId = 10 },
                    new Cidade { CidadeId = 714, NomeCidade = "Chapadinha", EstadoId = 10 },
                    new Cidade { CidadeId = 715, NomeCidade = "Buriticupu", EstadoId = 10 },
                    new Cidade { CidadeId = 716, NomeCidade = "Grajaú", EstadoId = 10 },
                    new Cidade { CidadeId = 717, NomeCidade = "Itapecuru Mirim", EstadoId = 10 },
                    new Cidade { CidadeId = 718, NomeCidade = "Santa Luzia", EstadoId = 10 },
                    new Cidade { CidadeId = 719, NomeCidade = "Coroatá", EstadoId = 10 },
                    new Cidade { CidadeId = 720, NomeCidade = "Viana", EstadoId = 10 }
                }
            },

            new Estado
            {
                EstadoId = 11,
                NomeEstado = "Mato Grosso",
                Sigla = "MT",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 701, NomeCidade = "Cuiabá", EstadoId = 11 },
                    new Cidade { CidadeId = 702, NomeCidade = "Várzea Grande", EstadoId = 11 },
                    new Cidade { CidadeId = 703, NomeCidade = "Rondonópolis", EstadoId = 11 },
                    new Cidade { CidadeId = 704, NomeCidade = "Sinop", EstadoId = 11 },
                    new Cidade { CidadeId = 705, NomeCidade = "Sorriso", EstadoId = 11 },
                    new Cidade { CidadeId = 706, NomeCidade = "Tangará da Serra", EstadoId = 11 },
                    new Cidade { CidadeId = 707, NomeCidade = "Cáceres", EstadoId = 11 },
                    new Cidade { CidadeId = 708, NomeCidade = "Primavera do Leste", EstadoId = 11 },
                    new Cidade { CidadeId = 709, NomeCidade = "Lucas do Rio Verde", EstadoId = 11 },
                    new Cidade { CidadeId = 710, NomeCidade = "Barra do Garças", EstadoId = 11 },
                    new Cidade { CidadeId = 711, NomeCidade = "Alta Floresta", EstadoId = 11 },
                    new Cidade { CidadeId = 712, NomeCidade = "Nova Mutum", EstadoId = 11 },
                    new Cidade { CidadeId = 713, NomeCidade = "Pontes e Lacerda", EstadoId = 11 },
                    new Cidade { CidadeId = 714, NomeCidade = "Campo Novo do Parecis", EstadoId = 11 },
                    new Cidade { CidadeId = 715, NomeCidade = "Juína", EstadoId = 11 },
                    new Cidade { CidadeId = 716, NomeCidade = "Campo Verde", EstadoId = 11 },
                    new Cidade { CidadeId = 717, NomeCidade = "Confresa", EstadoId = 11 },
                    new Cidade { CidadeId = 718, NomeCidade = "Juara", EstadoId = 11 },
                    new Cidade { CidadeId = 719, NomeCidade = "Peixoto de Azevedo", EstadoId = 11 },
                    new Cidade { CidadeId = 720, NomeCidade = "Colíder", EstadoId = 11 }
                }
            },
            new Estado
            {
                EstadoId = 12,
                NomeEstado = "Mato Grosso do Sul",
                Sigla = "MS",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 801, NomeCidade = "Campo Grande", EstadoId = 12 },
                    new Cidade { CidadeId = 802, NomeCidade = "Dourados", EstadoId = 12 },
                    new Cidade { CidadeId = 803, NomeCidade = "Três Lagoas", EstadoId = 12 },
                    new Cidade { CidadeId = 804, NomeCidade = "Corumbá", EstadoId = 12 },
                    new Cidade { CidadeId = 805, NomeCidade = "Ponta Porã", EstadoId = 12 },
                    new Cidade { CidadeId = 806, NomeCidade = "Naviraí", EstadoId = 12 },
                    new Cidade { CidadeId = 807, NomeCidade = "Nova Andradina", EstadoId = 12 },
                    new Cidade { CidadeId = 808, NomeCidade = "Sidrolândia", EstadoId = 12 },
                    new Cidade { CidadeId = 809, NomeCidade = "Aquidauana", EstadoId = 12 },
                    new Cidade { CidadeId = 810, NomeCidade = "Maracaju", EstadoId = 12 },
                    new Cidade { CidadeId = 811, NomeCidade = "Paranaíba", EstadoId = 12 },
                    new Cidade { CidadeId = 812, NomeCidade = "Amambai", EstadoId = 12 },
                    new Cidade { CidadeId = 813, NomeCidade = "Rio Brilhante", EstadoId = 12 },
                    new Cidade { CidadeId = 814, NomeCidade = "Chapadão do Sul", EstadoId = 12 },
                    new Cidade { CidadeId = 815, NomeCidade = "Coxim", EstadoId = 12 },
                    new Cidade { CidadeId = 816, NomeCidade = "Caarapó", EstadoId = 12 },
                    new Cidade { CidadeId = 817, NomeCidade = "São Gabriel do Oeste", EstadoId = 12 },
                    new Cidade { CidadeId = 818, NomeCidade = "Ivinhema", EstadoId = 12 },
                    new Cidade { CidadeId = 819, NomeCidade = "Aparecida do Taboado", EstadoId = 12 },
                    new Cidade { CidadeId = 820, NomeCidade = "Bataguassu", EstadoId = 12 }
                }

            },
            new Estado
            {
                EstadoId = 13,
                NomeEstado = "Minas Gerais",
                Sigla = "MG",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 901, NomeCidade = "Belo Horizonte", EstadoId = 13 },
                    new Cidade { CidadeId = 902, NomeCidade = "Uberlândia", EstadoId = 13 },
                    new Cidade { CidadeId = 903, NomeCidade = "Contagem", EstadoId = 13 },
                    new Cidade { CidadeId = 904, NomeCidade = "Juiz de Fora", EstadoId = 13 },
                    new Cidade { CidadeId = 905, NomeCidade = "Montes Claros", EstadoId = 13 },
                    new Cidade { CidadeId = 906, NomeCidade = "Betim", EstadoId = 13 },
                    new Cidade { CidadeId = 907, NomeCidade = "Uberaba", EstadoId = 13 },
                    new Cidade { CidadeId = 908, NomeCidade = "Ribeirão das Neves", EstadoId = 13 },
                    new Cidade { CidadeId = 909, NomeCidade = "Governador Valadares", EstadoId = 13 },
                    new Cidade { CidadeId = 910, NomeCidade = "Divinópolis", EstadoId = 13 },
                    new Cidade { CidadeId = 911, NomeCidade = "Ipatinga", EstadoId = 13 },
                    new Cidade { CidadeId = 912, NomeCidade = "Sete Lagoas", EstadoId = 13 },
                    new Cidade { CidadeId = 913, NomeCidade = "Santa Luzia", EstadoId = 13 },
                    new Cidade { CidadeId = 914, NomeCidade = "Ibirité", EstadoId = 13 },
                    new Cidade { CidadeId = 915, NomeCidade = "Poços de Caldas", EstadoId = 13 },
                    new Cidade { CidadeId = 916, NomeCidade = "Patos de Minas", EstadoId = 13 },
                    new Cidade { CidadeId = 917, NomeCidade = "Pouso Alegre", EstadoId = 13 },
                    new Cidade { CidadeId = 918, NomeCidade = "Teófilo Otoni", EstadoId = 13 },
                    new Cidade { CidadeId = 919, NomeCidade = "Varginha", EstadoId = 13 },
                    new Cidade { CidadeId = 920, NomeCidade = "Conselheiro Lafaiete", EstadoId = 13 }
                }
            },
            new Estado
            {
                EstadoId = 14,
                NomeEstado = "Pará",
                Sigla = "PA",
                Cidades = new List<Cidade>
                {
                    new Cidade { CidadeId = 1001, NomeCidade = "Belém", EstadoId = 14 },
                    new Cidade { CidadeId = 1002, NomeCidade = "Ananindeua", EstadoId = 14 },
                    new Cidade { CidadeId = 1003, NomeCidade = "Santarém", EstadoId = 14 },
                    new Cidade { CidadeId = 1004, NomeCidade = "Parauapebas", EstadoId = 14 },
                    new Cidade { CidadeId = 1005, NomeCidade = "Marabá", EstadoId = 14 },
                    new Cidade { CidadeId = 1006, NomeCidade = "Castanhal", EstadoId = 14 },
                    new Cidade { CidadeId = 1007, NomeCidade = "Abaetetuba", EstadoId = 14 },
                    new Cidade { CidadeId = 1008, NomeCidade = "Cametá", EstadoId = 14 },
                    new Cidade { CidadeId = 1009, NomeCidade = "Barcarena", EstadoId = 14 },
                    new Cidade { CidadeId = 1010, NomeCidade = "Altamira", EstadoId = 14 },
                    new Cidade { CidadeId = 1011, NomeCidade = "Tucuruí", EstadoId = 14 },
                    new Cidade { CidadeId = 1012, NomeCidade = "Itaituba", EstadoId = 14 },
                    new Cidade { CidadeId = 1013, NomeCidade = "Bragança", EstadoId = 14 },
                    new Cidade { CidadeId = 1014, NomeCidade = "Paragominas", EstadoId = 14 },
                    new Cidade { CidadeId = 1015, NomeCidade = "Marituba", EstadoId = 14 },
                    new Cidade { CidadeId = 1016, NomeCidade = "Capanema", EstadoId = 14 },
                    new Cidade { CidadeId = 1017, NomeCidade = "Redenção", EstadoId = 14 },
                    new Cidade { CidadeId = 1018, NomeCidade = "Tailândia", EstadoId = 14 },
                    new Cidade { CidadeId = 1019, NomeCidade = "Moju", EstadoId = 14 },
                    new Cidade { CidadeId = 1020, NomeCidade = "Benevides", EstadoId = 14 }
                }
            }
                };

















        }
    }
}
