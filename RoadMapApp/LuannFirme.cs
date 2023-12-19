using System.Text;

namespace RoadMapApp;

public class LuannFirme
{
    public static string Name => "Luann Firme";
    public static List<(string, int)> Skills => new List<(string, int)>{
            ("Fundamentos de C#", 5),
            ("Habilidades Gerais de Desenvolvimento",4),
            ("Fundamentos de Banco de Dados",4),
            ("Fundamentos de APS.NET Core",4),
            ("ORM",3),
            ("Injeção de Dependências",3),
            ("Bancos de Dados", 4),
            ("Fundamentos de Comunicação com API Clients", 3),
            ("Fundamentos de Comunicação em tempo real", 3),
            ("Fundamentos de Mapeamento de Objetos", 3),
            ("Testes", 2),
            ("Fundamentos de Micro-Serviços", 1),
            ("Conhecimento de Bibliotecas do lado do Cliente", 3),
            ("Habilidades em Modelos de interfaces ", 3),
            ("Bibliotecas boas de conhecer", 2),
         };
    public static string View()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Nome: {Name}");
        sb.AppendLine();
        sb.AppendLine("Habilidades:");
        foreach (var skill in Skills)
        {
            sb.AppendLine($"\t{skill.Item1} - {skill.Item2} estrelas");
        }
        var sum = Skills.Sum(x => x.Item2);
        sb.AppendLine();
        sb.AppendLine($"Total de estrelas: {sum}");
        return sb.ToString();
    }
}
