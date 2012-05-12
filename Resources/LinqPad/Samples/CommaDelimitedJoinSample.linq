<Query Kind="Statements">
  <Connection>
    <ID>f1f17718-71b8-4e35-898d-2fd6423a4e11</ID>
    <Persist>true</Persist>
    <Driver Assembly="IQDriver" PublicKeyToken="5b59726538a49684">IQDriver.IQDriver</Driver>
    <Provider>System.Data.SQLite</Provider>
    <CustomCxString>Data Source=C:\wd\MyDay\MyDay\Bin\MyDayData.db;FailIfMissing=True</CustomCxString>
    <AttachFileName>C:\wd\MyDay\MyDay\Bin\MyDayData.db</AttachFileName>
    <DisplayName>MyDayDataConnection</DisplayName>
    <DriverData>
      <StripUnderscores>false</StripUnderscores>
      <QuietenAllCaps>false</QuietenAllCaps>
    </DriverData>
  </Connection>
</Query>

var query = from a in Actions
from t in ActionTags.Where(x=>x.ActionCode == a.ActionCode).DefaultIfEmpty()
select new { a.ActionCode, a.ActionComments, t.TagCode};
 //Tags = g.Aggregate(String.Empty, (results, nextString)=> String.Format("{0},{1}", results, nextString))};

/*var groupedUsers = from user in users
						   group user by user.User into userGroup
						   select new
						   {
							   User = userGroup.Key,
							   userHobies =
								   userGroup.Aggregate((a, b) => 
									   new { User = a.User, Hobby = (a.Hobby + ", " + b.Hobby) }).Hobby
						   }
							;

*/

var groupedActions = from a in query.ToList()
group a by a.ActionCode into g
select new
		 {
			 ActionCode = g.First().ActionCode,
			 Tags = String.Join(",", g.Select(ga => ga.TagCode))
		 };

query.Dump();
groupedActions.Dump();