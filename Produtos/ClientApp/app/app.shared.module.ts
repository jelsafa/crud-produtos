import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './components/app/app.component';
import { ProdutoComponent } from './components/produtos/produto/produto.component';
import { ProdutosComponent } from './components/produtos/produtos.component';

import { ProdutoService } from './services/produto.service';

@NgModule({
    declarations: [
        AppComponent,
        ProdutoComponent,
        ProdutosComponent
    ],
    providers: [
        ProdutoService
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'produtos', pathMatch: 'full' },
            { path: 'produtos', component: ProdutosComponent },
            { path: 'produtos/:id', component: ProdutoComponent },
            { path: '**', redirectTo: 'produtos' }
        ])
    ]
})
export class AppModuleShared {
}
