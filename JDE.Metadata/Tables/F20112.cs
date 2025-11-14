using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F20112 - .
/// </summary>
public class F20112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDEXRPTTYP.
        /// </summary>
        public const string EDEXRPTTYP = "EDEXRPTTYP";

        /// <summary>
        /// EDEXRPTNUM.
        /// </summary>
        public const string EDEXRPTNUM = "EDEXRPTNUM";

        /// <summary>
        /// EDEMPLOYID.
        /// </summary>
        public const string EDEMPLOYID = "EDEMPLOYID";

        /// <summary>
        /// EDWRKSTNID.
        /// </summary>
        public const string EDWRKSTNID = "EDWRKSTNID";

        /// <summary>
        /// EDLIN.
        /// </summary>
        public const string EDLIN = "EDLIN";

        /// <summary>
        /// EDDTECRT.
        /// </summary>
        public const string EDDTECRT = "EDDTECRT";

        /// <summary>
        /// EDEXPTYPE.
        /// </summary>
        public const string EDEXPTYPE = "EDEXPTYPE";

        /// <summary>
        /// EDEXPDATE.
        /// </summary>
        public const string EDEXPDATE = "EDEXPDATE";

        /// <summary>
        /// EDEXPDAMT.
        /// </summary>
        public const string EDEXPDAMT = "EDEXPDAMT";

        /// <summary>
        /// EDEXPFAMT.
        /// </summary>
        public const string EDEXPFAMT = "EDEXPFAMT";

        /// <summary>
        /// EDPMTMETH.
        /// </summary>
        public const string EDPMTMETH = "EDPMTMETH";

        /// <summary>
        /// EDCHRGTO.
        /// </summary>
        public const string EDCHRGTO = "EDCHRGTO";

        /// <summary>
        /// EDBUSPURP.
        /// </summary>
        public const string EDBUSPURP = "EDBUSPURP";

        /// <summary>
        /// EDADDLCMT.
        /// </summary>
        public const string EDADDLCMT = "EDADDLCMT";

        /// <summary>
        /// EDEXPSTAT.
        /// </summary>
        public const string EDEXPSTAT = "EDEXPSTAT";

        /// <summary>
        /// EDCRCD.
        /// </summary>
        public const string EDCRCD = "EDCRCD";

        /// <summary>
        /// EDREIMCRCY.
        /// </summary>
        public const string EDREIMCRCY = "EDREIMCRCY";

        /// <summary>
        /// EDCACTION.
        /// </summary>
        public const string EDCACTION = "EDCACTION";

        /// <summary>
        /// EDRCPTLBL.
        /// </summary>
        public const string EDRCPTLBL = "EDRCPTLBL";

        /// <summary>
        /// EDERRREAS.
        /// </summary>
        public const string EDERRREAS = "EDERRREAS";

        /// <summary>
        /// EDHOTELCH.
        /// </summary>
        public const string EDHOTELCH = "EDHOTELCH";

        /// <summary>
        /// EDNUMNITES.
        /// </summary>
        public const string EDNUMNITES = "EDNUMNITES";

        /// <summary>
        /// EDHOTELLOC.
        /// </summary>
        public const string EDHOTELLOC = "EDHOTELLOC";

        /// <summary>
        /// EDCRCRDNUM.
        /// </summary>
        public const string EDCRCRDNUM = "EDCRCRDNUM";

        /// <summary>
        /// EDTICKNUM.
        /// </summary>
        public const string EDTICKNUM = "EDTICKNUM";

        /// <summary>
        /// EDTICKSTA.
        /// </summary>
        public const string EDTICKSTA = "EDTICKSTA";

        /// <summary>
        /// EDCARVEND.
        /// </summary>
        public const string EDCARVEND = "EDCARVEND";

        /// <summary>
        /// EDMILESDR.
        /// </summary>
        public const string EDMILESDR = "EDMILESDR";

        /// <summary>
        /// EDMILERT.
        /// </summary>
        public const string EDMILERT = "EDMILERT";

        /// <summary>
        /// EDTRIPDES.
        /// </summary>
        public const string EDTRIPDES = "EDTRIPDES";

        /// <summary>
        /// EDNUMCOEMP.
        /// </summary>
        public const string EDNUMCOEMP = "EDNUMCOEMP";

        /// <summary>
        /// EDNUMNCOEM.
        /// </summary>
        public const string EDNUMNCOEM = "EDNUMNCOEM";

        /// <summary>
        /// EDSCHLNAM.
        /// </summary>
        public const string EDSCHLNAM = "EDSCHLNAM";

        /// <summary>
        /// EDCRSNUM.
        /// </summary>
        public const string EDCRSNUM = "EDCRSNUM";

        /// <summary>
        /// EDCRSTITL.
        /// </summary>
        public const string EDCRSTITL = "EDCRSTITL";

        /// <summary>
        /// EDFCLTYNM.
        /// </summary>
        public const string EDFCLTYNM = "EDFCLTYNM";

        /// <summary>
        /// EDBENFTPD.
        /// </summary>
        public const string EDBENFTPD = "EDBENFTPD";

        /// <summary>
        /// EDTXR1.
        /// </summary>
        public const string EDTXR1 = "EDTXR1";

        /// <summary>
        /// EDTXA1.
        /// </summary>
        public const string EDTXA1 = "EDTXA1";

        /// <summary>
        /// EDFNLGRD.
        /// </summary>
        public const string EDFNLGRD = "EDFNLGRD";

        /// <summary>
        /// EDNUMERIC1.
        /// </summary>
        public const string EDNUMERIC1 = "EDNUMERIC1";

        /// <summary>
        /// EDNUMERIC2.
        /// </summary>
        public const string EDNUMERIC2 = "EDNUMERIC2";

        /// <summary>
        /// EDNUMERIC3.
        /// </summary>
        public const string EDNUMERIC3 = "EDNUMERIC3";

        /// <summary>
        /// EDTEXT1.
        /// </summary>
        public const string EDTEXT1 = "EDTEXT1";

        /// <summary>
        /// EDTEXT2.
        /// </summary>
        public const string EDTEXT2 = "EDTEXT2";

        /// <summary>
        /// EDTEXT3.
        /// </summary>
        public const string EDTEXT3 = "EDTEXT3";

        /// <summary>
        /// EDDATE1.
        /// </summary>
        public const string EDDATE1 = "EDDATE1";

        /// <summary>
        /// EDDATE2.
        /// </summary>
        public const string EDDATE2 = "EDDATE2";

        /// <summary>
        /// EDDATE3.
        /// </summary>
        public const string EDDATE3 = "EDDATE3";

        /// <summary>
        /// EDMCU0.
        /// </summary>
        public const string EDMCU0 = "EDMCU0";

        /// <summary>
        /// EDRECTYPE.
        /// </summary>
        public const string EDRECTYPE = "EDRECTYPE";

        /// <summary>
        /// EDLNID.
        /// </summary>
        public const string EDLNID = "EDLNID";

        /// <summary>
        /// EDCRR.
        /// </summary>
        public const string EDCRR = "EDCRR";

        /// <summary>
        /// EDEXR1.
        /// </summary>
        public const string EDEXR1 = "EDEXR1";

        /// <summary>
        /// EDLOCATN.
        /// </summary>
        public const string EDLOCATN = "EDLOCATN";

        /// <summary>
        /// EDBILLBLE.
        /// </summary>
        public const string EDBILLBLE = "EDBILLBLE";

        /// <summary>
        /// EDALTVEND.
        /// </summary>
        public const string EDALTVEND = "EDALTVEND";

        /// <summary>
        /// EDPREFSUPP.
        /// </summary>
        public const string EDPREFSUPP = "EDPREFSUPP";

        /// <summary>
        /// EDSBL.
        /// </summary>
        public const string EDSBL = "EDSBL";

        /// <summary>
        /// EDSBLT.
        /// </summary>
        public const string EDSBLT = "EDSBLT";

        /// <summary>
        /// EDAIRLINE.
        /// </summary>
        public const string EDAIRLINE = "EDAIRLINE";

        /// <summary>
        /// EDRCND.
        /// </summary>
        public const string EDRCND = "EDRCND";

        /// <summary>
        /// EDTYDA.
        /// </summary>
        public const string EDTYDA = "EDTYDA";

        /// <summary>
        /// EDREIMAMT.
        /// </summary>
        public const string EDREIMAMT = "EDREIMAMT";

        /// <summary>
        /// EDUNITS.
        /// </summary>
        public const string EDUNITS = "EDUNITS";

        /// <summary>
        /// EDRATE1.
        /// </summary>
        public const string EDRATE1 = "EDRATE1";

        /// <summary>
        /// EDPOLICYEX.
        /// </summary>
        public const string EDPOLICYEX = "EDPOLICYEX";

        /// <summary>
        /// EDCO.
        /// </summary>
        public const string EDCO = "EDCO";

        /// <summary>
        /// EDCRDC.
        /// </summary>
        public const string EDCRDC = "EDCRDC";

        /// <summary>
        /// EDCCTN.
        /// </summary>
        public const string EDCCTN = "EDCCTN";

        /// <summary>
        /// EDRECSRC.
        /// </summary>
        public const string EDRECSRC = "EDRECSRC";

        /// <summary>
        /// EDCCAN8.
        /// </summary>
        public const string EDCCAN8 = "EDCCAN8";

        /// <summary>
        /// EDREF2.
        /// </summary>
        public const string EDREF2 = "EDREF2";

        /// <summary>
        /// EDREF3.
        /// </summary>
        public const string EDREF3 = "EDREF3";

        /// <summary>
        /// EDREFDTE.
        /// </summary>
        public const string EDREFDTE = "EDREFDTE";

        /// <summary>
        /// EDREFDTE2.
        /// </summary>
        public const string EDREFDTE2 = "EDREFDTE2";

        /// <summary>
        /// EDAPPRID.
        /// </summary>
        public const string EDAPPRID = "EDAPPRID";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";

        /// <summary>
        /// EDTAPDA.
        /// </summary>
        public const string EDTAPDA = "EDTAPDA";

        /// <summary>
        /// EDPDIEMCAT.
        /// </summary>
        public const string EDPDIEMCAT = "EDPDIEMCAT";

        /// <summary>
        /// EDGOVTAMT.
        /// </summary>
        public const string EDGOVTAMT = "EDGOVTAMT";

        /// <summary>
        /// EDGOVTUAMT.
        /// </summary>
        public const string EDGOVTUAMT = "EDGOVTUAMT";
    }

    /// <inheritdoc />
    public override string TableName => "F20112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDEXRPTTYP", "EDEXRPTTYP", JdeDataType.String, 2, true, true),
        new JdeField("EDEXRPTNUM", "EDEXRPTNUM", JdeDataType.String, 20, true, true),
        new JdeField("EDEMPLOYID", "EDEMPLOYID", JdeDataType.Numeric, null, true, true),
        new JdeField("EDWRKSTNID", "EDWRKSTNID", JdeDataType.String, 20, true, true),
        new JdeField("EDLIN", "EDLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDDTECRT", "EDDTECRT", JdeDataType.Numeric, null, true, true),
        new JdeField("EDEXPTYPE", "EDEXPTYPE", JdeDataType.String, 8),
        new JdeField("EDEXPDATE", "EDEXPDATE", JdeDataType.Numeric),
        new JdeField("EDEXPDAMT", "EDEXPDAMT", JdeDataType.Numeric),
        new JdeField("EDEXPFAMT", "EDEXPFAMT", JdeDataType.Numeric),
        new JdeField("EDPMTMETH", "EDPMTMETH", JdeDataType.String, 6),
        new JdeField("EDCHRGTO", "EDCHRGTO", JdeDataType.String, 60),
        new JdeField("EDBUSPURP", "EDBUSPURP", JdeDataType.String, 80),
        new JdeField("EDADDLCMT", "EDADDLCMT", JdeDataType.String, 120),
        new JdeField("EDEXPSTAT", "EDEXPSTAT", JdeDataType.String, 4),
        new JdeField("EDCRCD", "EDCRCD", JdeDataType.String, 6),
        new JdeField("EDREIMCRCY", "EDREIMCRCY", JdeDataType.String, 6),
        new JdeField("EDCACTION", "EDCACTION", JdeDataType.String, 4),
        new JdeField("EDRCPTLBL", "EDRCPTLBL", JdeDataType.Numeric),
        new JdeField("EDERRREAS", "EDERRREAS", JdeDataType.String, 4),
        new JdeField("EDHOTELCH", "EDHOTELCH", JdeDataType.String, 16),
        new JdeField("EDNUMNITES", "EDNUMNITES", JdeDataType.Numeric),
        new JdeField("EDHOTELLOC", "EDHOTELLOC", JdeDataType.String, 50),
        new JdeField("EDCRCRDNUM", "EDCRCRDNUM", JdeDataType.String, 50),
        new JdeField("EDTICKNUM", "EDTICKNUM", JdeDataType.String, 30),
        new JdeField("EDTICKSTA", "EDTICKSTA", JdeDataType.String, 6),
        new JdeField("EDCARVEND", "EDCARVEND", JdeDataType.String, 16),
        new JdeField("EDMILESDR", "EDMILESDR", JdeDataType.Numeric),
        new JdeField("EDMILERT", "EDMILERT", JdeDataType.Numeric),
        new JdeField("EDTRIPDES", "EDTRIPDES", JdeDataType.String, 50),
        new JdeField("EDNUMCOEMP", "EDNUMCOEMP", JdeDataType.Numeric),
        new JdeField("EDNUMNCOEM", "EDNUMNCOEM", JdeDataType.Numeric),
        new JdeField("EDSCHLNAM", "EDSCHLNAM", JdeDataType.String, 50),
        new JdeField("EDCRSNUM", "EDCRSNUM", JdeDataType.String, 20),
        new JdeField("EDCRSTITL", "EDCRSTITL", JdeDataType.String, 60),
        new JdeField("EDFCLTYNM", "EDFCLTYNM", JdeDataType.String, 50),
        new JdeField("EDBENFTPD", "EDBENFTPD", JdeDataType.String, 2),
        new JdeField("EDTXR1", "EDTXR1", JdeDataType.Numeric),
        new JdeField("EDTXA1", "EDTXA1", JdeDataType.String, 20),
        new JdeField("EDFNLGRD", "EDFNLGRD", JdeDataType.String, 4),
        new JdeField("EDNUMERIC1", "EDNUMERIC1", JdeDataType.Numeric),
        new JdeField("EDNUMERIC2", "EDNUMERIC2", JdeDataType.Numeric),
        new JdeField("EDNUMERIC3", "EDNUMERIC3", JdeDataType.Numeric),
        new JdeField("EDTEXT1", "EDTEXT1", JdeDataType.String, 80),
        new JdeField("EDTEXT2", "EDTEXT2", JdeDataType.String, 80),
        new JdeField("EDTEXT3", "EDTEXT3", JdeDataType.String, 80),
        new JdeField("EDDATE1", "EDDATE1", JdeDataType.Numeric),
        new JdeField("EDDATE2", "EDDATE2", JdeDataType.Numeric),
        new JdeField("EDDATE3", "EDDATE3", JdeDataType.Numeric),
        new JdeField("EDMCU0", "EDMCU0", JdeDataType.String, 24),
        new JdeField("EDRECTYPE", "EDRECTYPE", JdeDataType.String, 2, true, true),
        new JdeField("EDLNID", "EDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("EDCRR", "EDCRR", JdeDataType.Numeric),
        new JdeField("EDEXR1", "EDEXR1", JdeDataType.String, 4),
        new JdeField("EDLOCATN", "EDLOCATN", JdeDataType.String, 20),
        new JdeField("EDBILLBLE", "EDBILLBLE", JdeDataType.String, 2),
        new JdeField("EDALTVEND", "EDALTVEND", JdeDataType.String, 30),
        new JdeField("EDPREFSUPP", "EDPREFSUPP", JdeDataType.String, 16),
        new JdeField("EDSBL", "EDSBL", JdeDataType.String, 16),
        new JdeField("EDSBLT", "EDSBLT", JdeDataType.String, 2),
        new JdeField("EDAIRLINE", "EDAIRLINE", JdeDataType.String, 16),
        new JdeField("EDRCND", "EDRCND", JdeDataType.String, 2),
        new JdeField("EDTYDA", "EDTYDA", JdeDataType.String, 4),
        new JdeField("EDREIMAMT", "EDREIMAMT", JdeDataType.Numeric),
        new JdeField("EDUNITS", "EDUNITS", JdeDataType.Numeric),
        new JdeField("EDRATE1", "EDRATE1", JdeDataType.Numeric),
        new JdeField("EDPOLICYEX", "EDPOLICYEX", JdeDataType.String, 6),
        new JdeField("EDCO", "EDCO", JdeDataType.String, 10),
        new JdeField("EDCRDC", "EDCRDC", JdeDataType.String, 6),
        new JdeField("EDCCTN", "EDCCTN", JdeDataType.String, 40),
        new JdeField("EDRECSRC", "EDRECSRC", JdeDataType.String, 2),
        new JdeField("EDCCAN8", "EDCCAN8", JdeDataType.Numeric),
        new JdeField("EDREF2", "EDREF2", JdeDataType.Numeric),
        new JdeField("EDREF3", "EDREF3", JdeDataType.String, 30),
        new JdeField("EDREFDTE", "EDREFDTE", JdeDataType.Numeric),
        new JdeField("EDREFDTE2", "EDREFDTE2", JdeDataType.Numeric),
        new JdeField("EDAPPRID", "EDAPPRID", JdeDataType.Numeric),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric),
        new JdeField("EDTAPDA", "EDTAPDA", JdeDataType.Numeric),
        new JdeField("EDPDIEMCAT", "EDPDIEMCAT", JdeDataType.String, 8),
        new JdeField("EDGOVTAMT", "EDGOVTAMT", JdeDataType.Numeric),
        new JdeField("EDGOVTUAMT", "EDGOVTUAMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F20112_0", "Primary Key on EDEXRPTTYP, EDEXRPTNUM, EDEMPLOYID, EDWRKSTNID, EDDTECRT, EDLIN, EDRECTYPE, EDLNID", new[] { "EDEXRPTTYP", "EDEXRPTNUM", "EDEMPLOYID", "EDWRKSTNID", "EDDTECRT", "EDLIN", "EDRECTYPE", "EDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F20112_2", "Index on EDPMTMETH, EDCRCD", new[] { "EDPMTMETH", "EDCRCD" }),
        new JdeIndex("F20112_3", "Index on EDEXPDATE", new[] { "EDEXPDATE" }),
        new JdeIndex("F20112_4", "Index on EDMCU0, EDSBL, EDCRCD, EDLIN", new[] { "EDMCU0", "EDSBL", "EDCRCD", "EDLIN" }),
        new JdeIndex("F20112_5", "Index on EDEXRPTTYP, EDEXRPTNUM, EDEMPLOYID, EDWRKSTNID, EDDTECRT, EDRECTYPE, SYS_NC00087$, SYS_NC00088$", new[] { "EDEXRPTTYP", "EDEXRPTNUM", "EDEMPLOYID", "EDWRKSTNID", "EDDTECRT", "EDRECTYPE", "SYS_NC00087$", "SYS_NC00088$" }),
        new JdeIndex("F20112_6", "Index on EDCCTN", new[] { "EDCCTN" })
    };
}
