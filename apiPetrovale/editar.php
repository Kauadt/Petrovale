<?php

include_once('conexao.php');

$postjson = json_decode(file_get_contents("php://input"), true);

$query = $pdo->prepare("UPDATE clientes SET numero = :numero, rua = :rua, cidade = :cidade, bairro = :bairro, estado = :estado, senha = :senha, nome = :nome, cpf = :cpf, telefone = :telefone, email = :email WHERE id_cliente = :id_cliente");
$query->bindValue(":numero", $postjson['numAdd']);
$query->bindValue(":rua", $postjson['street']);
$query->bindValue(":cidade", $postjson['city']);
$query->bindValue(":bairro", $postjson['bairro']);
$query->bindValue(":estado", $postjson['state']);
$query->bindValue(":senha", $postjson['password']);
$query->bindValue(":nome", $postjson['name']);
$query->bindValue(":cpf", $postjson['cpf']);
$query->bindValue(":telefone", $postjson['telefone']);
$query->bindValue(":email", $postjson['email']);
$query->bindValue(":id_cliente", $postjson['id_cliente']);
$querySuccess = $query->execute();


if ($querySuccess) {
    $query2 = $pdo->prepare("UPDATE conta_bancaria SET debitoAutomatico = :debito_automatico, contaCorrente = :conta_corrente, agencia = :agencia, numeroBanco = :numero_banco WHERE id_contaBancaria = :id_contaBancaria");
    $query2->bindValue(":debito_automatico", $postjson['autoDebit']);
    $query2->bindValue(":conta_corrente", $postjson['currentAcc']);
    $query2->bindValue(":agencia", $postjson['agency']);
    $query2->bindValue(":numero_banco", $postjson['numBank']);
    $query2->bindValue(":id_contaBancaria", $postjson['bankAccId']);

    $query2Success = $query2->execute();

} else {
    $query2Success = false;
}

if ($querySuccess && $query2Success) {
    $result = json_encode(array('success' => true));
} else {
    $result = json_encode(array('success' => false));
}

echo $result;
?>


