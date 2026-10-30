# Sistema de Gerenciamento de Biblioteca
> Uma solução acessível e intuitiva para o controle e acesso a dados de livros e usuários.

---

## Colaboradores
- **[@daniellegorte](https://github.com/daniellegorte)**
- **Roberta Maria Lansana**

---

## Tecnologias Utilizadas

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL_Workbench-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![XAMPP](https://img.shields.io/badge/XAMPP-FB7A24?style=for-the-badge&logo=xampp&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

---

## Requisitos e Configuração do Ambiente

### Instalação e Configuração do XAMPP e MySQL Workbench

1. Abra o **XAMPP Control Panel** e inicie o módulo **"MySQL"**.
2. No **MySQL Workbench**, acesse o servidor local em **MySQL Connections** (ou crie uma nova conexão com os dados abaixo):
   - **Connection Name:** `nomeDesejado`
   - **Hostname:** `127.0.0.1`
   - **Port:** *(porta indicada pelo XAMPP)*
   - **Username:** `root`
3. Crie um Banco de Dados nomeado **`biblioteca`**.
4. Execute o script SQL para criação da estrutura e povoamento do Banco de Dados.

---

### 2Conectando o Sistema ao Banco de Dados

1. Abra o projeto **"P1 - Gerenciamento de Biblioteca"** no **Visual Studio**.
2. No Gerenciador de Soluções, clique com o botão direito em **"Referências"** e selecione **"Manage NuGet Packages" (Gerenciar Pacotes do NuGet)**.
3. Na aba **Browse (Navegar)**, pesquise por **`MySql.Data`**, selecione o pacote oficial da Oracle e clique em **Install**.
4. Navegue até a classe `Conexao.cs` e localize o construtor `public Conexao()`:

```csharp
String dataSource = "datasource=localhost; username = root; password = '';" + "database='biblioteca';AllowZeroDateTime=true;";
```

> **Ajustes na String de Conexão:**
> - **`password`:** Deixe em branco (`""`) se o XAMPP estiver com a senha padrão.
> - **`database`:** Caso tenha alterado, substitua `'biblioteca'` pelo nome exato do banco de dados criado.

> ⚠️ **Atenção:** Para que a conexão seja estabelecida com sucesso, o módulo **MySQL** deve permanecer iniciado e ativo no **XAMPP Control Panel** (status destacado em verde).
