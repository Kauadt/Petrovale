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


  $queryAe = $pdo->prepare("INSERT INTO agendamento_estacionamento (data_agendamento, tempo, placa, id_servico) VALUES (:data_agendamento, :tempo, :placa, :id_servico)");
  $queryAe->bindValue(":tempo", $postjson['tempo']);
  $queryAe->bindValue(":data_agendamento", $postjson['data']);
  $queryAe->bindValue(":placa", $postjson['placa']);
  $queryAe->bindValue(":id_servico", $postjson['idServico']);
  $queryAe->execute();


  $queryV = $pdo->prepare("UPDATE vagas SET status_vagas = 'Ocupado' WHERE id_vaga = :id_vaga");
  $queryV->bindValue(":id_vaga", $postjson['id_vaga']);
  $queryV->execute();

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