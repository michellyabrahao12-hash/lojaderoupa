using lojaderoupa.Models;

namespace lojaderoupa.Data;




public class Roupasrepositorios
{
    
// private  static List<Roupasrepositorios> roupa = new List<Roupasrepositorios>();


private static Produto produto= new Produto { modelo ="calça", tamanho="30",preco=20.00,};
public Produto listaDeProduto (){ 
        
       return produto;
    }
}




