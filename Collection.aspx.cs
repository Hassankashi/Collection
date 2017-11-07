using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*-------------------------------*
    *                            *
    *     Free Web Tutorial      *
    *     Mahsa Hassankashi      *
    * technical.cosmicverse.info *
    *     cosmicverse.info       * 
    *                            * 
    *--------------------------- */
public partial class Collection : System.Web.UI.Page
{
    
    protected void btn_Array_Click(object sender, EventArgs e)
    {

        //It is obvious that strArray is 
        //1. string   --> Strongly Type 
        //2. Sized=10 --> Fixed Size

        string[] strArray = new string[10];

        for (int i = 0; i < 10; i++)
        {
            if (strArray[i]==null)
            {
                strArray[i] = (i+1).ToString();
            }
        }

        this.ListBoxArray.DataSource = null;
        this.ListBoxArray.Items.Clear();

        this.ListBoxArray.DataSource = strArray;
        this.ListBoxArray.DataBind();

        
    }

    protected void btn_ArrayList_Click(object sender, EventArgs e)
    {
        //It is NOT obvious that strArrayList is 1. string? int? object? decimal?  --> NOT Strongly Type 
        //                                       2. Sized=10? 20? 100?             -->NOT Fixed Size
        // Namespace: System.Collections

        System.Collections.ArrayList strArrayList = new System.Collections.ArrayList();
        //System.Linq.IQueryable  type of data is not specific runtime defered support
        strArrayList.Add("Mahsa");  //   "Mahsa": is string
        strArrayList.Add(1);        //        1 : is integer
        strArrayList.Add(0.89);     //      0.89: is decimal

        this.ListBoxArrayList.DataSource = null;
        this.ListBoxArrayList.Items.Clear();
        this.ListBoxArrayList.DataSource = strArrayList;
        this.ListBoxArrayList.DataBind();

        System.Text.StringBuilder str= new System.Text.StringBuilder();

        foreach (var item in strArrayList)
        {
            str.Append(" , "+item);
        }
        this.lblArrayList.Text = str.ToString();
       
    }

    protected void btn_ArrayListObject_Click(object sender, EventArgs e)
    {

        //Below is old way to fill obj from product , in Arraylist you need to create more than one instance
       // Product objProduct = new Product();
       // objProduct.Code = "1001";
       // objProduct.Name = "Chair";

        //It is NOT obvious that strArrayList is 
        //1. string? int? object? decimal? OR OBJECT??  --> NOT Strongly Type 
        //2. Sized=10? 20? 100?                         -->NOT Fixed Size
        // Namespace: System.Collections

        System.Collections.ArrayList objArrayList = new System.Collections.ArrayList();

        objArrayList.Add(new Product("1001", "Chair"));
        objArrayList.Add(new Product("1002", "Sofa"));
        objArrayList.Add(new Product("1003", "Carpet"));

        this.DropDownListArrayListObject.DataSource = null;
        this.DropDownListArrayListObject.Items.Clear();
        this.DropDownListArrayListObject.DataSource = objArrayList;

        //* Finding among Object of Array List is difficult , you have to find your specific item by index
        Product objTemp = (Product)objArrayList[0];
        objArrayList.Remove(objTemp);
        //*
        this.DropDownListArrayListObject.DataTextField = "_Name";
        this.DropDownListArrayListObject.DataValueField = "_Code";
        this.DropDownListArrayListObject.DataBind();
        this.GridViewArrayListObject.DataSource = objArrayList;
        this.GridViewArrayListObject.DataBind();


     }

    protected void btn_HashTable_Click(object sender, EventArgs e)
    {
       

        //It is NOT obvious that strArrayList is 
        //1. string? int? object? decimal? OR OBJECT??  --> NOT Strongly Type 
        //2. Sized=10? 20? 100?                         -->NOT Fixed Size
        // Namespace: System.Collections
        //Hashtable solve the problem in Arraylist when we are looking for specific item
        //Hashtable dedicate a key for each item, then finding item is easier and faster 

         System.Collections.Hashtable objHashTable = new System.Collections.Hashtable();
       
         objHashTable.Add("1001","Chair");
         objHashTable.Add("1002", "Sofa");
         objHashTable.Add("1003", "Carpet");

     
        this.DropDownListHashTable.DataSource = null;
        this.DropDownListHashTable.Items.Clear();
        this.DropDownListHashTable.DataSource = objHashTable;
        //* finding item is easier you just need to point to it by call its key 
        objHashTable.Remove("1002");
        //*
        this.DropDownListHashTable.DataTextField = "Value";
        this.DropDownListHashTable.DataValueField = "Key";
        this.DropDownListHashTable.DataBind();
        
    }

    
    protected void btn_StackPush_Click(object sender, EventArgs e)
    {

        //Stack is LIFO: Last in First Out
        System.Collections.Stack objStackPush = new System.Collections.Stack();

        //By Push method you can insert item at the top of the stack
        objStackPush.Push("Mahsa");
        objStackPush.Push("Hassankashi");
        this.lblPop.Text = "";
        this.ListBoxStack.DataSource = objStackPush.ToArray();
        this.ListBoxStack.DataBind();


    }

    protected void btn_StackPop_Click(object sender, EventArgs e)
    {

        System.Collections.Stack objStackPop = new System.Collections.Stack();

        objStackPop.Push("Mahsa");
        objStackPop.Push("Hassankashi");

        //By Pop method you can remove item from the top of the stack --> Last in First in 
        this.lblPop.Text = objStackPop.Pop().ToString();

        this.ListBoxStack.DataSource = objStackPop.ToArray();
        this.ListBoxStack.DataBind();

    }

    protected void btn_Queue_Click(object sender, EventArgs e)
    {

        //Queue is FIFO: First in First Out
        System.Collections.Queue objQueue = new System.Collections.Queue();

        //By Enqueue method you can insert item at the END of the Queue
        objQueue.Enqueue("Mahsa");
        objQueue.Enqueue("Hassankashi");
        objQueue.Enqueue("Cosmic");
        objQueue.Enqueue("Verse");

        this.lblQueue.Text = "";
        this.ListBoxQueue.DataSource = objQueue.ToArray();
        this.ListBoxQueue.DataBind();

    }

    protected void btn_DeQueue_Click(object sender, EventArgs e)
    {
        System.Collections.Queue objQueue = new System.Collections.Queue();

        objQueue.Enqueue("Mahsa");
        objQueue.Enqueue("Hassankashi");
        objQueue.Enqueue("Cosmic");
        objQueue.Enqueue("Verse");

        //By Dequeue method you can remove item from the BEGINING of the Queue --> First in First out FIFO
        this.lblQueue.Text=objQueue.Dequeue().ToString();
       
        this.ListBoxQueue.DataSource = objQueue.ToArray();
        this.ListBoxQueue.DataBind();

    }

    protected void btn_List_Click(object sender, EventArgs e)
    {
        //Like Array is Strong Type
        //Like ArrayList with No Dimension

        System.Collections.Generic.List<string> strList = new List<string>();


        strList.Add("Mahsa");
        strList.Add("Hassankashi");
        strList.Add("Cosmic");
        strList.Add("Verse");
       
        this.ListBoxListGeneric.DataSource = strList;
        this.ListBoxListGeneric.DataBind();

        System.Text.StringBuilder str = new System.Text.StringBuilder();

        foreach (var item in strList)
        {
            str.Append(" , " + item);
        }
        this.lblList.Text = str.ToString();


    }

    protected void btn_IList_Click(object sender, EventArgs e)
    {


        //Ilist can not be instantiate from Ilist , so it should be instantiate from List
        System.Collections.Generic.IList<string> strIList = new List<string>();

        strIList.Add("Mahsa");
        strIList.Add("Hassankashi");
        strIList.Add("Cosmic");
        strIList.Add("Verse");

        
        this.ListBoxListGeneric.DataSource = strIList;
        this.ListBoxListGeneric.DataBind();

        System.Text.StringBuilder str = new System.Text.StringBuilder();

        foreach (var item in strIList)
        {
            str.Append(" , " + item);
        }
        this.lblList.Text = str.ToString();


    }

    
    protected void btn_IEnumerable_Click(object sender, EventArgs e)
    {

        //IEnumerable can not be instantiate from Enumerable , so it should be instantiate from List
        System.Collections.Generic.IEnumerable<Employee> empIEnumerable = new List<Employee>
        {   new Employee { ID = 1001, Name="Mahsa"},
            new Employee { ID = 1002, Name = "Hassankashi" },
            new Employee { ID = 1003, Name = "CosmicVerse" },
            new Employee { ID = 1004, Name = "Technical" }
        };


        this.GridViewIEnumerable.DataSource = empIEnumerable;
        this.GridViewIEnumerable.DataBind();

        System.Text.StringBuilder str = new System.Text.StringBuilder();

        foreach (Employee item in empIEnumerable)
        {
            str.Append(" , " + item.ID +"-"+item.Name);
        }

        this.lblIEnumerable.Text = str.ToString();


    }


    //Follow "Entity Framework DatabaseFirst" from this article for making DBContext
    DataAccessEntities ctx = new DataAccessEntities();
    //var ctx = new DataAccessEntities();

    protected void btn_IQueryable_Click(object sender, EventArgs e)
    {
            

        //Difference between IQueryable and IEnumerable

        //You can instantiate IEnumerable from List

        IEnumerable<Employee> queryIEnumerable = new List<Employee>() ;


        //Bring  ALL records from server --> to client then filter collection
       //To bring all data from server you should omit where cluse from linq to sql 
        queryIEnumerable = from m in ctx.Employees select m;

        //If you use where as extension method with IEnumerable then All records will be loaded 
        queryIEnumerable = queryIEnumerable.Where(x => x.ID == 1).ToList();
       


        //You can not instantiate IQueryable

        IQueryable<Employee> queryIQueryable=null;

        //Bring just ONE record from server --> to client

        queryIQueryable = (from m in ctx.Employees
                     where m.ID == 1
                     select m);

        //Whenever you call IQueryable so ==> It will be executed 
        this.GridViewIQueryable.DataSource = queryIQueryable.ToList();
        this.GridViewIQueryable.DataBind();


    }


    protected void btn_ICollection_Click(object sender, EventArgs e)
    {

        //IList {indexer and Modify} vs ICollection {randomly and Modify}         
        //Collection can not be instantiate from ICollection , so it should be instantiate from List
        System.Collections.Generic.ICollection<string> strICollection = new List<string>();
        strICollection.Add("Mahsa");
        strICollection.Add("Hassankashi");
        //**Countable
        int ICollectionCount=strICollection.Count;

        this.ListBoxICollection.DataSource = strICollection;
        this.ListBoxICollection.DataBind();
        System.Text.StringBuilder str = new System.Text.StringBuilder();
        foreach (var item in strICollection)
        {
            str.Append(" , " + item);
        }
        this.lblICollection.Text = str.ToString();
        
        //***IList
        System.Collections.Generic.IList<Employee> objIList = new List<Employee>();
        objIList = (from m in ctx.Employees
                    select m).ToList();
       
       Employee obj = objIList.Where(i => i.Name == "Sara").FirstOrDefault();
       int indexofSara= objIList.IndexOf(obj);
       int cIList = objIList.Count;

        //***ICollection
        System.Collections.Generic.ICollection<Employee> objICollection = new List<Employee>();
        objICollection = (from m in ctx.Employees
                          select m).ToList();
        Employee objIC = objICollection.Where(i => i.Name == "Sara").FirstOrDefault();
        //You can not get index of object , if you clear comment from below code appears error
       // int indexofSaraICollection = objIC.IndexOf(objIC);
        int cICollection = objICollection.Count;

    }

    protected void btn_Dictionary_Click(object sender, EventArgs e)
    {


        //Dictionary can instantiate from Dictionary , Dictionary is similar to Hashtable, 
        //Dictionary is GENERIC but Hashtable is NON GENERIC
        //Such Hashtable you can find object by its key

        System.Collections.Generic.Dictionary<int, string> objDictionary = new Dictionary<int, string>();

        objDictionary.Add(1001, "Mahsa");
        objDictionary.Add(1002, "Hassankashi");
        objDictionary.Add(1003, "Cosmicverse");

        string str = objDictionary[1002];

        this.ListBoxDictionary.DataSource = objDictionary;
        this.ListBoxDictionary.DataBind();
       

    }
    
    protected void btn_StackPushGeneric_Click(object sender, EventArgs e)
    {

        //Stack is LIFO: Last in First Out
        //Here is for Push Stack in Generic
        //System.Collections.Stack objStackPush = new System.Collections.Stack();
        //Stack<T> can be instantiated from Stack<T>

        System.Collections.Generic.Stack<int> objStackPush = new System.Collections.Generic.Stack<int>();

        objStackPush.Push(1);
        objStackPush.Push(2);

        this.lblPopGeneric.Text = "";
        this.ListBoxStackGeneric.DataSource = objStackPush.ToArray();
        this.ListBoxStackGeneric.DataBind();

    }

    protected void btn_StackPopGeneric_Click(object sender, EventArgs e)
    {
        //Stack is LIFO: Last in First Out
        //Here is for Pop Stack in Generic
        //System.Collections.Stack objStackPop = new System.Collections.Stack();
        //Stack<T> can be instantiated from Stack<T>

        System.Collections.Generic.Stack<int> objStackPop = new System.Collections.Generic.Stack<int>();

        objStackPop.Push(1);
        objStackPop.Push(2);

        this.lblPop.Text = objStackPop.Pop().ToString();
        this.ListBoxStack.DataSource = objStackPop.ToArray();
        this.ListBoxStack.DataBind();

    }

    protected void btn_QueueGeneric_Click(object sender, EventArgs e)
    {

        //Queue is FIFO: First in First Out
        //Here is for Enqueue Queue in Generic
        //System.Collections.Queue objQueue = new System.Collections.Queue();
        //Queue<T> can be instantiated from Queue<T>

        System.Collections.Generic.Queue<int> objQueue = new System.Collections.Generic.Queue<int>();
        objQueue.Enqueue(1);
        objQueue.Enqueue(2);
      
        this.lblQueue.Text = "";

        this.ListBoxQueue.DataSource = objQueue.ToArray();
        this.ListBoxQueue.DataBind();

    }

    protected void btn_DeQueueGeneric_Click(object sender, EventArgs e)
    {


        //Queue is FIFO: First in First Out
        //Here is for Dequeue Queue in Generic
        //System.Collections.Queue objQueue = new System.Collections.Queue();
        //Queue<T> can be instantiated from Queue<T>

        System.Collections.Generic.Queue<int> objQueue = new System.Collections.Generic.Queue<int>();

        objQueue.Enqueue(1);
        objQueue.Enqueue(2);

        this.lblQueue.Text = objQueue.Dequeue().ToString();

        this.ListBoxQueue.DataSource = objQueue.ToArray();
        this.ListBoxQueue.DataBind();


    }

    
}

