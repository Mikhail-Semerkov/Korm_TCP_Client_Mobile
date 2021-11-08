using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Database.Sqlite;
using Android.Database;
using System.Collections;

namespace MenuActionBar
{
  public class AddressBookDbHelper: SQLiteOpenHelper
    {
        private const string APP_DATABASENAME = "Miratorg_ASUTP.db3";
        private const int APP_DATABASE_VERSION = 1;

        public AddressBookDbHelper(Context ctx):
            base(ctx, APP_DATABASENAME, null, APP_DATABASE_VERSION)
        {

        }

        public override void OnCreate(SQLiteDatabase db)
        {
            db.ExecSQL(@"CREATE TABLE IF NOT EXISTS AddressBook(
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            NameFerms TEXT NOT NULL,
                            NumberFerms TEXT NOT NULL,
                            Podrazdelenie TEXT NOT NULL,
                            NameAPP TEXT NOT NULL,
                            TelefonStacionar TEXT NOT NULL,
                            NameAdministrator  TEXT NULL,
                            MobileAdministrator  TEXT NOT NULL,
                            NameRukovoditel   TEXT NULL,
                            MobileRukovoditel  TEXT NOT NULL,                          
                            APIPAddres  TEXT NOT NULL,
                            IpAddres1  TEXT NOT NULL,
                            IpAddres2  TEXT NOT NULL,
                            IpAddres3  TEXT NOT NULL,
                            IpAddres4  TEXT NOT NULL,
                            IpAddres5  TEXT NOT NULL,
                            IpAddres6  TEXT NOT NULL,
                            IpAddres7  TEXT NOT NULL,
                            IpAddres8  TEXT NOT NULL,
                            Details  TEXT,
                            Location  TEXT)");
            //++++



            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','1','�����������','���58','58901','���� ����������','+7(910)290-37-27','�������� �����������','+7(980)302-09-88','10.200.1.30','10.200.1.31','10.200.1.32','','','','','','','','53.037523, 33.929392')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','2','�����������','APP1442','58568','���� �������','+7(919)298-93-94','','','10.0.56.2','10.0.57.4','10.0.57.5','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','3','�����������','APP1443','58903','������ �������','+7(919)190-40-88','������ �����','+7(910)743-69-05','10.200.3.30','10.200.3.31','10.200.3.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','4','�����������','APP20004','58904','��������� ���������','+7(980)310-24-93','������� ����������','+7(910)233-17-86','10.0.56.4','10.0.57.10','10.0.57.11','10.0.57.12','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','5','���������','APP20005','58085','��������� ���������','+7(915)539-52-08','','','10.0.56.5','10.0.57.14','10.0.57.15','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���','6','�����������','APP1466','58106','������� ������������','+7(980)307-49-88','������� ���������','+7(920)846-71-27','10.0.56.6','10.0.57.16','10.0.57.17','10.0.57.18','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','7','���������','APP1467','58107','������� �������','+7(915)530-81-35','����� �������','+7(920)848-32-69','10.0.56.7','10.0.57.19','10.0.57.20','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','8','���������','APP1488','58222','�������� ������','+7(919)190-39-75','���� �������','+7(930)828-80-54','10.0.56.8','10.0.57.21','10.0.57.22','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������ ���������','9','���������','���1489','58109','�������� �����������','+7(930)724-91-24','�������� ���������','+7(910)234-22-68','10.0.56.9','10.0.57.24','10.0.57.25','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','10','���������','APP14810','58110','����� ���������','+7(920)859-59-61','������ ����������','+7(930)825-80-06','10.0.56.10','10.0.57.26','10.0.57.27','10.0.57.28','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','11','���������','APP14811','58184','','','���� ��������','+7(919)190-22-12','10.0.56.11','10.0.57.30','10.0.57.31','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������������','12','���������','APP20012','58912','����� �������','+7(980)307-49-46','','','10.0.56.12','10.0.57.32','10.0.57.33','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','13','���������','APP20013','58213','������� ��������','+7(910)733-04-78','��������� ������','+7(980)312-40-61','10.200.13.30','10.200.13.31','10.200.13.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','14','���������','APP14614','58114','������ ������','+7(910)743-81-31','�������� ���������','+7(930)825-25-24','10.0.56.14','10.0.57.34','10.0.57.35','10.0.57.36','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','15','������������','APP15915','58915','������� ������','+7(980)306-72-47','������ �������','+7(910)233-24-67','10.200.15.30','10.200.15.31','10.200.15.32','10.200.15.33','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','16','������������','APP15816','58120','����� ��������','+7(930)722-07-24','������ �������','+7(910)330-44-39','10.200.16.30','10.200.16.31','10.200.16.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','17','������������','APP20017','58123','����� ���������','+7(929)024-20-35','������ ������������ �������','+7(919)193-25-39','10.200.17.30','10.200.17.31','10.200.17.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','18','������������','APP20018','58918','����� �������','+7(930)722-77-29','','','10.200.18.30','10.200.18.31','10.200.18.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�����','19','���������','APP14819','58115','����� ���������� �������','��� �����','����� ���������','+7(910)733-50-37','10.0.56.19','10.0.57.43','10.0.57.44','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������������','20','���������','APP20020','58125','�������� ��������','+7(980)311-36-41','��������� ���������','+7(910)332-85-13','10.0.56.20','10.0.57.45','10.0.57.46','10.0.57.47','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','21','���������','APP14621','58121','����� ������','+7(915)800-63-06','��������� ���������','+7(910)332-85-13','10.0.56.21','10.0.57.49','10.0.57.50','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','22','����������','APP15923','58922','������� ����������','+7(929)022-73-09','���� ����','+7(980)311-19-43','10.200.22.30','10.200.22.31','10.200.22.32','10.200.22.33','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','23','����������','APP20023','59923','��������� ��������','+7(980)307-49-28','������ ������','+7(920)852-09-84','10.200.23.30','10.200.23.31','10.200.23.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','24','���������','APP1488','58246','��������� �����������','+7(920)838-88-37','�������� ���������','+7(920)837-06-51','10.0.56.24','10.0.57.51','10.0.57.52','10.0.57.40','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������� ������','25','���������','APP20025','58135','������� ���������� �������','+7(920)838-23-02','���� �������','+7(920)838-22-90','10.0.56.25','10.0.57.53','10.0.57.54','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','26','���������','APP20026','58926','������� ���������','+7(919)298-09-22','���� �������','+7(980)306-42-34','10.0.56.26','10.0.57.55','10.0.57.56','10.0.57.42','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�����','27','���������','APP20027','58927','������� ��������','+7(910)743-99-67','����� ��������','+7(910)290-15-09','10.0.56.27','10.0.57.58','10.0.57.59','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','28','������������','APP20028','58928','������� �������','+7(915)530-81-70','������ �������','+7(919)193-25-58','10.200.28.30','10.200.28.31','10.200.28.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','29','���������','APP20029','58129','������� ��������','+7(980)310-25-99','','','10.200.29.30','10.200.29.31','10.200.29.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�����������','30','����������','APP15930','58930','����� ������','+7(920)607-22-56','������� ��������','+7(930)723-09-55','10.200.30.30','10.200.30.31','10.200.30.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','31','����������','APP20031','58931','������� ��������','+7(980)302-63-10','������� ���������� �������','��� �����','10.200.31.30','10.200.31.31','10.200.31.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','32','����������','APP20032','58132','������� ����������','+7(920)607-22-81','������� �����','+7(910)290-82-41','10.200.32.30','10.200.32.31','10.200.32.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������� �����','33','���������','APP20033','58933','������ �������','+7(962)134-21-71','������� ������','+7(980)330-35-81','10.200.33.30','10.200.33.31','10.200.33.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������ �1 ������','34','����������� �����','APP17434','58196','���� ��������','+7(919)291-52-25','������� ����������','+7(919)193-16-89','10.200.34.100','10.200.34.101','10.200.34.102','10.200.34.103','10.200.34.104','10.200.34.105','10.200.34.105','10.200.34.115','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','35','���������','APP14835','58935','������� �������','+7(910)743-90-70','���� ������','+7(915)534-53-46','10.200.35.30','10.200.35.31','10.200.35.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','36','����������','APP17636','58936','������ ����������','+7(919)290-70-87','��������� �����������','+7(919)264-76-72','10.200.36.30','10.200.36.31','10.200.36.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������ �2 ����','37','������������ �����','���17637','58872','������� ������','+7(919)208-61-07','��������� �������','+7(919)208-60-98','10.200.37.50','10.200.37.51','10.200.37.52','10.200.37.53','10.200.37.54','10.200.37.55','10.200.37.56','10.200.37.57','10.200.37.58','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','38','����������','���20038','58138','����� �����','+7(920)844-53-77','������� ������','+7(920)836-99-39','10.200.38.30','10.200.38.31','10.200.38.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','39','����������','APP17739','58939','������� ������','+7(915)534-33-69','������ �������','+7(920)607-22-19','10.200.39.30','10.200.39.31','10.200.39.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','40','���������','APP14840','58175','����� �����������','+7(910)733-26-06','������� ������','+7(919)190-22-49','10.200.40.30','10.200.40.31','10.200.40.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','41','������������','APP15041','58141','������ ��������','+7(915)800-25-56','������� �������','+7(919)190-22-59','10.200.41.30','10.200.41.31','10.200.41.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','42','���������','APP15042','59942','','','��������� ��������� �������','+7(915)800-82-72','10.200.42.30','10.200.42.31','10.200.42.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','43','���������','APP15043','58943','������ �������','+7(919)031-06-72','�������� ���������','+7(910)118-02-49','10.200.43.30','10.200.43.31','10.200.43.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','44','����������','���20044','59944','��������� ������������ �������','+7(910)733-83-74','','','10.200.44.30','10.200.44.31','10.200.44.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','45','���������','APP15045','56033','��������� ��������','+7(920)881-80-87','������ �������','+7(910)234-22-48','10.200.45.30','10.200.45.31','10.200.45.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�����','46','���������','APP15046','58946','������ ��������','+7(919)290-78-47','�������� ������','+7(910)118-02-66','10.200.46.30','10.200.46.31','10.200.46.32','10.200.46.33','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','47','����������','APP17747','59947','��� ���������','+7(910)743-38-91','��������� ������','+7(910)914-60-39','10.200.47.30','10.200.47.31','10.200.47.32','10.200.47.33','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','48','������������','APP20048','59948','����� ��������','+7(919)042-46-36','������ ���������','+7(910)760-44-10','10.200.48.30','10.200.48.31','10.200.48.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','49','����������','���17649','58949','��������� ��������','+7(980)311-19-50','��������� �����������','+7(919)264-76-72','10.200.49.30','10.200.49.31','10.200.49.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','50','����������','���20050','58950','������ �������','+7(910)743-80-44','','','10.200.50.30','10.200.50.31','10.200.50.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','51','������������','���15051','58951','����� �������','+7(915)800-46-96','��������� �������','+7(910)237-91-47','10.200.51.30','10.200.51.31','10.200.51.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����� �����','52','����������','APP20052','58952','������ ��������','+7(910)733-04-84','������ ������������� �������','+7(919)042-89-55','10.200.52.30','10.200.52.31','10.200.52.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','53','��������','���18153','58953','������� ���������','+7(930)897-17-70','������� ������������ �������','+7(930)790-32-60','10.200.53.30','10.200.53.31','10.200.53.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','54','������������','���20054','58954','������ ����������','+7(919)043-78-36','','','10.200.54.30','10.200.54.31','10.200.54.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','55','����������','APP20055','58955','��������� ���������','+7(910)720-19-31','����� ���������','+7(919)043-73-69','10.200.55.30','10.200.55.31','10.200.55.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','56','����������','���18356','58956','����� ������������� ���������','+7(919)042-47-69','������� ��������','+7(980)310-21-68','10.200.56.30','10.200.56.31','10.200.56.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','57','��������','APP17657','58957','�������� ������','+7(930)790-34-15','������� ��������','+7(910)290-26-33','10.200.57.30','10.200.57.31','10.200.57.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���� ���������','58','�����������','APP58','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���� �������','59','���������','APP59','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���� ���������','61','���������','APP14861','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���� ���������','62','������������','APP15962','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','63','��������','APP18163','58963','�������� �����','+7(980)311-36-21','������ ���������� �������','+7(910)151-62-57','10.200.63.30','10.200.63.31','10.200.63.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','64','��������','APP18164','58964','������� �������','+7(930)790-56-31','��������� ����������','+7(910)743-86-70','10.200.64.30','10.200.64.31','10.200.64.32','10.200.64.33','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','65','����������','APP18365','58965','������ ��������','+7(919)043-47-20','������ ������','+7(910)290-13-62','10.200.65.30','10.200.65.31','10.200.65.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','66','������������','APP20066','58966','���� �������','+7(910)233-18-57','������ �������','+7(910)234-22-48','10.200.66.30','10.200.66.31','10.200.66.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������������','67','��������','APP20067','58967','����� �������','+7(910)584-47-68','�������� �������','+7(920)742-04-30','10.200.67.30','10.200.67.31','10.200.67.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�����','68','��������','APP20068','58968','������� �������� ������','+7(930)798-03-69','��������� �������','+7(915)800-70-72','10.200.68.30','10.200.68.31','10.200.68.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','69','���������','APP20069','58969','���� �����������','+7(980)300-36-34','������� ��������� ������','+7(910)290-32-42','10.200.69.30','10.200.69.31','10.200.69.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��� ��������','70','�����������','APP14670','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','71','���������','APP20071','58971','���������� ���������','+7(910)866-01-84','������ �������','+7(980)310-26-63','10.200.71.30','10.200.71.31','10.200.71.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','72','���������','APP15171','58972','������ ���������','+7(919)030-11-59','����� �����','+7(930)849-61-09','10.200.72.30','10.200.72.31','10.200.72.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','73','������������','APP20073','58973','����� ������','+7(910)733-05-15','������� ���������','+7(910)234-20-66','10.200.73.30','10.200.73.31','10.200.73.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','74','���������','���20074','58974','����� ��������','��� �����','����� ��������','+7(910)914-58-64','10.200.74.30','10.200.74.31','10.200.74.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','75','����������','APP20075','58975','����� �������','+7(910)760-47-69','������� ���������','+7(915)800-59-75','10.200.75.30','10.200.75.31','10.200.75.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','76','����������','APP20076','58976','������ ���������','+7(920)321-98-29','�������� ������','+7(920)321-98-34','10.200.76.30','10.200.76.31','10.200.76.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','77','��������','APP20077','58977','������� ���������','+7(910)584-46-11','��������� ���������','+7(920)768-30-58','10.200.77.30','10.200.77.31','10.200.77.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','78','��������','APP20078','58978','������� ��������','+7(910)584-46-98','','','10.200.78.30','10.200.78.31','10.200.78.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','79','����������','APP20079','58979','����� ���������','+7(910)118-09-23','��������� ������������ �������','+7(919)193-25-09','10.200.79.30','10.200.79.31','10.200.79.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','80','���������','APP20080','58980','������� ����������','+7(910)865-74-88','������ �������','+7(915)800-25-06','10.200.80.30','10.200.80.31','10.200.80.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','81','���������','APP20081','58981','��������� ��������','+7(910)733-05-42','������ ������������','��� �����','10.200.81.30','10.200.81.31','10.200.81.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','82','��������','APP20082','58982','�������� ����������','+7(930)790-06-26','�������� ���������','+7(930)899-61-90','10.200.82.30','10.200.82.31','10.200.82.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����������','83','����������','APP20083','58983','����� ���������','+7(919)043-80-95','�������� ����������','��� �����','10.200.83.30','10.200.83.31','10.200.83.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','84','������������','���20084','58984','������� ����������','��� �����','����� �������','+7(915)800-23-75','10.200.84.30','10.200.84.31','10.200.84.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','85','�������','APP20085','58710','�������� ��������','+7(910)234-19-31','������� ��������','+7(915)808-67-76','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�����','86','�������','APP20085','58986','����� ��������','+7(910)290-15-26','������� ��������','+7(915)808-67-76','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','87','��������','APP20087','58987','���������� �������','+7(910)584-46-81','','','10.200.87.30','10.200.87.31','10.200.87.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','88','��������','APP20088','58988','��������� ���������� ��������','+7(930)790-49-16','','','10.200.88.30','10.200.88.31','10.200.88.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������� ��','89','��������','APP20089','58989','��������� ��������� ��������','+7(930)790-08-58','������� ���������� �����������','+7(930)790-79-64','10.200.89.30','10.200.89.31','10.200.89.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','90','���������','APP20090','58990','���� ��������','+7(910)290-14-31','����� ������','+7(910)733-85-90','10.200.90.30','10.200.90.31','10.200.90.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','91','���������','APP20091','58991','����� �����','+7(920)838-31-77','','','10.200.91.30','10.200.91.31','10.200.91.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�������','92','�����������','APP20092','58992','����� ���������� ����������','+7(915)530-90-51','��������� ������� ����������','+7(980)303-97-55','10.200.92.30','10.200.92.31','10.200.92.32','10.200.92.33','10.200.92.34','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','93','���������','APP20093','58993','�������� �����','+7(910)045-54-24','','','10.200.93.30','10.200.93.31','10.200.93.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','94','���������','���20094','58994','','','�������� ��������','+7(915)800-62-87','10.200.94.30','10.200.94.31','10.200.94.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������ �3 �����','95','������� �����','APP20095','58406','������ ������������� �����','+7(910)034-30-87','������ �����������','+7(980)319-67-95','10.200.95.70','10.200.95.71','10.200.95.72','10.200.95.73','10.200.95.74','10.200.95.75','10.200.95.76','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','96','��������','APP20096','58996','�������� �������','+7(930)790-69-74','������� ���������� �����������','+7(930)790-79-64','10.200.96.30','10.200.96.31','10.200.96.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','97','���������','APP20097','58997','��������� �����','+7(910)910-58-76','','','10.200.97.30','10.200.97.31','10.200.97.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','98','������������','15915','58998','','','�������� ������������ ���������','+7(915)800-76-03','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������','99','����������','APP17636','58999','�������� ��������','+7(919)290-73-13','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���� ��������','100','���������','APP200100','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���� �������','101','����������','APP200101','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���� ���������','104','����������','APP200104','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������','105','���������','APP200105','58905','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('�����','107','����������','APP17637','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('����� ����','108','���������','APP200108','','','','','','','','','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('���������','109','����������','APP200109','','','','','','10.200.109.30','10.200.109.31','10.200.109.32','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('��������� ��������','110','����������','APP200110','','','','','','10.200.110.30','10.200.110.31','10.200.110.30','','','','','','','','')");
            db.ExecSQL("Insert into AddressBook(NameFerms,NumberFerms,Podrazdelenie,NameAPP,TelefonStacionar,NameAdministrator,MobileAdministrator,NameRukovoditel,MobileRukovoditel,APIPAddres,IpAddres1,IpAddres2,IpAddres3,IpAddres4,IpAddres5,IpAddres6,IpAddres7,IpAddres8,Details,Location)VALUES('������� ��������','111','����������','APP200111','','','','','','10.200.111.30','10.200.111.31','10.200.111.32','','','','','','','','')");





        }

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            db.ExecSQL("DROP TABLE IF EXISTS AddressBook");
            OnCreate(db);
        }

        //Retrive All Contact Details
        public IList<AddressBook> GetAllContacts()
        {

            SQLiteDatabase db = this.ReadableDatabase;

           ICursor c =  db.Query("AddressBook", new string[] { "Id", "NameFerms", "NumberFerms", "Podrazdelenie", "NameAPP", "TelefonStacionar", "NameAdministrator", "MobileAdministrator", "NameRukovoditel", "MobileRukovoditel", "APIPAddres", "IpAddres1", "IpAddres2", "IpAddres3", "IpAddres4", "IpAddres5", "IpAddres6", "IpAddres7", "IpAddres8", "Details", "Location" }, null, null, null, null, null, null);

            var contacts = new List<AddressBook>();

            while (c.MoveToNext())
            {
                contacts.Add(new AddressBook
                        {
                            Id = c.GetInt(0),
                            NameFerms = c.GetString(1),
                            NumberFerms = c.GetString(2),
                            Podrazdelenie = c.GetString(3),
                            NameAPP = c.GetString(4),
                            TelefonStacionar = c.GetString(5),
                            NameAdministrator = c.GetString(6),
                            MobileAdministrator = c.GetString(7),
                            NameRukovoditel = c.GetString(8),
                            MobileRukovoditel = c.GetString(9),
                            APIPAddres = c.GetString(10),
                            IpAddres1 = c.GetString(11),
                            IpAddres2 = c.GetString(12),
                            IpAddres3 = c.GetString(13),
                            IpAddres4 = c.GetString(14),
                            IpAddres5 = c.GetString(15),
                            IpAddres6 = c.GetString(16),
                            IpAddres7 = c.GetString(17),
                            IpAddres8 = c.GetString(18),
                            Details = c.GetString(19),
                            Location = c.GetString(20)
                }); 
            }

            c.Close();
            db.Close();

            return contacts;
        }


        //Retrive All Contact Details
        public IList<AddressBook> GetContactsBySearchName(string nameToSearch)
        {

            SQLiteDatabase db = this.ReadableDatabase;

            ICursor c = db.Query("AddressBook", new string[] { "Id", "NameFerms", "NumberFerms", "Podrazdelenie", "NameAPP", "TelefonStacionar", "NameAdministrator", "MobileAdministrator", "NameRukovoditel", "MobileRukovoditel", "APIPAddres", "IpAddres1", "IpAddres2", "IpAddres3", "IpAddres4", "IpAddres5", "IpAddres6", "IpAddres7", "IpAddres8", "Details", "Location" }, "upper(NameFerms) LIKE ?", new string[] {"%"+ nameToSearch.ToUpper() +"%"}, null, null, null, null);

            var contacts = new List<AddressBook>();

            while (c.MoveToNext())
            {
                contacts.Add(new AddressBook
                {
                    Id = c.GetInt(0),
                    NameFerms = c.GetString(1),
                    NumberFerms = c.GetString(2),
                    Podrazdelenie = c.GetString(3),
                    NameAPP = c.GetString(4),
                    TelefonStacionar = c.GetString(5),
                    NameAdministrator = c.GetString(6),
                    MobileAdministrator = c.GetString(7),
                    NameRukovoditel = c.GetString(8),
                    MobileRukovoditel = c.GetString(9),
                    APIPAddres = c.GetString(10),
                    IpAddres1 = c.GetString(11),
                    IpAddres2 = c.GetString(12),
                    IpAddres3 = c.GetString(13),
                    IpAddres4 = c.GetString(14),
                    IpAddres5 = c.GetString(15),
                    IpAddres6 = c.GetString(16),
                    IpAddres7 = c.GetString(17),
                    IpAddres8 = c.GetString(18),
                    Details = c.GetString(19),
                    Location = c.GetString(20)
                });
            }

            c.Close();
            db.Close();

            return contacts;
        }

        //Add New Contact
        public void AddNewContact(AddressBook contactinfo)
        {
            SQLiteDatabase db = this.WritableDatabase;
            ContentValues vals = new ContentValues();
            vals.Put("NameFerms", contactinfo.NameFerms);
            vals.Put("NumberFerms", contactinfo.NumberFerms);
            vals.Put("Podrazdelenie", contactinfo.Podrazdelenie);
            vals.Put("NameAPP", contactinfo.NameAPP);
            vals.Put("TelefonStacionar", contactinfo.TelefonStacionar);
            vals.Put("NameAdministrator", contactinfo.NameAdministrator);
            vals.Put("MobileAdministartor", contactinfo.MobileAdministrator);
            vals.Put("NameRukovoditel", contactinfo.NameRukovoditel);
            vals.Put("MobileRukovoditel", contactinfo.MobileRukovoditel);
            vals.Put("APIPAddres", contactinfo.APIPAddres);
            vals.Put("IpAddres1", contactinfo.IpAddres1);
            vals.Put("IpAddres2", contactinfo.IpAddres2);
            vals.Put("IpAddres3", contactinfo.IpAddres3);
            vals.Put("IpAddres4", contactinfo.IpAddres4);
            vals.Put("IpAddres5", contactinfo.IpAddres5);
            vals.Put("IpAddres6", contactinfo.IpAddres6);
            vals.Put("IpAddres7", contactinfo.IpAddres7);
            vals.Put("IpAddres8", contactinfo.IpAddres8);
            vals.Put("Details", contactinfo.Details);
            vals.Put("Location", contactinfo.Location);
            db.Insert("AddressBook", null, vals);
        }

        //Get contact details by contact Id
        public ICursor getContactById(int id)
        {
            SQLiteDatabase db = this.ReadableDatabase;
            ICursor res = db.RawQuery("select * from AddressBook where Id=" + id + "", null);
            return res;
        }

        //Update Existing contact
        public void UpdateContact(AddressBook contitem)
        {
            if (contitem == null)
            {
                return;
            }

            //Obtain writable database
            SQLiteDatabase db = this.WritableDatabase;

            //Prepare content values
            ContentValues vals = new ContentValues();
            vals.Put("NameFerms", contitem.NameFerms);
            vals.Put("NumberFerms", contitem.NumberFerms);
            vals.Put("Podrazdelenie", contitem.Podrazdelenie);
            vals.Put("NameAPP", contitem.NameAPP);
            vals.Put("TelefonStacionar", contitem.TelefonStacionar);
            vals.Put("NameAdministrator", contitem.NameAdministrator);
            vals.Put("MobileAdministrator", contitem.MobileAdministrator);
            vals.Put("NameRukovoditel", contitem.NameRukovoditel);
            vals.Put("MobileRukovoditel", contitem.MobileRukovoditel);
            vals.Put("APIPAddres", contitem.APIPAddres);
            vals.Put("IpAddres1", contitem.IpAddres1);
            vals.Put("IpAddres2", contitem.IpAddres2);
            vals.Put("IpAddres3", contitem.IpAddres3);
            vals.Put("IpAddres4", contitem.IpAddres4);
            vals.Put("IpAddres5", contitem.IpAddres5);
            vals.Put("IpAddres6", contitem.IpAddres6);
            vals.Put("IpAddres7", contitem.IpAddres7);
            vals.Put("IpAddres8", contitem.IpAddres8);
            vals.Put("Details", contitem.Details);
            vals.Put("Location", contitem.Location);


            ICursor cursor = db.Query("AddressBook",
                    new String[] { "Id", "NameFerms", "NumberFerms", "Podrazdelenie", "NameAPP", "TelefonStacionar", "NameAdministrator", "MobileAdministrator", "NameRukovoditel", "MobileRukovoditel", "APIPAddres", "IpAddres1", "IpAddres2", "IpAddres3", "IpAddres4", "IpAddres5", "IpAddres6", "IpAddres7", "IpAddres8", "Details", "Location" }, "Id=?", new string[] { contitem.Id.ToString() }, null, null, null, null);

            if (cursor != null)
            {
                if (cursor.MoveToFirst())
                {
                    // update the row
                    db.Update("AddressBook", vals, "Id=?", new String[] { cursor.GetString(0) });
                }

                cursor.Close();
            }

        }


        //Delete Existing contact
        public void DeleteContact(string  contactId)
        {
            if (contactId == null)
            {
                return;
            }

            //Obtain writable database
            SQLiteDatabase db = this.WritableDatabase;

            ICursor cursor = db.Query("AddressBook",
                    new String[] { "Id", "NameFerms", "NumberFerms", "Podrazdelenie", "NameAPP", "TelefonStacionar", "NameAdministrator", "MobileAdministrator", "NameRukovoditel", "MobileRukovoditel", "APIPAddres", "IpAddres1", "IpAddres2", "IpAddres3", "IpAddres4", "IpAddres5", "IpAddres6", "IpAddres7", "IpAddres8", "Details", "Location" }, "Id=?", new string[] { contactId }, null, null, null, null);

            if (cursor != null)
            {
                if (cursor.MoveToFirst())
                {
                    // update the row
                    db.Delete("AddressBook", "Id=?", new String[] { cursor.GetString(0) });
                }

                cursor.Close();
            }

        }
        


    }
}