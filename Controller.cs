CAMPO TABELA CLIENTE:

public string nome, endereco, cidade, estado, cep, telefone;
public string codigoID;

Obs: Não esquecer do namespace  using System.Data.OleDb;


private void Form3_Load(object sender, EventArgs e)

{

txtCodigo.Text = codigoID;

txtNome.Text = nome;

txtEndereco.Text = endereco;

txtCidade.Text = cidade;

txtEstado.Text = estado;

txtCep.Text = cep;

txtTelefone.Text = telefone;

}

  Agora Click no Botão e coloca o novo codígo:

private void btnAlterar_Click(object sender, EventArgs e)

{

if (validaDados())

    AlterarDados();

else

    MessageBox.Show("Dados Inv lidos...");

    txtNome.Focus();

return;

}


Validação dos Dados:

private Boolean validaDados()

{

   if (txtNome.Text == string.Empty)

      return false;
 

   if (txtEndereco.Text == string.Empty)

      return false;

 

    if (txtCidade.Text == string.Empty)

      return false;

 

    if (txtEstado.Text == string.Empty)

      return false;

 

    if (txtCep.Text == string.Empty)

       return false;

 

    return true;

}

Antes desse comando abaixo, coloque sua conexão com seu banco de dados que esteja trabalhando.

"UPDATE Clientes SET nome ='" + txtNome.Text.Replace("'", "''") + "', endereco='" + txtEndereco.Text + "', _
cidade='" + txtCidade.Text + "', estado='" + txtEstado.Text + "', cep='" + txtCep.Text + "', telefone='" + _
txtTelefone.Text + "' WHERE codigo=" + int.Parse(codigoID) + "";

