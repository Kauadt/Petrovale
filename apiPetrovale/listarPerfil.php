<?php

include_once('conexao.php');

$busca = '%' . $_GET['busca'] . '%';
$idCliente = $_GET['idCliente'];

$query = $pdo->query("SELECT * FROM clientes c INNER JOIN conta_bancaria cb ON c.id_contaBancaria = cb.id_contaBancaria WHERE c.id_cliente = '$idCliente' AND nome LIKE '$busca'");

$res = $query->fetchAll(PDO::FETCH_ASSOC);

for ($i = 0; $i < count($res); $i++) {
    foreach ($res[$i] as $key => $value) {
    }
    $dados[] = array(
        'id' => $res[$i]['id_cliente'],
        'name' => $res[$i]['nome'],
        'num' => $res[$i]['numero'],
        'street' => $res[$i]['rua'],
        'city' => $res[$i]['rua'],
        'bairro' => $res[$i]['bairro'],
        'state' => $res[$i]['estado'],
        'password' => $res[$i]['senha'],
        'cpf' => $res[$i]['cpf'],
        'telefone' => $res[$i]['telefone'],
        'email' => $res[$i]['email'],
        'autoDebit' => $res[$i]['debitoAutomatico'],
        'currentAcc' => $res[$i]['contaCorrente'],
        'agency' => $res[$i]['agencia'],
        'numBank' => $res[$i]['numeroBanco'],
        'bankAccId' => $res[$i]['id_contaBancaria'],
    );

}

if (count($res) > 0) {
    $result = json_encode(array('success' => true, 'result' => $dados));

} else {
    $result = json_encode(array('success' => false, 'result' => '0'));

}
echo $result;

?>