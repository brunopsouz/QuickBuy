import { Component } from "@angular/core"

@Component({
  selector: "produto",
  template:"<html><body>{{ obterNome() }}</body></html>"
})

export class ProdutoComponent {
  //public id: number;
  public nome: string;
  //public preco: number;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return this.nome;
  }

}
