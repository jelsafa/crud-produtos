import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { Produto } from '../classes/produto.class';

@Injectable()
export class ProdutoService {
    public baseUrl: any;

    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl + 'api/produto/'; 
    }
   
    getProduto(id: number) {        
        return this.http.get(this.baseUrl + id)        
            .map(res => res.json());       
    }

    getProdutos() {
        return this.http.get(this.baseUrl)
            .map(res => res.json());
    }

    postProduto(produto: Produto) {
        return this.http.post(this.baseUrl, produto)
            .map(res => res.json());
    }

    deleteProduto(id: number) {
        return this.http.delete(this.baseUrl + id)
            .map(res => res.json());
    }
    
}