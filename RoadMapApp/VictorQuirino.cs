using System.Text;

namespace RoadMapApp;
public static class VictorQuirino
{
    public static string Name => "Víctor Souza Moreira Quirino";
    public static List<(string, int)> Skills => new List<(string, int)>{
        ("Fundamentos de C#", 3),
        ("Habilidades Gerais de Desenvolvimento", 4),
        ("Fundamentos de Bancos de Dados", 4),
        ("ORM", 2),
        ("Injeção de Dependência", 2),
        ("Bancos de Dados", 3),
        ("Testes", 2),
        ("Fundamentos de Micro-Serviços", 1)
    };

    public static string View(){
        var sb = new StringBuilder();
        sb.AppendLine($"Nome: {Name}");
        sb.AppendLine();
        sb.AppendLine("Habilidades:");
            foreach (var skill in Skills){
                sb.AppendLine($"\t{skill.Item1} - {skill.Item2} estrelas.");
            }
            var sum = Skills.Sum(x => x.Item2);
            sb.AppendLine();
            sb.AppendLine($"Total de estrelas: {sum}");
            return sb.ToString();
    }
}
