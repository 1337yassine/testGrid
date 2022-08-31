using Microsoft.AspNetCore.Http.Metadata;

namespace testGrid.Data
{
    public class ProjectServiceForm
    {
        private static readonly string[] Label = new[]
        {
            "ECARE", "BANCO", "DECLIC", "EMC", "TPMS", "TPMC", "PRECO", "REFCO", "PAGE", "PMI"
        };


        private static readonly string[] Perimeter = new[]
        {
            "FINANCE", "CLIENTELE", "CCM"
        };

        private static readonly string[] responsible = new[]
        {
            "Jerome", "Anas", "Imane" , "Axel" , "Dominique"
        };

        private static readonly List<string> Emails = new()
        {
            "Jerome@suez.com", "Anas@suez.com", "Imane@suez.com" , "Axel@suez.com" , "Dominique@suez.com"
        };

        public Task<List<Project>> GetProjectsAsync(int i)
        {
            
            return Task.FromResult(Enumerable.Range(1, 30).Select(index => new Project
            {
                
                Id = index + 1,
                Label = Label[Random.Shared.Next(Label.Length)],
                Perimeter = Perimeter[Random.Shared.Next(Perimeter.Length)],
                Responsible = responsible[Random.Shared.Next(responsible.Length)],
                Email = Emails


            }).ToList());
        }

    }
    }

