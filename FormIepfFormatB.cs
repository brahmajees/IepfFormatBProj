using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IepfFormatBProj
{
    public partial class iepfformatB : Form
    {
        public iepfformatB()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSave02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into iepftypebDT (RECORD_IDENTIFICATION, DETRECLINE, CRDPID, CRCLID, CRCLACCCAT," +
                "DRDPIDDRCLIDCDSL,FILLER1, CREDIT_QTY, DEBIT_QTY, CRQTYLIN_RCODE,CRQTYLIN_RDT, DRQTYLIN_RCODE, DRQTYLIN_RDT, " +
                "SHNAME, NAME2, NAME3,GURNAME, NOMNAME, FHNAME, FHGENDER,BIRTH_DT, " +
                "ACCSTATUS, BOCAT,BOPRODUCT, CUST_TYPE,BOSUB_STAT, OCC,PAN1, PAN2," +
                "PAN3, ACOPEN_DT,SEBIREGN, SE_ID, CHCORP_ID, CM_ID,TRADING_ID, RBI_REGNNO," +
                "RBIAPP_DT,TAXDED_STAT,NATIONALITY, BOADD1,BOADD2, BOADD3, BOCITY, BOSTATE, BOCOUNTRY, BOPINCODE,BOADD1P, BOADD2P, BOADD3P,BOCITYP, BOSTATEP, BOCOUNTRYP, " +
                "BOPINCODEP,PHONE_1, PHONE_2, BO_FAX, BO_EMAIL, ECS_MANDT_FLAG, DIVMICR_BCODE,DIVBANK_BR, BNKNAME, " +
                "BNKADD1, BNKADD2, BNKADD3, BNKCITY, BNKSTATE,BNKCOUNTRY, BNKPINCODE, DIVBANK_CURR, DIVBANK_ACTYPE," +
                "DIVBANK_ACC,AR_FLAG, UID1, UID2,UID3, PANGUARD, UIDGUARD,BO_RGESS_FLAG,MasterUniqNo) " +


            //FILLER2, FILLER3, FILLER4,FILLER6, FILLER7, FILLER8, FILLER9, FILLER10, FILLER11, FILLER12, FILLER13, FILLER14,FILLER15, FILLER16, 
            //FILLER21, FILLER22, FILLER23, FILLER24, FILLER25, FILLER17, FILLER18, FILLER19, FILLER20,FILLER5,

            "values(@RECORD_IDENTIFICATION,@DETRECLINE,@CRDPID,@CRCLID,@CRCLACCCAT," +
            "@DRDPIDDRCLIDCDSL,@FILLER1,@CREDIT_QTY,@DEBIT_QTY,@CRQTYLIN_RCODE,@CRQTYLIN_RDT,@DRQTYLIN_RCODE,@DRQTYLIN_RDT," +
            "@SHNAME,@NAME2,@NAME3,@GURNAME,@NOMNAME,@FHNAME,@FHGENDER,@BIRTH_DT," +
            "@ACCSTATUS,@BOCAT,@BOPRODUCT,@CUST_TYPE,@BOSUB_STAT,@OCC,@PAN1,@PAN2," +
            "@PAN3,@ACOPEN_DT,@SEBIREGN,@SE_ID,@CHCORP_ID,@CM_ID,@TRADING_ID,@RBI_REGNNO," +
            "@RBIAPP_DT,@TAXDED_STAT,@NATIONALITY,@BOADD1,@BOADD2,@BOADD3,@BOCITY,@BOSTATE," +
            "@BOCOUNTRY,@BOPINCODE,@BOADD1P,@BOADD2P,@BOADD3P,@BOCITYP,@BOSTATEP,@BOCOUNTRYP," +
            "@BOPINCODEP,@PHONE_1,@PHONE_2,@BO_FAX,@BO_EMAIL,@ECS_MANDT_FLAG,@DIVMICR_BCODE,@DIVBANK_BR,@BNKNAME," +
            "@BNKADD1,@BNKADD2,@BNKADD3,@BNKCITY,@BNKSTATE,@BNKCOUNTRY,@BNKPINCODE,@DIVBANK_CURR,@DIVBANK_ACTYPE,@DIVBANK_ACC," +
            "@AR_FLAG,@UID1,@UID2,@UID3,@PANGUARD,@UIDGUARD,@BO_RGESS_FLAG,@MasterUniqNo)", con);

            //@FILLER3,@FILLER4,@FILLER2,@FILLER6,@FILLER7,@FILLER8,@FILLER9,@FILLER10,@FILLER11,@FILLER12,@FILLER13,@FILLER14,@FILLER15,@FILLER16,@FILLER17,@FILLER18,@FILLER19,@FILLER20,@FILLER21,@FILLER22,@FILLER23,@FILLER24,@FILLER25,

            cmd.Parameters.AddWithValue("@RECORD_IDENTIFICATION", lblRecident.Text);
            cmd.Parameters.AddWithValue("@DETRECLINE"       ,txtDtlrlno.Text);
            cmd.Parameters.AddWithValue("@CRDPID"           ,txtCrdpid.Text);
            cmd.Parameters.AddWithValue("@CRCLID"           ,txtCrclid.Text);
            var crclaccat = comboBox2Crclacc.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@CRCLACCCAT"       ,crclaccat);
            cmd.Parameters.AddWithValue("@DRDPIDDRCLIDCDSL" ,txtDrdpiddrclidcdsl.Text);
            cmd.Parameters.AddWithValue("@FILLER1"          ,txtFiller01.Text);
            cmd.Parameters.AddWithValue("@CREDIT_QTY"       ,txtCrqty.Text);
            cmd.Parameters.AddWithValue("@DEBIT_QTY"        ,txtDrqty.Text);
            var crlinrc = comboBox2.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@CRQTYLIN_RCODE",crlinrc);
            cmd.Parameters.AddWithValue("@CRQTYLIN_RDT" ,dateTimePicker6.Value.ToString("yyyy-MM-dd"));
            var drlinrc = comboBox4.Text.Substring(0, 2);
            cmd.Parameters.AddWithValue("@DRQTYLIN_RCODE", drlinrc);
            cmd.Parameters.AddWithValue("@DRQTYLIN_RDT" ,dateTimePicker8.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@SHNAME"       ,txtShname.Text);
            cmd.Parameters.AddWithValue("@NAME2"        ,txtName2.Text);
            cmd.Parameters.AddWithValue("@NAME3"        ,txtName3.Text);
            cmd.Parameters.AddWithValue("@GURNAME"      ,txtGurname.Text);
            cmd.Parameters.AddWithValue("@NOMNAME"      ,txtNomname.Text);
            cmd.Parameters.AddWithValue("@FHNAME"       ,txtFhname.Text);
            var fhgender1 = comboBox5.Text.Substring(0,1);
            cmd.Parameters.AddWithValue("@FHGENDER"     ,fhgender1);
            cmd.Parameters.AddWithValue("@BIRTH_DT"     ,dateTimePicker3.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@ACCSTATUS"    ,txtAccstat.Text);
            cmd.Parameters.AddWithValue("@BOCAT"        ,txtBocat.Text);
            cmd.Parameters.AddWithValue("@BOPRODUCT"    ,txtBoproduct.Text);
            cmd.Parameters.AddWithValue("@CUST_TYPE"    ,txtCusttype.Text);
            cmd.Parameters.AddWithValue("@BOSUB_STAT"   ,txtBosubstat.Text);
            cmd.Parameters.AddWithValue("@OCC"          ,txtOccupation.Text);
            cmd.Parameters.AddWithValue("@PAN1"         ,txtPan1.Text);
            cmd.Parameters.AddWithValue("@PAN2"         ,txtPan2.Text);
            cmd.Parameters.AddWithValue("@PAN3"         ,txtPan3.Text);
            cmd.Parameters.AddWithValue("@ACOPEN_DT"    ,dateTimePicker4.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@SEBIREGN"     ,txtSubregn.Text);
            cmd.Parameters.AddWithValue("@SE_ID"       ,txtSeid.Text);
            cmd.Parameters.AddWithValue("@CHCORP_ID"   ,txtChcorpid.Text);
            cmd.Parameters.AddWithValue("@CM_ID"       ,txtCmid.Text);
            cmd.Parameters.AddWithValue("@TRADING_ID"  ,txtTradingid.Text);
            cmd.Parameters.AddWithValue("@RBI_REGNNO"  ,txtRbiregn.Text);
            cmd.Parameters.AddWithValue("@RBIAPP_DT"    ,dateTimePicker5.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TAXDED_STAT" ,txtTaxdedstat.Text);
           cmd.Parameters.AddWithValue("@NATIONALITY" ,txtNation.Text);
            cmd.Parameters.AddWithValue("@BOADD1"      ,txtBoadd1.Text);
            cmd.Parameters.AddWithValue("@BOADD2"      ,txtBoadd2.Text);
            cmd.Parameters.AddWithValue("@BOADD3"      ,txtBoadd3.Text);
            cmd.Parameters.AddWithValue("@BOCITY"      ,txtBocity.Text);
            cmd.Parameters.AddWithValue("@BOSTATE"     ,txtBostate.Text);
            cmd.Parameters.AddWithValue("@BOCOUNTRY"   ,txtBocountry.Text);
            cmd.Parameters.AddWithValue("@BOPINCODE"   ,txtBopincode.Text);
            cmd.Parameters.AddWithValue("@BOADD1P"     ,txtBoadd1p.Text);
            cmd.Parameters.AddWithValue("@BOADD2P"     ,txtBoadd2p.Text);
            cmd.Parameters.AddWithValue("@BOADD3P"     ,txtBoadd3p.Text);
            cmd.Parameters.AddWithValue("@BOCITYP"     ,txtBocityp.Text);
            cmd.Parameters.AddWithValue("@BOSTATEP"    ,txtBostatep.Text);
            cmd.Parameters.AddWithValue("@BOCOUNTRYP"  ,txtBocountryp.Text);
            cmd.Parameters.AddWithValue("@BOPINCODEP"  , txtBopincodep.Text);
            cmd.Parameters.AddWithValue("@PHONE_1"          ,txtPhone_1.Text);
            cmd.Parameters.AddWithValue("@PHONE_2"          ,txtPhone_2.Text);
            cmd.Parameters.AddWithValue("@BO_FAX"           ,txtBo_fax.Text);
            cmd.Parameters.AddWithValue("@BO_EMAIL"         ,txtBo_email.Text);
            var ecsmandtflg = comboBox6.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@ECS_MANDT_FLAG"   ,ecsmandtflg);
            cmd.Parameters.AddWithValue("@DIVMICR_BCODE"    ,txtDivmicr_bcode.Text);
            cmd.Parameters.AddWithValue("@DIVBANK_BR"       ,txtDivbank_br.Text);
            cmd.Parameters.AddWithValue("@BNKNAME"          ,txtBnkname.Text);
            cmd.Parameters.AddWithValue("@BNKADD1"          ,txtBnkadd1.Text);
            cmd.Parameters.AddWithValue("@BNKADD2"          ,txtBnkadd2.Text);
            cmd.Parameters.AddWithValue("@BNKADD3"          ,txtBnkadd3.Text);
            cmd.Parameters.AddWithValue("@BNKCITY"          ,txtBnkcity.Text);
            cmd.Parameters.AddWithValue("@BNKSTATE"         ,txtBnkstate.Text);
            cmd.Parameters.AddWithValue("@BNKCOUNTRY"       ,txtBnkcountry.Text);
            cmd.Parameters.AddWithValue("@BNKPINCODE"       ,txtBnkpincode.Text);
            cmd.Parameters.AddWithValue("@DIVBANK_CURR"     ,txtDivbank_curr.Text);
            cmd.Parameters.AddWithValue("@DIVBANK_ACTYPE"   ,txtDivbank_actype.Text);
            cmd.Parameters.AddWithValue("@DIVBANK_ACC"      ,txtDivbank_acc.Text);
            var arflg = comboBox7.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@AR_FLAG"          ,arflg);
            cmd.Parameters.AddWithValue("@UID1"             ,txtUid1.Text);
            cmd.Parameters.AddWithValue("@UID2"             ,txtUid2.Text);
            cmd.Parameters.AddWithValue("@UID3"             ,txtUid3.Text);
            cmd.Parameters.AddWithValue("@PANGUARD"         ,txtPanguard.Text);
            cmd.Parameters.AddWithValue("@UIDGUARD"         ,txtUidguard.Text);
            cmd.Parameters.AddWithValue("@BO_RGESS_FLAG"    ,txtBorgessflag.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMun02.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in iepftypebdt database");

        }

        private void btnSave01_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into iepftypebHd (Record_Identification,File_Identification,RTAIntRefNo,Credit_ISIN,filler,CA_Type,BApp_Dt,CA_Description,Execution_Dt,TotCrQty_FLin,TotDrQty_FLin,TotCrQty_Lin,TotDrQty_Lin,Totdetrec,CINBCIN,Finyr_rel,MasterUniqNo) " +
                "values (@Record_Identification, @File_Identification, @RTAIntRefNo, @Credit_ISIN,@filler, @CA_Type, " +
                "@BApp_Dt, @CA_Description, @Execution_Dt, @TotCrQty_FLin,@TotDrQty_FLin, @TotCrQty_Lin,@TotDrQty_Lin, @Totdetrec, @CINBCIN, @Finyr_rel,@MasterUniqNo)", con);

            cmd.Parameters.AddWithValue("@Record_Identification", txtRecidentification.Text);
            cmd.Parameters.AddWithValue("@File_Identification", txtFileidentification.Text);
            cmd.Parameters.AddWithValue("@RTAIntRefNo", txtIntrefno.Text);
            cmd.Parameters.AddWithValue("@Credit_ISIN", txtCreditisin.Text);
            cmd.Parameters.AddWithValue("@Filler", txtFiller0101.Text);
            cmd.Parameters.AddWithValue("@CA_Type", txtCaType01.Text);
            cmd.Parameters.AddWithValue("@BApp_Dt", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@CA_Description", txtCaDesc01.Text);
            cmd.Parameters.AddWithValue("@Execution_Dt", dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TotCrQty_FLin", txtTotalcrqtyfli.Text);
            cmd.Parameters.AddWithValue("@TotDrQty_FLin", txtTotaldrqtyfli.Text);
            cmd.Parameters.AddWithValue("@TotCrQty_Lin", txtTotalcrqtyli.Text);
            cmd.Parameters.AddWithValue("@TotDrQty_Lin", txtTotaldrqtylin.Text);
            cmd.Parameters.AddWithValue("@Totdetrec", txtTotalnoofrec.Text);
            //+REPLICATE('0', 16 - LEN(convert(bigint, allotment_quantity) * convert(bigint, Issue_Price))) + CONVERT(VARCHAR, convert(bigint, allotment_quantity) * convert(bigint, Issue_Price)) + '00'
            cmd.Parameters.AddWithValue("@CINBCIN", txtCinBcinNo.Text);
            cmd.Parameters.AddWithValue("@Finyr_rel", txtFyAmtRel.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtIepfmun01.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in iepftypebHd database");

        }

        private void btnSave03_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into iepftypebDIST " +
                "(Record_IDentification,DETRECLINE,ISIN,DR_CR_INDI,FROMDIST_NSDL,TODIST_NSDL,QTY,FLAGSTATDNR,CA_TYPE,MasterUniqNo) " +
                "values(@Record_IDentification,@DETRECLINE,@ISIN," +
                "@DR_CR_INDI,@FROMDIST_NSDL,@TODIST_NSDL,@QTY,@FLAGSTATDNR," +
                "@CA_TYPE,@MasterUniqNo)", con);
            cmd.Parameters.AddWithValue("@Record_IDentification", txtRecident03.Text);
            cmd.Parameters.AddWithValue("@DETRECLINE", txtDetailrecordno.Text);
            cmd.Parameters.AddWithValue("@ISIN", txtISIN.Text);
            var drcrind3 = comboBox2drcrindicator.Text.Substring(0, 1);
            cmd.Parameters.AddWithValue("@DR_CR_INDI", drcrind3);
            cmd.Parameters.AddWithValue("@FROMDIST_NSDL", txtFromdistinctivenonsdl.Text);
            cmd.Parameters.AddWithValue("@TODIST_NSDL", txtTodistinctivenonsdl.Text);
            cmd.Parameters.AddWithValue("@QTY", txtQuantity.Text);
            cmd.Parameters.AddWithValue("@FLAGSTATDNR", txtFDNR03.Text);
            cmd.Parameters.AddWithValue("@CA_TYPE", txtCaType03.Text);
            cmd.Parameters.AddWithValue("@MasterUniqNo", txtMun03.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has saved in iepftypebDIST database");
            
        }
      
        

        private void btnView01_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from iepftypebHd", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnView02_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from iepftypebDT", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnView03_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VCCIPL-TECH\\VENTURESQLEXP;Initial Catalog=VCCIPL;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from IepfNSDLDetailDistRecord", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void txtTodistinctivenonsdl_TextChanged(object sender, EventArgs e)
        {
            if (txtFromdistinctivenonsdl.Text.Length > 0 && txtTodistinctivenonsdl.Text.Length > 0)
            {
                txtQuantity.Text = Convert.ToString(Convert.ToInt32(txtTodistinctivenonsdl.Text) - Convert.ToInt32(txtFromdistinctivenonsdl.Text) + 1);
            }
        }
    }
}
