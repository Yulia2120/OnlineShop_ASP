
using BLogic.Domain;

namespace DAL
{
    public class SeedData
    {
        public static void SeedDatabase(Context context)
        {
           // context.Database.EnsureCreated();
            if (context.Products.Count() == 0 && context.ProductCategories.Count() == 0 && context.AnimalCategories.Count() == 0 && context.Companies.Count() == 0)
            {

                AnimalCategory Dogs = new AnimalCategory  { AnimalName = "Собаки" };
                AnimalCategory Cats = new AnimalCategory { AnimalName = "Коти" };
                AnimalCategory Birdy = new AnimalCategory { AnimalName = "Птахи" };
                AnimalCategory Rodents = new AnimalCategory { AnimalName = "Гризуни" };
                ProductCategory Dogfood = new ProductCategory { CategoryName = "Корм для собак", AnimalCategory = Dogs };
                ProductCategory Catfood = new ProductCategory { CategoryName = "Корм для котів", AnimalCategory = Cats };
                ProductCategory Birdfood = new ProductCategory { CategoryName = "Корм для птахів", AnimalCategory = Birdy };
                ProductCategory Rodentfood = new ProductCategory { CategoryName = "Корм для гризунів", AnimalCategory = Rodents };
                Company company1 = new Company { CompanyName = "Savory", Contact = "Чехія" };
                Company company2 = new Company { CompanyName = "Brit", Contact = "Чехія" };
                Company company3 = new Company { CompanyName = "Vitakraft", Contact = "Німеччина" };

                context.Products.AddRange(
                                 new Product
                                 {
                                     ProductName = "Вологий корм для дорослих собак Savory 400 г (м'ясне асорті)",
                                     ImgUrl = "https://i.ibb.co/wW17xF3/sobak-savory-400-g.webp",
                                     Price = 119.00M,
                                     ProductDescription = "Повнораціонний вологий корм з чотирма видами м'яса для дорослих собак всіх порід.",
                                     ProductCategory = Dogfood,
                                     Company = company1
                                 },

                                 new Product 
                                 {
                                     ProductName = "Вологий корм для цуценят Savory 400 г (курка)",
                                     ImgUrl = "https://i.ibb.co/xSSRYFL/korm-shenkov-savory-400-g-kurica.webp",
                                     Price = 119.00M,
                                     ProductDescription = "Корм ​​для цуценят Savory пробудить у вашого улюбленця ту життєву енергію, про яку він навіть сам не знав.",
                                     ProductCategory = Dogfood,
                                     Company = company1

                                 },
                                 new Product
                                 {
                                       ProductName = "Сухий корм для дорослих собак великих порід (вагою від 25 до 45 кг) Brit Premium Adult L 3 кг (курка)",
                                       ImgUrl = "https://i.ibb.co/k6SCXfM/3.webp",
                                       Price = 352.00M,
                                       ProductDescription = "Здорова шкіра і блискуча шерсть.Лососева олія - натуральне джерело Омега - 3 жирних кислот, сприяє блиску і здоров’ю шерсті.",
                                       ProductCategory = Dogfood,
                                       Company = company2
                                 },
                                 new Product
                                   {
                                       ProductName = "Сухий корм для цуценят та молодих собак великих порід  Brit Premium Junior L 15 кг (курка)",
                                       ImgUrl = "https://i.ibb.co/Nngnsnw/4.webp",
                                       Price = 1412.80M,
                                       ProductDescription = "Повноцінний корм з куркою для цуценят і молодих собак (1-24 місяців) великих порід (25-45 кг). З високим вмістом курки.",
                                       ProductCategory = Dogfood,
                                       Company = company2

                                 },
                                 new Product
                                 {
                                     ProductName = "Сухий корм для кошенят Brit Care Cat GF Kitten HGrowth & Development 2 кг (курка і індичка)",
                                     ImgUrl = "https://i.ibb.co/M2dppn2/1.webp",
                                     Price = 503.20M,
                                     ProductDescription = "Гіпоалергенна рецептура зі свіжою куркою й індичкою для кошенят (1–12 місяців), а також вагітних або годуючих котів.",
                                     ProductCategory= Catfood,
                                     Company = company2

                                 },
                                  new Product
                                  {
                                      ProductName = "Сухий корм для вибагливих котів Brit Care Cat GF Sensitive HDigestion & Delicate Taste 2 кг (індичка і лосось)",
                                      ImgUrl = "https://i.ibb.co/0Bk5VPx/2.webp",
                                      Price = 553.60M,
                                      ProductDescription = "Гіпоалергенна формула зі свіжою індичкою та лососем для дорослих котів від 12 місяців.",
                                      ProductCategory = Catfood,
                                      Company = company2

                                  },
                                   new Product
                                   {
                                       ProductName = "Вологий корм для стерилізованих котів Savory 400 г (ягня)",
                                       ImgUrl = "https://i.ibb.co/54zdkxn/3.webp",
                                       Price = 119.00M,
                                       ProductDescription = "Повнораціонний вологий корм з ягням для стерилізованих кішок.",
                                       ProductCategory = Catfood,
                                       Company = company1

                                   },
                                    new Product
                                    {
                                        ProductName = "Вологий корм для стерилізованих котів Savory 400 г (курка)",
                                        ImgUrl = "https://i.ibb.co/KjMpVH8/4.webp",
                                        Price = 119.00M,
                                        ProductDescription = "Повнораціонний вологий корм з куркою для стерилізованих кішок.",
                                        ProductCategory = Catfood,
                                        Company = company1

                                    },
                                      new Product
                                      {
                                          ProductName = "Корм для середніх австралійських папуг Vitakraft «Australian» 750 г",
                                          ImgUrl = "https://i.ibb.co/jTYsvQj/1.webp",
                                          Price = 333.00M,
                                          ProductDescription = "Склад корму відповідає раціону птаха у природному середовищі.",
                                          ProductCategory = Birdfood,
                                          Company = company3

                                      },
                                        new Product
                                        {
                                            ProductName = "Корм для великих амазонських папуг Vitakraft «Amazonian» 750 г",
                                            ImgUrl = "https://i.ibb.co/0QH7H9Z/2.webp",
                                            Price = 335.00M,
                                            ProductDescription = "Склад корму відповідає раціону птаха в природному середовищі існування.",
                                            ProductCategory = Birdfood,
                                            Company = company3

                                        },
                                          new Product
                                          {
                                              ProductName = "Корм для великих африканських папуг Vitakraft «African» 750 г",
                                              ImgUrl = "https://i.ibb.co/KGC8LgV/3.webp",
                                              Price = 309.00M,
                                              ProductDescription = "Склад корму відповідає раціону птаха у природному середовищі.",
                                              ProductCategory = Birdfood,
                                              Company = company3

                                          },
                                            new Product
                                            {
                                                ProductName = "Корм для канарок Vitakraft «Premium Menu» 500 г",
                                                ImgUrl = "https://i.ibb.co/j5bvmM7/4.webp",
                                                Price = 157.00M,
                                                ProductDescription = "Vitakraft Menu для канарок - збалансована основа харчування, яка містить усі важливі поживні речовини і мінеральні елементи для оптимальної кондиції вашого птаха.",
                                                ProductCategory = Birdfood,
                                                Company = company3

                                            },
                                            new Product
                                            {
                                                ProductName = "Корм для кроликів Vitakraft «Premium Menu Vital» 1 кг + 20 %",
                                                ImgUrl = "https://i.ibb.co/qDJsc9y/1.webp",
                                                Price = 185.00M,
                                                ProductDescription = "Меню Vital для дорослих кроликів є збалансованим раціоном, в складі якого Ваш вихованець знайдете все необхідне для свого здорового і тривалого життя.",
                                                ProductCategory = Rodentfood,
                                                Company = company3

                                            },
                                            new Product
                                            {
                                                ProductName = "Корм для морських свинок Vitakraft «Premium Menu Vital» 1 кг + 20 %",
                                                ImgUrl = "https://i.ibb.co/SsMzG5z/2.webp",
                                                Price = 215.00M,
                                                ProductDescription = "Меню Vital для морських свинок є збалансованим раціоном, в складі якого Ваш вихованець знайдете все необхідне для свого здорового і тривалого життя.",
                                                ProductCategory = Rodentfood,
                                                Company = company3

                                            },
                                            new Product
                                            {
                                                ProductName = "Корм для шиншил Vitakraft «VITA Special» 600 г",
                                                ImgUrl = "https://i.ibb.co/f2SknFB/3.webp",
                                                Price = 250.00M,
                                                ProductDescription = "Повнораціонний корм для шиншил різного віку. Меню у вигляді гранул ідеально підходить для вибагливих тварин",
                                                ProductCategory = Rodentfood,
                                                Company = company3

                                            },
                                            new Product
                                            {
                                                ProductName = "Корм для пацюків Vitakraft «Premium Menu Vital» 800 г",
                                                ImgUrl = "https://i.ibb.co/wsTJG15/4.webp",
                                                Price = 269.00M,
                                                ProductDescription = "Меню Vital - це збалансований раціон з цінним зерном, смачними фруктами та хрусткими горіхами для здорового всебічного харчування пацюків.",
                                                ProductCategory = Rodentfood,
                                                Company = company3

                                            }



                                 );


               // context.SaveChanges();


              




            }
        }


    }
}
////создать компанию
//var context = new U.UnitOfWork(connection);
//context.CompanyRepository.Save(company);
//context.Commit();