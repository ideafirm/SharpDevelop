﻿/*
 * Created by SharpDevelop.
 * User: Peter Forstmeier
 * Date: 21.05.2013
 * Time: 20:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

using ICSharpCode.Reporting.BaseClasses;
using ICSharpCode.Reporting.DataSource;
using ICSharpCode.Reporting.DataSource.Comparer;
using ICSharpCode.Reporting.Interfaces;
using ICSharpCode.Reporting.Interfaces.Data;
using ICSharpCode.Reporting.Items;

namespace ICSharpCode.Reporting.DataManager.Listhandling
{
	/// <summary>
	/// Description of CollectionHandling.
	/// </summary>
	public class CollectionSource:IDataViewHandling
	{

		readonly PropertyDescriptorCollection listProperties;
		readonly DataCollection<object> baseList;
		readonly ReportSettings reportSettings;
		readonly Type elementType;
		
		public CollectionSource(IEnumerable list, Type elementType, ReportSettings reportSettings)
		{
			this.elementType = elementType;
			
			baseList = CreateBaseList(list, elementType);
//			elementType =  baseList[0].GetType();
		
			this.reportSettings = reportSettings;
			this.listProperties = this.baseList.GetItemProperties(null);
			IndexList = new IndexList();
		}

		#region IDataViewHandling
		
		public  int Count
		{
			get {
				return this.baseList.Count;
			}
		}
		
		public Collection<AbstractColumn> AvailableFields {
			get {
				var availableFields = new Collection<AbstractColumn>();
				foreach (PropertyDescriptor p in this.listProperties){
					availableFields.Add (new AbstractColumn(p.Name,p.PropertyType));
				}
				return availableFields;
			}
		}
		
		public object Current {
			get {
				return baseList[((BaseComparer)IndexList[CurrentPosition]).ListIndex];
			}
		}
		
		
		public int CurrentPosition {
			
			get {
				return IndexList.CurrentPosition;
			}
			set {
				if ((value > -1)|| (value > this.IndexList.Count)){
					this.IndexList.CurrentPosition = value;
				}
				
//				BaseComparer bc = GetComparer(value);
//				Current = baseList[bc.ListIndex];
				
//				current = this.baseList[((BaseComparer)IndexList[value]).ListIndex];
			}
		}
		
		
		public bool MoveNext()
		{
			this.IndexList.CurrentPosition ++;
			return this.IndexList.CurrentPosition<this.IndexList.Count;
		}
		
		
		public void Bind()
		{
			if (reportSettings.GroupColumnCollection.Any()) {
				this.Group();
			} else {
				this.Sort ();
			}
		}
		
		
		public IndexList IndexList {get; private set;}
		
		#endregion
		
		
		#region Fill
		
		public void Fill(List<IPrintableObject> collection)
		{
			foreach (IPrintableObject item in collection)
			{
				if (item is IDataItem) {
					FillInternal(item as IDataItem);
				}
			}
		}
		
		
		void FillInternal (IDataItem item) {
			item.DBValue = String.Empty;
			var p = listProperties.Find(item.ColumnName,true);
			item.DBValue = p.GetValue(Current).ToString();
			if (String.IsNullOrEmpty(item.DataType)) {
				item.DataType = p.PropertyType.ToString();
			}
		}
		
		#endregion
		
		#region Fill_Test
		private IEnumerable<IGrouping<object, BaseComparer>> newList;
		private IEnumerator<IGrouping<object, BaseComparer>> groupEnumerator;
		private IEnumerator<BaseComparer> listEnumerator;
		
		public void Fill_Test (List<IPrintableObject> collection) {
			
			var currentKey = groupEnumerator.Current;
			Console.WriteLine("{0} - {1}",currentKey.Key,currentKey.Count());
			var z = listEnumerator.Current;
			Console.WriteLine("\t...{0} - {1}",((BaseComparer)z).ListIndex.ToString(),
			                  ((BaseComparer)z).ObjectArray[0].ToString());
		}
		
		
		public bool MoveNext_Test_List() {
			var canMove = listEnumerator.MoveNext();
			if (! canMove) {
				var groupCanMove = groupEnumerator.MoveNext();
				if (groupCanMove) {
					listEnumerator = groupEnumerator.Current.GetEnumerator();
					canMove = listEnumerator.MoveNext();
				} else {
					Console.WriteLine("end");
				}
			}
			return canMove;
		}
		
		
		#endregion
		
		#region Grouping
		public void Group()
		{
			var unsortedList = this.BuildIndexInternal(baseList,reportSettings.GroupColumnCollection);


			Console.WriteLine("GroupBy() _ 0");
			
//			var grouped_x = unsortedList.GroupBy(a => a.ObjectArray[0]);
			/*
			var grouped_x = GroupTestOne(unsortedList);
			
			foreach (var element in grouped_x) {
				Console.WriteLine("{0} - {1} ",element.Key.ToString(),element.ToString());
				foreach (var xx in element) {
					Console.WriteLine("...{0}",((BaseComparer)xx).ObjectArray[0].ToString());
				}
			}
			*/
			
			Console.WriteLine("GroupBy() _ 1");
			
			
//			   var groupByLinq = (from car in unsortedList
//			                           group car by car.ObjectArray[0]);

			
//			foreach (var element in groupByLinq) {
//				Console.WriteLine("{0} - {1} ",element.Key.ToString(),element.Key is BaseComparer);
//				foreach (var xx in element) {
//					Console.WriteLine("...{0}",((BaseComparer)xx).ObjectArray[0].ToString());
//				}
//			}
			
			
//			IEnumerable<IGrouping<BaseComparer, BaseComparer>> xx = unsortedList.GroupBy(a => a.ObjectArray[0]);
			
			IEnumerable<IGrouping<object, BaseComparer>> grouped = unsortedList.GroupBy(a => a.ObjectArray[0]);;
			Console.WriteLine("GroupBy() _ 2");
			
			foreach (var element in grouped) {
				Console.WriteLine("{0} - {1} ",element.Key.ToString(),element.Key is BaseComparer);
				foreach (var xx in element) {
					Console.WriteLine("...{0}",((BaseComparer)xx).ObjectArray[0].ToString());
				}
			}
			

//			newList = GroupTestOne(unsortedList);
			newList = GroupTestLinq(unsortedList);
			
			groupEnumerator = newList.GetEnumerator();
			groupEnumerator.MoveNext();
			listEnumerator = groupEnumerator.Current.GetEnumerator();
			listEnumerator.MoveNext();
			var z = listEnumerator.Current;
			Console.WriteLine("--------Display output-----");
		}

		
		IEnumerable<IGrouping<object, BaseComparer>> GroupTestOne (IndexList list) {
			return list.GroupBy(a => a.ObjectArray[0]);
		}
		
		IEnumerable<IGrouping<object, BaseComparer>> GroupTestLinq (IndexList list) {
			return (from car in list
			                           group car by car.ObjectArray[0]);
		}
		
		/*
		void Group_test(IndexList unsortedList)
		{
			Console.WriteLine("-------New group --------\t");

			var dictionary = BuildGroup_1(unsortedList, reportSettings.GroupColumnCollection);
			
//			foreach (var element in dictionary) {
//				Console.WriteLine("{0} - {1}", element.Key, element.Value.Count);
//			}
			var list = dictionary.Keys.ToList();
			list.Sort();
			
			Console.WriteLine("-------Sorted keys --------");
			foreach (var key in list) {
				Console.WriteLine("{0}: {1}", key, dictionary[key].Count);
				foreach (var element in dictionary[key]) {
					Console.WriteLine("\t{0} ", ((BaseComparer)element).ObjectArray[0].ToString());
				}
			}
			Console.WriteLine("-------Sort list by RandomInt --------");
			
			SortColumnCollection sc = new SortColumnCollection();
			sc.Add(new SortColumn("RandomInt", ListSortDirection.Ascending));
			
			foreach (var key in list) {
				Console.WriteLine("{0}: {1}", key, dictionary[key].Count);
				
				DataCollection<object> newSource = new DataCollection<object>(elementType);
				IndexList myList = new IndexList();
				foreach (var element in dictionary[key]) {
					newSource.Add(baseList[element.ListIndex]);
					myList = BuildSortIndex(newSource,sc);
					Console.WriteLine("\t{0} ", ((BaseComparer)element).ObjectArray[0].ToString());
				}
				dictionary[key] = myList;
//				dictionary[key] =  myList.OrderBy(a => a.ObjectArray[0]).ToList();
				
				
			}
			Console.WriteLine("Result");
			foreach (var key in list) {
				Console.WriteLine("{0}: {1}", key, dictionary[key].Count);
				foreach (var element in dictionary[key]) {
					Console.WriteLine("\t{0} ", ((BaseComparer)element).ObjectArray[0].ToString());
				}
			}
		}
		*/
		/*
		
		private Dictionary<string,IndexList> BuildGroup_1 (IndexList list,GroupColumnCollection groups) {
			var dictionary = new Dictionary<string,IndexList>();
			PropertyDescriptor[] groupProperties = BuildSortProperties (groups);
			foreach (var element in list) {
				string groupValue = ExtractValue (element,groupProperties);
				if (!dictionary.ContainsKey(groupValue)) {
					dictionary[groupValue] = new IndexList();
				}
				
				dictionary[groupValue].Add(element);
			}
			
			Console.WriteLine("Dictonary ");
			foreach (var el in dictionary.Values) {
				Console.WriteLine(el.Count.ToString());
				
				foreach (var element in el) {
					Console.WriteLine("-- {0}",element.ToString());
				}
			}
			return dictionary;
		}
		*/
		
/*
		private IndexList BuildGroup (IndexList source,GroupColumnCollection groups)
		{
			string compareValue = String.Empty;
			var idlist = new IndexList();

			PropertyDescriptor[] groupProperties = BuildSortProperties (groups);

			GroupComparer groupComparer = null;
			
			foreach (BaseComparer element in source) {
				var groupValue = ExtractValue(element,groupProperties);
				var query2 =  idlist.FirstOrDefault( s => ((GroupComparer)s).ObjectArray[0] == groupValue) as GroupComparer;
				if (query2 == null) {
					groupComparer = CreateGroupHeader(element);
					idlist.Add(groupComparer);
				} else {
					Console.WriteLine("xx");
				}
				if (compareValue != groupValue) {
					groupComparer = CreateGroupHeader(element);
					idlist.Add(groupComparer);
				}
				groupComparer.IndexList.Add(element);
				
				compareValue = groupValue;
			}
			ShowGrouping(ref idlist);
			return idlist;
		}
*/

		void ShowGrouping(ref IndexList idlist)
		{
			Console.WriteLine("----ShowGrouping---");
			foreach (GroupComparer el in idlist) {
				Console.WriteLine("{0}", el.ToString());
				if (el.IndexList.Any()) {
					foreach (var element in el.IndexList) {
						Console.WriteLine("--{0}", element.ToString());
					}
				}
			}
		}
		
		
		string ExtractValue(BaseComparer element,PropertyDescriptor[] groupProperties)
		{
			var rowItem = baseList[element.ListIndex];
			var values = FillComparer(groupProperties, rowItem);
//			return element.ObjectArray[0].ToString();
			return values[0].ToString();
		}
		
		
		static GroupComparer CreateGroupHeader (BaseComparer sc)
		{
			var gc = new GroupComparer(sc.ColumnCollection,sc.ListIndex,sc.ObjectArray);
			gc.IndexList = new IndexList();
			return gc;
		}
		
		#endregion
		
		
		#region BuildIndexList
		
		DataCollection<object> CreateBaseList(IEnumerable source, Type elementType)
		{
			var list = new DataCollection<object>(elementType);
			list.AddRange(source);
			return list;
		}
		
		
		IndexList BuildSortIndex(DataCollection<object> listToSort,Collection<AbstractColumn> sortColumnsCollection)
		{
			
			IndexList indexList = BuildIndexInternal(listToSort,sortColumnsCollection);
			
			if (indexList[0].ObjectArray.GetLength(0) == 1) {
				
				IEnumerable<BaseComparer> sortedList = GenericSorter (indexList);
				indexList.Clear();
				indexList.AddRange(sortedList);
			}
			else {
				indexList.Sort();
			}
			return indexList;
		}



		IndexList BuildIndexInternal(DataCollection<object> listToSort,Collection<AbstractColumn> sortColumnsCollection)
		{
			var indexList = new IndexList();
			PropertyDescriptor[] sortProperties = BuildSortProperties(sortColumnsCollection);
			for (int rowIndex = 0; rowIndex < listToSort.Count; rowIndex++) {
				var rowItem = listToSort[rowIndex];
				var values = FillComparer(sortProperties, rowItem);
				indexList.Add(new SortComparer(sortColumnsCollection, rowIndex, values));
			}
			return indexList;
		}
		
		#endregion
		
		
		#region Sorting delegates
		
		public void Sort()
		{
			if ((this.reportSettings.SortColumnsCollection != null)) {
				if (this.reportSettings.SortColumnsCollection.Count > 0) {
					IndexList = this.BuildSortIndex (baseList,reportSettings.SortColumnsCollection);
				} else {
					IndexList = this.BuildIndexInternal(baseList,reportSettings.SortColumnsCollection);
				}
			}
		}
		
		static IEnumerable<BaseComparer> GenericSorter (List<BaseComparer> list)
		{

			List<BaseComparer> sortedList = null;
			ListSortDirection sortDirection = GetSortDirection(list);
			
			sortedList = sortDirection == ListSortDirection.Ascending ? list.AsQueryable().AscendingOrder().ToList() : list.AsQueryable().DescendingOrder().ToList();
			return sortedList;
		}

		
		static ListSortDirection GetSortDirection(List<BaseComparer> list)
		{
			BaseComparer bc = list[0];
			var sortColumn = bc.ColumnCollection[0] as SortColumn;
			ListSortDirection sd = sortColumn.SortDirection;
			return sd;
		}
		
		
		Object[] FillComparer(PropertyDescriptor[] sortProperties,  object rowItem)
		{
			object[] values = new object[sortProperties.Length];
			for (int criteriaIndex = 0; criteriaIndex < sortProperties.Length; criteriaIndex++) {
				object value = sortProperties[criteriaIndex].GetValue(rowItem);
				if (value != null && value != DBNull.Value) {
					if (!(value is IComparable)) {
						throw new InvalidOperationException("ReportDataSource:BuildSortArray - > This type doesn't support IComparable." + value.ToString());
					}
					values[criteriaIndex] = value;
				}
			}
			return values;
		}
		
		private PropertyDescriptor[] BuildSortProperties (Collection<AbstractColumn> sortColumnCollection)
		{
			var sortProperties = new PropertyDescriptor[sortColumnCollection.Count];
			var descriptorCollection = this.baseList.GetItemProperties(null);
			
			for (var criteriaIndex = 0; criteriaIndex < sortColumnCollection.Count; criteriaIndex++){
				var descriptor = descriptorCollection.Find (sortColumnCollection[criteriaIndex].ColumnName,true);
				
				if (descriptor == null){
					throw new InvalidOperationException(String.Format(CultureInfo.CurrentCulture,
					                                                  "Die Liste enthält keine Spalte [{0}].",
					                                                  sortColumnCollection[criteriaIndex].ColumnName));
				}
				sortProperties[criteriaIndex] = descriptor;
			}
			return sortProperties;
		}
		
		
//		BaseComparer GetComparer(int position)
//		{
//			var bc = (BaseComparer)IndexList[position];
//			return bc;
//		}
		
		#endregion
		
		
		#region Debug Code

		private static void ShowIndexList (IndexList list)
		{
			foreach (BaseComparer element in list) {
				var groupComparer = element as GroupComparer;
				if (groupComparer == null) continue;
				if (groupComparer.IndexList.Any()) {
					var ss = String.Format("{0} with {1} Children",element.ObjectArray[0],groupComparer.IndexList.Count);
					System.Console.WriteLine(ss);
					foreach (BaseComparer c in groupComparer.IndexList) {
						Console.WriteLine("---- {0}",c.ObjectArray[0]);
					}
				}
			}
		}
		
//		static string  WrongColumnName(string propertyName)
//		{
//			return String.Format(CultureInfo.InvariantCulture, "Error : <{0}> missing!", propertyName);
//		}
		
		#endregion
		
		
		public void Reset()
		{
			throw new NotImplementedException();
		}
		
	}
}
