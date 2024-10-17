using System;

using Data_Array;

DataArray MyData = new DataArray(5);

MyData.ShowFuctions();
MyData.AddValuesFromUser();
/*MyData.AddValue(25);
MyData.AddValue(2);
MyData.AddValue(10);
MyData.AddValue(26);
MyData.AddValue(11);
MyData.AddValue(3);
MyData.AddValue(100);
MyData.AddValue(260);
MyData.AddValues();
MyData.AddValues(12);
MyData.AddValues(112);*/
MyData.DisplayValues();
/*MyData.RemoveValues(2);
MyData.RemoveValues(3);
MyData.RemoveValues(0); 
MyData.SearchValue(3);
MyData.SearchValue(4);
MyData.SearchValue(17);*/

MyData.RemoveValues(2,5);