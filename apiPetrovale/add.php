<?php

include_once('conexao.php');

$rawPost = file_get_contents("php://input");
error_log("Raw POST: " . $rawPost);

$postjson = json_decode($rawPost, true);

if ($postjson === null) {
  error_log("Erro ao decodificar JSON.");
  echo json_encode(array('success' => false, 'error' => 'Erro ao decodificar JSON.'));
  exit();
}

$query_buscar = $pdo->query("SELECT * from clientes where email = '$postjson[email]'");
$dados_buscar = $query_buscar->fetchAll(PDO::FETCH_ASSOC);

if (@count($dados_buscar) > 0) {
  $result = json_encode(array('success' => 'Email já Cadastrado!'));
  echo $result;
  exit();
} else {
  try {
    $pdo->beginTransaction();

    $queryCb = $pdo->prepare("INSERT INTO conta_bancaria (debitoAutomatico, contaCorrente, agencia, numeroBanco) VALUES (:debito_automatico, :conta_corrente, :agencia, :numero_banco)");
    $queryCb->bindValue(":debito_automatico", $postjson['autoDebitStatus']);
    $queryCb->bindValue(":conta_corrente", $postjson['currentAcc']);
    $queryCb->bindValue(":agencia", $postjson['agency']);
    $queryCb->bindValue(":numero_banco", $postjson['numBank']);
    $queryCb->execute();

    $lastId = $pdo->lastInsertId();

    $queryC = $pdo->prepare("INSERT INTO clientes (nome, email, senha, cpf, telefone, id_contaBancaria, numero, rua, cidade, bairro, estado) VALUES (:nome, :email, :senha, :cpf, :telefone , :id_contaBancaria, :numero, :rua, :cidade, :bairro, :estado)");
    $queryC->bindValue(":nome", $postjson['nome']);
    $queryC->bindValue(":email", $postjson['email']);
    $queryC->bindValue(":senha", $postjson['senha']);
    $queryC->bindValue(":cpf", $postjson['cpf']);
    $queryC->bindValue(":id_contaBancaria", $lastId);
    $queryC->bindValue(":telefone", $postjson['telefone']);
    $queryC->bindValue(":numero", $postjson['numAdd']);
    $queryC->bindValue(":rua", $postjson['street']);
    $queryC->bindValue(":bairro", $postjson['bairro']);
    $queryC->bindValue(":cidade", $postjson['city']);
    $queryC->bindValue(":estado", $postjson['state']);
    $queryC->execute();

    $pdo->commit();

    $result = json_encode(array('success' => true));
    echo $result;
  } catch (PDOException $e) {
    $pdo->rollBack();

    error_log("Erro no PDO: " . $e->getMessage());
    $result = json_encode(array('success' => false, 'error' => $e->getMessage()));
    echo $result;
  }
}

?>