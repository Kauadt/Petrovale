<?php

include_once('conexao.php');

$busca = isset($_GET['busca']) ? '%' . $_GET['busca'] . '%' : '';
$id_cliente = isset($_GET['id_cliente']) ? $_GET['id_cliente'] : '';
$list = isset($_GET['list']) ? $_GET['list'] : '';

switch ($list) {
    case 'homeScreen':
        $query = $pdo->query("SELECT * FROM produtos WHERE nome LIKE '$busca' LIMIT 4");
        break;
    case 'storeScreen':
        $query = $pdo->query("SELECT * FROM produtos WHERE nome LIKE '$busca'");
        break;
    case 'unity':
        $query = $pdo->query("SELECT * FROM postos WHERE nome LIKE '$busca'");
        break;
    case 'parking':
        $query = $pdo->query("SELECT * FROM vagas WHERE numero_vagas LIKE '$busca'");
        break;
    case 'fuel':
        $query = $pdo->query("SELECT * FROM servicos WHERE tipo = 'Combustivel' and nome LIKE '$busca'");
        break;
    case 'services':
        $query = $pdo->query("SELECT * FROM servicos WHERE tipo = 'Estacionamento' and nome LIKE '$busca'");
        break;
    case 'wash':
        $query = $pdo->query("SELECT * FROM servicos WHERE tipo = 'Lavagem' and nome LIKE '$busca'");
        break;
    default:
        $query = null;
        break;
}

$res = $query ? $query->fetchAll(PDO::FETCH_ASSOC) : [];
$dados = [];

switch ($list) {
    case 'homeScreen':
    case 'storeScreen':
        foreach ($res as $item) {
            $dados[] = array(
                'id_produto' => $item['id_produto'],
                'nome_produto' => $item['nome'],
                'descricao_produto' => $item['descricao'],
                'preco_produto' => $item['preco'],
                'desconto' => $item['desconto'],
                'foto' => $item['foto'],
            );
        }
        break;
    case 'unity':
        foreach ($res as $item) {
            $dados[] = array(
                'id_posto' => $item['id_posto'],
                'numero' => $item['numero'],
                'rua' => $item['rua'],
                'bairro' => $item['bairro'],
                'estado' => $item['estado'],
                'nome' => $item['nome'],
                'telefone' => $item['telefone'],
                'email' => $item['email'],
            );
        }
        break;
    case 'parking':
        foreach ($res as $item) {
            $dados[] = array(
                'idVacancy' => $item['id_vaga'],
                'numVacancy' => $item['numero_vagas'],
                'status' => $item['status_vagas'],
            );
        }
        break;
    case 'fuel':
    case 'services':
    case 'wash':
        foreach ($res as $item) {
            $dados[] = array(
                'idService' => $item['id_servico'],
                'price' => $item['preco'],
                'discount' => $item['desconto'],
                'nameService' => $item['nome'],
            );
        }
        break;
    default:
        $dados[] = array();
}

$result = count($res) > 0
    ? json_encode(array('success' => true, 'result' => $dados))
    : json_encode(array('success' => false, 'result' => '0'));

echo $result;
?>