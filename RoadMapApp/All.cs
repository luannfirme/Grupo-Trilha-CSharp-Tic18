using System.Text;
using RoadMapApp;

namespace RoadMapApp;

public static class All
{
      private static readonly List<List<(string, int)>> UserSkills = new List<List<(string, int)>>
      {
            AnaCaroline.Skills,
            Caio.Skills,
            LuannFirme.Skills,
            PauloRicardo.Skills,
            VictorQuirino.Skills,
      };

      public static List<(string, int)> GetGroupSkills()
      {
            return UserSkills.SelectMany(userSkills => userSkills)
                              .GroupBy(skill => skill.Item1)
                              .Select(groupedSkills => (groupedSkills.Key, groupedSkills
                              .Sum(skill => skill.Item2)))
                              .ToList();
      }

      public static int GetTotalStars()
      {
            return UserSkills.SelectMany(userSkills => userSkills)
                              .Sum(skill => skill.Item2);
      }

      public static string View()
      {
            var sb = new StringBuilder();
            sb.AppendLine("Resumo de habilidades da equipe:");
            sb.AppendLine();
            sb.AppendLine("Habilidades:");
            foreach (var skill in GetGroupSkills())
            {
                  sb.AppendLine($"\t{skill.Item1} - {skill.Item2} estrelas");
            }
            sb.AppendLine();
            sb.AppendLine($"Total de estrelas: {GetTotalStars()}");
            return sb.ToString();
      }
}