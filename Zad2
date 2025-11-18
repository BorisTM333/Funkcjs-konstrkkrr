function Product(name, price, category) {
    this.name = name;
    this.price = price;
    this.category = category;
    this.inStock = true;

    this.displayInfo = function() {
        console.log(this.category + " - " + this.name + " " + this.price + " zł");
    };

    this.applyDiscount = function(percent) {
        console.log("Zastosowano "+percent+"% rabatu " + "na " +this.name);

        this.price = this.price - (this.price * percent / 100);
    };
}

const product1 = new Product("Laptop", 3500, "Elektronika");
const product2 = new Product("Buty sportowe", 250, "Obuwie");
const product3 = new Product("Kawa mielona", 30, "Spożywcze");

product1.displayInfo();
product2.displayInfo();
product3.displayInfo();

product1.applyDiscount(10);

product1.displayInfo();
