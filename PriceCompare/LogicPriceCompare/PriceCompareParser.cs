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

        public List<ChainStore> Parse()
        {
            List<ChainStore> chainStores = new List<ChainStore>();
            foreach (string currentDirectory in Directory.GetDirectories(path))
            {
                string replaceChainStoreName = path + "\\";
                ChainStore chainStore = new ChainStore(currentDirectory.Replace(replaceChainStoreName, ""));
                foreach (string currentFile in Directory.GetFiles(currentDirectory))
                {
                    string replaceStoreName = currentFile + @"\";
                    replaceStoreName.Replace(".xml", "");

                    Store store = new Store(currentFile.Replace(replaceStoreName, ""));
                    XDocument xmlDoc = XDocument.Load(currentFile);
                    var items = xmlDoc.Descendants("item");
                    if (items != null)
                    {
                        foreach (XElement xmlItem in items)
                        {
                            if ((xmlItem.Element("ItemName") != null) && (xmlItem.Element("ItemPrice") != null))
                            {
                                string name = xmlItem.Element("ItemName").Value.ToString();
                                string price = xmlItem.Element("ItemPrice").Value.ToString();
                                try
                                {
                                    Item item = new Item(name, price);
                                    store.AddItem(item);
                                }
                                catch (ArgumentException)
                                {

                                }
                            }
                        }
                        chainStore.AddStore(store);
                    }
                }
                if (chainStore.Stores != null)
                {
                    chainStores.Add(chainStore);
                }
            }
            return chainStores;
        }

    }
}
