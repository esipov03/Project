using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.VisualBasic;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Radiator
{
    class DAL
    {

        public string connectionString = @"Server=" + Properties.Settings.Default.server + ";Database=" + Properties.Settings.Default.database + ";user=" + Properties.Settings.Default.login + ";Password=" + Properties.Settings.Default.password + ";";
        public ArrayList GetAllRabotnik()
        {
            ArrayList allRabotnik = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("USE RadiatorDB EXEC Sotrudnik", con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allRabotnik.Add(result);
                }
                catch
                {

                }


            }
            return allRabotnik;
        }
        public bool SaveNewSotrdunik(string Фамилия, string Имя, string Отчество, DateTime Датарождения)
        {
            bool flagResult = false;
            string query = string.Format("INSERT INTO Сотрудник ([Фамилия],[Имя],[Отчество],[Дата рождения])  VALUES ('{0}','{1}','{2}','{3}')", Фамилия, Имя, Отчество, Датарождения);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                    {
                        flagResult = true;
                    }

                    {

                    }
                }
                catch
                {

                }
            }
            return flagResult;

        }

        public bool SaveNewJournal(int СотрудникИД, int Действие, int NПриказа, DateTime Дата)
        {
            bool flagResult = false;
            string query = String.Format("INSERT INTO Журнал([СотрудникИД],[Действие],[NПриказа],[Дата])  VALUES ('{0}','{1}','{2}','{3}')", СотрудникИД, Действие, NПриказа, Дата);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                    {
                        flagResult = true;
                    }
                }
                catch (Exception)
                {

                }
            }
            return flagResult;
        }

        public void SaveNewPodrazdelenie(string Наименование)
        {

            string query = String.Format("USE RadiatorDB EXEC SetPodrazd_UpdateJournal {0}", Наименование);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();

                    com.ExecuteNonQuery();

                }
                catch (Exception)
                {

                }
            }

        }
        public void SaveNewDoljnost(string name)
        {

            string query = String.Format("USE RadiatorDB EXEC Set_Doljnsot_UpdateJournal {0}", name);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();

                    com.ExecuteNonQuery();

                }
                catch (Exception)
                {

                }
            }


        }
        public ArrayList GetAllPrichin()
        {
            ArrayList allPrichin = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SELECT * FROM Отпуск_причина ", con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allPrichin.Add(result);
                }
                catch
                {

                }


            }
            return allPrichin;
        }
        public bool SaveNewOtpusk(int ПричинаИД, DateTime Дата_Начала, DateTime Дата_Конца, int countDay, string СотрудникИД)
        {
            bool flagResult = false;
            string query = String.Format("INSERT INTO Отпуск([ПричинаИД],[Дата начала],[Дата окончания],[Кол-во дней],[СотрудникИД])  VALUES ('{0}','{1}','{2}','{3}','{4}'); ", ПричинаИД, Дата_Начала, Дата_Конца, countDay, СотрудникИД);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                    {
                        flagResult = true;
                    }

                }
                catch (Exception)
                {

                }

            }
            return flagResult;
        }


        public int DateDiff(DateTime dat1, DateTime dat2)
        {
            TimeSpan ts = dat2 - dat1;
            return ts.Days;

        }
        public ArrayList GetAllDeistv()
        {
            ArrayList allDeistv = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("SELECT * FROM Действие ", con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allDeistv.Add(result);
                }
                catch
                {

                }


            }
            return allDeistv;


        }

        public void AddDolJournal()
        {
            string query = String.Format("UPDATE Журнал SET Должность = (SELECT MAX(Должность.Id) FROM  Должность), Подразделение = (SELECT MAX(Подразделение.Id) FROM Подразделение) WHERE Журнал.Id = (SELECT MAX(Журнал.Id) FROM Журнал)");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }

            }

        }
        public string pis;
        public void AddPodJournal()
        {
            string query = String.Format("INSERT INTO Журнал([Подразделение]) SELECT Max(id) FROM Подразделение");
            pis = query.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }

            }

        }
        public bool SaveNewZP(string СотрудникИД, decimal Сумма, DateTime Дата)
        {
            bool flagResult = false;
            string query = String.Format("INSERT INTO Зарплата([СотрудникИД],[Сумма],[Дата])  VALUES ('{0}',{1},'{2}')", СотрудникИД, Сумма.ToString("0.00", CultureInfo.GetCultureInfo("en-US")), Дата);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();
                    if (com.ExecuteNonQuery() == 1)
                    {
                        flagResult = true;
                    }
                }
                catch (Exception)
                {

                }
            }
            return flagResult;
        }

        public ArrayList SearchFromSotrudnik(string FIO)
        {
            string query = String.Format("USE RadiatorDB EXEC FindS '{0}'; ", FIO);
            ArrayList SearchSotr = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            SearchSotr.Add(result);
                }
                catch
                {

                }


            }
            return SearchSotr;




        }
        internal ArrayList GetAllSotrudnik1(string SotrudnikID)
        {

            ArrayList AllJournalS = new ArrayList();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = String.Format("SELECT * FROM Журнал Where СотрудникИД ='{0}' Order By OpenDate", SotrudnikID);
                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            AllJournalS.Add(result);
                }
                catch
                {

                }
            }
            return AllJournalS;


        }

        public ArrayList JournalFromSotrudnik(string SoID)
        //Выводит при клике на сотрудника соотвествующую запись в журнале
        {

            ArrayList allSotDol = new ArrayList();
            string query = String.Format("USE RadiatorDB EXEC ViewJournal {0};", SoID);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allSotDol.Add(result);
                }
                catch
                {

                }


            }
            return allSotDol;
        }
        public ArrayList OtpuskSearch(string SoID)
        {

            ArrayList allOtpuskS = new ArrayList();
            string query = String.Format("USE RadiatorDB EXEC GetOtpusk {0};", SoID);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allOtpuskS.Add(result);
                }
                catch
                {

                }


            }
            return allOtpuskS;
        }
        public ArrayList ZPSearch(string SoID)
        {

            ArrayList allZP = new ArrayList();
            string query = String.Format("USE RadiatorDB EXEC ViewZP2 {0};", SoID);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allZP.Add(result);
                }
                catch
                {

                }


            }
            return allZP;
        }

        public ArrayList ZpFromYear(string SoID, string b)
        {

            ArrayList allZPFromYear = new ArrayList();
            string query = String.Format("USE RadiatorDB EXEC ZpGOd {0},{1};", SoID, b);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allZPFromYear.Add(result);
                }
                catch
                {

                }


            }
            return allZPFromYear;
        }

        public bool DeleteFromJournal(string JId)
        {
            string qeury = string.Format("USE RadiatorDB EXEC DeleteJournal {0}", JId);
            bool check = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(qeury, con);
                try
                {
                    con.Open();
                   if( com.ExecuteNonQuery()==1)
                    {
                        check = true;
                    }


                }
                catch (Exception)
                {

                }

            }

            return check;
        }
        public ArrayList OtpuskS(string SoID, string b)
        {

            ArrayList allOtpuskS = new ArrayList();
            string query = String.Format("USE RadiatorDB EXEC  {0},{1};", SoID, b);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allOtpuskS.Add(result);


                }
                catch
                {

                }


            }
            return allOtpuskS;
        }
        public void SerachDolTextBox(TextBox cajaText)
        {
            string query = String.Format("USE RadiatorDB EXEC FindDol");

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        cajaText.AutoCompleteCustomSource.Add(dr["Наименование"].ToString());


                    }
                    dr.Close();
                }

                catch
                {

                }


            }
        }
        public void SerachPodTextBox(TextBox cajaText)
        {
            string query = String.Format("USE RadiatorDB EXEC SetPod");

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        cajaText.AutoCompleteCustomSource.Add(dr["Наименование"].ToString());


                    }
                    dr.Close();
                }

                catch
                {

                }


            }
        }

        public object SummaZP(string ID, string Year)
        {

            string query = String.Format("USE RadiatorDB EXEC SummZP {0},{1};", ID, Year);



            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand com = new SqlCommand(query, con);
            con.Open();


            object answer = com.ExecuteScalar();
            return answer;


        }
        public ArrayList FromSpravka(string SoID)
        {

            ArrayList DLySpravki = new ArrayList();
            string query = String.Format("USE RadiatorDB EXEC Spravkaa {0};", SoID);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            DLySpravki.Add(result);
                }
                catch
                {

                }


            }
            return DLySpravki;
        }

        public ArrayList Spravka(string SoID,string s,string po)
        {

            ArrayList Otpuska = new ArrayList();
            string query = String.Format("USE RadiatorDB EXEC WordOtpusk {0},{1},{2};", SoID,s,po);
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {

                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        while (dr.Read())
                        {
                            Otpuska.Add(Convert.ToString(dr["puk"]));
                        }


                }
                catch
                {

                }


            }
            return Otpuska;
        }
        public ArrayList Search_Reason(int id_Reason, string id_Sot)
        {
            string query = String.Format("USE RadiatorDB EXEC Search_Reason {0},{1}; ", id_Reason, id_Sot);
            ArrayList ListReason = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            ListReason.Add(result);
                }
                catch
                {

                }


            }
            return ListReason;

        }


        // добавление в личную карточку без должности и подразделения
        public void Insert_Journal(string CustomersId, string dei, string prikaz, DateTime date)
        {
            string query = String.Format("Insert into Журнал([СотрудникИД],[Действие],[NПриказа],[Дата]) VALUES ('{0}','{1}','{2}','{3}')", CustomersId, dei, prikaz, date);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.ExecuteNonQuery();
            }
        }




        public void Insert_Dol_Pod(string pod, string dol)
        {
            string query = String.Format("USE RadiatorDB EXEC InsertJournal '{0}','{1}'", pod, dol);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.ExecuteNonQuery();


            }
        }
        public ArrayList GetAllUsers()
        {
            ArrayList allusers = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand("Select Users.id,Users.Login as 'Логин',Users.Password as 'Пароль',Role.Name as 'Роль' from Users inner join Role on Role.id=Users.Role", con);
                try
                {

                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            allusers.Add(result);
                }
                catch
                {

                }


            }
            return allusers;
        }
            public ArrayList GetAllRole()
            {
                ArrayList allRole = new ArrayList();
                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    SqlCommand com = new SqlCommand("Select id,Name from Role", con);
                    try
                    {

                        con.Open();


                        SqlDataReader dr = com.ExecuteReader();
                        if (dr.HasRows)
                            foreach (DbDataRecord result in dr)
                                allRole.Add(result);
                    }
                    catch
                    {

                    }


                }
                return allRole;

            }


        public bool Insert_User(string Login, string Password,string Role)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC InsertUser '{0}','{1}',{2};", Login,Password,Role);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                
                    con.Open();

                    if (com.ExecuteNonQuery() == 1)
                    {
                    check = true;
                    }
                              
            }
            return check;
        }

        public bool Delete_User(string id)
        {
            bool check = false;
            string query = String.Format("Delete Users where Users.id={0};", id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }

        public object idRole(string IDUser)
        {

            string query = String.Format("Select Users.Role from Users where Users.id={0};", IDUser);



            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand com = new SqlCommand(query, con);
            con.Open();


            object answer = com.ExecuteScalar();
            return answer;


        }

        public bool Edit_User(string id,string login,string password,string idroL)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC EditUser {0},{1},{2},{3};",id,login,password,idroL );
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }

        public bool Edit_Customer(string LastName, string FirstName, string Patronymic, DateTime Birthday,string id)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC EditCustomer {0},{1},{2},'{3}',{4};", LastName,FirstName,Patronymic,Birthday,id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;

        }

        public object GetNameCustomerMessageBox(string IDUser)
        {

            string query = String.Format("Select Сотрудник.Фамилия + ' ' +Сотрудник.Имя + ' ' +Сотрудник.Отчество from Сотрудник where Сотрудник.id={0};", IDUser);



            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand com = new SqlCommand(query, con);
            con.Open();


            object answer = com.ExecuteScalar();
            return answer;


        }
        public void DeleteCustomer(string id)
        {
            
            string query = String.Format("USE RadiatorDB EXEC DeleteCustomer {0};",id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                com.ExecuteNonQuery();
                
                   
                

            }
           

        }

        public bool Edit_Salary(string idC, string idSa, decimal summa,DateTime date)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC EditSalary {0},{1},{2},'{3}';", idC,idSa,summa.ToString("0.00", CultureInfo.GetCultureInfo("en-US")), date);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;

        }

        public bool DeleteSalary(string id)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC DeleteSalary {0};", id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;

        }

        public object idReason(string OtpuskId)
        {

            string query = String.Format("USE RadiatorDB EXEC GetReasonOtpuskIdForOtpusk {0};", OtpuskId);



            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand com = new SqlCommand(query, con);
            con.Open();


            object answer = com.ExecuteScalar();
            return answer;


        }
        public bool Edit_Otpusk(string id, string reason,DateTime start,DateTime end, string contDay)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC EditOtpusk {0},{1},'{2}','{3}',{4};", id, reason, start, end, contDay);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }

        public bool Delete_Otpusk(string id)
        {
            bool check = false;
            string query = String.Format("Delete Отпуск where Отпуск.Id={0};", id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }

        public bool EditPersonalCard(string id,string deistv,string prikaz,DateTime data,string dol, string pod)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC EditPersonalCard {0},{1},'{2}','{3}',{4},{5};", id,deistv,prikaz,data, pod,dol);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }
        public object idPDeistv(string Id)
        {

            string query = String.Format("GetDeistvforCard {0};", Id);



            SqlConnection con = new SqlConnection(connectionString);


            SqlCommand com = new SqlCommand(query, con);
            con.Open();


            object answer = com.ExecuteScalar();
            return answer;


        }
        public bool MetkaDelete(string id,bool metka)
        {
            
            string query = String.Format("update Сотрудник set [Метка на удаление]=0 where Сотрудник.Id={0};", id);
            string query1 = String.Format("update Сотрудник set [Метка на удаление]=1 where Сотрудник.Id={0};", id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (metka)
                {
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return false;
                }
                else
                {
                    SqlCommand com = new SqlCommand(query1, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return true;
                   
                }

            }
           
        }

        public ArrayList getMetkaCustomer()
        {
            string query = String.Format("Select Сотрудник.Id, Сотрудник.Фамилия, Сотрудник.Имя, Сотрудник.Отчество , FORMAT(Сотрудник.[Дата рождения] , 'dd.MM.yyyy') AS [Дата рождения],Сотрудник.[Метка на удаление] from Сотрудник where [Метка на удаление]=1");
            ArrayList Metka = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            Metka.Add(result);
                }
                catch
                {

                }


            }
            return Metka;

        }
        public bool MetkaDeleteFromJournal(string id, bool metka)
        {

            string query = String.Format("update Журнал set [Метка на удаление]=0 where Журнал.Id={0};", id);
            string query1 = String.Format("update Журнал set [Метка на удаление]=1 where Журнал.Id={0};", id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (metka)
                {
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return false;
                }
                else
                {
                    SqlCommand com = new SqlCommand(query1, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return true;

                }

            }

        }
        public ArrayList getMetkaJournal(string id)
        {
            string query = String.Format("USE RadiatorDB EXEC getMetkaJournal {0}",id);
            ArrayList Metka = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            Metka.Add(result);
                }
                catch
                {

                }


            }
            return Metka;

        }
        public bool MetkaDeleteFromSalary(string id, bool metka)
        {

            string query = String.Format("update Зарплата set [Метка на удаление]=0 where Зарплата.Id={0};", id);
            string query1 = String.Format("update Зарплата set [Метка на удаление]=1 where Зарплата.Id={0};", id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (metka)
                {
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return false;
                }
                else
                {
                    SqlCommand com = new SqlCommand(query1, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return true;

                }

            }

        }
        public ArrayList getMetkaFromSalary(string id)
        {
            string query = String.Format("USE RadiatorDB EXEC getMetkaFromSalary {0}", id);
            ArrayList Metka = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            Metka.Add(result);
                }
                catch
                {

                }


            }
            return Metka;

        }
        public bool MetkaDeleteFromOtpusk(string id, bool metka)
        {

            string query = String.Format("update Отпуск set [Метка на удаление]=0 where Отпуск.Id={0};", id);
            string query1 = String.Format("update Отпуск set [Метка на удаление]=1 where Отпуск.Id={0};", id);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (metka)
                {
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return false;
                }
                else
                {
                    SqlCommand com = new SqlCommand(query1, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    return true;

                }

            }

        }
        public ArrayList getMetkaFromOtpusk(string id)
        {
            string query = String.Format("USE RadiatorDB EXEC getMetkaFromOtpusk {0}", id);
            ArrayList Metka = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            Metka.Add(result);
                }
                catch
                {

                }


            }
            return Metka;

        }

        public bool Set_Custmomer_PersonalCard_Date(string CustId, DateTime start)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC Set_Custmomer_PersonalCard_Date {0},'{1}';", CustId,start);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }

        public ArrayList Get_Customer_Dol_Date(string id)
        {
            string query = String.Format("USE RadiatorDB EXEC Get_Customer_Dol_Date {0}", id);
            ArrayList Metka = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        foreach (DbDataRecord result in dr)
                            Metka.Add(result);
                }
                catch
                {

                }


            }
            return Metka;

        }

        public ArrayList DurationOfWork(string id)
        {
            string query = String.Format("USE RadiatorDB EXEC DurationOfWork {0}", id);
            ArrayList Metka = new ArrayList();
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();


                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.HasRows)
                        while (dr.Read())
                        {
                           Metka.Add(Convert.ToString(dr[0]));
                        }
                }
                catch
                {

                }


            }
            return Metka;

        }
        public bool Delete_Custmomer_PersonalCard_Date(string JournalID)
        {
            bool check = false;
            string query = String.Format("Delete Сотрудник_Должность_Длительность where Сотрудник_Должность_Длительность.ЖурналИД={0}", JournalID);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }

        public bool UpdateDateEndВismissale(string CustId, DateTime end)
        {
            bool check = false;
            string query = String.Format("USE RadiatorDB EXEC UpdateDateEndВismissal {0},'{1}';", CustId, end);
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);

                con.Open();

                if (com.ExecuteNonQuery() == 1)
                {
                    check = true;
                }

            }
            return check;
        }



    }

}

    
        

    
    


    

