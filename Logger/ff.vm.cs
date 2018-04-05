 public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<AnnualInvoice> invoices = new List<AnnualInvoice>
            {
                new AnnualInvoice{ Year = 2010,
                    FirstInvoice = new Invoice{Name="oneFirst", Months = 3},
                    SecondInvoice = new Invoice{Name="oneSecond", Months = 4},
                    ThirdInvoice = new Invoice{Name="oneThird", Months = 2},
                    FourthInvoice = new Invoice{Name="oneFourth", Months = 3} },

                new AnnualInvoice{ Year = 2012,
                    FirstInvoice = new Invoice{Name="twoFirst", Months = 2},
                    SecondInvoice = new Invoice{Name="twoSecond", Months = 3},
                    ThirdInvoice = new Invoice{Name="twoThird", Months = 6},
                    FourthInvoice = new Invoice{Name="twoFourth", Months = 1} },

                new AnnualInvoice { Year = 2015,
                    FirstInvoice = new Invoice{Name="threeFirst", Months = 5},
                    SecondInvoice = new Invoice{Name="threeSecond", Months = 3},
                    ThirdInvoice = new Invoice{Name="threeThird", Months = 2},
                    FourthInvoice = new Invoice{Name="threeFourth", Months = 2} }
            };

            icTodoList.ItemsSource = invoices;
        }


        public class Invoice
        {
            public string Name { get; set; }

            public int Months { get; set; }
        }

        public class AnnualInvoice
        {
            // 3 = quarterly,  6 = semi-annually, 12 = annually -- for simplicity
            public int Year { get; set; }

            public Invoice FirstInvoice { get; set; }
            public Invoice SecondInvoice { get; set; }
            public Invoice ThirdInvoice { get; set; }
            public Invoice FourthInvoice { get; set; }
        }
    }
