# ProjetoTopicosEspeciais
Projeto de Tópicos Especiais - Cadastro de atendimentos entre pacientes e profissionais.

## Entidades

1. Paciente
   - ID             | Int
   - Nome           | String
   - Endereco       | String 
   - Telefone       | String
   - (inserir campos do paciente)
2. Profissional
   - ID             | Int
   - Nome           | String
   - Telefone       | String
   - CRM            | Int
   - (inserir campos do profissional)
3. Atendimento
   - ID             | Int
   - Descricao      | String
   - Status         | Enum
   - PacienteId     | Int
   - ProfissionalId | Int
   - (inserir campos do atendimento)

## Operações

1. Paciente
- [ ] Cadastrar
- [ ] Editar
- [ ] Excluir
- [ ] Listar
2. Profissional
- [ ] Cadastrar
- [ ] Editar
- [ ] Excluir
- [ ] Listar
3. Atendimento
- [ ] Cadastrar
- [ ] Editar
- [ ] Excluir
- [ ] Listar
- [ ] Vincular Paciente
- [ ] Vincular Profissional
