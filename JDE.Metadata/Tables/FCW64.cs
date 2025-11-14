using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW64 - .
/// </summary>
public class FCW64 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WXJOBS.
        /// </summary>
        public const string WXJOBS = "WXJOBS";

        /// <summary>
        /// WXUSER.
        /// </summary>
        public const string WXUSER = "WXUSER";

        /// <summary>
        /// WXC9MLNU.
        /// </summary>
        public const string WXC9MLNU = "WXC9MLNU";

        /// <summary>
        /// WXC9LANC.
        /// </summary>
        public const string WXC9LANC = "WXC9LANC";

        /// <summary>
        /// WXC9ITMP.
        /// </summary>
        public const string WXC9ITMP = "WXC9ITMP";

        /// <summary>
        /// WXC9STRC.
        /// </summary>
        public const string WXC9STRC = "WXC9STRC";

        /// <summary>
        /// WXC9LVNO.
        /// </summary>
        public const string WXC9LVNO = "WXC9LVNO";

        /// <summary>
        /// WXC9LVL0.
        /// </summary>
        public const string WXC9LVL0 = "WXC9LVL0";

        /// <summary>
        /// WXC9LVL1.
        /// </summary>
        public const string WXC9LVL1 = "WXC9LVL1";

        /// <summary>
        /// WXC9LVL2.
        /// </summary>
        public const string WXC9LVL2 = "WXC9LVL2";

        /// <summary>
        /// WXC9LVL3.
        /// </summary>
        public const string WXC9LVL3 = "WXC9LVL3";

        /// <summary>
        /// WXC9LVL4.
        /// </summary>
        public const string WXC9LVL4 = "WXC9LVL4";

        /// <summary>
        /// WXC9LVL5.
        /// </summary>
        public const string WXC9LVL5 = "WXC9LVL5";

        /// <summary>
        /// WXC9LVL6.
        /// </summary>
        public const string WXC9LVL6 = "WXC9LVL6";

        /// <summary>
        /// WXC9LVL7.
        /// </summary>
        public const string WXC9LVL7 = "WXC9LVL7";

        /// <summary>
        /// WXC9LVL8.
        /// </summary>
        public const string WXC9LVL8 = "WXC9LVL8";

        /// <summary>
        /// WXC9LVL9.
        /// </summary>
        public const string WXC9LVL9 = "WXC9LVL9";

        /// <summary>
        /// WXC9PLNM.
        /// </summary>
        public const string WXC9PLNM = "WXC9PLNM";

        /// <summary>
        /// WXKCOO.
        /// </summary>
        public const string WXKCOO = "WXKCOO";

        /// <summary>
        /// WXPARS.
        /// </summary>
        public const string WXPARS = "WXPARS";

        /// <summary>
        /// WXDOCO.
        /// </summary>
        public const string WXDOCO = "WXDOCO";

        /// <summary>
        /// WXDCTO.
        /// </summary>
        public const string WXDCTO = "WXDCTO";

        /// <summary>
        /// WXMCU.
        /// </summary>
        public const string WXMCU = "WXMCU";

        /// <summary>
        /// WXLOCN.
        /// </summary>
        public const string WXLOCN = "WXLOCN";

        /// <summary>
        /// WXLOTN.
        /// </summary>
        public const string WXLOTN = "WXLOTN";

        /// <summary>
        /// WXC9DOCO1.
        /// </summary>
        public const string WXC9DOCO1 = "WXC9DOCO1";

        /// <summary>
        /// WXC9DOCO2.
        /// </summary>
        public const string WXC9DOCO2 = "WXC9DOCO2";

        /// <summary>
        /// WXC9DOCO3.
        /// </summary>
        public const string WXC9DOCO3 = "WXC9DOCO3";

        /// <summary>
        /// WXC9DOCO4.
        /// </summary>
        public const string WXC9DOCO4 = "WXC9DOCO4";

        /// <summary>
        /// WXC9DOCO5.
        /// </summary>
        public const string WXC9DOCO5 = "WXC9DOCO5";

        /// <summary>
        /// WXC9DOCO6.
        /// </summary>
        public const string WXC9DOCO6 = "WXC9DOCO6";

        /// <summary>
        /// WXC9DOCO7.
        /// </summary>
        public const string WXC9DOCO7 = "WXC9DOCO7";

        /// <summary>
        /// WXC9DOCO8.
        /// </summary>
        public const string WXC9DOCO8 = "WXC9DOCO8";

        /// <summary>
        /// WXC9DOCO9.
        /// </summary>
        public const string WXC9DOCO9 = "WXC9DOCO9";

        /// <summary>
        /// WXC9DOCO10.
        /// </summary>
        public const string WXC9DOCO10 = "WXC9DOCO10";

        /// <summary>
        /// WXC9DOCO11.
        /// </summary>
        public const string WXC9DOCO11 = "WXC9DOCO11";

        /// <summary>
        /// WXC9DOCO12.
        /// </summary>
        public const string WXC9DOCO12 = "WXC9DOCO12";

        /// <summary>
        /// WXC9DOCO13.
        /// </summary>
        public const string WXC9DOCO13 = "WXC9DOCO13";

        /// <summary>
        /// WXC9DOCO14.
        /// </summary>
        public const string WXC9DOCO14 = "WXC9DOCO14";

        /// <summary>
        /// WXC9DOCO15.
        /// </summary>
        public const string WXC9DOCO15 = "WXC9DOCO15";

        /// <summary>
        /// WXC9DOCO16.
        /// </summary>
        public const string WXC9DOCO16 = "WXC9DOCO16";

        /// <summary>
        /// WXC9DOCO17.
        /// </summary>
        public const string WXC9DOCO17 = "WXC9DOCO17";

        /// <summary>
        /// WXC9DOCO18.
        /// </summary>
        public const string WXC9DOCO18 = "WXC9DOCO18";

        /// <summary>
        /// WXC9DOCO19.
        /// </summary>
        public const string WXC9DOCO19 = "WXC9DOCO19";

        /// <summary>
        /// WXC9DOCO20.
        /// </summary>
        public const string WXC9DOCO20 = "WXC9DOCO20";

        /// <summary>
        /// WXC9DOCO21.
        /// </summary>
        public const string WXC9DOCO21 = "WXC9DOCO21";

        /// <summary>
        /// WXC9DOCO22.
        /// </summary>
        public const string WXC9DOCO22 = "WXC9DOCO22";

        /// <summary>
        /// WXC9DOCO23.
        /// </summary>
        public const string WXC9DOCO23 = "WXC9DOCO23";

        /// <summary>
        /// WXC9DOCO24.
        /// </summary>
        public const string WXC9DOCO24 = "WXC9DOCO24";

        /// <summary>
        /// WXC9DOCO25.
        /// </summary>
        public const string WXC9DOCO25 = "WXC9DOCO25";

        /// <summary>
        /// WXC9DOCO26.
        /// </summary>
        public const string WXC9DOCO26 = "WXC9DOCO26";

        /// <summary>
        /// WXC9DOCO27.
        /// </summary>
        public const string WXC9DOCO27 = "WXC9DOCO27";

        /// <summary>
        /// WXC9DOCO28.
        /// </summary>
        public const string WXC9DOCO28 = "WXC9DOCO28";

        /// <summary>
        /// WXC9DOCO29.
        /// </summary>
        public const string WXC9DOCO29 = "WXC9DOCO29";

        /// <summary>
        /// WXC9DOCO30.
        /// </summary>
        public const string WXC9DOCO30 = "WXC9DOCO30";

        /// <summary>
        /// WXC9ITMX1.
        /// </summary>
        public const string WXC9ITMX1 = "WXC9ITMX1";

        /// <summary>
        /// WXC9ITMX2.
        /// </summary>
        public const string WXC9ITMX2 = "WXC9ITMX2";

        /// <summary>
        /// WXC9ITMX3.
        /// </summary>
        public const string WXC9ITMX3 = "WXC9ITMX3";

        /// <summary>
        /// WXC9ITMX4.
        /// </summary>
        public const string WXC9ITMX4 = "WXC9ITMX4";

        /// <summary>
        /// WXC9ITMX5.
        /// </summary>
        public const string WXC9ITMX5 = "WXC9ITMX5";

        /// <summary>
        /// WXC9ITMX6.
        /// </summary>
        public const string WXC9ITMX6 = "WXC9ITMX6";

        /// <summary>
        /// WXC9ITMX7.
        /// </summary>
        public const string WXC9ITMX7 = "WXC9ITMX7";

        /// <summary>
        /// WXC9ITMX8.
        /// </summary>
        public const string WXC9ITMX8 = "WXC9ITMX8";

        /// <summary>
        /// WXC9ITMX9.
        /// </summary>
        public const string WXC9ITMX9 = "WXC9ITMX9";

        /// <summary>
        /// WXC9ITMX10.
        /// </summary>
        public const string WXC9ITMX10 = "WXC9ITMX10";

        /// <summary>
        /// WXC9ITMX11.
        /// </summary>
        public const string WXC9ITMX11 = "WXC9ITMX11";

        /// <summary>
        /// WXC9ITMX12.
        /// </summary>
        public const string WXC9ITMX12 = "WXC9ITMX12";

        /// <summary>
        /// WXC9ITMX13.
        /// </summary>
        public const string WXC9ITMX13 = "WXC9ITMX13";

        /// <summary>
        /// WXC9ITMX14.
        /// </summary>
        public const string WXC9ITMX14 = "WXC9ITMX14";

        /// <summary>
        /// WXC9ITMX15.
        /// </summary>
        public const string WXC9ITMX15 = "WXC9ITMX15";

        /// <summary>
        /// WXC9ITMX16.
        /// </summary>
        public const string WXC9ITMX16 = "WXC9ITMX16";

        /// <summary>
        /// WXC9ITMX17.
        /// </summary>
        public const string WXC9ITMX17 = "WXC9ITMX17";

        /// <summary>
        /// WXC9ITMX18.
        /// </summary>
        public const string WXC9ITMX18 = "WXC9ITMX18";

        /// <summary>
        /// WXC9ITMX19.
        /// </summary>
        public const string WXC9ITMX19 = "WXC9ITMX19";

        /// <summary>
        /// WXC9ITMX20.
        /// </summary>
        public const string WXC9ITMX20 = "WXC9ITMX20";

        /// <summary>
        /// WXC9ITMX21.
        /// </summary>
        public const string WXC9ITMX21 = "WXC9ITMX21";

        /// <summary>
        /// WXC9ITMX22.
        /// </summary>
        public const string WXC9ITMX22 = "WXC9ITMX22";

        /// <summary>
        /// WXC9ITMX23.
        /// </summary>
        public const string WXC9ITMX23 = "WXC9ITMX23";

        /// <summary>
        /// WXC9ITMX24.
        /// </summary>
        public const string WXC9ITMX24 = "WXC9ITMX24";

        /// <summary>
        /// WXC9ITMX25.
        /// </summary>
        public const string WXC9ITMX25 = "WXC9ITMX25";

        /// <summary>
        /// WXC9ITMX26.
        /// </summary>
        public const string WXC9ITMX26 = "WXC9ITMX26";

        /// <summary>
        /// WXC9ITMX27.
        /// </summary>
        public const string WXC9ITMX27 = "WXC9ITMX27";

        /// <summary>
        /// WXC9ITMX28.
        /// </summary>
        public const string WXC9ITMX28 = "WXC9ITMX28";

        /// <summary>
        /// WXC9ITMX29.
        /// </summary>
        public const string WXC9ITMX29 = "WXC9ITMX29";

        /// <summary>
        /// WXC9ITMX30.
        /// </summary>
        public const string WXC9ITMX30 = "WXC9ITMX30";

        /// <summary>
        /// WXC9UORG1.
        /// </summary>
        public const string WXC9UORG1 = "WXC9UORG1";

        /// <summary>
        /// WXC9UORG2.
        /// </summary>
        public const string WXC9UORG2 = "WXC9UORG2";

        /// <summary>
        /// WXC9UORG3.
        /// </summary>
        public const string WXC9UORG3 = "WXC9UORG3";

        /// <summary>
        /// WXC9UORG4.
        /// </summary>
        public const string WXC9UORG4 = "WXC9UORG4";

        /// <summary>
        /// WXC9UORG5.
        /// </summary>
        public const string WXC9UORG5 = "WXC9UORG5";

        /// <summary>
        /// WXC9UORG6.
        /// </summary>
        public const string WXC9UORG6 = "WXC9UORG6";

        /// <summary>
        /// WXC9UORG7.
        /// </summary>
        public const string WXC9UORG7 = "WXC9UORG7";

        /// <summary>
        /// WXC9UORG8.
        /// </summary>
        public const string WXC9UORG8 = "WXC9UORG8";

        /// <summary>
        /// WXC9UORG9.
        /// </summary>
        public const string WXC9UORG9 = "WXC9UORG9";

        /// <summary>
        /// WXC9UORG10.
        /// </summary>
        public const string WXC9UORG10 = "WXC9UORG10";

        /// <summary>
        /// WXC9UORG11.
        /// </summary>
        public const string WXC9UORG11 = "WXC9UORG11";

        /// <summary>
        /// WXC9UORG12.
        /// </summary>
        public const string WXC9UORG12 = "WXC9UORG12";

        /// <summary>
        /// WXC9UORG13.
        /// </summary>
        public const string WXC9UORG13 = "WXC9UORG13";

        /// <summary>
        /// WXC9UORG14.
        /// </summary>
        public const string WXC9UORG14 = "WXC9UORG14";

        /// <summary>
        /// WXC9UORG15.
        /// </summary>
        public const string WXC9UORG15 = "WXC9UORG15";

        /// <summary>
        /// WXC9UORG16.
        /// </summary>
        public const string WXC9UORG16 = "WXC9UORG16";

        /// <summary>
        /// WXC9UORG17.
        /// </summary>
        public const string WXC9UORG17 = "WXC9UORG17";

        /// <summary>
        /// WXC9UORG18.
        /// </summary>
        public const string WXC9UORG18 = "WXC9UORG18";

        /// <summary>
        /// WXC9UORG19.
        /// </summary>
        public const string WXC9UORG19 = "WXC9UORG19";

        /// <summary>
        /// WXC9UORG20.
        /// </summary>
        public const string WXC9UORG20 = "WXC9UORG20";

        /// <summary>
        /// WXC9UORG21.
        /// </summary>
        public const string WXC9UORG21 = "WXC9UORG21";

        /// <summary>
        /// WXC9UORG22.
        /// </summary>
        public const string WXC9UORG22 = "WXC9UORG22";

        /// <summary>
        /// WXC9UORG23.
        /// </summary>
        public const string WXC9UORG23 = "WXC9UORG23";

        /// <summary>
        /// WXC9UORG24.
        /// </summary>
        public const string WXC9UORG24 = "WXC9UORG24";

        /// <summary>
        /// WXC9UORG25.
        /// </summary>
        public const string WXC9UORG25 = "WXC9UORG25";

        /// <summary>
        /// WXC9UORG26.
        /// </summary>
        public const string WXC9UORG26 = "WXC9UORG26";

        /// <summary>
        /// WXC9UORG27.
        /// </summary>
        public const string WXC9UORG27 = "WXC9UORG27";

        /// <summary>
        /// WXC9UORG28.
        /// </summary>
        public const string WXC9UORG28 = "WXC9UORG28";

        /// <summary>
        /// WXC9UORG29.
        /// </summary>
        public const string WXC9UORG29 = "WXC9UORG29";

        /// <summary>
        /// WXC9UORG30.
        /// </summary>
        public const string WXC9UORG30 = "WXC9UORG30";

        /// <summary>
        /// WXC9QTY1.
        /// </summary>
        public const string WXC9QTY1 = "WXC9QTY1";

        /// <summary>
        /// WXC9QTY2.
        /// </summary>
        public const string WXC9QTY2 = "WXC9QTY2";

        /// <summary>
        /// WXC9QTY3.
        /// </summary>
        public const string WXC9QTY3 = "WXC9QTY3";

        /// <summary>
        /// WXC9QTY4.
        /// </summary>
        public const string WXC9QTY4 = "WXC9QTY4";

        /// <summary>
        /// WXC9QTY5.
        /// </summary>
        public const string WXC9QTY5 = "WXC9QTY5";

        /// <summary>
        /// WXC9QTY6.
        /// </summary>
        public const string WXC9QTY6 = "WXC9QTY6";

        /// <summary>
        /// WXC9QTY7.
        /// </summary>
        public const string WXC9QTY7 = "WXC9QTY7";

        /// <summary>
        /// WXC9QTY8.
        /// </summary>
        public const string WXC9QTY8 = "WXC9QTY8";

        /// <summary>
        /// WXC9QTY9.
        /// </summary>
        public const string WXC9QTY9 = "WXC9QTY9";

        /// <summary>
        /// WXC9QTY10.
        /// </summary>
        public const string WXC9QTY10 = "WXC9QTY10";

        /// <summary>
        /// WXC9QTY11.
        /// </summary>
        public const string WXC9QTY11 = "WXC9QTY11";

        /// <summary>
        /// WXC9QTY12.
        /// </summary>
        public const string WXC9QTY12 = "WXC9QTY12";

        /// <summary>
        /// WXC9QTY13.
        /// </summary>
        public const string WXC9QTY13 = "WXC9QTY13";

        /// <summary>
        /// WXC9QTY14.
        /// </summary>
        public const string WXC9QTY14 = "WXC9QTY14";

        /// <summary>
        /// WXC9QTY15.
        /// </summary>
        public const string WXC9QTY15 = "WXC9QTY15";

        /// <summary>
        /// WXC9QTY16.
        /// </summary>
        public const string WXC9QTY16 = "WXC9QTY16";

        /// <summary>
        /// WXC9QTY17.
        /// </summary>
        public const string WXC9QTY17 = "WXC9QTY17";

        /// <summary>
        /// WXC9QTY18.
        /// </summary>
        public const string WXC9QTY18 = "WXC9QTY18";

        /// <summary>
        /// WXC9QTY19.
        /// </summary>
        public const string WXC9QTY19 = "WXC9QTY19";

        /// <summary>
        /// WXC9QTY20.
        /// </summary>
        public const string WXC9QTY20 = "WXC9QTY20";

        /// <summary>
        /// WXC9QTY21.
        /// </summary>
        public const string WXC9QTY21 = "WXC9QTY21";

        /// <summary>
        /// WXC9QTY22.
        /// </summary>
        public const string WXC9QTY22 = "WXC9QTY22";

        /// <summary>
        /// WXC9QTY23.
        /// </summary>
        public const string WXC9QTY23 = "WXC9QTY23";

        /// <summary>
        /// WXC9QTY24.
        /// </summary>
        public const string WXC9QTY24 = "WXC9QTY24";

        /// <summary>
        /// WXC9QTY25.
        /// </summary>
        public const string WXC9QTY25 = "WXC9QTY25";

        /// <summary>
        /// WXC9QTY26.
        /// </summary>
        public const string WXC9QTY26 = "WXC9QTY26";

        /// <summary>
        /// WXC9QTY27.
        /// </summary>
        public const string WXC9QTY27 = "WXC9QTY27";

        /// <summary>
        /// WXC9QTY28.
        /// </summary>
        public const string WXC9QTY28 = "WXC9QTY28";

        /// <summary>
        /// WXC9QTY29.
        /// </summary>
        public const string WXC9QTY29 = "WXC9QTY29";

        /// <summary>
        /// WXC9QTY30.
        /// </summary>
        public const string WXC9QTY30 = "WXC9QTY30";

        /// <summary>
        /// WXC9SOCN1.
        /// </summary>
        public const string WXC9SOCN1 = "WXC9SOCN1";

        /// <summary>
        /// WXC9SOCN2.
        /// </summary>
        public const string WXC9SOCN2 = "WXC9SOCN2";

        /// <summary>
        /// WXC9SOCN3.
        /// </summary>
        public const string WXC9SOCN3 = "WXC9SOCN3";

        /// <summary>
        /// WXC9SOCN4.
        /// </summary>
        public const string WXC9SOCN4 = "WXC9SOCN4";

        /// <summary>
        /// WXC9SOCN5.
        /// </summary>
        public const string WXC9SOCN5 = "WXC9SOCN5";

        /// <summary>
        /// WXC9SOCN6.
        /// </summary>
        public const string WXC9SOCN6 = "WXC9SOCN6";

        /// <summary>
        /// WXC9SOCN7.
        /// </summary>
        public const string WXC9SOCN7 = "WXC9SOCN7";

        /// <summary>
        /// WXC9SOCN8.
        /// </summary>
        public const string WXC9SOCN8 = "WXC9SOCN8";

        /// <summary>
        /// WXC9SOCN9.
        /// </summary>
        public const string WXC9SOCN9 = "WXC9SOCN9";

        /// <summary>
        /// WXC9SOCN10.
        /// </summary>
        public const string WXC9SOCN10 = "WXC9SOCN10";

        /// <summary>
        /// WXC9SOCN11.
        /// </summary>
        public const string WXC9SOCN11 = "WXC9SOCN11";

        /// <summary>
        /// WXC9SOCN12.
        /// </summary>
        public const string WXC9SOCN12 = "WXC9SOCN12";

        /// <summary>
        /// WXC9SOCN13.
        /// </summary>
        public const string WXC9SOCN13 = "WXC9SOCN13";

        /// <summary>
        /// WXC9SOCN14.
        /// </summary>
        public const string WXC9SOCN14 = "WXC9SOCN14";

        /// <summary>
        /// WXC9SOCN15.
        /// </summary>
        public const string WXC9SOCN15 = "WXC9SOCN15";

        /// <summary>
        /// WXC9SOCN16.
        /// </summary>
        public const string WXC9SOCN16 = "WXC9SOCN16";

        /// <summary>
        /// WXC9SOCN17.
        /// </summary>
        public const string WXC9SOCN17 = "WXC9SOCN17";

        /// <summary>
        /// WXC9SOCN18.
        /// </summary>
        public const string WXC9SOCN18 = "WXC9SOCN18";

        /// <summary>
        /// WXC9SOCN19.
        /// </summary>
        public const string WXC9SOCN19 = "WXC9SOCN19";

        /// <summary>
        /// WXC9SOCN20.
        /// </summary>
        public const string WXC9SOCN20 = "WXC9SOCN20";

        /// <summary>
        /// WXC9SOCN21.
        /// </summary>
        public const string WXC9SOCN21 = "WXC9SOCN21";

        /// <summary>
        /// WXC9SOCN22.
        /// </summary>
        public const string WXC9SOCN22 = "WXC9SOCN22";

        /// <summary>
        /// WXC9SOCN23.
        /// </summary>
        public const string WXC9SOCN23 = "WXC9SOCN23";

        /// <summary>
        /// WXC9SOCN24.
        /// </summary>
        public const string WXC9SOCN24 = "WXC9SOCN24";

        /// <summary>
        /// WXC9SOCN25.
        /// </summary>
        public const string WXC9SOCN25 = "WXC9SOCN25";

        /// <summary>
        /// WXC9SOCN26.
        /// </summary>
        public const string WXC9SOCN26 = "WXC9SOCN26";

        /// <summary>
        /// WXC9SOCN27.
        /// </summary>
        public const string WXC9SOCN27 = "WXC9SOCN27";

        /// <summary>
        /// WXC9SOCN28.
        /// </summary>
        public const string WXC9SOCN28 = "WXC9SOCN28";

        /// <summary>
        /// WXC9SOCN29.
        /// </summary>
        public const string WXC9SOCN29 = "WXC9SOCN29";

        /// <summary>
        /// WXC9SOCN30.
        /// </summary>
        public const string WXC9SOCN30 = "WXC9SOCN30";

        /// <summary>
        /// WXLTTR.
        /// </summary>
        public const string WXLTTR = "WXLTTR";

        /// <summary>
        /// WXDRQJ.
        /// </summary>
        public const string WXDRQJ = "WXDRQJ";

        /// <summary>
        /// WXNXTR.
        /// </summary>
        public const string WXNXTR = "WXNXTR";

        /// <summary>
        /// WXC9FILE.
        /// </summary>
        public const string WXC9FILE = "WXC9FILE";
    }

    /// <inheritdoc />
    public override string TableName => "FCW64";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WXJOBS", "WXJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WXUSER", "WXUSER", JdeDataType.String, 20, true, true),
        new JdeField("WXC9MLNU", "WXC9MLNU", JdeDataType.Numeric, null, true, true),
        new JdeField("WXC9LANC", "WXC9LANC", JdeDataType.Numeric, null, true, true),
        new JdeField("WXC9ITMP", "WXC9ITMP", JdeDataType.Numeric),
        new JdeField("WXC9STRC", "WXC9STRC", JdeDataType.String, 6),
        new JdeField("WXC9LVNO", "WXC9LVNO", JdeDataType.Numeric),
        new JdeField("WXC9LVL0", "WXC9LVL0", JdeDataType.String, 50),
        new JdeField("WXC9LVL1", "WXC9LVL1", JdeDataType.String, 12),
        new JdeField("WXC9LVL2", "WXC9LVL2", JdeDataType.String, 12),
        new JdeField("WXC9LVL3", "WXC9LVL3", JdeDataType.String, 12),
        new JdeField("WXC9LVL4", "WXC9LVL4", JdeDataType.String, 12),
        new JdeField("WXC9LVL5", "WXC9LVL5", JdeDataType.String, 12),
        new JdeField("WXC9LVL6", "WXC9LVL6", JdeDataType.String, 12),
        new JdeField("WXC9LVL7", "WXC9LVL7", JdeDataType.String, 12),
        new JdeField("WXC9LVL8", "WXC9LVL8", JdeDataType.String, 12),
        new JdeField("WXC9LVL9", "WXC9LVL9", JdeDataType.String, 12),
        new JdeField("WXC9PLNM", "WXC9PLNM", JdeDataType.String, 100),
        new JdeField("WXKCOO", "WXKCOO", JdeDataType.String, 10),
        new JdeField("WXPARS", "WXPARS", JdeDataType.String, 16),
        new JdeField("WXDOCO", "WXDOCO", JdeDataType.Numeric),
        new JdeField("WXDCTO", "WXDCTO", JdeDataType.String, 4),
        new JdeField("WXMCU", "WXMCU", JdeDataType.String, 24),
        new JdeField("WXLOCN", "WXLOCN", JdeDataType.String, 40),
        new JdeField("WXLOTN", "WXLOTN", JdeDataType.String, 60),
        new JdeField("WXC9DOCO1", "WXC9DOCO1", JdeDataType.Numeric),
        new JdeField("WXC9DOCO2", "WXC9DOCO2", JdeDataType.Numeric),
        new JdeField("WXC9DOCO3", "WXC9DOCO3", JdeDataType.Numeric),
        new JdeField("WXC9DOCO4", "WXC9DOCO4", JdeDataType.Numeric),
        new JdeField("WXC9DOCO5", "WXC9DOCO5", JdeDataType.Numeric),
        new JdeField("WXC9DOCO6", "WXC9DOCO6", JdeDataType.Numeric),
        new JdeField("WXC9DOCO7", "WXC9DOCO7", JdeDataType.Numeric),
        new JdeField("WXC9DOCO8", "WXC9DOCO8", JdeDataType.Numeric),
        new JdeField("WXC9DOCO9", "WXC9DOCO9", JdeDataType.Numeric),
        new JdeField("WXC9DOCO10", "WXC9DOCO10", JdeDataType.Numeric),
        new JdeField("WXC9DOCO11", "WXC9DOCO11", JdeDataType.Numeric),
        new JdeField("WXC9DOCO12", "WXC9DOCO12", JdeDataType.Numeric),
        new JdeField("WXC9DOCO13", "WXC9DOCO13", JdeDataType.Numeric),
        new JdeField("WXC9DOCO14", "WXC9DOCO14", JdeDataType.Numeric),
        new JdeField("WXC9DOCO15", "WXC9DOCO15", JdeDataType.Numeric),
        new JdeField("WXC9DOCO16", "WXC9DOCO16", JdeDataType.Numeric),
        new JdeField("WXC9DOCO17", "WXC9DOCO17", JdeDataType.Numeric),
        new JdeField("WXC9DOCO18", "WXC9DOCO18", JdeDataType.Numeric),
        new JdeField("WXC9DOCO19", "WXC9DOCO19", JdeDataType.Numeric),
        new JdeField("WXC9DOCO20", "WXC9DOCO20", JdeDataType.Numeric),
        new JdeField("WXC9DOCO21", "WXC9DOCO21", JdeDataType.Numeric),
        new JdeField("WXC9DOCO22", "WXC9DOCO22", JdeDataType.Numeric),
        new JdeField("WXC9DOCO23", "WXC9DOCO23", JdeDataType.Numeric),
        new JdeField("WXC9DOCO24", "WXC9DOCO24", JdeDataType.Numeric),
        new JdeField("WXC9DOCO25", "WXC9DOCO25", JdeDataType.Numeric),
        new JdeField("WXC9DOCO26", "WXC9DOCO26", JdeDataType.Numeric),
        new JdeField("WXC9DOCO27", "WXC9DOCO27", JdeDataType.Numeric),
        new JdeField("WXC9DOCO28", "WXC9DOCO28", JdeDataType.Numeric),
        new JdeField("WXC9DOCO29", "WXC9DOCO29", JdeDataType.Numeric),
        new JdeField("WXC9DOCO30", "WXC9DOCO30", JdeDataType.Numeric),
        new JdeField("WXC9ITMX1", "WXC9ITMX1", JdeDataType.Numeric),
        new JdeField("WXC9ITMX2", "WXC9ITMX2", JdeDataType.Numeric),
        new JdeField("WXC9ITMX3", "WXC9ITMX3", JdeDataType.Numeric),
        new JdeField("WXC9ITMX4", "WXC9ITMX4", JdeDataType.Numeric),
        new JdeField("WXC9ITMX5", "WXC9ITMX5", JdeDataType.Numeric),
        new JdeField("WXC9ITMX6", "WXC9ITMX6", JdeDataType.Numeric),
        new JdeField("WXC9ITMX7", "WXC9ITMX7", JdeDataType.Numeric),
        new JdeField("WXC9ITMX8", "WXC9ITMX8", JdeDataType.Numeric),
        new JdeField("WXC9ITMX9", "WXC9ITMX9", JdeDataType.Numeric),
        new JdeField("WXC9ITMX10", "WXC9ITMX10", JdeDataType.Numeric),
        new JdeField("WXC9ITMX11", "WXC9ITMX11", JdeDataType.Numeric),
        new JdeField("WXC9ITMX12", "WXC9ITMX12", JdeDataType.Numeric),
        new JdeField("WXC9ITMX13", "WXC9ITMX13", JdeDataType.Numeric),
        new JdeField("WXC9ITMX14", "WXC9ITMX14", JdeDataType.Numeric),
        new JdeField("WXC9ITMX15", "WXC9ITMX15", JdeDataType.Numeric),
        new JdeField("WXC9ITMX16", "WXC9ITMX16", JdeDataType.Numeric),
        new JdeField("WXC9ITMX17", "WXC9ITMX17", JdeDataType.Numeric),
        new JdeField("WXC9ITMX18", "WXC9ITMX18", JdeDataType.Numeric),
        new JdeField("WXC9ITMX19", "WXC9ITMX19", JdeDataType.Numeric),
        new JdeField("WXC9ITMX20", "WXC9ITMX20", JdeDataType.Numeric),
        new JdeField("WXC9ITMX21", "WXC9ITMX21", JdeDataType.Numeric),
        new JdeField("WXC9ITMX22", "WXC9ITMX22", JdeDataType.Numeric),
        new JdeField("WXC9ITMX23", "WXC9ITMX23", JdeDataType.Numeric),
        new JdeField("WXC9ITMX24", "WXC9ITMX24", JdeDataType.Numeric),
        new JdeField("WXC9ITMX25", "WXC9ITMX25", JdeDataType.Numeric),
        new JdeField("WXC9ITMX26", "WXC9ITMX26", JdeDataType.Numeric),
        new JdeField("WXC9ITMX27", "WXC9ITMX27", JdeDataType.Numeric),
        new JdeField("WXC9ITMX28", "WXC9ITMX28", JdeDataType.Numeric),
        new JdeField("WXC9ITMX29", "WXC9ITMX29", JdeDataType.Numeric),
        new JdeField("WXC9ITMX30", "WXC9ITMX30", JdeDataType.Numeric),
        new JdeField("WXC9UORG1", "WXC9UORG1", JdeDataType.Numeric),
        new JdeField("WXC9UORG2", "WXC9UORG2", JdeDataType.Numeric),
        new JdeField("WXC9UORG3", "WXC9UORG3", JdeDataType.Numeric),
        new JdeField("WXC9UORG4", "WXC9UORG4", JdeDataType.Numeric),
        new JdeField("WXC9UORG5", "WXC9UORG5", JdeDataType.Numeric),
        new JdeField("WXC9UORG6", "WXC9UORG6", JdeDataType.Numeric),
        new JdeField("WXC9UORG7", "WXC9UORG7", JdeDataType.Numeric),
        new JdeField("WXC9UORG8", "WXC9UORG8", JdeDataType.Numeric),
        new JdeField("WXC9UORG9", "WXC9UORG9", JdeDataType.Numeric),
        new JdeField("WXC9UORG10", "WXC9UORG10", JdeDataType.Numeric),
        new JdeField("WXC9UORG11", "WXC9UORG11", JdeDataType.Numeric),
        new JdeField("WXC9UORG12", "WXC9UORG12", JdeDataType.Numeric),
        new JdeField("WXC9UORG13", "WXC9UORG13", JdeDataType.Numeric),
        new JdeField("WXC9UORG14", "WXC9UORG14", JdeDataType.Numeric),
        new JdeField("WXC9UORG15", "WXC9UORG15", JdeDataType.Numeric),
        new JdeField("WXC9UORG16", "WXC9UORG16", JdeDataType.Numeric),
        new JdeField("WXC9UORG17", "WXC9UORG17", JdeDataType.Numeric),
        new JdeField("WXC9UORG18", "WXC9UORG18", JdeDataType.Numeric),
        new JdeField("WXC9UORG19", "WXC9UORG19", JdeDataType.Numeric),
        new JdeField("WXC9UORG20", "WXC9UORG20", JdeDataType.Numeric),
        new JdeField("WXC9UORG21", "WXC9UORG21", JdeDataType.Numeric),
        new JdeField("WXC9UORG22", "WXC9UORG22", JdeDataType.Numeric),
        new JdeField("WXC9UORG23", "WXC9UORG23", JdeDataType.Numeric),
        new JdeField("WXC9UORG24", "WXC9UORG24", JdeDataType.Numeric),
        new JdeField("WXC9UORG25", "WXC9UORG25", JdeDataType.Numeric),
        new JdeField("WXC9UORG26", "WXC9UORG26", JdeDataType.Numeric),
        new JdeField("WXC9UORG27", "WXC9UORG27", JdeDataType.Numeric),
        new JdeField("WXC9UORG28", "WXC9UORG28", JdeDataType.Numeric),
        new JdeField("WXC9UORG29", "WXC9UORG29", JdeDataType.Numeric),
        new JdeField("WXC9UORG30", "WXC9UORG30", JdeDataType.Numeric),
        new JdeField("WXC9QTY1", "WXC9QTY1", JdeDataType.Numeric),
        new JdeField("WXC9QTY2", "WXC9QTY2", JdeDataType.Numeric),
        new JdeField("WXC9QTY3", "WXC9QTY3", JdeDataType.Numeric),
        new JdeField("WXC9QTY4", "WXC9QTY4", JdeDataType.Numeric),
        new JdeField("WXC9QTY5", "WXC9QTY5", JdeDataType.Numeric),
        new JdeField("WXC9QTY6", "WXC9QTY6", JdeDataType.Numeric),
        new JdeField("WXC9QTY7", "WXC9QTY7", JdeDataType.Numeric),
        new JdeField("WXC9QTY8", "WXC9QTY8", JdeDataType.Numeric),
        new JdeField("WXC9QTY9", "WXC9QTY9", JdeDataType.Numeric),
        new JdeField("WXC9QTY10", "WXC9QTY10", JdeDataType.Numeric),
        new JdeField("WXC9QTY11", "WXC9QTY11", JdeDataType.Numeric),
        new JdeField("WXC9QTY12", "WXC9QTY12", JdeDataType.Numeric),
        new JdeField("WXC9QTY13", "WXC9QTY13", JdeDataType.Numeric),
        new JdeField("WXC9QTY14", "WXC9QTY14", JdeDataType.Numeric),
        new JdeField("WXC9QTY15", "WXC9QTY15", JdeDataType.Numeric),
        new JdeField("WXC9QTY16", "WXC9QTY16", JdeDataType.Numeric),
        new JdeField("WXC9QTY17", "WXC9QTY17", JdeDataType.Numeric),
        new JdeField("WXC9QTY18", "WXC9QTY18", JdeDataType.Numeric),
        new JdeField("WXC9QTY19", "WXC9QTY19", JdeDataType.Numeric),
        new JdeField("WXC9QTY20", "WXC9QTY20", JdeDataType.Numeric),
        new JdeField("WXC9QTY21", "WXC9QTY21", JdeDataType.Numeric),
        new JdeField("WXC9QTY22", "WXC9QTY22", JdeDataType.Numeric),
        new JdeField("WXC9QTY23", "WXC9QTY23", JdeDataType.Numeric),
        new JdeField("WXC9QTY24", "WXC9QTY24", JdeDataType.Numeric),
        new JdeField("WXC9QTY25", "WXC9QTY25", JdeDataType.Numeric),
        new JdeField("WXC9QTY26", "WXC9QTY26", JdeDataType.Numeric),
        new JdeField("WXC9QTY27", "WXC9QTY27", JdeDataType.Numeric),
        new JdeField("WXC9QTY28", "WXC9QTY28", JdeDataType.Numeric),
        new JdeField("WXC9QTY29", "WXC9QTY29", JdeDataType.Numeric),
        new JdeField("WXC9QTY30", "WXC9QTY30", JdeDataType.Numeric),
        new JdeField("WXC9SOCN1", "WXC9SOCN1", JdeDataType.Numeric),
        new JdeField("WXC9SOCN2", "WXC9SOCN2", JdeDataType.Numeric),
        new JdeField("WXC9SOCN3", "WXC9SOCN3", JdeDataType.Numeric),
        new JdeField("WXC9SOCN4", "WXC9SOCN4", JdeDataType.Numeric),
        new JdeField("WXC9SOCN5", "WXC9SOCN5", JdeDataType.Numeric),
        new JdeField("WXC9SOCN6", "WXC9SOCN6", JdeDataType.Numeric),
        new JdeField("WXC9SOCN7", "WXC9SOCN7", JdeDataType.Numeric),
        new JdeField("WXC9SOCN8", "WXC9SOCN8", JdeDataType.Numeric),
        new JdeField("WXC9SOCN9", "WXC9SOCN9", JdeDataType.Numeric),
        new JdeField("WXC9SOCN10", "WXC9SOCN10", JdeDataType.Numeric),
        new JdeField("WXC9SOCN11", "WXC9SOCN11", JdeDataType.Numeric),
        new JdeField("WXC9SOCN12", "WXC9SOCN12", JdeDataType.Numeric),
        new JdeField("WXC9SOCN13", "WXC9SOCN13", JdeDataType.Numeric),
        new JdeField("WXC9SOCN14", "WXC9SOCN14", JdeDataType.Numeric),
        new JdeField("WXC9SOCN15", "WXC9SOCN15", JdeDataType.Numeric),
        new JdeField("WXC9SOCN16", "WXC9SOCN16", JdeDataType.Numeric),
        new JdeField("WXC9SOCN17", "WXC9SOCN17", JdeDataType.Numeric),
        new JdeField("WXC9SOCN18", "WXC9SOCN18", JdeDataType.Numeric),
        new JdeField("WXC9SOCN19", "WXC9SOCN19", JdeDataType.Numeric),
        new JdeField("WXC9SOCN20", "WXC9SOCN20", JdeDataType.Numeric),
        new JdeField("WXC9SOCN21", "WXC9SOCN21", JdeDataType.Numeric),
        new JdeField("WXC9SOCN22", "WXC9SOCN22", JdeDataType.Numeric),
        new JdeField("WXC9SOCN23", "WXC9SOCN23", JdeDataType.Numeric),
        new JdeField("WXC9SOCN24", "WXC9SOCN24", JdeDataType.Numeric),
        new JdeField("WXC9SOCN25", "WXC9SOCN25", JdeDataType.Numeric),
        new JdeField("WXC9SOCN26", "WXC9SOCN26", JdeDataType.Numeric),
        new JdeField("WXC9SOCN27", "WXC9SOCN27", JdeDataType.Numeric),
        new JdeField("WXC9SOCN28", "WXC9SOCN28", JdeDataType.Numeric),
        new JdeField("WXC9SOCN29", "WXC9SOCN29", JdeDataType.Numeric),
        new JdeField("WXC9SOCN30", "WXC9SOCN30", JdeDataType.Numeric),
        new JdeField("WXLTTR", "WXLTTR", JdeDataType.String, 6),
        new JdeField("WXDRQJ", "WXDRQJ", JdeDataType.Numeric),
        new JdeField("WXNXTR", "WXNXTR", JdeDataType.String, 6),
        new JdeField("WXC9FILE", "WXC9FILE", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW64_0", "Primary Key on WXJOBS, WXUSER, WXC9LANC, WXC9MLNU", new[] { "WXJOBS", "WXUSER", "WXC9LANC", "WXC9MLNU" }, isUnique: true, isPrimaryKey: true)
    };
}
