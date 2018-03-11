import { Component } from '@angular/core';
import { Routes, RouterModule, Router, ActivatedRoute } from "@angular/router";
import { Produto } from '../../classes/produto.class';
import { ProdutoService } from '../../services/produto.service';

@Component({
    selector: 'produtos',
    templateUrl: './produtos.component.html'
})
export class ProdutosComponent {
    public produtos: Produto[] = [];
    public carregando: boolean = false;

    constructor(private router: Router, private produtoService: ProdutoService) {
        this.todosProdutos();
    }

    todosProdutos() {
        this.carregando = true;
        this.produtoService.getProdutos().subscribe(data => {
            this.produtos = data;
            this.carregando = false;
        });
    }

    editarProduto(id: number) {
        this.router.navigate(['produtos', id]);
    }

    deletarProduto(id: number) {
        this.produtoService.deleteProduto(id).subscribe(() => {
            this.todosProdutos();
        });
    }

    novoProduto() {
        this.router.navigate(['produtos', 0]);
    }
}
