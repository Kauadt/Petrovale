<?php
include_once('conexao.php');


$postjson = json_decode(file_get_contents("php://input"), true);

if (!isset($postjson['idCliente'])) {
    error_log("Chave 'idCliente' não está definida no JSON.");
    echo json_encode(array('success' => false, 'error' => 'Chave "idCliente" não está definida no JSON.'));
    exit();
}

$idCliente = $postjson['idCliente'];
try {
    $pdo->beginTransaction();

    $query1 = $pdo->query("SELECT * FROM pagamentos p 
    INNER JOIN venda_servicos vs 
    ON p.id_vendaServico = vs.id_vendaServicos 
    INNER JOIN clientes c 
    ON vs.id_cliente = c.id_cliente
    INNER JOIN servicos s
    ON vs.id_servico = s.id_servico
    WHERE status_pagamento = 'a definir'
    AND c.id_cliente = '$idCliente'");
    
    $res1 = $query1->fetchAll(PDO::FETCH_ASSOC);


    $query2 = $pdo->query("SELECT * FROM pagamentos p 
    INNER JOIN venda_produtos vp 
    ON p.id_vendaProduto = vp.id_vendaProduto 
    INNER JOIN clientes c 
    ON vp.id_cliente = c.id_cliente 
    INNER JOIN produtos prod
    ON vp.id_produto = prod.id_produto
    WHERE status_pagamento = 'a definir' 
    AND c.id_cliente = '$idCliente'");

    $res2 = $query2->fetchAll(PDO::FETCH_ASSOC);

    $pdo->commit();

    $result = json_encode(array('success' => true, 'res1' => $res1, 'res2' => $res2));
    echo $result;
} catch (PDOException $e) {
    $pdo->rollBack();

    error_log("Erro no PDO: " . $e->getMessage());
    $result = json_encode(array('success' => false, 'error' => $e->getMessage()));
    echo $result;
}
?>


<?php
// include_once('conexao.php');

// $postjson = json_decode(file_get_contents("php://input"), true);

// if (!isset($postjson['idCliente'])) {
//     error_log("Chave 'idCliente' não está definida no JSON.");
//     echo json_encode(array('success' => false, 'error' => 'Chave "idCliente" não está definida no JSON.'));
//     exit();
// }

// $idCliente = $postjson['idCliente'];
// try {
//     $pdo->beginTransaction();

//     $query1 = $pdo->query("SELECT * FROM pagamentos p 
//     INNER JOIN venda_servicos vs ON p.id_vendaServico = vs.id_vendaServicos 
//     INNER JOIN clientes c ON vs.id_cliente = c.id_cliente 
//     WHERE status_pagamento = 'a definir' AND c.id_cliente = '$idCliente'");

//     $res1 = $query1->fetchAll(PDO::FETCH_ASSOC);

//     $query2 = $pdo->query("SELECT * FROM pagamentos p 
//     INNER JOIN venda_servicos vs 
//     ON p.id_vendaServico = vs.id_vendaServicos 
//     INNER JOIN clientes c 
//     ON vs.id_cliente = c.id_cliente
//     INNER JOIN servicos s
//     ON vs.id_servico = s.id_servico
//     WHERE status_pagamento = 'a definir'
//     AND c.id_cliente = '$idCliente'");

//     $res2 = $query2->fetchAll(PDO::FETCH_ASSOC);

//     $ArrayUnion = array_merge($res1, $res2);

//     $pdo->commit();

//     $result = json_encode(array('success' => true, 'ArrayUnion' => $ArrayUnion));
//     echo $result;
// } catch (PDOException $e) {
//     $pdo->rollBack();

//     error_log("Erro no PDO: " . $e->getMessage());
//     $result = json_encode(array('success' => false, 'error' => $e->getMessage()));
//     echo $result;
// }
?>
