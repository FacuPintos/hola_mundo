namespace Program{

public class Producto {

    string nombre;
    int precio;
    List<Review> Reviews = new List<Review>() ;

public Producto(string nom, int pre){

    this.nombre = nom;
    this.precio = pre;

}
    public void AgregarReview(Review review){

        this.Reviews.Add(review);

        



    }

}

}