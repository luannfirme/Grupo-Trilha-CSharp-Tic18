### Residência em Tecnologia da Informação e Comunicação
#### INSTRUÇÃO PRÁTICA .NET-P004
##### MÓDULO .NB – Formação .Net – Básico - Trilha

**OBJETIVO DA ATIVIDADE TEMPO**
- Conhecer o SGBD MySql através do desenvolvimento de um Modelo Entidade Relacionamento e, posterior, implementação dele. Além disso, estimular o trabalho em equipe através do Git Flow recomendado.
- 4H

**DESCRIÇÃO**
- Atividade em Grupo

**Sobre o versionamento desta atividade:**
- Esta atividade deve ser feita no Repósitório/Branch referente ao projeto pessoal da equipe.
- Criem uma Branch “Database”.
- Sigam o Git Flow discutido em sala:
  1. Protejam a Branch no GitHub;
  2. Para cada tarefa a ser realizada, criem um Branch com a seguinte assinatura: `DOTNET-P004/idtarefa-descricao_breve_da_tarefa`
  3. O desenvolvedor responsável pela tarefa irá fazer todos os commits referentes (e exclusivamente) a essa tarefa nesse Branch.
  4. Após finalizar a implementação, o desenvolvedor irá fazer um novo Merge de Database (Origin) em seu Branch (Target) e realizar testes a fim de garantir que tudo ainda esteja funcionando.
  5. Em seguida, o desenvolvedor deve criar um Pull Request para o Branch Database, que deverá ser aprovado por alguém da equipe.

**Orientações:**
- Nessa tarefa sua equipe deve pensar quais entidades principais o `<Projeto Pessoal>` deve possuir inicialmente. Além disso, descrever essas entidades pelos seus atributos e relacionamentos. As Referências abaixo podem ajudar!

**Tarefas:**
- **Id_01:**
  - Criar um arquivo markdown `Readme.md` descrevendo, brevemente, as Entidades e os Relacionamentos iniciais do projeto.
- **Id_02:**
  - Montar o Diagrama Entidade Relacionamento desta etapa do projeto e salvar no seguinte diretório: `<raiz do projeto>/files/database/`. Fique à vontade para usar a ferramenta que gerar maior produtividade na sua equipe.
- **Id_03:**
  - Criar o script inicial para criação, se não existir, do Banco de Dados. Nomear o arquivo com `00_init_db.sql` e salvar no diretório citado acima.
- **Id_04.sql_"nome da entidade":**
  - Para cada entidade, implementar o script SQL responsável pela sua criação, sem adicionar chaves estrangeiras. Nomear os arquivos da seguinte forma `01_create_nome_entidade.sql`.
- **Id_05:**
  - Criar um script SQL para alterar as tabelas adicionando as chaves estrangeiras necessárias. Nomear o arquivo com `02_add_FK.sql`.
- **Id_06:**
  - Criar um script SQL para popular, inicialmente, a base de dados. Nomear o arquivo com `03_populate_db.sql`

**REFERÊNCIAS**
- [w3schools MySQL](https://www.w3schools.com/MySQL/default.asp)
- [GitHub - professorjosedeassis/mysql](https://github.com/professorjosedeassis/mysql/blob/master/README.md)
