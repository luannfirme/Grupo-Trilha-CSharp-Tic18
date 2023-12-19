using System.Text;

namespace RoadMapApp
{
    public class Caio
    {
        public static string Name => "Caio Gonçalves";
        public static List<(string, int)> Skills => new List<(string, int)>{
            ("Fundamentos de C#", 5),
            ("Habilidades Gerais de Desenvolvimento",5),
            ("Fundamentos de Banco de Dados",5),
            ("Fundamentos de APS.NET Core",2),
            ("ORM",4),
            ("Injeção de Dependências",4),
            ("Bancos de Dados", 5),
            ("Fundamentos de Comunicação com API Clients", 5),
            ("Fundamentos de Comunicação em tempo real", 4),
            ("Fundamentos de Mapeamento de Objetos", 3),
            ("Fundamentos de Micro-Serviços", 1),
            ("Conhecimento de Bibliotecas do lado do Cliente", 4),
            ("Habilidades em Modelos de interfaces ", 2),
            ("Bibliotecas boas de conhecer", 3),
        };

        public static string View()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine();
            sb.AppendLine("Habilidades");
            foreach (var skill in Skills)
            {
                sb.AppendLine($"\t{skill.Item1} - {skill.Item2} estrelas.");
            }
            var sum = Skills.Sum(x => x.Item2);
            sb.AppendLine();
            sb.AppendLine($"Total de estrelas: {sum}");
            return sb.ToString();
        }
    }
}