using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataPriceCompare;

namespace LogicPriceCompare
{
    public class PriceCompareParser
    {
        private const string path = @"C:\Users\yariv\Source\Repos\repository\PriceCompare\DataPriceCompare\ChainStores";

        public void Parse()
        {
            foreach (string currentDirectory in Directory.GetDirectories(path))
            {
                StoresDocument storesDocument = GetDataStoresFile(currentDirectory);
                foreach (string currentFile in Directory.GetFiles(currentDirectory))
                {
                    if (!currentFile.StartsWith("Stores"))
                    {
                        XDocument xmlDoc = XDocument.Load(currentFile);
                        Store store  = AddStoreToDB(xmlDoc, storesDocument);
                        if (store != null)
                        {
                            var items = xmlDoc.Descendants("item").ToList();
                            if (items.Count == 0)
                            {
                                items = xmlDoc.Descendants("Item").ToList();
                            }
                            if (items != null)
                            {
                                AddItemsToDB(items, store);
                            }
                        }
                    }
                }
            }
        }

        private void AddItemsToDB(List<XElement> items, Store store)
        {
            List<Item> itemsDB = new List<Item>();
            PriceCompareDataAccess dataAccess = new PriceCompareDataAccess();
            foreach (XElement xmlItem in items)
            {
                Item item = new Item(xmlItem.Element("ItemName").Value.ToString());
                item.Price = xmlItem.Element("ItemPrice").Value.ToString();
                item.Code = xmlItem.Element("ItemCode").Value.ToString();
                item.Type = xmlItem.Element("ItemType").Value.ToString();
                item.Quantity = xmlItem.Element("Quantity").Value.ToString();
                item.UnitOfMeasure = xmlItem.Element("UnitOfMeasure").Value.ToString();
                item.StoreId = store.Id;
               // item.StoreId = dataAccess.GetStoreId(store);
                itemsDB.Add(item);
            }
            dataAccess.AddItems(itemsDB);
        }

        private Store AddStoreToDB(XDocument xmlDoc, StoresDocument storesDocument)
        {
            Store store = null;
            if(storesDocument != null)
            {
                string storeId = xmlDoc.Element("StoreId").Value.ToString();
                string name = storesDocument.Stores[storeId];
                if (name != null)
                {
                    store = new Store(name);
                    store.ChainStoreName = storesDocument.ChainStoresName;
                    PriceCompareDataAccess dataAccess = new PriceCompareDataAccess();
                    dataAccess.AddStore(store);
                }
            }
            return store;
        }

        private StoresDocument GetDataStoresFile(string directory)
        {
            StoresDocument storesDocument = null;
            foreach (string currentFile in Directory.GetFiles(directory))
            {
                if(currentFile.StartsWith("Stores"))
                {
                    XDocument xmlDoc = XDocument.Load(currentFile);
                    string chainStoresName = xmlDoc.Element("ChainName").ToString();
                    if(chainStoresName != null)
                    {
                        storesDocument = new StoresDocument(chainStoresName);
                        var stores = xmlDoc.Descendants("Store").ToList();
                        if(stores.Count == 0)
                        {
                            stores = xmlDoc.Descendants("store").ToList();
                        }
                        foreach (XElement xmlStore  in stores)
                        {
                            string id = xmlStore.Element("StoreId").Value.ToString();
                            string name = xmlStore.Element("StoreName").Value.ToString();
                            storesDocument.AddStore(id, name);
                        }
                        return storesDocument;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }
    }
}
