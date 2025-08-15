<?php
include_once('conexao.php');

$postjson = json_decode(file_get_contents("php://input"), true);

$query = $pdo->query("SELECT * FROM clientes where email = '$postjson[email]' and senha = '$postjson[senha]'");

$dados = $query->fetchAll(PDO::FETCH_ASSOC);

if (count($dados) == 0) {
    $result = json_encode(array('success' => 'Dados Incorretos!'));
} else {
    $result = json_encode(array('success' => true, 'data' => $dados));
}

echo $result;
?>
