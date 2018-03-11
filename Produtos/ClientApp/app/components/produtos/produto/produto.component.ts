import { Component, Inject, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Produto } from '../../../classes/produto.class';
import { ProdutoService } from '../../../services/produto.service';

@Component({
    selector: 'produto',
    templateUrl: './produto.component.html'
})
export class ProdutoComponent {

    public produto: Produto;
    public id: any;
    public carregando: boolean;
    public mensagem: any = null;
        
    constructor(private router: Router, private route: ActivatedRoute, private produtoService: ProdutoService) {
        this.route.params.subscribe(params => { this.id = params.id });//console.log(params) });
        

        if (this.id == 0) {
            this.produto = new Produto();
        } else {
            this.carregando = true;
            this.produtoService.getProduto(this.id).subscribe(data => {
                this.produto = data;
                this.carregando = false;
            });
        }
    }

    salvarProduto() {
        this.produtoService.postProduto(this.produto).subscribe(() => {
            this.voltarProdutos();
        });
    }

    voltarProdutos() {
        this.router.navigate(['produtos']);
    }
}
