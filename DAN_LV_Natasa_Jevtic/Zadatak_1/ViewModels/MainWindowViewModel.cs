using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Zadatak_1.Commands;
using Zadatak_1.Models;

namespace Zadatak_1.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        MainWindow mainWindow;
        Pizza pizzaModel = new Pizza();
        PizzaSizes sizes = new PizzaSizes();
        PizzaIngredients ingredients = new PizzaIngredients();

        private vwPizza pizza;

        public vwPizza Pizza
        {
            get
            {
                return pizza;
            }
            set
            {
                pizza = value;
                OnPropertyChanged("Pizza");
            }
        }

        private List<string> pizzaSizesList;

        public List<string> PizzaSizesList
        {
            get
            {
                return pizzaSizesList;
            }
            set
            {
                pizzaSizesList = value;
                OnPropertyChanged("PizzaSizesList");
            }
        }

        private List<string> pizzaIngredientsList;

        public List<string> PizzaIngredientsList
        {
            get
            {
                return pizzaIngredientsList;
            }
            set
            {
                pizzaIngredientsList = value;
                OnPropertyChanged("PizzaIngredientsList");
            }
        }

        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }

        private ICommand cancel;
        public ICommand Cancel
        {
            get
            {
                if (cancel == null)
                {
                    cancel = new RelayCommand(param => CancelExecute(), param => CanCancelExecute());
                }
                return cancel;
            }
        }

        private bool salami;

        public bool Salami
        {
            get
            {
                return salami;
            }
            set
            {
                salami = value;
                OnPropertyChanged("Salami");
            }
        }

        private bool ham;

        public bool Ham
        {
            get
            {
                return ham;
            }
            set
            {
                ham = value;
                OnPropertyChanged("Ham");
            }
        }

        private bool kulen;

        public bool Kulen
        {
            get
            {
                return kulen;
            }
            set
            {
                kulen = value;
                OnPropertyChanged("Kulen");
            }
        }

        private bool ketchup;

        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                OnPropertyChanged("Ketchup");
            }
        }

        private bool mayonnaise;

        public bool Mayonnaise
        {
            get
            {
                return mayonnaise;
            }
            set
            {
                mayonnaise = value;
                OnPropertyChanged("Mayonnaise");
            }
        }

        private bool chillyPepper;

        public bool ChillyPepper
        {
            get
            {
                return chillyPepper;
            }
            set
            {
                chillyPepper = value;
                OnPropertyChanged("ChillyPepper");
            }
        }

        private bool olives;

        public bool Olives
        {
            get
            {
                return olives;
            }
            set
            {
                olives = value;
                OnPropertyChanged("Olives");
            }
        }

        private bool oregano;

        public bool Oregano
        {
            get
            {
                return oregano;
            }
            set
            {
                oregano = value;
                OnPropertyChanged("Oregano");
            }
        }

        private bool sesame;

        public bool Sesame
        {
            get
            {
                return sesame;
            }
            set
            {
                sesame = value;
                OnPropertyChanged("Sesame");
            }
        }

        private bool cheese;

        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                OnPropertyChanged("Cheese");
            }
        }
        public List<bool> isIngredientsAdded { get; set; }

        private ICommand calculateAmount;
        public ICommand CalculateAmount
        {
            get
            {
                if (calculateAmount == null)
                {
                    calculateAmount = new RelayCommand(param => CalculateAmountExecute(), param => CanCalculateAmountExecute());
                }
                return calculateAmount;
            }
        }

        private int totalPrice;

        public int TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }

        private bool canChoose = true;

        public bool CanChoose
        {
            get
            {
                return canChoose;
            }
            set
            {
                canChoose = value;
                OnPropertyChanged("CanChoose");
            }
        }

        public bool IsPizzaCreated { get; set; }

        public MainWindowViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            Pizza = new vwPizza();
            PizzaSizesList = sizes.GetPizzaSizes();
            PizzaIngredientsList = new List<string>();
        }        

        public void CancelExecute()
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to cancel creating the order?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    mainWindow.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool CanCancelExecute()
        {
            return true;
        }

        public void CalculateAmountExecute()
        {
            if (Pizza.PizzaSize == null || Pizza.PizzaSize.Length == 0)
            {
                MessageBox.Show("Please choose size of pizza.", "Notification");
            }
            else
            {
                StringBuilder sb = new StringBuilder(Pizza.PizzaIngredients);
                if (Salami == true)
                {
                    PizzaIngredientsList.Add("Salami");
                    sb.Append("Salami ");
                }
                if (Ham == true)
                {
                    PizzaIngredientsList.Add("Ham");
                    sb.Append("Ham ");
                }
                if (Kulen == true)
                {
                    PizzaIngredientsList.Add("Kulen");
                    sb.Append("Kulen ");
                }
                if (Ketchup == true)
                {
                    PizzaIngredientsList.Add("Ketchup");
                    sb.Append("Ketchup ");
                }
                if (Mayonnaise == true)
                {
                    PizzaIngredientsList.Add("Mayonnaise");
                    sb.Append("Mayonnaise ");
                }
                if (ChillyPepper == true)
                {
                    PizzaIngredientsList.Add("ChillyPepper");
                    sb.Append("ChillyPepper ");
                }
                if (Olives == true)
                {
                    PizzaIngredientsList.Add("Olives");
                    sb.Append("Olives ");
                }
                if (Sesame == true)
                {
                    PizzaIngredientsList.Add("Sesame");
                    sb.Append("Sesame ");
                }
                if (Oregano == true)
                {
                    PizzaIngredientsList.Add("Oregano");
                    sb.Append("Oregano ");
                }
                if (Cheese == true)
                {
                    PizzaIngredientsList.Add("Cheese");
                    sb.Append("Cheese ");
                }
                Pizza.PizzaIngredients = sb.ToString();
                if (Pizza.PizzaIngredients == null || Pizza.PizzaIngredients.Length == 0)
                {
                    MessageBox.Show("Please add ingredients of pizza.", "Notification");
                }
                else
                {
                    try
                    {
                        Pizza.TotalAmount = Calculator.CalculateAmount(Pizza.PizzaIngredients, Pizza.PizzaSize);
                        TotalPrice = Pizza.TotalAmount;
                        CanChoose = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }                
            }
        }
        public bool CanCalculateAmountExecute()
        {
            if (TotalPrice != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void SaveExecute()
        {
            if (TotalPrice == 0)
            {
                MessageBox.Show("Please first calculate price of pizza.", "Notification");
            }            
            else
            {
                try
                {
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to save the order?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        IsPizzaCreated = pizzaModel.CreatePizza(Pizza);
                        if (IsPizzaCreated)
                        {
                            MessageBox.Show("Pizza is ordered.", "Notification", MessageBoxButton.OK);
                        }
                        else
                        {
                            MessageBox.Show("Pizza cannot be ordered.", "Notification", MessageBoxButton.OK);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public bool CanSaveExecute()
        {
            if (IsPizzaCreated)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}