using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dragablz;

namespace OptionalCloseButton
{
    public class MainWindowViewModel
    {
        private readonly IInterTabClient _interTabClient = new InterTabClient();
        private readonly ObservableCollection<HeaderedItemViewModel> _items;

        public MainWindowViewModel()
        {
            _items = new ObservableCollection<HeaderedItemViewModel>();
        }

        public MainWindowViewModel(params HeaderedItemViewModel[] items)
        {
            _items = new ObservableCollection<HeaderedItemViewModel>(items);
        }

        public ObservableCollection<HeaderedItemViewModel> Items
        {
            get { return _items; }
        }

        public IInterTabClient InterTabClient
        {
            get { return _interTabClient; }
        }

        public Func<HeaderedItemViewModel> Factory
        {
            get
            {
                return
                    () =>
                    {
                        var dateTime = DateTime.Now;

                        return new HeaderedItemViewModel()
                        {
                            Header = new HeaderWithCloseViewModel() { Header = dateTime.ToLongTimeString() },
                            Content = dateTime.ToString("R")
                        };
                    };
            }
        }
    }
}
