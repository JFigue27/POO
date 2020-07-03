console.log('Account');

// function Account(name, document) {
//   this.id;
//   this.name = name;
//   this.document = document;
//   this.email;
//   this.password;
// }

class Account {
  constructor(name, document) {
    this.id;
    this.name = name;
    this.document = document;
    this.email;
    this.password;
  }
  printAccount() {
    console.log(this.name);
    console.log(this.document);
  }
}
