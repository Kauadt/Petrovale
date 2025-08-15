<?php

include_once('conexao.php');

$postjson = json_decode(file_get_contents("php://input"), true);

if ($postjson === null) {
  error_log("Erro ao decodificar JSON.");
  echo json_encode(array('success' => false, 'error' => 'Erro ao decodificar JSON.'));
  exit();
}

try {
  $pdo->beginTransaction();
                       
  $queryVs = $pdo->prepare("INSERT INTO venda_servicos (data_vendaservicos, id_cliente, id_servico) VALUES (:data_vendaservicos, :id_cliente, :id_servico)");
  $queryVs->bindValue(":data_vendaservicos", $postjson['data']);
  $queryVs->bindValue(":id_cliente", $postjson['idCliente']);
  $queryVs->bindValue(":id_servico", $postjson['idServico']);
 
  $queryVs->execute();

  $lastId = $pdo->lastInsertId();


  $queryP = $pdo->prepare("INSERT INTO pagamentos (data_pagamento, forma_pagamento, status_pagamento, valor, id_vendaservico) VALUES (:data_pagamento, :forma_pagamento, :status_pagamento, :valor, :id_vendaservico)");
  $queryP->bindValue(":data_pagamento", $postjson['data']);
  $queryP->bindValue(":forma_pagamento", $postjson['formaPagamento']);
  $queryP->bindValue(":status_pagamento", $postjson['statusPagamento']);
  $queryP->bindValue(":valor", $postjson['valor']);
  $queryP->bindValue(":id_vendaservico", $lastId);

  $queryP->execute();

  $queryAl = $pdo->prepare("INSERT INTO agendamento_lavagem (horario, data_agendamento, placa, id_servico) VALUES (:horario, :data_agendamento, :placa, :id_servico)");
  $queryAl->bindValue(":horario", $postjson['horario']);
  $queryAl->bindValue(":data_agendamento", $postjson['data']);
  $queryAl->bindValue(":placa", $postjson['placa']);
  $queryAl->bindValue(":id_servico", $postjson['idServico']);

  $queryAl->execute();

  $pdo->commit();

  $result = json_encode(array('success' => true));
  echo $result;
} catch (PDOException $e) {
  $pdo->rollBack();

  error_log("Erro no PDO: " . $e->getMessage());
  $result = json_encode(array('success' => false, 'error' => $e->getMessage()));
  echo $result;
}

?>