using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laminar.Common.Entities;
using Laminar.Common.Library;
using Laminar.UI.CommonMVVM;

namespace Laminar.UI.IGTest
{
    public class IGCollectionViewModel : IIGViewModelBase
    {
        private bool _isWorking;
        private IDataSelectService<IContractVO> _dataService;
        private ObservableCollection<IContractVO> _entities;


        public IGCollectionViewModel()
        {
            LoadData();
        }

        private void OnMessage(EntityMessage<ContractDO> message)
        {
            switch (message.MessageType)
            {
                case EntityMessageType.Added:
                    OnEntityAdded(message.EntityKey);
                    break;
                case EntityMessageType.Changed:
                    OnEntityChanged(message.EntityKey);
                    break;
                case EntityMessageType.Deleted:
                    OnEntityDeleted(message.EntityKey);
                    break;
            }
        }

        private void OnEntityDeleted(IKeyVersion key)
        {
            var item = _entities.SingleOrDefault(x => x.Id == key.Id);
            _entities.Remove(item);
        }

        private void OnEntityChanged(IKeyVersion key)
        {
            var item = _entities.SingleOrDefault(x => x.Id == key.Id);
            var index = _entities.IndexOf(item);
            _entities.RemoveAt(index);
            var updatedItem = _dataService.SelectOne(key);
            _entities.Insert(index, updatedItem);
        }

        private void OnEntityAdded(IKeyVersion key)
        {
            var addedItem = _dataService.SelectOne(key);
            _entities.Add(addedItem);
        }

        public bool IsWorking
        {
            get { return _isWorking; }
//            set { SetProperty(ref _isWorking, value, () => IsWorking); }
            set { OnPropertyChanged(); }
        }

        public IContractVO SelectedEntity { get; set; }

        public ObservableCollection<IContractVO> Entities
        {
            get { return _entities; }
//            set { SetProperty(ref _entities, value, () => Entities); }
            set { OnPropertyChanged();}
        }



        private void InitializeService()
        {
            _dataService = ServiceProvider.GetService<IDataSelectService<IContractVO>>();
//            Messenger.Default.Register<EntityMessage<ContractDO>>(this, OnMessage);

            IsWorking = true;
            LoadData();

//            base.OnInitializeInRuntime();
        }

        private void LoadData()
        {

            var entities = new ObservableCollection<IContractVO>();
            var uiSyncContext = TaskScheduler.FromCurrentSynchronizationContext();
            var task = Task.Factory.StartNew(() =>
            {
                foreach (var item in _dataService.SelectAll().OrderBy(x => x.ContractId))
                {
                    entities.Add(item);
                }

            });

            task.ContinueWith((antecedent) =>
            {
                Entities = entities;
                IsWorking = false;
            }, uiSyncContext);
        }

//        private DelegateCommand _newCommand;
//
//        public DelegateCommand NewCommand
//        {
//            get
//            {
//                if (_newCommand == null)
//                {
//                    _newCommand = new DelegateCommand(New);
//                }
//                return _newCommand;
//            }
//        }

//        private DelegateCommand<IContractVO> _editCommand;
//
//        public DelegateCommand<IContractVO> EditCommand
//        {
//            get
//            {
//                if (_editCommand == null)
//                {
//                    _editCommand = new DelegateCommand<IContractVO>(Edit, CanExecuteEntityCommand);
//                }
//                return _editCommand;
//            }
//        }

        public void New()
        {
            ShowDocument(null);
        }
        public void Edit(IContractVO entity)
        {
            ShowDocument(entity);
        }

        private bool CanExecuteEntityCommand(IContractVO entity)
        {
            return entity != null;
        }


        private void ShowDocument(IKey key)
        {
            ShowDialogWindow(key);
        }

        public void ShowDialogWindow(IKey key)
        {
//            var messageBox = GetService<IMessageBoxService>();
//            messageBox.Show("ShowDialogWindow");
            //
//            DXDialogWindow dialog = null;
//            ContractEditView view = null;
//            try
//            {
//                dialog = new DXDialogWindow();
//                view = new ContractEditView();
//                dialog.Content = view;
//
//                var supportParameter = view.DataContext as ISupportParameter;
//
//                if (supportParameter != null)
//                {
//                    supportParameter.Parameter = key;
//                }
//
//
//                dialog.Show();
//            }
//            catch (Exception ex)
//            {
//                if (dialog != null) dialog.Close();
//                var messageBox = GetService<IMessageBoxService>();
//                messageBox.Show(ex.Message, "Exception");
//
//            }

        }

//        private IDocumentManagerService DocumentManagerService
//        {
//            //get { return GetService<IDocumentManagerService>(ServiceSearchMode.PreferParents); }
//            get { return null; }
//        }


    }
}
