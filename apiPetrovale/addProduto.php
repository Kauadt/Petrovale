<?php

// include_once('conexao.php');

// $postjson = json_decode(file_get_contents("php://input"), true);


// $query = $pdo->prepare("INSERT INTO venda_produtos SET valor = :valor, data_vendaproduto = :data_vendaproduto, quantidade = :quantidade, id_posto = :id_posto, id_produto = :id_produto, id_cliente = :id_cliente ");

// $query->bindValue(":valor", $postjson['valor']);
// $query->bindValue(":data_vendaproduto", $postjson['data']);
// $query->bindValue(":quantidade", $postjson['quantidade']);
// $query->bindValue(":id_posto", $postjson['idPosto']);
// $query->bindValue(":id_produto", $postjson['idProduto']);
// $query->bindValue(":id_cliente", $postjson['idCliente']);

// $query->execute();

// if ($query) {
//   $result = json_encode(array('success' => true));

// } else {
//   $result = json_encode(array('success' => false));

// }

// echo $result;


?>


<?php

include_once('conexao.php');

$postjson = json_decode(file_get_contents("php://input"), true);

try {
    $query = $pdo->prepare("INSERT INTO venda_produtos SET valor = :valor, data_vendaproduto = :data_vendaproduto, quantidade = :quantidade, id_posto = :id_posto, id_produto = :id_produto, id_cliente = :id_cliente ");

    $query->bindValue(":valor", $postjson['valor']);
    $query->bindValue(":data_vendaproduto", $postjson['data']);
    $query->bindValue(":quantidade", $postjson['quantidade']);
    $query->bindValue(":id_posto", $postjson['idPosto']);
    $query->bindValue(":id_produto", $postjson['idProduto']);
    $query->bindValue(":id_cliente", $postjson['idCliente']);

    $query->execute();

    if ($query) {
        $result = json_encode(array('success' => true));
    } else {
        $result = json_encode(array('success' => false, 'error' => 'Erro ao executar a consulta.'));
    }

} catch (PDOException $e) {
    $result = json_encode(array('success' => false, 'error' => 'Erro no banco de dados: ' . $e->getMessage()));
}

echo $result;
?>
